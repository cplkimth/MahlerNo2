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

        private string BaseUrl => $"http://{Settings.Default.IP}:{Settings.Default.Port}/api/shot";

        public List<string> GetDateList()
        {
            string url = BaseUrl;

            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode == false)
                return null;
            var result = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<List<string>>(result);

            throw new NotImplementedException("ApiClient.GetDateList");

//            byte[] mybytearray = null;
//            _response = _client.GetAsync(string.Format("http://localhost:13925/api/values")).Result;
//            if (_response.IsSuccessStatusCode)
//            {
//                string result=null;
//                result = _response.Content.ReadAsStringAsync().Result.Replace("\"", string.Empty);
//                mybytearray=Convert.FromBase64String(result);
//
//                var stream = new MemoryStream(mybytearray);
//                pictureBox1.Image = Image.FromStream(stream);
//            }
        }

        public byte[] GetShot(string date, string time)
        {
            string url = $"{BaseUrl}/{date}/{time}";

            var response = _client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode == false)
                return null;

            string result = response.Content.ReadAsStringAsync().Result.Replace("\"", string.Empty);
            return Convert.FromBase64String(result);
        }
    }
}