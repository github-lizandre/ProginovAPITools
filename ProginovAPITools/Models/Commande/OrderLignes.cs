using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProginovAPITools.Models.Commande
{
    public class OrderLignesRoot
    {
        [JsonProperty("lignes")]
        public List<OrderLignes> Lignes { get; set; }
    }

    public class OrderHistoLignesRoot
    {
        [JsonProperty("histolig")]
        public List<OrderLignes> Lignes { get; set; }
        
    }

    public class OrderLignes
    {
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("devise")]
        public string Devise { get; set; }
        [JsonProperty("mt_ht")]
        public double MontantHorsTaxes { get; set; }
        [JsonProperty("no_ligne")]
        public int NumeroLigne { get; set; }
        [JsonProperty("nom_pro")]
        public string NomProduit { get; set; }
        [JsonProperty("px_vte")]
        public double PrixVente { get; set; }
        [JsonProperty("qte")]
        public int Quantite { get; set; }
        [JsonProperty("refext")]
        public string RefText { get; set; }
        [JsonProperty("rem_app")]
        public bool RemiseApplique { get; set; }
        [JsonProperty("remise1")]
        public double Remise { get; set; }
        [JsonProperty("px_net")]
        public double PrixNet { get; set; }
        [JsonProperty("spe_marque_tec")]
        public string MarqueTecDoc { get; set; }
        [JsonProperty("no_cde")]
        public string NumeroCommande { get; set; }
        [JsonProperty("spe_dat_dispo")]
        public string DateDispo { get; set; }
        [JsonProperty("no_bl")]
        public int? NumeroBL { get; set; }
        [JsonProperty("spe_dat_cde")]
        public string DateCommande { get; set; }
        [JsonProperty("spe_relk_bp")]
        public int NumeroReliquatBp { get; set; }
        [JsonProperty("spe_bldispo")]
        public bool SpelBLDispo { get; set; }
        [JsonProperty("dat_mvt")]
        public string Dat_mvt { get; set; }
    }
}