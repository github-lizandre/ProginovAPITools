using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Produit
{
    public class ProduitLiesModelRoot
    {
        [JsonProperty("products")]
        public List<ProduitLiesModel> Products { get; set; }
    }

    public class ProduitLiesModel
    {
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("nom_pro")]
        public string NomProduit { get; set; }
        [JsonProperty("spe_prcomp")]
        public bool ProduitComplementaires { get; set; }
        [JsonProperty("spe_prlie")]
        public bool ProduitLies { get; set; }
        [JsonProperty("spe_quantite")]
        public int Quantite { get; set; }
        [JsonProperty("spe_qte_lie")]
        public double QuantiteLie { get; set; }
    }
}
