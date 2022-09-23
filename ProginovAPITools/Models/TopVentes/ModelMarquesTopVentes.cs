using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.TopVentes
{
    public class ModelMarquesTopVentesRoot
    {
        [JsonProperty("marques")]
        public List<ModelMarquesTopVentes> Marques { get; set; }
    }

    public class ModelMarquesTopVentes
    {
        [JsonProperty("marque_cds")]
        public string Marque { get; set; }
        [JsonProperty("lib_marque_pnv")]
        public string MarqueProgi { get; set; }
        [JsonProperty("marque_pnv")]
        public string CodeMarque { get; set; }
        [JsonProperty("familles")]
        public List<ModelFamillesTopVente> Familles { get; set; }
    }
}
