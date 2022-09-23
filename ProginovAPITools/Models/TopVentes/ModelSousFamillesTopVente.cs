using Newtonsoft.Json;

namespace ProginovAPITools.Models.TopVentes
{
    public class ModelSousFamillesTopVente
    {
        [JsonProperty("sfamille")]
        public int Identifiant { get; set; }
        [JsonProperty("lib_sfamille")]
        public string Libelle { get; set; }
    }
}