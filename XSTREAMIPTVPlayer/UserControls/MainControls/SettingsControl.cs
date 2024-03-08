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
    public partial class SettingsControl : UserControl
    {
        private Form1 form1Instance;
        public SettingsControl()
        {
            InitializeComponent();
            

        }
        public void AddProfileControl()
        {

            settingsMainPanel.Controls.Clear(); // Clear existing controls
            AddUserProfile addUserProfile = new AddUserProfile();
            addUserProfile.Dock = DockStyle.Fill; // Fill the entire mainPanel
            settingsMainPanel.Controls.Add(addUserProfile); // Add the User Control
        }

        private void settingsMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageProfiles_Click(object sender, EventArgs e)
        {
            bool isLoaded = form1Instance.IsControlLoaded<ManageProfiles>();

            if (!isLoaded)
            {

            }

        }
    }
}
