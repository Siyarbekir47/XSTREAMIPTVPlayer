using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using XSTREAMIPTVPlayer.Models;

namespace XSTREAMIPTVPlayer
{
    public class Xtream
    {
        public string xUsername { get; set; }
        public string xPassword { get; set; }
        public string xServerIp { get; set; }

        void loadUserCredential()
        {
            string filePath = "ActiveUser.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                UserCredential activeUser = JsonConvert.DeserializeObject<UserCredential>(json);
                xServerIp = activeUser.ServerIp;
                xUsername = activeUser.Username;
                xPassword = activeUser.Password;
            }
            else
            {
                MessageBox.Show("No active user found");
            }

        }

        public string get_authenticate_URL()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}";
            return url ;
        }
        public string get_live_categories()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_live_categories";
            return url;
        }
        public string get_vod_categories()
        {

            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_vod_categories";
            return url;
        }
        public string get_live_streams()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_live_streams";
            return url;
        }
        public string get_vod_streams()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_vod_streams";
            return url;
        }
        public string get_vod_info()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_vod_info";
            return url;
        }
        public string get_series_categories()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_series_categories";
            return url;
        }
        public string get_series()
        {
            loadUserCredential();
            string url = $"{xServerIp}/player_api.php?username={xUsername}&password={xPassword}&action=get_series";
            return url;
        }

        //get_live_categories", "get_vod_categories", "get_live_streams", "get_short_epg", "get_simple_data_table", "get_vod_streams", "get_vod_info", "get_series_categories", "get_series"

    }
}
