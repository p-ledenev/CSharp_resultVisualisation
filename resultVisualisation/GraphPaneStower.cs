using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace resultVisualisation
{
    class GraphPaneStower
    {
        protected List<Machine> machines;
        protected Machine averageResult;

        private Color[] colors = new Color[] {
            Color.Aqua, Color.Blue, Color.BlueViolet, Color.Brown, Color.Chartreuse, Color.DarkOliveGreen,
            Color.CornflowerBlue, Color.Plum, Color.DarkOrange, Color.Aquamarine, Color.Fuchsia, Color.Gold, Color.Yellow,
            Color.DeepPink, Color.DeepSkyBlue, Color.Green
        };

        public GraphPaneStower(List<Machine> machines, Machine averageResult)
        {
            this.machines = machines;
            this.averageResult = averageResult;
        }

        public void stow(GraphPane pane)
        {
            addCurves(pane);
        }

        protected void addCurves(GraphPane pane)
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

            pane.YAxis.Title.Text = "profit";
            pane.YAxis.Title.FontSpec.Size = 12;
            pane.YAxis.Color = Color.Gray;
            pane.YAxis.MajorGrid.Color = Color.Gray;
            pane.YAxis.MajorGrid.IsVisible = true;

            pane.Legend.Position = LegendPos.InsideBotLeft;

            LineItem curve = pane.AddCurve(averageResult.title, averageResult, Color.Red, SymbolType.None);
            curve.Line.Width = 2;

            int i = 0;
            foreach (Machine machine in machines)
            {
                i++;
                Color color = colors[i % colors.Count()];
                pane.AddCurve(machine.title, machine, color, SymbolType.None);
            }
        }
    }
}
