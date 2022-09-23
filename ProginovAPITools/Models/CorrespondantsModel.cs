using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class CorrespondantsModel
    {
        [JsonProperty("contacts")]
        public List<CorrespondantModel> Contacts { get; set; }
    }
}
