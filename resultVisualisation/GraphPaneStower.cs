using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using ZedGraph;

namespace resultVisualisation
{
    class GraphPaneStower
    {
        protected List<Machine> machines;
        protected Machine averageResult;

        private Color[] colors = new Color[] {
            Color.Aqua, Color.Blue, Color.BlueViolet, Color.GreenYellow,
            Color.CornflowerBlue, Color.Orange, Color.Fuchsia, Color.Yellow,
            Color.DarkGreen, Color.Gray, Color.Firebrick,  Color.LightCoral, Color.Lime, Color.DarkKhaki, 
            Color.LightPink, Color.OrangeRed ,Color.MidnightBlue
        };

        public GraphPaneStower(List<Machine> machines, Machine averageResult)
        {
            this.machines = machines;
            this.averageResult = averageResult;
        }

        public void stowAll(GraphPane pane)
        {
            prepare(pane);
            addAverageCurve(pane);
            addMachinesCurves(pane);
        }

        public void stowAverage(GraphPane pane)
        {
            prepare(pane);
            addAverageCurve(pane);
        }

        protected void prepare(GraphPane pane)
        {
            pane.CurveList.Clear();

            pane.IsFontsScaled = false;

            pane.Title.Text = "Profit Changing over Time";
            pane.Title.FontSpec.Size = 14;

            pane.XAxis.Title.Text = "date";
            pane.XAxis.Title.FontSpec.Size = 12;
            pane.XAxis.Color = Color.Gray;
            pane.XAxis.MajorGrid.Color = Color.Gray;
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.Type = AxisType.Date;
            pane.XAxis.Scale.Format = "dd.MM.yy";
            pane.XAxis.Scale.Min = new XDate(getFirstDate());
            pane.XAxis.Scale.Max = new XDate(getLastDate());
            pane.XAxis.Scale.MajorUnit = DateUnit.Month;
            pane.XAxis.Scale.MajorStep = 1;

            pane.YAxis.Title.Text = "profit";
            pane.YAxis.Title.FontSpec.Size = 12;
            pane.YAxis.Color = Color.Gray;
            pane.YAxis.MajorGrid.Color = Color.Gray;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.Scale.Min = getMinimumValue() - 2;
            pane.YAxis.Scale.Max = getMaximunValue();
            pane.XAxis.Scale.MajorStep = 1;

            pane.Legend.Position = LegendPos.InsideBotLeft;
        }

        protected void addMachinesCurves(GraphPane pane)
        {
            int i = 0;
            foreach (Machine machine in machines)
            {
                i++;
                Color color = colors[i % colors.Count()];
                LineItem curve = pane.AddCurve(machine.title, machine, color, SymbolType.None);
                curve.Line.Width = 2;
            }
        }

        protected void addAverageCurve(GraphPane pane)
        {
            LineItem curve = pane.AddCurve(averageResult.title, averageResult, Color.Red, SymbolType.None);
            curve.Line.Width = 2;
        }

        private DateTime getFirstDate()
        {
            return machines[0].getFirstDate();
        }

        private DateTime getLastDate()
        {
            return machines[0].getLastDate();
        }

        private double getMinimumValue()
        {
            return getValueFor((value1,value2) => value1 < value2);
        }

        private double getMaximunValue()
        {
            return getValueFor((value1, value2) => value1 > value2);
        }

        private double getValueFor(Func<double, double, Boolean> comparation)
        {
            double result = machines[0].slices[0].value;
            machines.ForEach(machine =>
            {
                double current = machine.getValueFor(comparation);
                if (comparation(current, result))
                    result = current;
            });

            return result;
        }
    }
}
