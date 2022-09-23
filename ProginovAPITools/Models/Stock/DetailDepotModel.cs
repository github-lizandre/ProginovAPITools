using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class DetailDepotModel
    {
        [JsonProperty("codpro")]
        public int CodeProduit { get; set; }
        //quantités physiquement présentes en stock
        [JsonProperty("stock_physique")]
        public int StockPhysique { get; set; }
        //quantités disponibles (physique – réservées…)
        [JsonProperty("stock_reel")]
        public int StockReel { get; set; }
        //permet d’indiquer s’il existe des commandes fournisseurs sur le produi
        [JsonProperty("stock_futur")]
        public int StockFutur { get; set; }
    }
}
