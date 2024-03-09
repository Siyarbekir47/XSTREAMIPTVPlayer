namespace XSTREAMIPTVPlayer.UserControls
{
    partial class ManageProfiles
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
            btnAddNewProfile = new Button();
            SuspendLayout();
            // 
            // btnAddNewProfile
            // 
            btnAddNewProfile.Location = new Point(905, 659);
            btnAddNewProfile.Name = "btnAddNewProfile";
            btnAddNewProfile.Size = new Size(75, 23);
            btnAddNewProfile.TabIndex = 0;
            btnAddNewProfile.Tag = "btnAddNewProfile";
            btnAddNewProfile.Text = "btnAddNewProfile";
            btnAddNewProfile.UseVisualStyleBackColor = true;
            btnAddNewProfile.Click += btnAddNewProfile_Click;
            // 
            // ManageProfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddNewProfile);
            Name = "ManageProfiles";
            Size = new Size(1010, 704);
            Load += ManageProfiles_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddNewProfile;
    }
}
