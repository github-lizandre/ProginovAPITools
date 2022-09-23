using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Promos
{
    public class ListePromoProductModelRoot
    {
        [JsonProperty("promotions")]
        public List<ListePromoProductModel> Promotions { get; set; }
    }

    public class ListePromoProductModel
    {
        //Pernet de savoir si un produit doit etre mis en avant
        [JsonProperty("exceptionnel")]
        public bool Exceptionnel { get; set; }
        [JsonProperty("cat_tar")]
        public string CategorieTarifaire { get; set; }
        [JsonProperty("c_promo")]
        public string CodePromo { get; set; }
        //classement pour l'affichage
        [JsonProperty("classement")]
        public int Classement { get; set; }
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("dat_deb")]
        public string DateDebut { get; set; }
        [JsonProperty("dat_fin")]
        public string DateFin { get; set; }
        //Evenement exceptionnel
        [JsonProperty("eve_exc")]
        public string EvennementExceptionnel { get; set; }
        [JsonProperty("marque")]
        public string Marque { get; set; }
        [JsonProperty("marque_cds")]
        public string MarqueCds { get; set; }
        [JsonProperty("nb_client")]
        public int NbClients { get; set; }
        [JsonProperty("nom_pro")]
        public string NomProduit { get; set; }
        [JsonProperty("px_net")]
        public bool PrixNet { get; set; }
        [JsonProperty("qte_vendue")]
        public int QuantiteVendue { get; set; }
        [JsonProperty("refext")]
        public string ReferenceExterne { get; set; }
        [JsonProperty("stock")]
        public double Stock { get; set; }
    }
}
