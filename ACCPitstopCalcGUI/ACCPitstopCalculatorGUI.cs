using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.ComponentModel;

namespace ACCPitstopCalcGUI
{
    public partial class FrmGUI : Form
    {
        sortLapTimes sorter;
        private class sortLapTimes : System.Collections.IComparer
        {
            private int sortModifier = -1;
            public sortLapTimes()
            {

            }
            public int Compare(object a, object b)
            {
                DataGridViewRow rowA = (DataGridViewRow)a;
                DataGridViewRow rowB = (DataGridViewRow)b;
                bool compareResult = (int)rowA.Cells[0].Value > (int)rowB.Cells[0].Value;
                int orderResult;
                if (compareResult)
                {
                    orderResult = 1;
                }
                else
                {
                    orderResult = -1;
                }
                return orderResult * sortModifier;
            }
        }
        public FrmGUI()
        {
            sorter = new();
            InitializeComponent();
        }
        private void c_EntrylistUpdate(string sender, ksBroadcastingNetwork.Structs.CarInfo carInfo)
        {
            Program.carInfo = carInfo;
        }
        private void c_OnRealTimeCarUpdate(string sender, ksBroadcastingNetwork.Structs.RealtimeCarUpdate carUpdate)
        {
            if(Program.realTimeUpdate.FocusedCarIndex == carUpdate.CarIndex)
            {
                if (!(Program.realTimeCarUpdate.Laps == carUpdate.Laps))
                {
                    if(dgvLapTimes.Rows.Count != 0)
                    {
                        DataGridViewRowCollection rows = dgvLapTimes.Rows;
                        bool lapExists = false;
                        foreach(DataGridViewRow r in rows)
                        {
                            if((int)r.Cells[0].Value == carUpdate.Laps - 1)
                            {
                                lapExists = true;
                            }
                            else
                            {
                                lapExists = false;
                            }
                        }
                            if(!lapExists)
                        {
                            int rowAdded = dgvLapTimes.Rows.Add();
                            DataGridViewRow newRow = dgvLapTimes.Rows[rowAdded];
                            decimal lapTimeS = (decimal)carUpdate.LastLap.LaptimeMS / 1000;
                                if (dgvLapTimes.InvokeRequired)
                                {
                                    BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        newRow.Cells[2].Value = lapTimeS % 60;
                                    });
                                    BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        newRow.Cells[1].Value = Math.Floor(lapTimeS / 60);
                                    });
                                    BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        newRow.Cells[0].Value = carUpdate.Laps - 1;
                                    });
                                    BeginInvoke((MethodInvoker)delegate ()
                                    {
                                        label1.Text = Program.realTimeCarUpdate.LastLap.LaptimeMS.ToString();
                                    });
                                }
                                else
                                {
                                    newRow.Cells[2].Value = lapTimeS % 60;
                                    newRow.Cells[1].Value = Math.Floor(lapTimeS / 60);
                                    newRow.Cells[0].Value = carUpdate.Laps - 1;
                                }
                            } 
                        
                    }
                    else
                    {
                        int rowAdded = dgvLapTimes.Rows.Add();
                        DataGridViewRow newRow = dgvLapTimes.Rows[rowAdded];
                        decimal lapTimeS = (decimal)carUpdate.LastLap.LaptimeMS / 1000;
                        if (dgvLapTimes.InvokeRequired)
                        {
                            BeginInvoke((MethodInvoker)delegate ()
                            {
                                newRow.Cells[2].Value = lapTimeS % 60;
                            });
                            BeginInvoke((MethodInvoker)delegate ()
                            {
                                newRow.Cells[1].Value = Math.Floor(lapTimeS / 60);
                            });
                            BeginInvoke((MethodInvoker)delegate ()
                            {
                                newRow.Cells[0].Value = carUpdate.Laps - 1;
                            });
                            BeginInvoke((MethodInvoker)delegate ()
                            {
                                label1.Text = Program.realTimeCarUpdate.LastLap.LaptimeMS.ToString();
                            });
                        }
                        else
                        {
                            newRow.Cells[2].Value = lapTimeS % 60;
                            newRow.Cells[1].Value = Math.Floor(lapTimeS / 60);
                            newRow.Cells[0].Value = carUpdate.Laps - 1;
                        }
                    }
                    dgvLapTimes.Sort(sorter);
                }
                Program.realTimeCarUpdate = carUpdate;
            }
        }
        private void c_OnRealTimeUpdate(string sender, ksBroadcastingNetwork.Structs.RealtimeUpdate update)
        {
            Program.realTimeUpdate = update;
            if (nudTimeRemainingHours.InvokeRequired)
            {
                nudTimeRemainingHours.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingHours.Value = update.SessionEndTime.Hours; });
                nudTimeRemainingMinutes.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingMinutes.Value = update.SessionEndTime.Minutes; });
                nudTimeRemainingSeconds.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingSeconds.Value = update.SessionEndTime.Seconds; });

            }
            else
            {
                nudTimeRemainingHours.Value = update.SessionEndTime.Hours;
                nudTimeRemainingMinutes.Value = update.SessionEndTime.Minutes;
                nudTimeRemainingSeconds.Value = update.SessionEndTime.Seconds;
            }
        }
        private void c_OnTrackDataUpdate(string sender, ksBroadcastingNetwork.Structs.TrackData trackData)
        {
            Program.trackData = trackData;

        }
        private void c_OnBroadcastingEvent(string sender, ksBroadcastingNetwork.Structs.BroadcastingEvent broadcastingEvent)
        {
            Program.broadcastingEvents = broadcastingEvent;
        }

        private void c_ConnectionStateChanged(int connectionId, bool connectionSuccess, bool isReadonly, string error)
        {
            if (connectionSuccess)
            {
                Program.protocol = Program.client.MessageHandler;
                Program.protocol.OnConnectionStateChanged += c_ConnectionStateChanged;
                Program.protocol.OnEntrylistUpdate += c_EntrylistUpdate;
                Program.protocol.OnRealtimeCarUpdate += c_OnRealTimeCarUpdate;
                Program.protocol.OnRealtimeUpdate += c_OnRealTimeUpdate;
                Program.protocol.OnTrackDataUpdate += c_OnTrackDataUpdate;
                Program.protocol.OnBroadcastingEvent += c_OnBroadcastingEvent;
            }
            else
            {
                label1.Text = "error";
            }
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
            if (dgvLapTimes.SelectedCells.Count != 0)
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
            Program.client.Shutdown();
            Program.client.Dispose();
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal timeRemainingSeconds = (nudTimeRemainingHours.Value * 60 * 60) + (nudTimeRemainingMinutes.Value * 60) + nudTimeRemainingSeconds.Value;
            if (dgvLapTimes.RowCount != 0)
            {
                DataGridViewRowCollection lapTimes = dgvLapTimes.Rows;
                List<decimal> lapTimesSeconds = new();
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
        private void c_GameStatusChanged(object sender, EventArgs e)
        {
            label1.Text = "Memory Connected";
        }
        private void FrmGUI_Shown(object sender, EventArgs e)
        {
            Program.client = new("127.0.0.1", 9000, "Your Name", "asd", "", 250);
            Program.client.MessageHandler.OnConnectionStateChanged += c_ConnectionStateChanged;
        }
    }
}
