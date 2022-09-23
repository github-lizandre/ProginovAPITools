using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models
{
    public class TypeLivraisonModelRoot
    {
        [JsonProperty("listtypeliv")]
        public List<TypeLivraisonModel> Types { get; set; }
    }
    public class TypeLivraisonModel
    {
        [JsonProperty("intitule")]
        public string Intitule { get; set; }
        [JsonProperty("typ_cde")]
        public int TypeCommande { get; set; }
        [JsonProperty("mod_liv")]
        public string ModeLivraison { get; set; }
        [JsonProperty("jour_cutoff")]
        public int? JourCutOff { get; set; }
        [JsonProperty("heure_cutoff")]
        public string HeureCutOff { get; set; }
    }
}
