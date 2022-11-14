using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProginovAPITools.Models.Transporteurs
{
    public class ParamTransporteurRoot
    {
        [JsonProperty("params")]
        public ParamTransporteur Params { get; set; }
    }
    public class ParamTransporteur
    {
        [JsonProperty("cod_cli")]
        public int CodeClient { get; set; }
        [JsonProperty("departement")]
        public int Departement { get; set; }
        //True/False selon coche sur le site Web
        [JsonProperty("enlevement")]
        public bool Enlevement { get; set; }
        //True/False selon coche sur le site Web
        [JsonProperty("samedi")]
        public bool Samedi { get; set; }
        [JsonProperty("products")]
        public List<ParamTransporteurProducts> Products { get; set; }
    }

    public class ParamTransporteurProducts
    {
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("qte")]
        public int Quantite { get; set; }
    }
}
