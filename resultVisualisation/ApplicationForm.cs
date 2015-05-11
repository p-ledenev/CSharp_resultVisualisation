using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace resultVisualisation
{
    public partial class ApplicationForm : Form
    {
        private List<Machine> machines;
        private Machine averageResult;

        private String ticket;
        private String year;
        private String strategy;

        public ApplicationForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            machines = new List<Machine>();
            averageResult = new Machine("average");

            comboTicket.SelectedIndex = comboTicket.Items.Count - 1;
            comboYear.SelectedIndex = comboYear.Items.Count - 1;
            comboTimeFrame.SelectedIndex = comboTimeFrame.Items.Count - 1;
            comboStrategy.SelectedIndex = comboStrategy.Items.Count - 1;
        }

        private void comboTicketSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboYearSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTimeFrameSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboStrategySelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonViewClick(object sender, EventArgs e)
        {
            ticket = (String)comboTicket.SelectedItem;
            year = (String)comboYear.SelectedItem;
            strategy = (String)comboStrategy.SelectedItem;

            init();

            readMachines();
            readAverageResult();
            readSummary();

            DataGridStower gridStower = new DataGridStower(machines, averageResult);
            gridStower.stow(dataGridSummary);

            GraphPaneStower paneStower = new GraphPaneStower(machines, averageResult);
            paneStower.stow(controlZedGraph.GraphPane);

            controlZedGraph.AxisChange();
            controlZedGraph.Invalidate();
            dataGridSummary.Invalidate();
        }

        private void readMachines()
        {
            StreamReader reader = new StreamReader("results/machinesMoney_" + ticket + "_" + year + "_" + strategy + ".csv");

            String line = reader.ReadLine();
            String[] strMachines = line.Split(new string[] { " ;" }, StringSplitOptions.None);
            foreach (String strMachine in strMachines)
                if (strMachine != null && strMachine.Any())
                    machines.Add(new Machine(strMachine.Split(';')[0]));

            line = reader.ReadLine();
            for (; line != null; line = reader.ReadLine())
            {
                if (line == "")
                    continue;

                strMachines = line.Split(new string[] { " ;" }, StringSplitOptions.None);
                for (int i = 0; i < strMachines.Count(); i++)
                    if (strMachines[i] != null && strMachines[i].Any())
                        machines[i].addSlice(strMachines[i]);
            }
        }

        private void readAverageResult()
        {
            StreamReader reader = new StreamReader("results/averageMoney_" + ticket + "_" + year + "_" + strategy + ".csv");

            String line = "";
            for (; line != null; line = reader.ReadLine())
            {
                if (line == "")
                    continue;

                averageResult.addSlice(line);
            }
        }

        private void readSummary()
        {
            StreamReader reader = new StreamReader("results/machinesSummary_" + ticket + "_" + year + "_" + strategy + ".csv");

            reader.ReadLine();
            String[] maxLoss = reader.ReadLine().Split(';');
            String[] maxMoney = reader.ReadLine().Split(';');
            String[] endPeriodMoney = reader.ReadLine().Split(';');

            for (int i = 0; i < machines.Count; i++)
            {
                machines[i].maxLoss = parseDouble(maxLoss[i + 1]);
                machines[i].maxMoney = parseDouble(maxMoney[i + 1]);
                machines[i].endPeriodMoney = parseDouble(endPeriodMoney[i + 1]);
            }

            averageResult.maxLoss = parseDouble(maxLoss[maxLoss.Count() - 2]);
            averageResult.maxMoney = parseDouble(maxMoney[maxMoney.Count() - 2]);
            averageResult.endPeriodMoney = parseDouble(endPeriodMoney[endPeriodMoney.Count() - 2]);
        }

        private double parseDouble(String value)
        {
            return Double.Parse(value.Replace(".", ","));
        }

        private void buttonZoomClick(object sender, EventArgs e)
        {
            controlZedGraph.ZoomOut(controlZedGraph.GraphPane);
        }
    }
}
