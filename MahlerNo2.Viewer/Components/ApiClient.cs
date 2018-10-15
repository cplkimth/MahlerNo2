#region
using System;
using System.Collections.Generic;
using System.Net.Http;
using MahlerNo2.Viewer.Properties;
using Newtonsoft.Json;
#endregion

namespace MahlerNo2.Viewer.Components
{
    public class ApiClient
    {
        #region singleton
        private static ApiClient _instance;

        public static ApiClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ApiClient();
                return _instance;
            }
        }

        private ApiClient()
        {
            _client = new HttpClient();
        }
        #endregion

        private readonly HttpClient _client;

        private readonly string _baseUrl = $"http://{Settings.Default.IP}:{Settings.Default.Port}/api";

        private string Shot => _baseUrl + "/shot";
        private string Backup => _baseUrl + "/backup";

        public List<string> GetDateList()
        {
            string url = Shot;

            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode == false)
                return null;
            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<string>>(result);
        }

        public byte[] GetShot(string date, string time)
        {
            string url = $"{Shot}/{date}/{time}";

            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode == false)
                return null;

            string result = response.Content.ReadAsStringAsync().Result.Replace("\"", string.Empty);
            return Convert.FromBase64String(result);
        }

        public List<string> GetFileNamesInDate(string date)
        {
            // http://10.10.14.99:3512/api/backup/180717
            string url = $"{Backup}/{date}";

            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode == false)
                return null;
            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<string>>(result);
        }
        
        public byte[] GetShotForBackup(string date, string time)
        {
            // http://10.10.14.99:3512/api/backup/180717/094624
            string url = $"{Backup}/{date}/{time}";

            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode == false)
                return null;

            string result = response.Content.ReadAsStringAsync().Result.Replace("\"", string.Empty);
            return Convert.FromBase64String(result);
        }
    }
}