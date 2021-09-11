
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimeRemainingHours = new System.Windows.Forms.Label();
            this.lblTimeRemainingMinutes = new System.Windows.Forms.Label();
            this.lblTimeRemainingSeconds = new System.Windows.Forms.Label();
            this.nudTimeRemainingHours = new System.Windows.Forms.NumericUpDown();
            this.nudTimeRemainingMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudTimeRemainingSeconds = new System.Windows.Forms.NumericUpDown();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsiConfig,
            this.tsmiAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsiConfig
            // 
            this.tsiConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.backgroundToolStripMenuItem});
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
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
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
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // lblFuelPerLap
            // 
            this.lblFuelPerLap.BackColor = System.Drawing.SystemColors.Control;
            this.lblFuelPerLap.Location = new System.Drawing.Point(13, 50);
            this.lblFuelPerLap.Name = "lblFuelPerLap";
            this.lblFuelPerLap.Size = new System.Drawing.Size(100, 15);
            this.lblFuelPerLap.TabIndex = 1;
            this.lblFuelPerLap.Text = "Fuel Per Lap: ";
            this.lblFuelPerLap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.Location = new System.Drawing.Point(13, 150);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(100, 30);
            this.lblTimeRemaining.TabIndex = 2;
            this.lblTimeRemaining.Text = "Time Remaining";
            this.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectedLaps
            // 
            this.lblProjectedLaps.Location = new System.Drawing.Point(13, 241);
            this.lblProjectedLaps.Name = "lblProjectedLaps";
            this.lblProjectedLaps.Size = new System.Drawing.Size(100, 15);
            this.lblProjectedLaps.TabIndex = 3;
            this.lblProjectedLaps.Text = "Projected Laps: ";
            this.lblProjectedLaps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelTankSize
            // 
            this.lblFuelTankSize.Location = new System.Drawing.Point(13, 100);
            this.lblFuelTankSize.Name = "lblFuelTankSize";
            this.lblFuelTankSize.Size = new System.Drawing.Size(100, 15);
            this.lblFuelTankSize.TabIndex = 4;
            this.lblFuelTankSize.Text = "Fuel Tank Size: ";
            this.lblFuelTankSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelToAdd
            // 
            this.lblFuelToAdd.Location = new System.Drawing.Point(13, 291);
            this.lblFuelToAdd.Name = "lblFuelToAdd";
            this.lblFuelToAdd.Size = new System.Drawing.Size(100, 15);
            this.lblFuelToAdd.TabIndex = 5;
            this.lblFuelToAdd.Text = "Fuel To Add: ";
            this.lblFuelToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRefuelTo
            // 
            this.lblRefuelTo.Location = new System.Drawing.Point(13, 341);
            this.lblRefuelTo.Name = "lblRefuelTo";
            this.lblRefuelTo.Size = new System.Drawing.Size(100, 15);
            this.lblRefuelTo.TabIndex = 6;
            this.lblRefuelTo.Text = "Refuel To: ";
            this.lblRefuelTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectedLapsOutput
            // 
            this.lblProjectedLapsOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblProjectedLapsOutput.Location = new System.Drawing.Point(120, 241);
            this.lblProjectedLapsOutput.Name = "lblProjectedLapsOutput";
            this.lblProjectedLapsOutput.Size = new System.Drawing.Size(120, 15);
            this.lblProjectedLapsOutput.TabIndex = 10;
            this.lblProjectedLapsOutput.Text = "--";
            this.lblProjectedLapsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelToAddOutput
            // 
            this.lblFuelToAddOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFuelToAddOutput.Location = new System.Drawing.Point(120, 291);
            this.lblFuelToAddOutput.Name = "lblFuelToAddOutput";
            this.lblFuelToAddOutput.Size = new System.Drawing.Size(120, 15);
            this.lblFuelToAddOutput.TabIndex = 11;
            this.lblFuelToAddOutput.Text = "--";
            this.lblFuelToAddOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRefuelToOutput
            // 
            this.lblRefuelToOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRefuelToOutput.Location = new System.Drawing.Point(120, 341);
            this.lblRefuelToOutput.Name = "lblRefuelToOutput";
            this.lblRefuelToOutput.Size = new System.Drawing.Size(120, 15);
            this.lblRefuelToOutput.TabIndex = 12;
            this.lblRefuelToOutput.Text = "--";
            this.lblRefuelToOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 391);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDeleteLap
            // 
            this.btnDeleteLap.Location = new System.Drawing.Point(537, 415);
            this.btnDeleteLap.Name = "btnDeleteLap";
            this.btnDeleteLap.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLap.TabIndex = 15;
            this.btnDeleteLap.Text = "Delete Lap";
            this.btnDeleteLap.UseVisualStyleBackColor = true;
            this.btnDeleteLap.Click += new System.EventHandler(this.btnDeleteLap_Click);
            // 
            // lblEnterLapTime
            // 
            this.lblEnterLapTime.AutoSize = true;
            this.lblEnterLapTime.Location = new System.Drawing.Point(408, 28);
            this.lblEnterLapTime.Name = "lblEnterLapTime";
            this.lblEnterLapTime.Size = new System.Drawing.Size(91, 15);
            this.lblEnterLapTime.TabIndex = 16;
            this.lblEnterLapTime.Text = "Enter Lap Time: ";
            // 
            // btnEnterLapTime
            // 
            this.btnEnterLapTime.AutoSize = true;
            this.btnEnterLapTime.Location = new System.Drawing.Point(404, 114);
            this.btnEnterLapTime.Name = "btnEnterLapTime";
            this.btnEnterLapTime.Size = new System.Drawing.Size(95, 25);
            this.btnEnterLapTime.TabIndex = 18;
            this.btnEnterLapTime.Text = "Enter Lap Time";
            this.btnEnterLapTime.UseVisualStyleBackColor = true;
            this.btnEnterLapTime.Click += new System.EventHandler(this.btnEnterLapTime_Click);
            // 
            // nudFuelPerLap
            // 
            this.nudFuelPerLap.DecimalPlaces = 2;
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
            // 
            // nudFuelTankSize
            // 
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
            // 
            // btnClearAllLaps
            // 
            this.btnClearAllLaps.Location = new System.Drawing.Point(662, 415);
            this.btnClearAllLaps.Name = "btnClearAllLaps";
            this.btnClearAllLaps.Size = new System.Drawing.Size(75, 23);
            this.btnClearAllLaps.TabIndex = 23;
            this.btnClearAllLaps.Text = "Clear";
            this.btnClearAllLaps.UseVisualStyleBackColor = true;
            this.btnClearAllLaps.Click += new System.EventHandler(this.btnClearAllLaps_Click);
            // 
            // lblLapTimes
            // 
            this.lblLapTimes.AutoSize = true;
            this.lblLapTimes.Location = new System.Drawing.Point(537, 28);
            this.lblLapTimes.Name = "lblLapTimes";
            this.lblLapTimes.Size = new System.Drawing.Size(57, 15);
            this.lblLapTimes.TabIndex = 25;
            this.lblLapTimes.Text = "LapTimes";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 423);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(116, 15);
            this.lblError.TabIndex = 26;
            this.lblError.Text = "Error Error Error Error";
            this.lblError.Visible = false;
            // 
            // nudLapTimeMinutes
            // 
            this.nudLapTimeMinutes.Location = new System.Drawing.Point(404, 48);
            this.nudLapTimeMinutes.Name = "nudLapTimeMinutes";
            this.nudLapTimeMinutes.Size = new System.Drawing.Size(120, 23);
            this.nudLapTimeMinutes.TabIndex = 27;
            this.nudLapTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLapTimeMinutes
            // 
            this.lblLapTimeMinutes.Location = new System.Drawing.Point(298, 46);
            this.lblLapTimeMinutes.Name = "lblLapTimeMinutes";
            this.lblLapTimeMinutes.Size = new System.Drawing.Size(100, 23);
            this.lblLapTimeMinutes.TabIndex = 28;
            this.lblLapTimeMinutes.Text = "Minutes: ";
            this.lblLapTimeMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLapTimeSeconds
            // 
            this.lblLapTimeSeconds.Location = new System.Drawing.Point(298, 70);
            this.lblLapTimeSeconds.Name = "lblLapTimeSeconds";
            this.lblLapTimeSeconds.Size = new System.Drawing.Size(100, 23);
            this.lblLapTimeSeconds.TabIndex = 30;
            this.lblLapTimeSeconds.Text = "Seconds: ";
            this.lblLapTimeSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudLapTimeSeconds
            // 
            this.nudLapTimeSeconds.DecimalPlaces = 3;
            this.nudLapTimeSeconds.Location = new System.Drawing.Point(404, 72);
            this.nudLapTimeSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudLapTimeSeconds.Name = "nudLapTimeSeconds";
            this.nudLapTimeSeconds.Size = new System.Drawing.Size(120, 23);
            this.nudLapTimeSeconds.TabIndex = 29;
            this.nudLapTimeSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvLapTimes
            // 
            this.dgvLapTimes.AllowUserToAddRows = false;
            this.dgvLapTimes.AllowUserToDeleteRows = false;
            this.dgvLapTimes.AllowUserToResizeColumns = false;
            this.dgvLapTimes.AllowUserToResizeRows = false;
            this.dgvLapTimes.CausesValidation = false;
            this.dgvLapTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lap,
            this.Minutes,
            this.Seconds});
            this.dgvLapTimes.Location = new System.Drawing.Point(537, 47);
            this.dgvLapTimes.MultiSelect = false;
            this.dgvLapTimes.Name = "dgvLapTimes";
            this.dgvLapTimes.ReadOnly = true;
            this.dgvLapTimes.RowHeadersVisible = false;
            this.dgvLapTimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLapTimes.RowTemplate.Height = 25;
            this.dgvLapTimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLapTimes.Size = new System.Drawing.Size(205, 362);
            this.dgvLapTimes.TabIndex = 31;
            // 
            // Lap
            // 
            this.Lap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Lap.HeaderText = "Lap";
            this.Lap.Name = "Lap";
            this.Lap.ReadOnly = true;
            this.Lap.Width = 51;
            // 
            // Minutes
            // 
            this.Minutes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Minutes.HeaderText = "Minutes";
            this.Minutes.Name = "Minutes";
            this.Minutes.ReadOnly = true;
            this.Minutes.Width = 75;
            // 
            // Seconds
            // 
            this.Seconds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Seconds.HeaderText = "Seconds";
            this.Seconds.Name = "Seconds";
            this.Seconds.ReadOnly = true;
            this.Seconds.Width = 76;
            // 
            // lblTimeRemainingHours
            // 
            this.lblTimeRemainingHours.AutoSize = true;
            this.lblTimeRemainingHours.Location = new System.Drawing.Point(120, 155);
            this.lblTimeRemainingHours.Name = "lblTimeRemainingHours";
            this.lblTimeRemainingHours.Size = new System.Drawing.Size(42, 15);
            this.lblTimeRemainingHours.TabIndex = 32;
            this.lblTimeRemainingHours.Text = "Hours:";
            // 
            // lblTimeRemainingMinutes
            // 
            this.lblTimeRemainingMinutes.Location = new System.Drawing.Point(102, 179);
            this.lblTimeRemainingMinutes.Name = "lblTimeRemainingMinutes";
            this.lblTimeRemainingMinutes.Size = new System.Drawing.Size(60, 15);
            this.lblTimeRemainingMinutes.TabIndex = 33;
            this.lblTimeRemainingMinutes.Text = "Minutes:";
            this.lblTimeRemainingMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeRemainingSeconds
            // 
            this.lblTimeRemainingSeconds.Location = new System.Drawing.Point(102, 203);
            this.lblTimeRemainingSeconds.Name = "lblTimeRemainingSeconds";
            this.lblTimeRemainingSeconds.Size = new System.Drawing.Size(60, 15);
            this.lblTimeRemainingSeconds.TabIndex = 34;
            this.lblTimeRemainingSeconds.Text = "Seconds:";
            this.lblTimeRemainingSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTimeRemainingHours
            // 
            this.nudTimeRemainingHours.Location = new System.Drawing.Point(168, 153);
            this.nudTimeRemainingHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudTimeRemainingHours.Name = "nudTimeRemainingHours";
            this.nudTimeRemainingHours.Size = new System.Drawing.Size(71, 23);
            this.nudTimeRemainingHours.TabIndex = 35;
            this.nudTimeRemainingHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudTimeRemainingMinutes
            // 
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
            // 
            // nudTimeRemainingSeconds
            // 
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
            // FrmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGUI";
            this.Text = "Pitstop Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGUI_FormClosing);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Lap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seconds;
        private System.Windows.Forms.Label lblTimeRemainingHours;
        private System.Windows.Forms.Label lblTimeRemainingMinutes;
        private System.Windows.Forms.Label lblTimeRemainingSeconds;
        private System.Windows.Forms.NumericUpDown nudTimeRemainingHours;
        private System.Windows.Forms.NumericUpDown nudTimeRemainingMinutes;
        private System.Windows.Forms.NumericUpDown nudTimeRemainingSeconds;
    }
}

