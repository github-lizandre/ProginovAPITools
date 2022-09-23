using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.TopVentes
{
    public class ModelFamillesTopVente
    {
        [JsonProperty("famille")]
        public int Identifiant { get; set; }
        [JsonProperty("lib_famille")]
        public string Libelle { get; set; }
        [JsonProperty("sfamilles")]
        public List<ModelSousFamillesTopVente> SousFamilles { get; set; }
    }
}
