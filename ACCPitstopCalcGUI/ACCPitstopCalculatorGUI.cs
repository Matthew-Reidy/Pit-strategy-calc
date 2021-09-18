using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.ComponentModel;
using System.Drawing;

namespace ACCPitstopCalcGUI
{
    public partial class FrmGUI : Form
    {
        enum ColorScheme
        {
            light,
            dark
        }
        ColorScheme colorScheme;
        sortLapTimes sorter;
        Control.ControlCollection controls;
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
            colorScheme = ColorScheme.dark;
            sorter = new();
            InitializeComponent();
        }
        private void c_EntrylistUpdate(string sender, ksBroadcastingNetwork.Structs.CarInfo carInfo)
        {
            Program.carInfo = carInfo;
        }
        private void c_OnRealTimeCarUpdate(string sender, ksBroadcastingNetwork.Structs.RealtimeCarUpdate carUpdate)
        {
            
            Program.realTimeCarUpdate = carUpdate;
        }
        private void c_OnRealTimeUpdate(string sender, ksBroadcastingNetwork.Structs.RealtimeUpdate update)
        {
            Program.realTimeUpdate = update;
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
                int estimatedLaps = FuelCalculatorDLL.FuelCalc.ProjectedLaps(timeRemainingSeconds + Program.graphics.iCurrentTime/1000, averageLapTime);
                int fillTo = FuelCalculatorDLL.FuelCalc.FinalCalculation(nudFuelPerLap.Value, estimatedLaps);
                if (fillTo > nudFuelTankSize.Value) 
                {
                    fillTo = (int)nudFuelTankSize.Value;
                }
                lblRefuelToOutput.Text = fillTo.ToString();
                lblProjectedLapsOutput.Text = estimatedLaps.ToString();
            }
        }
        private void c_GameStatusChanged(object sender, EventArgs e)
        {
            Program.memoryConnected = Program.sharedMemory.IsRunning;
            if (label1.InvokeRequired) 
            { 
                label1.Invoke((MethodInvoker)delegate () {
                    label1.Text = Program.memoryConnected.ToString(); 
                });
            }
        }
        private void c_staticInfoChanged(object sender, EventArgs e)
        {
            Program.staticInfo = Program.sharedMemory.ReadStaticInfo();
            if (nudFuelTankSize.InvokeRequired)
            {
                nudFuelTankSize.Invoke((MethodInvoker)delegate () { nudFuelTankSize.Value = (decimal)Program.staticInfo.MaxFuel; });
            }else
            {
                nudFuelTankSize.Value = (decimal)Program.staticInfo.MaxFuel;
            }
        }
        private void c_graphicsInfoChanged(object sender, EventArgs e)
        {
            AssettoCorsaSharedMemory.Graphics newGraphics = Program.sharedMemory.ReadGraphics();
            if (Program.graphics.CompletedLaps != int.MaxValue)
            {
                if(Program.graphics.iLastTime != int.MaxValue)
                {
                    if(newGraphics.CompletedLaps != Program.graphics.CompletedLaps)
                    {
                        bool lapExists = false;
                        DataGridViewRowCollection rows = dgvLapTimes.Rows;
                        if(dgvLapTimes.RowCount != 0) 
                        {
                            foreach (DataGridViewRow r in rows)
                            {
                                if ((int)r.Cells[0].Value == newGraphics.CompletedLaps)
                                {
                                    lapExists = true;
                                }
                                else
                                {
                                    lapExists = false;
                                }
                            }
                            if (!lapExists)
                            {
                                int rowAdded = 0;
                                if (dgvLapTimes.InvokeRequired)
                                {
                                    dgvLapTimes.Invoke((MethodInvoker)delegate () { rowAdded = dgvLapTimes.Rows.Add(); });
                                }
                                else
                                {
                                    dgvLapTimes.Rows.Add();
                                }
                                DataGridViewRow newRow = dgvLapTimes.Rows[rowAdded];
                                decimal lapTimeS = (decimal)newGraphics.iLastTime / 1000;
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
                                        newRow.Cells[0].Value = newGraphics.CompletedLaps;
                                    });
                                }
                                else
                                {
                                    newRow.Cells[2].Value = lapTimeS % 60;
                                    newRow.Cells[1].Value = Math.Floor(lapTimeS / 60);
                                    newRow.Cells[0].Value = newGraphics.CompletedLaps;
                                }
                            }
                        }
                        else
                        {
                            int rowAdded = 0;
                            if (dgvLapTimes.InvokeRequired)
                            {
                                dgvLapTimes.Invoke((MethodInvoker)delegate () { rowAdded = dgvLapTimes.Rows.Add(); });
                            }
                            else
                            {
                                dgvLapTimes.Rows.Add();
                            }
                            DataGridViewRow newRow = dgvLapTimes.Rows[rowAdded];
                            decimal lapTimeS = (decimal)newGraphics.iLastTime / 1000;
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
                                    newRow.Cells[0].Value = newGraphics.CompletedLaps;
                                });
                            }
                            else
                            {
                                newRow.Cells[2].Value = lapTimeS % 60;
                                newRow.Cells[1].Value = Math.Floor(lapTimeS / 60);
                                newRow.Cells[0].Value = newGraphics.CompletedLaps;
                            }
                            if (dgvLapTimes.InvokeRequired)
                            {
                                dgvLapTimes.Invoke((MethodInvoker)delegate () { dgvLapTimes.Sort(sorter = new()); });
                            }
                        }
                    }
                }
            }
            decimal time = (decimal)newGraphics.SessionTimeLeft;
            decimal timeRemainingHours = (decimal)Math.Floor(time / (1000 * 60 * 60));
            time -= timeRemainingHours * 1000 * 60 * 60;
            decimal timeRemainingMinutes = (decimal)Math.Floor(time / (1000 *60));
            time -= timeRemainingMinutes * 1000 * 60;
            decimal timeRemainingSeconds = time/1000;
            
            if (newGraphics.SessionTimeLeft != -1) 
            {
                if (nudTimeRemainingHours.InvokeRequired)
                {
                    nudTimeRemainingHours.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingHours.Value = timeRemainingHours; });
                    nudTimeRemainingMinutes.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingMinutes.Value = timeRemainingMinutes; });
                    nudTimeRemainingSeconds.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingSeconds.Value = timeRemainingSeconds; });

                }
                else
                {

                    nudTimeRemainingHours.Value = timeRemainingHours;
                    nudTimeRemainingMinutes.Value = timeRemainingMinutes;
                    nudTimeRemainingSeconds.Value = timeRemainingSeconds;
                }
                if (nudFuelPerLap.InvokeRequired)
                {
                    nudFuelPerLap.Invoke((MethodInvoker)delegate () { nudFuelPerLap.Value = (decimal)newGraphics.FuelXLap; });
                }
                else
                {
                    nudFuelPerLap.Value = (decimal)newGraphics.FuelXLap;
                }
            }
            Program.graphics = newGraphics;
        }
        private void c_physicsInfoChanged(object sender, EventArgs e)
        {
            Program.physics = Program.sharedMemory.ReadPhysics();
        }
        private void FrmGUI_Shown(object sender, EventArgs e)
        {
            Program.memoryConnected = false;
            Program.sharedMemory.Start();
            Program.sharedMemory.GameStatusChanged += c_GameStatusChanged;
            Program.memoryConnected = Program.sharedMemory.IsRunning;
            Program.sharedMemory.GraphicsUpdated += c_graphicsInfoChanged;
            Program.sharedMemory.PhysicsUpdated += c_physicsInfoChanged;
            Program.sharedMemory.StaticInfoUpdated += c_staticInfoChanged;
            Program.client = new("127.0.0.1", 9000, "Your Name", "asd", "", 250);
            Program.client.MessageHandler.OnConnectionStateChanged += c_ConnectionStateChanged;
        }

        private void tsmiOpenOverlay_Click(object sender, EventArgs e)
        {

        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
            this.ForeColor = SystemColors.WindowText;
            controls = this.Controls;
            foreach (Control c in controls)
            {
                c.BackColor = SystemColors.ControlLight;
                c.ForeColor = SystemColors.ControlText;
            }
            menuStrip1.BackColor = SystemColors.Window;
            tsmiFile.BackColor = SystemColors.Window;
            tsiConfig.BackColor = SystemColors.Window;
            tsmiAbout.BackColor = SystemColors.Window;
            tsmiFile.ForeColor = SystemColors.WindowText;
            tsiConfig.ForeColor = SystemColors.WindowText;
            tsmiAbout.ForeColor = SystemColors.WindowText;
            colorScheme = ColorScheme.light;
        }

        private void tsmiFile_DropDownOpened(object sender, EventArgs e)
        {
            switch (colorScheme)
            {
                case ColorScheme.dark:
                    ((ToolStripMenuItem)sender).BackColor = SystemColors.Window;
                    ((ToolStripMenuItem)sender).ForeColor = SystemColors.WindowText;
                    break;
                case ColorScheme.light:
                    ((ToolStripMenuItem)sender).BackColor = SystemColors.WindowText;
                    ((ToolStripMenuItem)sender).ForeColor = SystemColors.Window;
                    break;
                default:
                    break;

            }
        }

        private void tsmiFile_DropDownClosed(object sender, EventArgs e)
        {
            switch (colorScheme)
            {
                case ColorScheme.dark:
                    ((ToolStripMenuItem)sender).BackColor = SystemColors.WindowText;
                    ((ToolStripMenuItem)sender).ForeColor = SystemColors.Window;
                    break;
                case ColorScheme.light:
                    ((ToolStripMenuItem)sender).BackColor = SystemColors.Window;
                    ((ToolStripMenuItem)sender).ForeColor = SystemColors.WindowText;
                    break;
                default:
                    break;

            }
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ForeColor = SystemColors.Window;
            this.BackColor = SystemColors.WindowFrame;
            controls = this.Controls;
            foreach (Control c in controls)
            {
                c.ForeColor = SystemColors.ControlLightLight;
                c.BackColor = SystemColors.WindowFrame;
            }
            menuStrip1.BackColor = SystemColors.WindowText;
            tsmiFile.ForeColor = SystemColors.Window;
            tsiConfig.ForeColor = SystemColors.Window;
            tsmiAbout.ForeColor = SystemColors.Window;
            tsmiFile.BackColor = SystemColors.WindowText;
            tsiConfig.BackColor = SystemColors.WindowText;
            tsmiAbout.BackColor = SystemColors.WindowText;
            colorScheme = ColorScheme.dark;
        }
    }
}
