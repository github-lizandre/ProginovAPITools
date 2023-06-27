using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.Litiges
{
    public class TypeLitigeModelRoot
    {
        [JsonProperty("tabgco")]
        public List<TypeLitigeModel> TypeLitiges { get; set; }
    }
    public class TypeLitigeModel
    {
        [JsonProperty("a_tab")]
        public string Code { get; set; }
        [JsonProperty("inti_tab")]
        public string Intitule { get; set; }
    }
}
