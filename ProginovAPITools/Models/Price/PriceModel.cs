using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Price
{
    public class PriceModelRoot
    {
        [JsonProperty("price")]
        public List<PriceModel> Prices { get; set; }
    }
    public class PriceModel
    {
        [JsonProperty("zlo1")]
        public bool Zlo1 { get; set; }
        [JsonProperty("zlo2")]
        public bool Zlo2 { get; set; }
        [JsonProperty("zlo3")]
        public bool Zlo3 { get; set; }
        [JsonProperty("zlo4")]
        public bool Zlo4 { get; set; }
        [JsonProperty("zlo5")]
        public bool Zlo5 { get; set; }
        [JsonProperty("codcli")]
        public int CodeClient { get; set; }
        [JsonProperty("codpro")]
        public int CodeProduit { get; set; }
        [JsonProperty("prixpro")]
        public double PrixProduit { get; set; }
        [JsonProperty("prixref")]
        public double PrixRef { get; set; }
        //Une indication si il existe des remises par quantite
        [JsonProperty("remqte")]
        public bool RemiseQuantite { get; set; }
        [JsonProperty("remises")]
        public List<double?> Remises { get; set; }
        //Differents paliers a partir duquel les remises s'appliquent
        [JsonProperty("palremqte")]
        public string PalierRemiseQuantite { get; set; }
        [JsonProperty("prixhpromo")]
        public double PrixHPromo { get; set; }
        [JsonProperty("datepx")]
        public string DatePrix { get; set; }
        [JsonProperty("typecde")]
        public int TypeCommande { get; set; }
        [JsonProperty("depot")]
        public int Depot { get; set; }
        //Indication si le prix est donné pour une quantite particuliere
        [JsonProperty("px_pour")]
        public int PrixPour { get; set; }
        [JsonProperty("mult_vte")]
        public int? MultipleDeVente { get; set; }
        [JsonProperty("spe_datdebpromo")]
        public string DateDebutPromo { get; set; }
        [JsonProperty("spe_datfinpromo")]
        public string DateFinPromo { get; set; }
        [JsonProperty("codpromo")]
        public string CodePromo { get; set; }
    }
}
