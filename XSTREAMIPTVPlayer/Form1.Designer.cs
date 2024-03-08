namespace XSTREAMIPTVPlayer
{
    partial class Form1
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
            upperPanel = new Panel();
            labelTitel = new Label();
            button1 = new Button();
            btnMaximize = new Button();
            btnToggleLeftPanel = new Button();
            btnExit = new Button();
            leftPanel = new Panel();
            btnSettings = new Button();
            btnMovie = new Button();
            btnSeries = new Button();
            btnLive = new Button();
            btnDashboad = new Button();
            mainPanel = new Panel();
            upperPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // upperPanel
            // 
            upperPanel.BackColor = Color.Black;
            upperPanel.Controls.Add(labelTitel);
            upperPanel.Controls.Add(button1);
            upperPanel.Controls.Add(btnMaximize);
            upperPanel.Controls.Add(btnToggleLeftPanel);
            upperPanel.Controls.Add(btnExit);
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(1157, 28);
            upperPanel.TabIndex = 0;
            upperPanel.MouseDown += upperPanel_MouseDown;
            // 
            // labelTitel
            // 
            labelTitel.AutoSize = true;
            labelTitel.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitel.ForeColor = SystemColors.ButtonShadow;
            labelTitel.Location = new Point(55, 6);
            labelTitel.Name = "labelTitel";
            labelTitel.Size = new Size(197, 16);
            labelTitel.TabIndex = 7;
            labelTitel.Text = "@Siyarbekir's IP-TV Player";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Reference Sans Serif", 9.75F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1013, 0);
            button1.Name = "button1";
            button1.Size = new Size(48, 28);
            button1.TabIndex = 6;
            button1.Text = "_";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("MS Reference Sans Serif", 9.75F);
            btnMaximize.ForeColor = SystemColors.Control;
            btnMaximize.Location = new Point(1061, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(48, 28);
            btnMaximize.TabIndex = 8;
            btnMaximize.Text = "[ ]";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnToggleLeftPanel
            // 
            btnToggleLeftPanel.FlatAppearance.BorderSize = 0;
            btnToggleLeftPanel.FlatStyle = FlatStyle.Flat;
            btnToggleLeftPanel.ForeColor = SystemColors.ButtonShadow;
            btnToggleLeftPanel.Image = Properties.Resources.Design_ohne_Titel_10__2_;
            btnToggleLeftPanel.Location = new Point(0, 0);
            btnToggleLeftPanel.Name = "btnToggleLeftPanel";
            btnToggleLeftPanel.Size = new Size(49, 28);
            btnToggleLeftPanel.TabIndex = 5;
            btnToggleLeftPanel.UseVisualStyleBackColor = true;
            btnToggleLeftPanel.Click += btnToggleLeftPanel_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("MS Reference Sans Serif", 9.75F);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(1109, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 28);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(66, 66, 66);
            leftPanel.Controls.Add(btnSettings);
            leftPanel.Controls.Add(btnMovie);
            leftPanel.Controls.Add(btnSeries);
            leftPanel.Controls.Add(btnLive);
            leftPanel.Controls.Add(btnDashboad);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 28);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(147, 704);
            leftPanel.TabIndex = 1;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = SystemColors.ButtonHighlight;
            btnSettings.Image = Properties.Resources.Design_ohne_Titel_8__1_;
            btnSettings.Location = new Point(0, 582);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(147, 122);
            btnSettings.TabIndex = 3;
            btnSettings.Tag = "settings";
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnMovie
            // 
            btnMovie.Dock = DockStyle.Top;
            btnMovie.FlatAppearance.BorderSize = 0;
            btnMovie.FlatStyle = FlatStyle.Flat;
            btnMovie.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMovie.ForeColor = SystemColors.ButtonHighlight;
            btnMovie.Image = Properties.Resources.Design_ohne_Titel_7__1_;
            btnMovie.Location = new Point(0, 366);
            btnMovie.Name = "btnMovie";
            btnMovie.Size = new Size(147, 122);
            btnMovie.TabIndex = 3;
            btnMovie.Tag = "movies";
            btnMovie.Text = "Movies";
            btnMovie.TextAlign = ContentAlignment.BottomCenter;
            btnMovie.UseVisualStyleBackColor = true;
            btnMovie.Click += btnMovie_Click;
            // 
            // btnSeries
            // 
            btnSeries.Dock = DockStyle.Top;
            btnSeries.FlatAppearance.BorderSize = 0;
            btnSeries.FlatStyle = FlatStyle.Flat;
            btnSeries.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeries.ForeColor = SystemColors.ButtonHighlight;
            btnSeries.Image = Properties.Resources.Design_ohne_Titel_5__1_;
            btnSeries.Location = new Point(0, 244);
            btnSeries.Name = "btnSeries";
            btnSeries.Size = new Size(147, 122);
            btnSeries.TabIndex = 2;
            btnSeries.Tag = "series";
            btnSeries.Text = "Series";
            btnSeries.TextAlign = ContentAlignment.BottomCenter;
            btnSeries.UseVisualStyleBackColor = true;
            btnSeries.Click += btnSeries_Click;
            // 
            // btnLive
            // 
            btnLive.Dock = DockStyle.Top;
            btnLive.FlatAppearance.BorderSize = 0;
            btnLive.FlatStyle = FlatStyle.Flat;
            btnLive.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLive.ForeColor = SystemColors.ButtonHighlight;
            btnLive.Image = Properties.Resources.Design_ohne_Titel_3__1_;
            btnLive.Location = new Point(0, 122);
            btnLive.Name = "btnLive";
            btnLive.Size = new Size(147, 122);
            btnLive.TabIndex = 1;
            btnLive.Tag = "liveTV";
            btnLive.Text = "Live-TV";
            btnLive.TextAlign = ContentAlignment.BottomCenter;
            btnLive.UseVisualStyleBackColor = true;
            btnLive.Click += btnLive_Click;
            // 
            // btnDashboad
            // 
            btnDashboad.BackgroundImage = Properties.Resources.Siyarbekir_2_;
            btnDashboad.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboad.Dock = DockStyle.Top;
            btnDashboad.FlatAppearance.BorderSize = 0;
            btnDashboad.FlatStyle = FlatStyle.Flat;
            btnDashboad.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboad.ForeColor = SystemColors.ButtonHighlight;
            btnDashboad.Location = new Point(0, 0);
            btnDashboad.Name = "btnDashboad";
            btnDashboad.Size = new Size(147, 122);
            btnDashboad.TabIndex = 4;
            btnDashboad.Tag = "Dashboard";
            btnDashboad.UseVisualStyleBackColor = true;
            btnDashboad.Click += btnDashboad_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(48, 48, 48);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(147, 28);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1010, 704);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            mainPanel.MouseDown += mainPanel_MouseDown;
            mainPanel.MouseMove += mainPanel_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 732);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            Controls.Add(upperPanel);
            Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 640);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            upperPanel.ResumeLayout(false);
            upperPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel upperPanel;
        private Panel leftPanel;
        private Button btnLive;
        private Button btnSeries;
        private Button btnSettings;
        private Button btnMovie;
        private Button btnExit;
        private Panel mainPanel;
        private Button btnToggleLeftPanel;
        private Button button1;
        private Label labelTitel;
        private Button btnMaximize;
        private Button btnDashboad;
    }
}
