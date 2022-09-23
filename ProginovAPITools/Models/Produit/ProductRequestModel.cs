using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class ProductRequestRootModel
    {
        [JsonProperty("products")]
        public List<ProductRequestModel> Produits { get; set; }
    }
    public class ProductRequestModel
    {
        [JsonProperty("refext")]
        public string RefText { get; set; }

        [JsonProperty("spe_marque_tec")]
        public string MarqueTecDoc { get; set; }

        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
    }
}
