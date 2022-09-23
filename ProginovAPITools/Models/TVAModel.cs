using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models
{
    public class TVAModelRoot
    {
        [JsonProperty("vat")]
        public List<TVAModel> TVAs { get; set; }
    }
    public class TVAModel
    {
        [JsonProperty("code_tva")]
        public int CodeTVA { get; set; }
        [JsonProperty("tva_libe")]
        public string LibelleTVA { get; set; }
        [JsonProperty("tx_tva")]
        public double TauxTVA { get; set; }
    }
}
