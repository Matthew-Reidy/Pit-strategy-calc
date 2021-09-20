
namespace ACCPitstopCalcGUI
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAutomaticTelemetry = new System.Windows.Forms.CheckBox();
            this.chkResetOnNewSession = new System.Windows.Forms.CheckBox();
            this.chkResetCalculation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkAutomaticTelemetry
            // 
            this.chkAutomaticTelemetry.AutoSize = true;
            this.chkAutomaticTelemetry.Checked = true;
            this.chkAutomaticTelemetry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutomaticTelemetry.Location = new System.Drawing.Point(13, 13);
            this.chkAutomaticTelemetry.Name = "chkAutomaticTelemetry";
            this.chkAutomaticTelemetry.Size = new System.Drawing.Size(202, 19);
            this.chkAutomaticTelemetry.TabIndex = 0;
            this.chkAutomaticTelemetry.Text = "Enable Automatic Data Gathering";
            this.chkAutomaticTelemetry.UseVisualStyleBackColor = true;
            this.chkAutomaticTelemetry.CheckedChanged += new System.EventHandler(this.chkAutomaticTelemetry_CheckedChanged);
            // 
            // chkResetOnNewSession
            // 
            this.chkResetOnNewSession.AutoSize = true;
            this.chkResetOnNewSession.Location = new System.Drawing.Point(13, 39);
            this.chkResetOnNewSession.Name = "chkResetOnNewSession";
            this.chkResetOnNewSession.Size = new System.Drawing.Size(169, 19);
            this.chkResetOnNewSession.TabIndex = 1;
            this.chkResetOnNewSession.Text = "Reset Laps On New Session";
            this.chkResetOnNewSession.UseVisualStyleBackColor = true;
            this.chkResetOnNewSession.CheckedChanged += new System.EventHandler(this.chkResetOnNewSession_CheckedChanged);
            // 
            // chkResetCalculation
            // 
            this.chkResetCalculation.AutoSize = true;
            this.chkResetCalculation.Enabled = false;
            this.chkResetCalculation.Location = new System.Drawing.Point(46, 64);
            this.chkResetCalculation.Name = "chkResetCalculation";
            this.chkResetCalculation.Size = new System.Drawing.Size(230, 19);
            this.chkResetCalculation.TabIndex = 2;
            this.chkResetCalculation.Text = "Reset Fuel Calculation On New Session";
            this.chkResetCalculation.UseVisualStyleBackColor = true;
            this.chkResetCalculation.CheckedChanged += new System.EventHandler(this.chkResetCalculation_CheckedChanged);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 111);
            this.Controls.Add(this.chkResetCalculation);
            this.Controls.Add(this.chkResetOnNewSession);
            this.Controls.Add(this.chkAutomaticTelemetry);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAutomaticTelemetry;
        private System.Windows.Forms.CheckBox chkResetOnNewSession;
        private System.Windows.Forms.CheckBox chkResetCalculation;
    }
}