namespace XSTREAMIPTVPlayer.UserControls
{
    partial class AddUserProfile
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            txtNickName = new TextBox();
            btnSaveUser = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            txtServerIP = new TextBox();
            lblAddUser = new Label();
            lstvUsers = new ListView();
            cmnNickname = new ColumnHeader();
            cmnUsername = new ColumnHeader();
            cmnPassword = new ColumnHeader();
            cmnServerIP = new ColumnHeader();
            btnActivateUser = new Button();
            btnDeleteUser = new Button();
            btnDownloadEPG = new Button();
            panel1 = new Panel();
            btnUpdateChannels = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 38, 38);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtNickName);
            panel2.Controls.Add(btnSaveUser);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(txtServerIP);
            panel2.Controls.Add(lblAddUser);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 285);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.Siyarbekir_2_;
            pictureBox1.Location = new Point(352, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtNickName
            // 
            txtNickName.BackColor = Color.FromArgb(48, 48, 48);
            txtNickName.BorderStyle = BorderStyle.None;
            txtNickName.ForeColor = Color.White;
            txtNickName.Location = new Point(16, 79);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(330, 16);
            txtNickName.TabIndex = 6;
            txtNickName.Text = "NickName";
            txtNickName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSaveUser
            // 
            btnSaveUser.BackColor = Color.FromArgb(48, 48, 48);
            btnSaveUser.FlatAppearance.BorderSize = 0;
            btnSaveUser.FlatStyle = FlatStyle.Flat;
            btnSaveUser.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveUser.ForeColor = Color.White;
            btnSaveUser.Location = new Point(16, 252);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(99, 33);
            btnSaveUser.TabIndex = 5;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = false;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(48, 48, 48);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(16, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 16);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(48, 48, 48);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(16, 128);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(330, 16);
            txtUserName.TabIndex = 2;
            txtUserName.Text = "Username";
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtServerIP
            // 
            txtServerIP.BackColor = Color.FromArgb(48, 48, 48);
            txtServerIP.BorderStyle = BorderStyle.None;
            txtServerIP.ForeColor = Color.White;
            txtServerIP.Location = new Point(16, 226);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(330, 16);
            txtServerIP.TabIndex = 1;
            txtServerIP.Text = "Server IP";
            txtServerIP.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAddUser
            // 
            lblAddUser.AutoSize = true;
            lblAddUser.Font = new Font("MS Reference Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddUser.ForeColor = Color.White;
            lblAddUser.Location = new Point(30, 15);
            lblAddUser.Name = "lblAddUser";
            lblAddUser.Size = new Size(307, 46);
            lblAddUser.TabIndex = 0;
            lblAddUser.Text = "Add new Profile";
            // 
            // lstvUsers
            // 
            lstvUsers.BackColor = Color.FromArgb(48, 48, 48);
            lstvUsers.Columns.AddRange(new ColumnHeader[] { cmnNickname, cmnUsername, cmnPassword, cmnServerIP });
            lstvUsers.Dock = DockStyle.Top;
            lstvUsers.Font = new Font("MS Reference Sans Serif", 12F);
            lstvUsers.ForeColor = Color.White;
            lstvUsers.Location = new Point(0, 0);
            lstvUsers.Name = "lstvUsers";
            lstvUsers.Size = new Size(760, 378);
            lstvUsers.TabIndex = 0;
            lstvUsers.UseCompatibleStateImageBehavior = false;
            lstvUsers.View = View.Details;
            // 
            // cmnNickname
            // 
            cmnNickname.Text = "Nickname";
            cmnNickname.Width = 150;
            // 
            // cmnUsername
            // 
            cmnUsername.Text = "Username";
            cmnUsername.Width = 150;
            // 
            // cmnPassword
            // 
            cmnPassword.Text = "Password";
            cmnPassword.Width = 150;
            // 
            // cmnServerIP
            // 
            cmnServerIP.Text = "Server IP";
            cmnServerIP.Width = 250;
            // 
            // btnActivateUser
            // 
            btnActivateUser.Location = new Point(625, 7);
            btnActivateUser.Name = "btnActivateUser";
            btnActivateUser.Size = new Size(126, 29);
            btnActivateUser.TabIndex = 5;
            btnActivateUser.Text = "ActivateUser";
            btnActivateUser.UseVisualStyleBackColor = true;
            btnActivateUser.Click += btnActivateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(420, 7);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(126, 29);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "btnDeleteUser";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnDownloadEPG
            // 
            btnDownloadEPG.Location = new Point(215, 4);
            btnDownloadEPG.Name = "btnDownloadEPG";
            btnDownloadEPG.Size = new Size(126, 29);
            btnDownloadEPG.TabIndex = 7;
            btnDownloadEPG.Text = "btnDownloadEPG";
            btnDownloadEPG.UseVisualStyleBackColor = true;
            btnDownloadEPG.Click += btnDownloadEPG_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdateChannels);
            panel1.Controls.Add(btnDownloadEPG);
            panel1.Controls.Add(btnActivateUser);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 378);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 41);
            panel1.TabIndex = 8;
            // 
            // btnUpdateChannels
            // 
            btnUpdateChannels.Location = new Point(10, 4);
            btnUpdateChannels.Name = "btnUpdateChannels";
            btnUpdateChannels.Size = new Size(126, 29);
            btnUpdateChannels.TabIndex = 8;
            btnUpdateChannels.Text = "btnUpdateChannels";
            btnUpdateChannels.UseVisualStyleBackColor = true;
            btnUpdateChannels.Click += btnUpdateChannels_Click;
            // 
            // AddUserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lstvUsers);
            Name = "AddUserProfile";
            Size = new Size(760, 704);
            Load += AddUserProfile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lblAddUser;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtServerIP;
        private Button btnSaveUser;
        private TextBox txtNickName;
        private ListView lstvUsers;
        private ColumnHeader cmnUsername;
        private ColumnHeader cmnServerIP;
        private ColumnHeader cmnNickname;
        private PictureBox pictureBox1;
        private Button btnActivateUser;
        private ColumnHeader cmnPassword;
        private Button btnDeleteUser;
        private Button btnDownloadEPG;
        private Panel panel1;
        private Button btnUpdateChannels;
    }
}
