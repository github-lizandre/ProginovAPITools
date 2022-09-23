using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Promos
{
    public class ListePromoModelRoot
    {
        [JsonProperty("promotions")]
        public List<ListePromoModel> Promotions { get; set; }
    }

    public class ListePromoModel
    {
        [JsonProperty("cod_promo")]
        public string CodePromo { get; set; }
        [JsonProperty("intitule")]
        public string Intitule { get; set; } 
        [JsonProperty("datdeb")]
        public string DateDebut { get; set; }        
        [JsonProperty("datfin")]
        public string DateFin { get; set; }
        [JsonProperty("marque_tec")]
        public string MarqueTecDoc { get; set; }
    }
}
