using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using XSTREAMIPTVPlayer.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace XSTREAMIPTVPlayer.UserControls
{
    public partial class AddUserProfile : UserControl
    {
        private void SaveUser(string serverIp, string username, string password, string nickname)
        {
            // Save user to database

            // Create a new user object
            var user = new
            {
                ServerIp = serverIp,
                Username = username,
                Password = password,
                Nickname = nickname
            };

            //serialize the user object to json
            string userDataJson = JsonConvert.SerializeObject(user);

            //file path to save the user data
            string filePath = "users.json";

            //read the existing user data, or create a new list if the file doesn't exist
            List<dynamic> users = File.Exists(filePath)
                ? JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(filePath))
                : new List<dynamic>();

            //add the new user to the existing user data
            users.Add(user);

            //write the updated user data to the file
            File.WriteAllText(filePath, JsonConvert.SerializeObject(users, Formatting.Indented));




        }

        private void UpdateUserListDisplay()
        {
            string filePath = "users.json";
            if (File.Exists(filePath))
            {
                // Clear the ListView before adding new items
                lstvUsers.Items.Clear();

                List<dynamic> users = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(filePath));

                foreach (var user in users)
                {
                    // Make sure user.Username and user.ServerIP are not null before adding them
                    string username = user.Username != null ? user.Username.ToString() : "Unknown";
                    string serverIP = user.ServerIp != null ? user.ServerIp.ToString() : "Unknown";
                    string nickname = user.Nickname != null ? user.Nickname.ToString() : "Unknown";
                    string password = user.Password != null ? user.Password.ToString() : "Unknown";

                    // Create a new ListViewItem with the username
                    ListViewItem item = new ListViewItem(nickname);
                    // Add subitems if you want to display other details
                    item.SubItems.Add(username);
                    item.SubItems.Add(password);
                    item.SubItems.Add(serverIP);

                    // ... Add other subitems as needed

                    // Add the item to the ListView
                    lstvUsers.Items.Add(item);
                }
            }
        }
        public AddUserProfile()
        {
            InitializeComponent();
            lstvUsers.FullRowSelect = true;
        }

        private void AddUserProfile_Load(object sender, EventArgs e)
        {
            UpdateUserListDisplay();
        }


        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            SaveUser(txtServerIP.Text, txtUserName.Text, txtPassword.Text, txtNickName.Text);
            UpdateUserListDisplay();
        }


        private void btnActivateUser_Click(object sender, EventArgs e)
        {
            if (lstvUsers.SelectedItems.Count > 0)
            {
                var selectedItem = lstvUsers.SelectedItems[0];
                var selectedUser = new UserCredential
                {
                    Username = selectedItem.SubItems[1].Text, // Assuming the first column is Username
                    Password = selectedItem.SubItems[2].Text,  // Assuming the third column is Password
                    ServerIp = selectedItem.SubItems[3].Text // Assuming the second column is Server IP

                };

                string json = JsonConvert.SerializeObject(selectedUser, Formatting.Indented);
                File.WriteAllText("ActiveUser.json", json);
                string currUser = selectedUser.Username;
            }
            else
            {
                MessageBox.Show("Please select a user from the list.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lstvUsers.SelectedItems.Count > 0)
            {
                var selectedItem = lstvUsers.SelectedItems[0];
                var selectedUser = new UserCredential
                {
                    Username = selectedItem.SubItems[1].Text, // Assuming the first column is Username
                    Password = selectedItem.SubItems[2].Text,  // Assuming the third column is Password
                    ServerIp = selectedItem.SubItems[3].Text // Assuming the second column is Server IP

                };

                string filePath = "users.json";
                if (File.Exists(filePath))
                {
                    List<dynamic> users = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText(filePath));
                    users.RemoveAll(u => u.Username == selectedUser.Username && u.ServerIp == selectedUser.ServerIp);
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(users, Formatting.Indented));
                    UpdateUserListDisplay();
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the list.");
            }
        }
        //http://crystal.ottc.pro/xmltv.php?username=GA08JHDB4V&password=Y3FHW2VUZY


        public async Task<string> DownloadEPGAndSaveToFile(string epgUrl, string user, string serverIp)
        {
            using (var client = new HttpClient())
            {
                // Send a GET request to the EPG URL
                var response = await client.GetAsync(epgUrl);
                response.EnsureSuccessStatusCode();

                // Read the response content as a string
                string epgData = await response.Content.ReadAsStringAsync();

                // Create the EPG directory path in the application's base directory
                string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EPGData");
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                // Use the current date and time to create a unique file name
                string fileName = $"EPG_{user}_{serverIp}.xml";
                string savedXMLPath = Path.Combine(directoryPath, fileName);

                // Save the EPG data to the file
                await File.WriteAllTextAsync(savedXMLPath, epgData);
                MessageBox.Show($"EPG data saved to {savedXMLPath}");

                return epgData; // Return the EPG data in case you need it
            }
        }


        private void btnDownloadEPG_Click(object sender, EventArgs e)
        {
            string filePath = "ActiveUser.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                UserCredential activeUser = JsonConvert.DeserializeObject<UserCredential>(json);
                string serverIp = activeUser.ServerIp;
                string user = activeUser.Username;
                string pass = activeUser.Password;
                string url = $"{serverIp}/xmltv.php?username={user}&password={pass}";
                Clipboard.SetText(url);
                MessageBox.Show("URL copied to clipboard");
                DownloadEPGAndSaveToFile(url, user, serverIp);
            }

            else
            {
                MessageBox.Show("No active User");
            }
            //DownloadEPGAndSaveToFile("http://crystal.ottc.pro/xmltv.php?username=GA08JHDB4V&password=Y3FHW2VUZY", currUser);
            //string url = $"{serverIp}/player_api.php?username={user}&password={pass}&action=get_live_streams";
        }

        private void btnUpdateChannels_Click(object sender, EventArgs e)
        {
            Xtream xtream = new Xtream();
            string urlLiveCategories = xtream.get_live_categories();
            string urlVodCategories = xtream.get_vod_categories();
            string urlLiveStreams = xtream.get_live_streams();
            string urlVodStreams = xtream.get_vod_streams();
            string urlVodInfo = xtream.get_vod_info();
            string urlSeries = xtream.get_series();
            string urlSeriesCategories = xtream.get_series_categories();

            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Userinfo");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);   
            }
            Web web = new Web();
            web.DownloadJsonAsync(urlLiveCategories, Path.Combine(directoryPath, xtream.xUsername + "_LiveCategories.json"));
            web.DownloadJsonAsync(urlVodCategories, Path.Combine(directoryPath, xtream.xUsername + "_VodCategories.json"));
            web.DownloadJsonAsync(urlLiveStreams, Path.Combine(directoryPath, xtream.xUsername + "_LiveStreams.json"));
            web.DownloadJsonAsync(urlVodStreams, Path.Combine(directoryPath, xtream.xUsername + "_VodStreams.json"));
            web.DownloadJsonAsync(urlVodInfo, Path.Combine(directoryPath, xtream.xUsername + "_VodInfo.json"));
            web.DownloadJsonAsync(urlSeries, Path.Combine(directoryPath, xtream.xUsername + "_Series.json"));
            web.DownloadJsonAsync(urlSeriesCategories, Path.Combine(directoryPath, xtream.xUsername + "_SeriesCategories.json"));

            //DownloadEPGAndSaveToFile("http://crystal.ottc.pro/xmltv.php?username=GA08JHDB4V&password=Y3FHW2VUZY", currUser);
            //string url = $"{serverIp}/player_api.php?username={user}&password={pass}&action=get_live_streams";
            //https://github.com/chazlarson/py-xtream-codes/blob/master/xtream.py
            //get_live_categories", "get_vod_categories", "get_live_streams", "get_short_epg", "get_simple_data_table", "get_vod_streams", "get_vod_info", "get_series_streams", "get_series"
        }
    }
}

