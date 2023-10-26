using Newtonsoft.Json;

namespace ProginovAPITools.Models
{
    public class SpeLstStockModel
    {
        
        [JsonProperty("depot")]
        public int Depot { get; set; }
        [JsonProperty("stock")]
        public int Stock { get; set; }
        [JsonProperty("nom_depot")]
        public string NomDepot { get; set; }
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
    }
}