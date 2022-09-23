using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.Adresses
{
    public class PaysModelRoot
    {
        [JsonProperty("tabcomp")]
        public List<PaysModel> Pays { get; set; }
    }

    public class PaysModel
    {
        [JsonProperty("a_tab")]
        public string Code { get; set; }
        [JsonProperty("inti_tab")]
        public string Description { get; set; }
        [JsonProperty("web")]
        public bool IsWeb { get; set; }
    }
}
