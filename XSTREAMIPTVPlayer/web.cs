using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XSTREAMIPTVPlayer
{
    public class Web
    {
        //download JSON's from the server and save them to the local file
        public async Task DownloadJsonAsync(string url, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();

                // Parse the JSON content to ensure it's valid
                var parsedJson = JsonConvert.DeserializeObject(content);

                // Serialize it back to a string with indentation
                string prettyJson = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);

                await File.WriteAllTextAsync(filePath, prettyJson);

            }
        }


    }
}
