using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace resultVisualisation
{
    public partial class ApplicationForm : Form
    {
        private List<Machine> machines;
        private Machine averageResult;

        public ApplicationForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            reset();

            StrategiesParamsExtracter paramsExtracter = new StrategiesParamsExtracter();

            comboYear.Items.AddRange(paramsExtracter.getYears());
            comboTicket.Items.AddRange(paramsExtracter.getTickets());
            comboStrategy.Items.AddRange(paramsExtracter.getStrategies());
            comboSieveParam.Items.AddRange(paramsExtracter.getSieveParams());
            comboFillingGapsNumber.Items.AddRange(paramsExtracter.getFillingGapsNumber());

            comboSieveParam.SelectedIndex = 0;
            comboStrategy.SelectedIndex = 0;
            comboTicket.SelectedIndex = 0;
            comboYear.SelectedIndex = 0;
            comboFillingGapsNumber.SelectedIndex = 0;
        }

        private void reset()
        {
            machines = new List<Machine>();
            averageResult = new Machine("average");
        }

        private String buildDataSuffix()
        {

            String ticket = (string) comboTicket.SelectedItem;
            Int32 year = (int) comboYear.SelectedItem;
            String strategy = (string) comboStrategy.SelectedItem;
            Double sieveParam = (double) comboSieveParam.SelectedItem;
            Int32 fillingGapNumber = (int) comboFillingGapsNumber.SelectedItem;

            return ticket + "_" + year + "_" + sieveParam.ToString().Replace(",", ".") + "_" + fillingGapNumber +
                   "_" + strategy + ".csv";
        }

        private String getAverageMoneyFileName()
        {
            return StrategiesParamsExtracter.path + "averageMoney_" + buildDataSuffix();
        }

        private String getMachinesMoneyFileName()
        {
            return StrategiesParamsExtracter.path + "machinesMoney_" + buildDataSuffix();
        }

        private String getMachinesSummaryFileName()
        {
            return StrategiesParamsExtracter.path + "machinesSummary_" + buildDataSuffix();
        }

        private void informIfDataFileNotExist()
        {
            dataFileInfo.Text = "";

            if (!allCombosSelected() || !File.Exists(getAverageMoneyFileName()))
                dataFileInfo.Text = "Data file not exist";
        }

        private StreamReader readFile(String fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Data file not exist: \n" + fileName);
                throw new Exception("Data file not exist");
            }

            return new StreamReader(fileName);
        }

        private bool allCombosSelected()
        {
            ComboBox[] combos = {comboYear, comboStrategy, comboTicket, comboSieveParam, comboFillingGapsNumber};

            return combos.All(element => element.SelectedItem != null);
        }

        private void comboTicketSelectedIndexChanged(object sender, EventArgs e)
        {
            informIfDataFileNotExist();
        }

        private void comboYearSelectedIndexChanged(object sender, EventArgs e)
        {
            informIfDataFileNotExist();
        }

        private void comboSieveParamSelectedIndexChanged(object sender, EventArgs e)
        {
            informIfDataFileNotExist();
        }

        private void comboStrategySelectedIndexChanged(object sender, EventArgs e)
        {
            informIfDataFileNotExist();
        }

        private void comboFillingGapsNumberIndexChanged(object sender, EventArgs e)
        {
            informIfDataFileNotExist();
        }

        private void buttonViewClick(object sender, EventArgs e)
        {
            reset();
            
            try
            {
                readMachines();
                readAverageResult();
                readSummary();
            }
            catch (Exception exception)
            {
                return;
            }
           
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
            StreamReader reader = readFile(getMachinesMoneyFileName());

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
            StreamReader reader = readFile(getAverageMoneyFileName());

            reader.ReadLine();
            for (String line=""; line != null; line = reader.ReadLine())
            {
                if (line == "")
                    continue;

                    averageResult.addSlice(line);
            }
        }

        private void readSummary()
        {
            StreamReader reader = readFile(getMachinesSummaryFileName());

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
