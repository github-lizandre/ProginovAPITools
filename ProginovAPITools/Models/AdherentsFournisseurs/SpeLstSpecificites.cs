using Newtonsoft.Json;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class SpeLstSpecificites
    {
        [JsonProperty("cod_crit")]
        public int CodeCritere { get; set; }
        [JsonProperty("lib_crit")]
        public string LibelleCritere { get; set; }
    }
}