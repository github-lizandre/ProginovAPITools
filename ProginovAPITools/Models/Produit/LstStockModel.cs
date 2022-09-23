using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProginovAPITools.Models
{
    public class LstStockModel
    {
        [JsonProperty("cod_soc")]
        public int CodeSociete { get; set; }
        [JsonProperty("nom_soc")]
        public string NomSociete { get; set; }
        [JsonProperty("stock")]
        public int Stock { get; set; }
        [JsonProperty("principal")]
        public bool Principal { get; set; }
        [JsonProperty("dat_dispo")]
        public string DateDispo { get; set; }
        [JsonProperty("stk_futur")]
        public string StockFutur { get; set; }
        [JsonProperty("spe_lst_stock_depot")]
        public List<SpeLstStockModel> SpeLstStockDepot {get; set;}
    }
}