using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.Litiges
{
    public class MotifLitigeModelRoot
    {
        [JsonProperty("tabgco")]
        public List<MotifLitigeModel> MotifLitiges { get; set; }
    }
    public class MotifLitigeModel
    {
        [JsonProperty("zal1")]
        public string LibelleLong { get; set; }
        [JsonProperty("inti_tab")]
        public string LibelleCourt { get; set; }
        [JsonProperty("a_tab")]
        public string CodeMotif { get; set; }
        [JsonProperty("zta1")]
        public string TypeLitige { get; set; }
    }
}
