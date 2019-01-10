using Newtonsoft.Json;
using RedMosquitoView.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RedMosquitoView.Services
{
    class WebCamService
    {
        public List<WebCamItem> GetWebcams()
        {
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("http://api.oceandrivers.com/v1.0/getWebCams/").Result;
            }

            return JsonConvert.DeserializeObject<List<WebCamItem>>(json);
        }
    }
}
