using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Adresses
{
    public class AdresseSuccessRoot
    {
        [JsonProperty("success")]
        public AdresseSuccess Success { get; set; }
    }
    public class AdresseSuccess
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("createid")] //correspond a cod_adr
        public int CodeAdresse { get; set; }
        [JsonProperty("createid2")] //correspond a no_lieu
        public int NoLieu { get; set; }
    }
}
