using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.TopVentes
{
    public class ModelProduitTopVenteRoot
    {
        [JsonProperty("topventes")]
        public List<ModelProduitTopVente> TopVentes { get; set; }
    }

    public class ModelProduitTopVente
    {
        [JsonProperty("famille")]
        public int IdentifiantFamille { get; set; }
        [JsonProperty("marque_cds")]
        public string Marque { get; set; }
        [JsonProperty("s_famille")]
        public int IdentifiantSousFamille { get; set; }
        [JsonProperty("refext")]
        public string Reference { get; set; }
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("nom_pro")]
        public string Nom { get; set; }
        [JsonProperty("classement")]
        public int Classement { get; set; }
    }
}
