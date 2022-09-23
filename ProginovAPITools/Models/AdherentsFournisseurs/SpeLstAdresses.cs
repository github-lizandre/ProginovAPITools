using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class SpeLstAdresses
    {
        [JsonProperty("adresse")]
        public List<string> Adresse { get; set; }
        [JsonProperty("k_post2")]
        public string CodePostal { get; set; }
        [JsonProperty("nom_adr")]
        public string NomAdresse { get; set; }
        [JsonProperty("num_fax")]
        public string NumeroFax { get; set; }
        [JsonProperty("num_tel")]
        public string NumeroTelephone { get; set; }
        [JsonProperty("ville")]
        public string Ville { get; set; }
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }
        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

    }
}