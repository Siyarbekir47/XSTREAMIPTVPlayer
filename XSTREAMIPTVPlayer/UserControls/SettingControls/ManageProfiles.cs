using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XSTREAMIPTVPlayer.UserControls
{
    public partial class ManageProfiles : UserControl
    {
        private SettingsControl settingsControlInstance;

        public ManageProfiles(SettingsControl settingsControl)
        {
            InitializeComponent();
            settingsControlInstance = settingsControl;
        }

        private void btnAddNewProfile_Click(object sender, EventArgs e)
        {
            settingsControlInstance.AddProfileControl();
        }

        private void ManageProfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
