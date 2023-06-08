using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiniApps.Task.Logic.Models.GitHub
{
    internal class License
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spdx_id")]
        public string SpdxID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("node_id")]
        public string NodeID { get; set; }
    }
}
