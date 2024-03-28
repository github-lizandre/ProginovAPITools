using Newtonsoft.Json;
using System;

namespace ProginovAPITools.Models
{
    public class SpeLstStockModel
    {
        
        [JsonProperty("depot")]
        public int Depot { get; set; }
        [JsonProperty("stock")]
        public double StockDouble { get; set; }
        public int Stock
        {
            get
            {
                int DecimalPart;
                DecimalPart = Convert.ToInt32(Math.Truncate(StockDouble));
                return DecimalPart;
            }
        }
        [JsonProperty("nom_depot")]
        public string NomDepot { get; set; }
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
    }
}