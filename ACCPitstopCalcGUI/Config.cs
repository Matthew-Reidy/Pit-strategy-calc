using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCPitstopCalcGUI
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void chkAutomaticTelemetry_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.automaticTelemetryEnabled = chkAutomaticTelemetry.Checked;
        }

        private void chkResetOnNewSession_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.automaticResetLaps = chkResetOnNewSession.Checked;
            chkResetCalculation.Enabled = chkResetOnNewSession.Checked;
            if(!chkResetOnNewSession.Checked && chkResetCalculation.Checked)
            {
                chkResetCalculation.Checked = false;
            }
        }

        private void chkResetCalculation_CheckedChanged(object sender, EventArgs e)
        {
            Program.settings.automaticResetCalculation = chkResetCalculation.Checked;
        }

        private void Config_Load(object sender, EventArgs e)
        {
            chkAutomaticTelemetry.Checked = Program.settings.automaticTelemetryEnabled;
            chkResetCalculation.Checked = Program.settings.automaticResetCalculation;
            chkResetOnNewSession.Checked = Program.settings.automaticResetLaps;
        }
    }
}
