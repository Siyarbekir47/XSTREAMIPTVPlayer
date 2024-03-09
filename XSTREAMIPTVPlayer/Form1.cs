using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using XSTREAMIPTVPlayer.UserControlls;
using XSTREAMIPTVPlayer.UserControls;
using XSTREAMIPTVPlayer.Models;
using Newtonsoft.Json;

namespace XSTREAMIPTVPlayer
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //define the constants
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int HT_Left = 10;
        public const int HT_Right = 11;
        public const int HT_Top = 12;
        public const int HT_TopLeft = 13;
        public const int HT_TopRight = 14;
        public const int HT_Bottom = 15;
        public const int HT_BottomLeft = 16;
        public const int HT_BottomRight = 17;
        public const int WM_NCHITTEST = 0x84;
        private const int BORDER_WIDTH = 15; // Width of the border for resizing

        public bool IsMenuCollapsed { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            IsMenuCollapsed = false;


            //debug test load user
        }

        //load current user
        public static List<UserCredential> LoadUserCredentials(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                MessageBox.Show("Works");
                return JsonConvert.DeserializeObject<List<UserCredential>>(json);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
                return new List<UserCredential>(); // Return an empty list on error
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"An error occurred while parsing the JSON data: {ex.Message}");
                return new List<UserCredential>(); // Return an empty list on error
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;

                // Check if the mouse is within the resizing border
                if (x >= clientSize.Width - BORDER_WIDTH && y >= clientSize.Height - BORDER_WIDTH)
                {
                    m.Result = (IntPtr)HT_BottomRight; // Bottom right corner
                }
                else if (x >= clientSize.Width - BORDER_WIDTH)
                {
                    m.Result = (IntPtr)HT_Right; // Right edge
                }
                else if (y >= clientSize.Height - BORDER_WIDTH)
                {
                    m.Result = (IntPtr)HT_Bottom; // Bottom edge
                }


            }
        }

        // Public or internal method to check if a control is loaded
        public bool IsControlLoaded<T>() where T : UserControl
        {
            return mainPanel.Controls.OfType<T>().Any();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseLeftPanel()
        {
            // Check if the panel is visible by checking its width
            if (IsMenuCollapsed == false)
            {
                // Hide the panel by setting the width to 0
                leftPanel.Width = 0;
                // Optional: Adjust the mainPanel location and width to fill the freed space
                mainPanel.Location = new Point(0, mainPanel.Location.Y);
                mainPanel.Width = this.ClientSize.Width;
                IsMenuCollapsed = true;
            }
            else
            {
                // Show the panel by setting the width to the original width, e.g., 200
                leftPanel.Width = 200;
                // Optional: Reset the mainPanel location and width
                mainPanel.Location = new Point(leftPanel.Width, mainPanel.Location.Y);
                mainPanel.Width = this.ClientSize.Width - leftPanel.Width;
                IsMenuCollapsed = false;
            }
        }

        private void ResizeFromBottomRight(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Location.X >= this.mainPanel.ClientSize.Width - BORDER_WIDTH && e.Location.Y >= this.mainPanel.ClientSize.Height - BORDER_WIDTH)
                {
                    // Release the mouse capture and send the resize message
                    ReleaseCapture();
                    // Send the HTBOTTOMRIGHT message to resize the form diagonally
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_BottomRight, 0);
                }
            }
        }
        private void UpdateCursorForResizing(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= mainPanel.Width - BORDER_WIDTH && e.Location.Y >= mainPanel.Height - BORDER_WIDTH)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void upperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ResizeFromBottomRight(sender, e);
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateCursorForResizing(sender, e);
        }

        private void btnToggleLeftPanel_Click(object sender, EventArgs e)
        {
            CollapseLeftPanel();
        }

        //function to toggle left panel

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // Check if the form is currently maximized
            if (this.WindowState == FormWindowState.Maximized)
            {
                // If it is, then clicking the button should restore it to normal size
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // If it's not maximized, then clicking the button should maximize it
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            // Check if LiveTVControl is already loaded
            bool isLoaded = mainPanel.Controls.OfType<LiveTVControl>().Any();

            if (!isLoaded)
            {
                mainPanel.Controls.Clear(); // Clear existing controls
                LiveTVControl liveTvControl = new LiveTVControl();
                liveTvControl.Dock = DockStyle.Fill; // Fill the entire mainPanel
                mainPanel.Controls.Add(liveTvControl); // Add the User Control
            }


        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            bool isLoaded = mainPanel.Controls.OfType<SeriesControl>().Any();

            if (!isLoaded)
            {
                mainPanel.Controls.Clear(); // Clear existing controls
                SeriesControl seriesControl = new SeriesControl();
                seriesControl.Dock = DockStyle.Fill; // Fill the entire mainPanel
                mainPanel.Controls.Add(seriesControl); // Add the User Control
            }


        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            bool isLoaded = mainPanel.Controls.OfType<MoviesControl>().Any();

            if (!isLoaded)
            {

                mainPanel.Controls.Clear(); // Clear existing controls
                MoviesControl moviesControl = new MoviesControl();
                moviesControl.Dock = DockStyle.Fill; // Fill the entire mainPanel
                mainPanel.Controls.Add(moviesControl); // Add the User Control
            }

        }

        private void btnDashboad_Click(object sender, EventArgs e)
        {
            bool isLoaded = mainPanel.Controls.OfType<DashboardControl>().Any();

            if (!isLoaded)
            {

                mainPanel.Controls.Clear(); // Clear existing controls
                DashboardControl dashboardControl = new DashboardControl();
                dashboardControl.Dock = DockStyle.Fill; // Fill the entire mainPanel
                mainPanel.Controls.Add(dashboardControl); // Add the User Control
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            bool isLoaded = mainPanel.Controls.OfType<SettingsControl>().Any();

            if (!isLoaded)
            {

                mainPanel.Controls.Clear(); // Clear existing controls
                SettingsControl settingsControl = new SettingsControl();
                settingsControl.Dock = DockStyle.Fill; // Fill the entire mainPanel
                mainPanel.Controls.Add(settingsControl); // Add the User Control
            }
        }
    }
}
