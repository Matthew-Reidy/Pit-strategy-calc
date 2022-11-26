
namespace ACCPitstopCalcGUI
{
    partial class FrmGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenOverlay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFuelPerLap = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblProjectedLaps = new System.Windows.Forms.Label();
            this.lblFuelTankSize = new System.Windows.Forms.Label();
            this.lblFuelToAdd = new System.Windows.Forms.Label();
            this.lblRefuelTo = new System.Windows.Forms.Label();
            this.lblProjectedLapsOutput = new System.Windows.Forms.Label();
            this.lblFuelToAddOutput = new System.Windows.Forms.Label();
            this.lblRefuelToOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDeleteLap = new System.Windows.Forms.Button();
            this.lblEnterLapTime = new System.Windows.Forms.Label();
            this.btnEnterLapTime = new System.Windows.Forms.Button();
            this.nudFuelPerLap = new System.Windows.Forms.NumericUpDown();
            this.nudFuelTankSize = new System.Windows.Forms.NumericUpDown();
            this.btnClearAllLaps = new System.Windows.Forms.Button();
            this.lblLapTimes = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.nudLapTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblLapTimeMinutes = new System.Windows.Forms.Label();
            this.lblLapTimeSeconds = new System.Windows.Forms.Label();
            this.nudLapTimeSeconds = new System.Windows.Forms.NumericUpDown();
            this.dgvLapTimes = new System.Windows.Forms.DataGridView();
            this.lblTimeRemainingHours = new System.Windows.Forms.Label();
            this.lblTimeRemainingMinutes = new System.Windows.Forms.Label();
            this.lblTimeRemainingSeconds = new System.Windows.Forms.Label();
            this.nudTimeRemainingHours = new System.Windows.Forms.NumericUpDown();
            this.nudTimeRemainingMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudTimeRemainingSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblTrackLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkClickThrough = new System.Windows.Forms.CheckBox();
            this.hscOverlayTransparency = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelPerLap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelTankSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapTimeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeRemainingHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeRemainingMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeRemainingSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsiConfig,
            this.tsmiAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenOverlay});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // tsmiOpenOverlay
            // 
            this.tsmiOpenOverlay.Name = "tsmiOpenOverlay";
            this.tsmiOpenOverlay.Size = new System.Drawing.Size(114, 22);
            this.tsmiOpenOverlay.Text = "Overlay";
            this.tsmiOpenOverlay.Click += new System.EventHandler(this.tsmiOpenOverlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(103, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsiConfig
            // 
            this.tsiConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.tsiConfig.ForeColor = System.Drawing.SystemColors.Window;
            this.tsiConfig.Name = "tsiConfig";
            this.tsiConfig.Size = new System.Drawing.Size(55, 20);
            this.tsiConfig.Text = "Config";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.selectToolStripMenuItem.Text = "Select...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.BackColor = System.Drawing.SystemColors.WindowText;
            this.tsmiAbout.ForeColor = System.Drawing.SystemColors.Window;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // lblFuelPerLap
            // 
            this.lblFuelPerLap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFuelPerLap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelPerLap.Location = new System.Drawing.Point(13, 50);
            this.lblFuelPerLap.Name = "lblFuelPerLap";
            this.lblFuelPerLap.Size = new System.Drawing.Size(100, 15);
            this.lblFuelPerLap.TabIndex = 1;
            this.lblFuelPerLap.Text = "Fuel Per Lap: ";
            this.lblFuelPerLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTimeRemaining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeRemaining.Location = new System.Drawing.Point(13, 150);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(100, 30);
            this.lblTimeRemaining.TabIndex = 2;
            this.lblTimeRemaining.Text = "Time Remaining";
            this.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectedLaps
            // 
            this.lblProjectedLaps.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblProjectedLaps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectedLaps.Location = new System.Drawing.Point(13, 241);
            this.lblProjectedLaps.Name = "lblProjectedLaps";
            this.lblProjectedLaps.Size = new System.Drawing.Size(100, 15);
            this.lblProjectedLaps.TabIndex = 3;
            this.lblProjectedLaps.Text = "Projected Laps: ";
            this.lblProjectedLaps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelTankSize
            // 
            this.lblFuelTankSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFuelTankSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelTankSize.Location = new System.Drawing.Point(13, 100);
            this.lblFuelTankSize.Name = "lblFuelTankSize";
            this.lblFuelTankSize.Size = new System.Drawing.Size(100, 15);
            this.lblFuelTankSize.TabIndex = 4;
            this.lblFuelTankSize.Text = "Fuel Tank Size: ";
            this.lblFuelTankSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelToAdd
            // 
            this.lblFuelToAdd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFuelToAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelToAdd.Location = new System.Drawing.Point(13, 291);
            this.lblFuelToAdd.Name = "lblFuelToAdd";
            this.lblFuelToAdd.Size = new System.Drawing.Size(100, 15);
            this.lblFuelToAdd.TabIndex = 5;
            this.lblFuelToAdd.Text = "Fuel To Add: ";
            this.lblFuelToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRefuelTo
            // 
            this.lblRefuelTo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblRefuelTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRefuelTo.Location = new System.Drawing.Point(13, 341);
            this.lblRefuelTo.Name = "lblRefuelTo";
            this.lblRefuelTo.Size = new System.Drawing.Size(100, 15);
            this.lblRefuelTo.TabIndex = 6;
            this.lblRefuelTo.Text = "Refuel To: ";
            this.lblRefuelTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectedLapsOutput
            // 
            this.lblProjectedLapsOutput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblProjectedLapsOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProjectedLapsOutput.Location = new System.Drawing.Point(120, 241);
            this.lblProjectedLapsOutput.Name = "lblProjectedLapsOutput";
            this.lblProjectedLapsOutput.Size = new System.Drawing.Size(120, 15);
            this.lblProjectedLapsOutput.TabIndex = 10;
            this.lblProjectedLapsOutput.Text = "--";
            this.lblProjectedLapsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelToAddOutput
            // 
            this.lblFuelToAddOutput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFuelToAddOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelToAddOutput.Location = new System.Drawing.Point(120, 291);
            this.lblFuelToAddOutput.Name = "lblFuelToAddOutput";
            this.lblFuelToAddOutput.Size = new System.Drawing.Size(120, 15);
            this.lblFuelToAddOutput.TabIndex = 11;
            this.lblFuelToAddOutput.Text = "--";
            this.lblFuelToAddOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRefuelToOutput
            // 
            this.lblRefuelToOutput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblRefuelToOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRefuelToOutput.Location = new System.Drawing.Point(120, 341);
            this.lblRefuelToOutput.Name = "lblRefuelToOutput";
            this.lblRefuelToOutput.Size = new System.Drawing.Size(120, 15);
            this.lblRefuelToOutput.TabIndex = 12;
            this.lblRefuelToOutput.Text = "--";
            this.lblRefuelToOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculate.Location = new System.Drawing.Point(13, 391);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDeleteLap
            // 
            this.btnDeleteLap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDeleteLap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteLap.Location = new System.Drawing.Point(481, 415);
            this.btnDeleteLap.Name = "btnDeleteLap";
            this.btnDeleteLap.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLap.TabIndex = 15;
            this.btnDeleteLap.Text = "Delete Lap";
            this.btnDeleteLap.UseVisualStyleBackColor = false;
            this.btnDeleteLap.Click += new System.EventHandler(this.btnDeleteLap_Click);
            // 
            // lblEnterLapTime
            // 
            this.lblEnterLapTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterLapTime.AutoSize = true;
            this.lblEnterLapTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblEnterLapTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnterLapTime.Location = new System.Drawing.Point(352, 28);
            this.lblEnterLapTime.Name = "lblEnterLapTime";
            this.lblEnterLapTime.Size = new System.Drawing.Size(91, 15);
            this.lblEnterLapTime.TabIndex = 16;
            this.lblEnterLapTime.Text = "Enter Lap Time: ";
            // 
            // btnEnterLapTime
            // 
            this.btnEnterLapTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterLapTime.AutoSize = true;
            this.btnEnterLapTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnterLapTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnterLapTime.Location = new System.Drawing.Point(348, 114);
            this.btnEnterLapTime.Name = "btnEnterLapTime";
            this.btnEnterLapTime.Size = new System.Drawing.Size(95, 25);
            this.btnEnterLapTime.TabIndex = 18;
            this.btnEnterLapTime.Text = "Enter Lap Time";
            this.btnEnterLapTime.UseVisualStyleBackColor = false;
            this.btnEnterLapTime.Click += new System.EventHandler(this.btnEnterLapTime_Click);
            // 
            // nudFuelPerLap
            // 
            this.nudFuelPerLap.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudFuelPerLap.DecimalPlaces = 2;
            this.nudFuelPerLap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudFuelPerLap.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFuelPerLap.Location = new System.Drawing.Point(119, 48);
            this.nudFuelPerLap.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFuelPerLap.Name = "nudFuelPerLap";
            this.nudFuelPerLap.Size = new System.Drawing.Size(120, 23);
            this.nudFuelPerLap.TabIndex = 19;
            this.nudFuelPerLap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFuelPerLap.Value = new decimal(new int[] {
            31,
            0,
            0,
            65536});
            this.nudFuelPerLap.ValueChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudFuelTankSize
            // 
            this.nudFuelTankSize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudFuelTankSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudFuelTankSize.Location = new System.Drawing.Point(119, 98);
            this.nudFuelTankSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFuelTankSize.Name = "nudFuelTankSize";
            this.nudFuelTankSize.Size = new System.Drawing.Size(120, 23);
            this.nudFuelTankSize.TabIndex = 20;
            this.nudFuelTankSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFuelTankSize.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // btnClearAllLaps
            // 
            this.btnClearAllLaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAllLaps.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClearAllLaps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearAllLaps.Location = new System.Drawing.Point(606, 415);
            this.btnClearAllLaps.Name = "btnClearAllLaps";
            this.btnClearAllLaps.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllLaps.TabIndex = 23;
            this.btnClearAllLaps.Text = "Clear";
            this.btnClearAllLaps.UseVisualStyleBackColor = false;
            this.btnClearAllLaps.Click += new System.EventHandler(this.btnClearAllLaps_Click);
            // 
            // lblLapTimes
            // 
            this.lblLapTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLapTimes.AutoSize = true;
            this.lblLapTimes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLapTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLapTimes.Location = new System.Drawing.Point(481, 28);
            this.lblLapTimes.Name = "lblLapTimes";
            this.lblLapTimes.Size = new System.Drawing.Size(57, 15);
            this.lblLapTimes.TabIndex = 25;
            this.lblLapTimes.Text = "LapTimes";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblError.Location = new System.Drawing.Point(13, 423);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(116, 15);
            this.lblError.TabIndex = 26;
            this.lblError.Text = "Error Error Error Error";
            this.lblError.Visible = false;
            // 
            // nudLapTimeMinutes
            // 
            this.nudLapTimeMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLapTimeMinutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudLapTimeMinutes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudLapTimeMinutes.Location = new System.Drawing.Point(348, 48);
            this.nudLapTimeMinutes.Name = "nudLapTimeMinutes";
            this.nudLapTimeMinutes.Size = new System.Drawing.Size(120, 23);
            this.nudLapTimeMinutes.TabIndex = 27;
            this.nudLapTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLapTimeMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLapTimeMinutes
            // 
            this.lblLapTimeMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLapTimeMinutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLapTimeMinutes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLapTimeMinutes.Location = new System.Drawing.Point(242, 46);
            this.lblLapTimeMinutes.Name = "lblLapTimeMinutes";
            this.lblLapTimeMinutes.Size = new System.Drawing.Size(100, 23);
            this.lblLapTimeMinutes.TabIndex = 28;
            this.lblLapTimeMinutes.Text = "Minutes: ";
            this.lblLapTimeMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLapTimeSeconds
            // 
            this.lblLapTimeSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLapTimeSeconds.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblLapTimeSeconds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLapTimeSeconds.Location = new System.Drawing.Point(242, 70);
            this.lblLapTimeSeconds.Name = "lblLapTimeSeconds";
            this.lblLapTimeSeconds.Size = new System.Drawing.Size(100, 23);
            this.lblLapTimeSeconds.TabIndex = 30;
            this.lblLapTimeSeconds.Text = "Seconds: ";
            this.lblLapTimeSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudLapTimeSeconds
            // 
            this.nudLapTimeSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLapTimeSeconds.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudLapTimeSeconds.DecimalPlaces = 3;
            this.nudLapTimeSeconds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudLapTimeSeconds.Location = new System.Drawing.Point(348, 72);
            this.nudLapTimeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudLapTimeSeconds.Name = "nudLapTimeSeconds";
            this.nudLapTimeSeconds.Size = new System.Drawing.Size(120, 23);
            this.nudLapTimeSeconds.TabIndex = 29;
            this.nudLapTimeSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLapTimeSeconds.Value = new decimal(new int[] {
            45678,
            0,
            0,
            196608});
            // 
            // dgvLapTimes
            // 
            this.dgvLapTimes.AllowUserToAddRows = false;
            this.dgvLapTimes.AllowUserToDeleteRows = false;
            this.dgvLapTimes.AllowUserToResizeColumns = false;
            this.dgvLapTimes.AllowUserToResizeRows = false;
            this.dgvLapTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLapTimes.CausesValidation = false;
            this.dgvLapTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLapTimes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLapTimes.Location = new System.Drawing.Point(481, 47);
            this.dgvLapTimes.MultiSelect = false;
            this.dgvLapTimes.Name = "dgvLapTimes";
            this.dgvLapTimes.ReadOnly = true;
            this.dgvLapTimes.RowHeadersVisible = false;
            this.dgvLapTimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLapTimes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvLapTimes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLapTimes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvLapTimes.RowTemplate.Height = 25;
            this.dgvLapTimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLapTimes.Size = new System.Drawing.Size(205, 362);
            this.dgvLapTimes.TabIndex = 31;
            // 
            // lblTimeRemainingHours
            // 
            this.lblTimeRemainingHours.AutoSize = true;
            this.lblTimeRemainingHours.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTimeRemainingHours.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeRemainingHours.Location = new System.Drawing.Point(120, 155);
            this.lblTimeRemainingHours.Name = "lblTimeRemainingHours";
            this.lblTimeRemainingHours.Size = new System.Drawing.Size(42, 15);
            this.lblTimeRemainingHours.TabIndex = 32;
            this.lblTimeRemainingHours.Text = "Hours:";
            // 
            // lblTimeRemainingMinutes
            // 
            this.lblTimeRemainingMinutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTimeRemainingMinutes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeRemainingMinutes.Location = new System.Drawing.Point(102, 179);
            this.lblTimeRemainingMinutes.Name = "lblTimeRemainingMinutes";
            this.lblTimeRemainingMinutes.Size = new System.Drawing.Size(60, 15);
            this.lblTimeRemainingMinutes.TabIndex = 33;
            this.lblTimeRemainingMinutes.Text = "Minutes:";
            this.lblTimeRemainingMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeRemainingSeconds
            // 
            this.lblTimeRemainingSeconds.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTimeRemainingSeconds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeRemainingSeconds.Location = new System.Drawing.Point(102, 203);
            this.lblTimeRemainingSeconds.Name = "lblTimeRemainingSeconds";
            this.lblTimeRemainingSeconds.Size = new System.Drawing.Size(60, 15);
            this.lblTimeRemainingSeconds.TabIndex = 34;
            this.lblTimeRemainingSeconds.Text = "Seconds:";
            this.lblTimeRemainingSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTimeRemainingHours
            // 
            this.nudTimeRemainingHours.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudTimeRemainingHours.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudTimeRemainingHours.Location = new System.Drawing.Point(168, 153);
            this.nudTimeRemainingHours.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTimeRemainingHours.Name = "nudTimeRemainingHours";
            this.nudTimeRemainingHours.Size = new System.Drawing.Size(71, 23);
            this.nudTimeRemainingHours.TabIndex = 35;
            this.nudTimeRemainingHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimeRemainingHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudTimeRemainingMinutes
            // 
            this.nudTimeRemainingMinutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudTimeRemainingMinutes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudTimeRemainingMinutes.Location = new System.Drawing.Point(168, 177);
            this.nudTimeRemainingMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeRemainingMinutes.Name = "nudTimeRemainingMinutes";
            this.nudTimeRemainingMinutes.Size = new System.Drawing.Size(71, 23);
            this.nudTimeRemainingMinutes.TabIndex = 36;
            this.nudTimeRemainingMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTimeRemainingMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudTimeRemainingSeconds
            // 
            this.nudTimeRemainingSeconds.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nudTimeRemainingSeconds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nudTimeRemainingSeconds.Location = new System.Drawing.Point(168, 201);
            this.nudTimeRemainingSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeRemainingSeconds.Name = "nudTimeRemainingSeconds";
            this.nudTimeRemainingSeconds.Size = new System.Drawing.Size(71, 23);
            this.nudTimeRemainingSeconds.TabIndex = 37;
            this.nudTimeRemainingSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTrackLength
            // 
            this.lblTrackLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrackLength.AutoSize = true;
            this.lblTrackLength.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTrackLength.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrackLength.Location = new System.Drawing.Point(303, 178);
            this.lblTrackLength.Name = "lblTrackLength";
            this.lblTrackLength.Size = new System.Drawing.Size(74, 15);
            this.lblTrackLength.TabIndex = 38;
            this.lblTrackLength.Text = "Track Length";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(303, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            // 
            // chkClickThrough
            // 
            this.chkClickThrough.AutoSize = true;
            this.chkClickThrough.Location = new System.Drawing.Point(303, 215);
            this.chkClickThrough.Name = "chkClickThrough";
            this.chkClickThrough.Size = new System.Drawing.Size(143, 19);
            this.chkClickThrough.TabIndex = 40;
            this.chkClickThrough.Text = "Click Through Overlay";
            this.chkClickThrough.UseVisualStyleBackColor = true;
            this.chkClickThrough.CheckedChanged += new System.EventHandler(this.chkClickThrough_CheckedChanged);
            // 
            // hscOverlayTransparency
            // 
            this.hscOverlayTransparency.Location = new System.Drawing.Point(303, 237);
            this.hscOverlayTransparency.Maximum = 109;
            this.hscOverlayTransparency.Name = "hscOverlayTransparency";
            this.hscOverlayTransparency.Size = new System.Drawing.Size(165, 17);
            this.hscOverlayTransparency.TabIndex = 41;
            this.hscOverlayTransparency.ValueChanged += new System.EventHandler(this.hscOverlayTransparency_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "label2";
            // 
            // FrmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hscOverlayTransparency);
            this.Controls.Add(this.chkClickThrough);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrackLength);
            this.Controls.Add(this.nudTimeRemainingSeconds);
            this.Controls.Add(this.nudTimeRemainingMinutes);
            this.Controls.Add(this.nudTimeRemainingHours);
            this.Controls.Add(this.lblTimeRemainingSeconds);
            this.Controls.Add(this.lblTimeRemainingMinutes);
            this.Controls.Add(this.lblTimeRemainingHours);
            this.Controls.Add(this.dgvLapTimes);
            this.Controls.Add(this.lblLapTimeSeconds);
            this.Controls.Add(this.nudLapTimeSeconds);
            this.Controls.Add(this.lblLapTimeMinutes);
            this.Controls.Add(this.nudLapTimeMinutes);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblLapTimes);
            this.Controls.Add(this.btnClearAllLaps);
            this.Controls.Add(this.nudFuelTankSize);
            this.Controls.Add(this.nudFuelPerLap);
            this.Controls.Add(this.btnEnterLapTime);
            this.Controls.Add(this.lblEnterLapTime);
            this.Controls.Add(this.btnDeleteLap);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRefuelToOutput);
            this.Controls.Add(this.lblFuelToAddOutput);
            this.Controls.Add(this.lblProjectedLapsOutput);
            this.Controls.Add(this.lblRefuelTo);
            this.Controls.Add(this.lblFuelToAdd);
            this.Controls.Add(this.lblFuelTankSize);
            this.Controls.Add(this.lblProjectedLaps);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblFuelPerLap);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(760, 489);
            this.Name = "FrmGUI";
            this.Text = "Pitstop Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGUI_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGUI_FormClosed);
            this.Shown += new System.EventHandler(this.FrmGUI_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelPerLap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFuelTankSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLapTimeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeRemainingHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeRemainingMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeRemainingSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsiConfig;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.Label lblFuelPerLap;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label lblProjectedLaps;
        private System.Windows.Forms.Label lblFuelTankSize;
        private System.Windows.Forms.Label lblFuelToAdd;
        private System.Windows.Forms.Label lblRefuelTo;
        protected System.Windows.Forms.Label lblProjectedLapsOutput;
        protected System.Windows.Forms.Label lblFuelToAddOutput;
        protected System.Windows.Forms.Label lblRefuelToOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDeleteLap;
        private System.Windows.Forms.Label lblEnterLapTime;
        private System.Windows.Forms.Button btnEnterLapTime;
        private System.Windows.Forms.NumericUpDown nudFuelPerLap;
        private System.Windows.Forms.NumericUpDown nudFuelTankSize;
        private System.Windows.Forms.Button btnClearAllLaps;
        private System.Windows.Forms.Label lblLapTimes;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.NumericUpDown nudLapTimeMinutes;
        private System.Windows.Forms.Label lblLapTimeMinutes;
        private System.Windows.Forms.Label lblLapTimeSeconds;
        private System.Windows.Forms.NumericUpDown nudLapTimeSeconds;
        private System.Windows.Forms.DataGridView dgvLapTimes;
        private System.Windows.Forms.Label lblTimeRemainingHours;
        private System.Windows.Forms.Label lblTimeRemainingMinutes;
        private System.Windows.Forms.Label lblTimeRemainingSeconds;
        private System.Windows.Forms.NumericUpDown nudTimeRemainingHours;
        private System.Windows.Forms.NumericUpDown nudTimeRemainingMinutes;
        private System.Windows.Forms.NumericUpDown nudTimeRemainingSeconds;
        private System.Windows.Forms.Label lblTrackLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenOverlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkClickThrough;
        private System.Windows.Forms.HScrollBar hscOverlayTransparency;
        private System.Windows.Forms.Label label2;
    }
}

