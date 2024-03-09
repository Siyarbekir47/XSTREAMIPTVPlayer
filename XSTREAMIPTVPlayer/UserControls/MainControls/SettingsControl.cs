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

        public SettingsControl()
        {
            InitializeComponent();
            

        }
        public void AddProfileControl()
        {


        }

        private void settingsMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnManageProfiles_Click(object sender, EventArgs e)
        {

            bool isLoaded = settingsMainPanel.Controls.OfType<AddUserProfile>().Any();

            if (!isLoaded)
            {

                settingsMainPanel.Controls.Clear(); // Clear existing controls
                AddUserProfile addUserProfile = new AddUserProfile();
                addUserProfile.Dock = DockStyle.Fill; // Fill the entire mainPanel
                settingsMainPanel.Controls.Add(addUserProfile); // Add the User Control
            }


        }
    }
}
