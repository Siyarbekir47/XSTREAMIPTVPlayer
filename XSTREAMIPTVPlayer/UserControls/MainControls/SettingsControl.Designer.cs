namespace XSTREAMIPTVPlayer.UserControls
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            userInfoPanel = new Panel();
            btnAppInfos = new Button();
            btnAccountSettings = new Button();
            btnManageProfiles = new Button();
            btnActiveProfile = new Button();
            settingsMainPanel = new Panel();
            userInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userInfoPanel
            // 
            userInfoPanel.BackColor = Color.FromArgb(56, 56, 56);
            userInfoPanel.Controls.Add(btnAppInfos);
            userInfoPanel.Controls.Add(btnAccountSettings);
            userInfoPanel.Controls.Add(btnManageProfiles);
            userInfoPanel.Controls.Add(btnActiveProfile);
            userInfoPanel.Dock = DockStyle.Left;
            userInfoPanel.Location = new Point(0, 0);
            userInfoPanel.Name = "userInfoPanel";
            userInfoPanel.Size = new Size(250, 704);
            userInfoPanel.TabIndex = 0;
            // 
            // btnAppInfos
            // 
            btnAppInfos.Dock = DockStyle.Bottom;
            btnAppInfos.FlatAppearance.BorderSize = 0;
            btnAppInfos.FlatStyle = FlatStyle.Flat;
            btnAppInfos.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAppInfos.ForeColor = SystemColors.ButtonHighlight;
            btnAppInfos.Image = Properties.Resources.Design_ohne_Titel_15__1_;
            btnAppInfos.Location = new Point(0, 460);
            btnAppInfos.Name = "btnAppInfos";
            btnAppInfos.Size = new Size(250, 122);
            btnAppInfos.TabIndex = 6;
            btnAppInfos.Tag = "Application Infos";
            btnAppInfos.Text = "Application Infos";
            btnAppInfos.TextAlign = ContentAlignment.BottomCenter;
            btnAppInfos.UseVisualStyleBackColor = true;
            // 
            // btnAccountSettings
            // 
            btnAccountSettings.Dock = DockStyle.Bottom;
            btnAccountSettings.FlatAppearance.BorderSize = 0;
            btnAccountSettings.FlatStyle = FlatStyle.Flat;
            btnAccountSettings.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccountSettings.ForeColor = SystemColors.ButtonHighlight;
            btnAccountSettings.Image = Properties.Resources.Design_ohne_Titel_14__1_;
            btnAccountSettings.Location = new Point(0, 582);
            btnAccountSettings.Name = "btnAccountSettings";
            btnAccountSettings.Size = new Size(250, 122);
            btnAccountSettings.TabIndex = 5;
            btnAccountSettings.Tag = "Account Settings";
            btnAccountSettings.Text = "Account Settings";
            btnAccountSettings.TextAlign = ContentAlignment.BottomCenter;
            btnAccountSettings.UseVisualStyleBackColor = true;
            // 
            // btnManageProfiles
            // 
            btnManageProfiles.Dock = DockStyle.Top;
            btnManageProfiles.FlatAppearance.BorderSize = 0;
            btnManageProfiles.FlatStyle = FlatStyle.Flat;
            btnManageProfiles.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageProfiles.ForeColor = SystemColors.ButtonHighlight;
            btnManageProfiles.Image = Properties.Resources.Design_ohne_Titel_12__1_;
            btnManageProfiles.Location = new Point(0, 122);
            btnManageProfiles.Name = "btnManageProfiles";
            btnManageProfiles.Size = new Size(250, 122);
            btnManageProfiles.TabIndex = 3;
            btnManageProfiles.Tag = "Manage Profiles";
            btnManageProfiles.Text = "Manage Profiles";
            btnManageProfiles.TextAlign = ContentAlignment.BottomCenter;
            btnManageProfiles.UseVisualStyleBackColor = true;
            btnManageProfiles.Click += btnManageProfiles_Click;
            // 
            // btnActiveProfile
            // 
            btnActiveProfile.Dock = DockStyle.Top;
            btnActiveProfile.FlatAppearance.BorderSize = 0;
            btnActiveProfile.FlatStyle = FlatStyle.Flat;
            btnActiveProfile.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActiveProfile.ForeColor = SystemColors.ButtonHighlight;
            btnActiveProfile.Image = Properties.Resources.Design_ohne_Titel_13__1_;
            btnActiveProfile.Location = new Point(0, 0);
            btnActiveProfile.Name = "btnActiveProfile";
            btnActiveProfile.Size = new Size(250, 122);
            btnActiveProfile.TabIndex = 4;
            btnActiveProfile.Tag = "Active Profile";
            btnActiveProfile.Text = "Active Profile";
            btnActiveProfile.TextAlign = ContentAlignment.BottomCenter;
            btnActiveProfile.UseVisualStyleBackColor = true;
            // 
            // settingsMainPanel
            // 
            settingsMainPanel.Dock = DockStyle.Fill;
            settingsMainPanel.Location = new Point(250, 0);
            settingsMainPanel.Name = "settingsMainPanel";
            settingsMainPanel.Size = new Size(760, 704);
            settingsMainPanel.TabIndex = 1;
            settingsMainPanel.Paint += settingsMainPanel_Paint;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(settingsMainPanel);
            Controls.Add(userInfoPanel);
            Name = "SettingsControl";
            Size = new Size(1010, 704);
            userInfoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel userInfoPanel;
        private Button btnManageProfiles;
        private Button btnActiveProfile;
        private Panel settingsMainPanel;
        private Button btnAppInfos;
        private Button btnAccountSettings;
    }
}
