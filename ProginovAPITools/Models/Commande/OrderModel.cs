using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Commande
{
    public class OrderModelRoot
    {
        [JsonProperty("orders")]
        public List<OrderModel> Orders { get; set; }
    }
    public class OrderModel
    {
        [JsonProperty("adr_fac")]
        public List<string> AdresseFacturation { get; set; }
        [JsonProperty("adr_liv")]
        public List<string> AdresseLivraison { get; set; }
        [JsonProperty("adrfac4")]
        public string AdresseFaturationLigne4 { get; set; }
        [JsonProperty("adrliv4")]
        public string AdresseLivraisonLigne4 { get; set; }
        [JsonProperty("dat_cde")]
        public string DateCommande { get; set; }
        [JsonProperty("dat_liv")]
        public string DateLivraison { get; set; }
        [JsonProperty("k_post2f")]
        public string CodePostalFacturation { get; set; }
        [JsonProperty("k_post2l")]
        public string CodePostalLivraison { get; set; }
        [JsonProperty("mod_liv")]
        public string ModeDeLivraison { get; set; }
        [JsonProperty("mt_ht")]
        public double MontantHorsTaxes { get; set; }
        [JsonProperty("no_bl")]
        public int NumeroBL { get; set; }
        [JsonProperty("no_cde")]
        public int NumeroCommande { get; set; }
        [JsonProperty("no_fact")]
        public int NumeroFacture { get; set; }
        [JsonProperty("ori_cde")]
        public string OrigineDeLaCommande { get; set; }
        [JsonProperty("poids")]
        public double Poids { get; set; }
        [JsonProperty("ref_cde")]
        public string ReferenceCommande { get; set; }
        [JsonProperty("typ_cde")]
        public int TypeCommande { get; set; }
        [JsonProperty("typ_sai")]
        public string TypeSai { get; set; }
        [JsonProperty("villef")]
        public string VilleFacturation { get; set; }
        [JsonProperty("villel")]
        public string VilleLivraison { get; set; }
        [JsonProperty("spe_bldispo")]
        public bool SpelBLDispo { get; set; }
        [JsonProperty("spe_facdispo")]
        public bool SpelFactureDispo { get; set; }
        [JsonProperty("lignes")]
        public List<OrderLignes> Lignes { get; set; }
    }
}
