using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class DroitsWebModel
    {
        [JsonProperty("tableaulibre")]
        public List<SiteModel> Droits { get; set; }
    }

    public class SiteModel
    {
        [JsonProperty("zt0")]
        public string Nom { get; set; }
    }
}
