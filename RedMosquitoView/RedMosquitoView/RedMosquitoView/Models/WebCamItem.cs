using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedMosquitoView.Models
{
    public class WebCamItem
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }


}
