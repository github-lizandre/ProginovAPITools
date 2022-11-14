using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.Transporteurs
{
    public class ModelTransporteurRoot
    {
        [JsonProperty("transporteurs")]
        public List<ModelTransporteur> Transporteurs { get; set; }
    }
    public class ModelTransporteur
    {
        [JsonProperty("position")]
        public int Position { get; set; }
        [JsonProperty("cod_fou")]
        public int CodeTransporteur { get; set; }
        [JsonProperty("nom_fou")]
        public string NomTransporteur { get; set; }
        [JsonProperty("lib_trs")]
        public string LibelleTransporteur { get; set; }
        [JsonProperty("delai")]
        public string Delai { get; set; }
        [JsonProperty("prix")]
        public double? Prix { get; set; }
        [JsonProperty("typ_con")]
        public string typ_con { get; set; }
    }
}
