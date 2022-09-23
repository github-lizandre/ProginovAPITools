using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Price
{
    public class PriceRequestModelRoot
    {
        [JsonProperty("price")]
        public List<PriceRequestModel> Prices { get; set; }
    }
    public class PriceRequestModel
    {
        [JsonProperty("cod_cli")]
        public int CodeClient { get; set; }
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("typ_cde")]
        public int TypeCommande { get; set; }
        [JsonProperty("qte")]
        public int Quantite { get; set; }
        [JsonProperty("date_px")]
        public string DateDuPrix { get; set; }
    }
}
