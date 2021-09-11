using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ACCPitstopCalcGUI
{
    public partial class FrmGUI : Form
    {
        public FrmGUI()
        {
            InitializeComponent();
        }

        private void tbTimeRemaining_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ':' || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void tbEnterLapTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ':' || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }
        private void btnEnterLapTime_Click(object sender, EventArgs e)
        {
            if (nudLapTimeMinutes.Value > 0 || nudLapTimeSeconds.Value > 0)
            {
                nudLapTimeSeconds.Value = Math.Round(nudLapTimeSeconds.Value, 3);
                int RowAdded = dgvLapTimes.Rows.Add();
                DataGridViewRow newRow = dgvLapTimes.Rows[RowAdded];
                newRow.Cells[0].Value = RowAdded + 1;
                newRow.Cells[1].Value = nudLapTimeMinutes.Value;
                newRow.Cells[2].Value = nudLapTimeSeconds.Value;
            }
        }

        private void btnDeleteLap_Click(object sender, EventArgs e)
        {
            if(dgvLapTimes.SelectedCells.Count != 0)
            {
                int rowIndex = dgvLapTimes.CurrentCell.RowIndex;
                    dgvLapTimes.Rows.RemoveAt(rowIndex);
            }
            else
            {
                if (dgvLapTimes.Rows.Count != 0)
                {
                    dgvLapTimes.Rows.RemoveAt(dgvLapTimes.Rows.Count - 1);
                }
            }
        }

        private void btnClearAllLaps_Click(object sender, EventArgs e)
        {
            dgvLapTimes.Rows.Clear();
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application was developed by Shentar and Squid - Copyright 2021");
        }

        private void FrmGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal timeRemainingSeconds = (nudTimeRemainingHours.Value * 60 * 60) + (nudTimeRemainingMinutes.Value * 60) + nudTimeRemainingSeconds.Value;
            if (dgvLapTimes.RowCount != 0)
            {
                DataGridViewRowCollection lapTimes = dgvLapTimes.Rows;
                List<decimal> lapTimesSeconds = new List<decimal>();
                foreach (DataGridViewRow lapTime in lapTimes)
                {
                    lapTimesSeconds.Add(FuelCalculatorDLL.FuelCalc.LapToSeconds((decimal)lapTime.Cells[1].Value, (decimal)lapTime.Cells[2].Value));
                }
                decimal averageLapTime = FuelCalculatorDLL.FuelCalc.AvgCalc(lapTimesSeconds);
                int estimatedLaps = FuelCalculatorDLL.FuelCalc.ProjectedLaps(timeRemainingSeconds, averageLapTime);
                int fillTo = FuelCalculatorDLL.FuelCalc.FinalCalculation(nudFuelPerLap.Value, estimatedLaps);
                lblRefuelToOutput.Text = fillTo.ToString();
                lblProjectedLapsOutput.Text = estimatedLaps.ToString();
            }
        }
    }
}
