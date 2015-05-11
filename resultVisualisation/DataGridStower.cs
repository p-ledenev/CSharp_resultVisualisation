using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace resultVisualisation
{
    class DataGridStower
    {
        protected List<Machine> machines;

        public DataGridStower(List<Machine> machines, Machine averageResult)
        {
            this.machines = new List<Machine>();
            this.machines.AddRange(machines);
            this.machines.Add(averageResult);
        }

        public void stow(DataGridView dataGrid)
        {
            fillDataGridHeader(dataGrid);
            fillDataGridWith("maxLoss", dataGrid);
            fillDataGridWith("maxMoney", dataGrid);
            fillDataGridWith("endPeriodMoney", dataGrid);
        }

        private void fillDataGridHeader(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = "Parameter";
            column.Width = 90;
            dataGrid.Columns.Add(column);

            foreach (Machine machine in machines)
            {
                column = new DataGridViewTextBoxColumn();
                column.Name = machine.title;
                column.Width = 52;
                dataGrid.Columns.Add(column);
            }
        }

        private void fillDataGridWith(String parameterName, DataGridView dataGrid)
        {
            DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();

            int i = 0;
            row.Cells[i++].Value = parameterName;

            foreach (Machine machine in machines)
                row.Cells[i++].Value = machine.GetType().GetProperty(parameterName).GetValue(machine, null);

            dataGrid.Rows.Add(row);
        }
    }
}
