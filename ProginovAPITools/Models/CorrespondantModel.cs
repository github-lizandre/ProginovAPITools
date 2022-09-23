using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class CorrespondantModel
    {
        [JsonProperty("cod_cor")]
        public int CodeCorrespondant { get; set; }
        [JsonProperty("cod_tiers")]
        public int CodeTiers { get; set; }
        [JsonProperty("no_corresp")]
        public int NoCorrespondant { get; set; }
        [JsonProperty("nom_cor")]
        public string Nom { get; set; }
        [JsonProperty("internet")]
        public string Email { get; set; }
        [JsonProperty("fct_emp")]
        public int Fonction { get; set; }
        [JsonProperty("spe_droits_web")]
        public string DroitsWeb { get; set; }
    }
}
