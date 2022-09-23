using Newtonsoft.Json;

namespace ProginovAPITools.Models
{
    public class SpeLstStockModel
    {
        [JsonProperty("depot")]
        int Depot { get; set; }
        [JsonProperty("stock")]
        int Stock { get; set; }
    }
}