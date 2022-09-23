using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models
{
    public class ConstructeurRoot
    {
        [JsonProperty("tableaulibre")]
        public List<ConstructeurModel> Constructeurs { get; set; }
    }
    public class ConstructeurModel
    {
        [JsonProperty("za0")]
        public string Nom { get; set; }
        [JsonProperty("zt0")]
        public string Id { get; set; }
    }
}
