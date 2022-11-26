using AssettoCorsaSharedMemory;
using Overlays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ACCPitstopCalcGUI
{
    public partial class FrmGUI : Form
    {
        /// <summary>
        /// enumerates a set of potential color schemes for the main form
        /// </summary>
        public enum ColorScheme
        {
            light,
            dark
        }
        //initializes a collection of controls for use in theme switching
        Control.ControlCollection controls;
        //initializes an XmlSerializer object for the purpose of saving and loading settings
        readonly XmlSerializer serializer = new(typeof(Settings));
        
        /// <summary>
        /// main constructor
        /// </summary>
        public FrmGUI()
        {
            settings.colorScheme = ColorScheme.dark;
            InitializeComponent();
        }
        /// <summary>
        /// settings that can be writtin and read from an XML file
        /// </summary>
        [Serializable]
        public struct Settings
        {
            public ColorScheme colorScheme;
            public int windowed_x;
            public int windowed_y;

            public FuelOverlay.FuelOverlaySettings fuelOverlaySettings;
        }
        /// <summary>
        /// structure that defines laps in terms of lap number and lap time
        /// </summary>
        public struct Lap
        {
            public int lapNumber { get; set; }
            public int lapTime { get; set; }
            public decimal lastLapFuel { get; set; }
        }
        //declaration for opening a fuel calculation overlay later in code
        FuelOverlay fuelOverlay;
        BindingList<Lap> lapTimes;
        BindingSource lapTimesBinding;
        decimal lastLapFuelInTank;
        private Settings settings = new();
        /// <summary>
        /// save basic settings to do with the master form
        /// </summary>
        private void saveOptions()
        {
            settings.windowed_x = Location.X;
            settings.windowed_y = Location.Y;
            if (fuelOverlay != null)
            {
                settings.fuelOverlaySettings = fuelOverlay.GetSettings();
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PitStopCalculator";
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            try
            {
                    System.IO.FileStream file = System.IO.File.Create(path + "\\settings.xml");
                    serializer.Serialize(file, settings);
                    file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an issue writing your settings. Please Ensure that the file in 'My Documents\\pitStopCalculator\\settings.xml', or any of its parents are" +
                    " not read-only" + ex.Message);
            }
        }
        /// <summary>
        /// load basic settings to do with the master form
        /// </summary>
        private void loadOptions()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\PitStopCalculator\\settings.xml";
            if (System.IO.File.Exists(path))
            {
                System.IO.FileStream file = System.IO.File.Open(path, System.IO.FileMode.Open);
                var _data = serializer.Deserialize(file);
                if (_data.GetType() == typeof(Settings))
                {
                    settings = (Settings)_data;
                }
                file.Close();
            }
        }
        
        /*
        /// <summary>
        /// map the entrylist from UDP data to an internal variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="carInfo">UDP data on the static car data in the session</param>
        private void c_EntrylistUpdate(string sender, ksBroadcastingNetwork.Structs.CarInfo carInfo)
        {
            Program.carInfo = carInfo;
        }
        /// <summary>
        /// map the car data from UDP data to an internal variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="carUpdate">UDP data on the dynamic car data in the session</param>
        private void c_OnRealTimeCarUpdate(string sender, ksBroadcastingNetwork.Structs.RealtimeCarUpdate carUpdate)
        {
            
            Program.realTimeCarUpdate = carUpdate;
        }
        /// <summary>
        /// map real time data from UDP data about the session to an internal variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="update">UDP data concerning the session and track</param>
        private void c_OnRealTimeUpdate(string sender, ksBroadcastingNetwork.Structs.RealtimeUpdate update)
        {
            Program.realTimeUpdate = update;
        }
        /// <summary>
        /// map track data from UDP data about the track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="trackData">UDP data about the track</param>
        private void c_OnTrackDataUpdate(string sender, ksBroadcastingNetwork.Structs.TrackData trackData)
        {
            Program.trackData = trackData;

        }
        /// <summary>
        /// gonna be honest, no one knows what this is, but mapping it to internal variable anyway
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="broadcastingEvent">what is this kunos?</param>
        private void c_OnBroadcastingEvent(string sender, ksBroadcastingNetwork.Structs.BroadcastingEvent broadcastingEvent)
        {
            Program.broadcastingEvents = broadcastingEvent;
        }
        /// <summary>
        /// event that designates if the UDP connection state has been changed
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="connectionSuccess"></param>
        /// <param name="isReadonly"></param>
        /// <param name="error"></param>

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
        }*/
        /// <summary>
        /// enters a lap time to a DataGridView containing all lap times upon pressing the "Enter Lap Time" button on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterLapTime_Click(object sender, EventArgs e)
        {
            if (nudLapTimeMinutes.Value > 0 || nudLapTimeSeconds.Value > 0)
            {
                nudLapTimeSeconds.Value = Math.Round(nudLapTimeSeconds.Value, 3);
                int _lapNumber = lapTimes.Count != 0 ? lapTimes.Max(x => x.lapNumber) + 1 : 1;
                AddLapTime(_lapNumber, (int)((nudLapTimeMinutes.Value * 60 + nudLapTimeSeconds.Value)*1000),nudFuelPerLap.Value);
            }
        }
        /// <summary>
        /// Refactoring of adding lap times to a DataGridView reducing length of code
        /// </summary>
        /// <param name="lap"> lap number</param>
        /// <param name="minutes">minutes portion of lap duration</param>
        /// <param name="seconds">seconds portion of lap duration</param>
        private void AddLapTime(int lapCount, int milliseconds, decimal lastLapFuel)
        {
            if (lapCount > 0)
            {
                Lap lap = new()
                {
                    lapNumber = lapCount,
                    lapTime = milliseconds,
                    lastLapFuel = lastLapFuel
                };
                int index = -1;
                foreach (Lap x in lapTimes)
                {
                    if (x.lapNumber == lap.lapNumber)
                    {
                        index = lapTimes.IndexOf(x);
                    }
                }
                if (index != -1)
                {
                    dgvLapTimes.Invoke((MethodInvoker)delegate () { lapTimes.RemoveAt(index); });
                }
                dgvLapTimes.Invoke((MethodInvoker)delegate () { lapTimes.Add(lap); });
            }
        }
        /// <summary>
        /// deletes a lap time from the DataGridView containing lap times
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// clears the DataGridView containing all laps
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAllLaps_Click(object sender, EventArgs e)
        {
            dgvLapTimes.Rows.Clear();
        }
        /// <summary>
        /// closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// opens a text box with credit to the developers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application was developed by Shentar and Squid - Copyright 2021");
        }
        /// <summary>
        /// includes some clean-up and saving of settings prior to fully closing the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveOptions();
            Program.sharedMemory.Stop();
            /*Program.client.Shutdown();
            Program.client.Dispose();*/
        }
        /// <summary>
        /// actuated on clicking the Calculate Button, calculating fuel required as per the inputs on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateFuel();
        }
        /// <summary>
        /// contains the logic required for calculating fuel
        /// </summary>
        private void CalculateFuel()
        {
            //convert the remaining session time to seconds
            decimal nudTimeRemainingMilliseconds = ((nudTimeRemainingHours.Value * 60 * 60) + (nudTimeRemainingMinutes.Value * 60) + nudTimeRemainingSeconds.Value) * 1000;
            decimal timeRemainingMilliseconds = Program.graphics.SessionTimeLeft > 0 ? (decimal)Program.graphics.SessionTimeLeft : nudTimeRemainingMilliseconds;
            if(Program.graphics.DriverStintTimeLeft > 0)
                //timeRemainingMilliseconds = timeRemainingMilliseconds > Program.graphics.DriverStintTimeLeft ? timeRemainingMilliseconds : Program.graphics.DriverStintTimeLeft;

            if (lapTimes != null)
            {
                if (lapTimes.Count > 0)
                {
                    //assign minimum, maximum and average lap times from the list of lap times
                    decimal maxFuelConsumption = lapTimes.Min(x => x.lastLapFuel);
                    decimal minFuelConsumption = lapTimes.Max(x => x.lastLapFuel);
                    decimal avgFuelPerLap = lapTimes.Average(x => x.lastLapFuel);
                    //[0] fuel duration in laps
                    //[1] how much to fill fuel tank by
                    //[2] how much fuel will be remaining at the end of the race
                    List<decimal> avgFuelData = FuelCalculatorDLL.FuelCalc.CalculateFuel(timeRemainingMilliseconds, (decimal)lapTimes.Average(x => x.lapTime), avgFuelPerLap, lastLapFuelInTank, (decimal)Program.staticInfo.MaxFuel);
                    List<decimal> minFuelData = FuelCalculatorDLL.FuelCalc.CalculateFuel(timeRemainingMilliseconds, (decimal)lapTimes.Average(x => x.lapTime), minFuelConsumption, lastLapFuelInTank, (decimal)Program.staticInfo.MaxFuel);
                    List<decimal> maxFuelData = FuelCalculatorDLL.FuelCalc.CalculateFuel(timeRemainingMilliseconds, (decimal)lapTimes.Average(x => x.lapTime), maxFuelConsumption, lastLapFuelInTank, (decimal)Program.staticInfo.MaxFuel);
                    
                    fuelOverlay?.UpdateAverage(avgFuelData[1], avgFuelData[0], avgFuelData[2]);
                    fuelOverlay?.UpdateMax(maxFuelData[1], maxFuelData[0], maxFuelData[2]);
                    fuelOverlay?.UpdateMin(minFuelData[1], minFuelData[0], minFuelData[2]);

                    lblRefuelToOutput.Invoke((MethodInvoker)delegate { lblRefuelToOutput.Text = avgFuelData[1].ToString(); });
                    lblProjectedLapsOutput.Invoke((MethodInvoker)delegate { lblProjectedLapsOutput.Text = avgFuelData[0].ToString(); });
                }
            }
        }
        /// <summary>
        /// shared memory handler for when the status of Assetto Corsa (Competizione) changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_GameStatusChanged(object sender, EventArgs e)
        {
            if (Program.sharedMemory.IsRunning)
            {
                Program.memoryConnected = true;
            }
        }
        /// <summary>
        /// shared memory handler for when the race, practice or qualifying session static info is updated. currently used only to grab the maximum fuel a car can handle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// event handler to capture data from shared memory partaining to graphical aspects of AC/ACC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_graphicsInfoChanged(object sender, EventArgs e)
        {            
            Graphics newGraphics = Program.sharedMemory.ReadGraphics();
            Physics newPhysics = Program.sharedMemory.ReadPhysics();
            StaticInfo newStaticInfo = Program.sharedMemory.ReadStaticInfo();
            if (newGraphics.Status == ACC_STATUS.AC_LIVE)
            {
                if (Program.graphics.CompletedLaps != 0)
                {
                    if (Program.graphics.iLastTime != int.MaxValue)
                    {
                        if (newGraphics.CompletedLaps != Program.graphics.CompletedLaps)
                        {
                            if (lastLapFuelInTank != 0)
                            {
                                AddLapTime(newGraphics.CompletedLaps, newGraphics.iLastTime, lastLapFuelInTank - (decimal)newPhysics.Fuel);
                            }
                            else
                            {
                                AddLapTime(newGraphics.CompletedLaps, newGraphics.iLastTime, (decimal)newGraphics.FuelXLap);
                            }
                            CalculateFuel();
                            lastLapFuelInTank = (decimal)newPhysics.Fuel;
                        }
                    }
                }
            }
            updateFormControls(newGraphics);
            Program.graphics = newGraphics;
            Program.physics = newPhysics;
            Program.staticInfo = newStaticInfo;

            //restart the graphics read timer here to prevent a 'race' between threads and errors cropping up
            Program.sharedMemory.graphicsTimer.Start();
            label1.Invoke((MethodInvoker)delegate { label1.Text = lastLapFuelInTank.ToString(); });
        }
        /// <summary>
        /// refactors updating the form controls outside of c_graphicsInfoChanged
        /// </summary>
        /// <param name="graphics">shared memory data partaining to the graphical aspects of AC/ACC</param>
        private void updateFormControls(Graphics graphics)
        {
            decimal time = graphics.SessionTimeLeft != float.PositiveInfinity ? (decimal)graphics.SessionTimeLeft : 0;
            decimal timeRemainingHours = Math.Floor(time / (1000 * 60 * 60));
            time -= timeRemainingHours * 1000 * 60 * 60;
            decimal timeRemainingMinutes = Math.Floor(time / (1000 * 60));
            time -= timeRemainingMinutes * 1000 * 60;
            decimal timeRemainingSeconds = time / 1000;

            if (graphics.SessionTimeLeft >= 0)
            {
                nudTimeRemainingHours.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingHours.Value = timeRemainingHours; });
                nudTimeRemainingMinutes.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingMinutes.Value = timeRemainingMinutes; });
                nudTimeRemainingSeconds.BeginInvoke((MethodInvoker)delegate () { nudTimeRemainingSeconds.Value = timeRemainingSeconds; });
                nudFuelPerLap.Invoke((MethodInvoker)delegate () { nudFuelPerLap.Value = (decimal)graphics.FuelXLap; });
            }
        }
        /// <summary>
        /// event handler to capture data from shared memory partaining to physics data from AC/ACC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void c_physicsInfoChanged(object sender, EventArgs e)
        {
            Program.physics = Program.sharedMemory.ReadPhysics();
            Program.sharedMemory.physicsTimer.Start();
        }*/
        /// <summary>
        /// after the main form is shown, loads settings, sets event handlers, begins shared memory and UDP functions, and styles the form as per the settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGUI_Shown(object sender, EventArgs e)
        {
            loadOptions();
            lapTimes = new();
            lapTimesBinding = new(lapTimes, null);
            dgvLapTimes.DataSource = lapTimesBinding;
            dgvLapTimes.Columns[0].HeaderText = "Lap";
            dgvLapTimes.Columns[1].HeaderText = "Lap (ms)";
            dgvLapTimes.Columns[2].HeaderText = "Fuel uesd";
            dgvLapTimes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLapTimes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLapTimes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            switch (settings.colorScheme)
            {
                case (ColorScheme.light):
                    lightModeSwitch();
                    break;
                case (ColorScheme.dark):
                    darkModeSwitch();
                    break;
                default:
                    darkModeSwitch();
                    break;
            }
            if(0 > settings.fuelOverlaySettings.transparency || 100 < settings.fuelOverlaySettings.transparency)
            {
                hscOverlayTransparency.Value = 25;
                settings.fuelOverlaySettings.transparency = 25;
            }
            else
            {
                hscOverlayTransparency.Value = (int)settings.fuelOverlaySettings.transparency;
            }
            chkClickThrough.Invoke((MethodInvoker)delegate () { chkClickThrough.Checked = settings.fuelOverlaySettings.isClickThrough; });
            Program.memoryConnected = false;
            Program.sharedMemory.Start();
            Program.sharedMemory.GameStatusChanged += c_GameStatusChanged;
            Program.memoryConnected = Program.sharedMemory.IsRunning;
            Program.sharedMemory.GraphicsUpdated += c_graphicsInfoChanged;
            //Program.sharedMemory.PhysicsUpdated += c_physicsInfoChanged;
            Program.sharedMemory.StaticInfoUpdated += c_staticInfoChanged;
            //Program.client = new("127.0.0.1", 9000, "Your Name", "asd", "", 250);
            //Program.client.MessageHandler.OnConnectionStateChanged += c_ConnectionStateChanged;
        }

        /// <summary>
        /// open semitransparent overlay with fuel calculations on it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiOpenOverlay_Click(object sender, EventArgs e)
        {
            if(fuelOverlay == null)
            {
                fuelOverlay = new(settings.fuelOverlaySettings);
                fuelOverlay.Show();
                CalculateFuel();
            }
        }
        /// <summary>
        /// event handler to change the form to "light mode"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lightModeSwitch();
        }
        /// <summary>
        /// changes form and controls to a light version
        /// </summary>
        private void lightModeSwitch()
        {
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            controls = this.Controls;
            foreach (Control c in controls)
            {
                c.BackColor = System.Drawing.SystemColors.ControlLight;
                c.ForeColor = System.Drawing.SystemColors.ControlText;
            }
            menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            tsmiFile.BackColor = System.Drawing.SystemColors.Window;
            tsiConfig.BackColor = System.Drawing.SystemColors.Window;
            tsmiAbout.BackColor = System.Drawing.SystemColors.Window;
            tsmiFile.ForeColor = System.Drawing.SystemColors.WindowText;
            tsiConfig.ForeColor = System.Drawing.SystemColors.WindowText;
            tsmiAbout.ForeColor = System.Drawing.SystemColors.WindowText;
            settings.colorScheme = ColorScheme.light;
        }
        /// <summary>
        /// event handler to change the form to "dark mode"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkModeSwitch();
        }
        /// <summary>
        /// switches the form and controls to a dark version
        /// </summary>
        private void darkModeSwitch()
        {
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            controls = this.Controls;
            foreach (Control c in controls)
            {
                c.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                c.BackColor = System.Drawing.SystemColors.WindowFrame;
            }
            menuStrip1.BackColor = System.Drawing.SystemColors.WindowText;
            tsmiFile.ForeColor = System.Drawing.SystemColors.Window;
            tsiConfig.ForeColor = System.Drawing.SystemColors.Window;
            tsmiAbout.ForeColor = System.Drawing.SystemColors.Window;
            tsmiFile.BackColor = System.Drawing.SystemColors.WindowText;
            tsiConfig.BackColor = System.Drawing.SystemColors.WindowText;
            tsmiAbout.BackColor = System.Drawing.SystemColors.WindowText;
            settings.colorScheme = ColorScheme.dark;
        }
        /// <summary>
        /// once the form is all done saving and cleaning up, exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
        /// <summary>
        /// saves the settings of the main form upon command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveOptions();
        }
        /// <summary>
        /// changes the overlay between clickable and click-through
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkClickThrough_CheckedChanged(object sender, EventArgs e)
        {
            settings.fuelOverlaySettings.isClickThrough= chkClickThrough.Checked;
            if (fuelOverlay != null)
            {
                if (settings.fuelOverlaySettings.isClickThrough)
                {
                    fuelOverlay.makeClickthrough();
                }
                else
                {
                    fuelOverlay.makeClickable();
                }
            }
        }

        private void hscOverlayTransparency_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = hscOverlayTransparency.Value.ToString();
            if (fuelOverlay != null)
                fuelOverlay.ChangeTransparency((decimal)hscOverlayTransparency.Value/100);
        }
    }
}
