using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class ContactFournisseurModelRoot
    {
        [JsonProperty("contacts")]
        public List<ContactFournisseurModel> ContactsFournisseurs { get; set; }
    }
    public class ContactFournisseurModel
    {
        [JsonProperty("nom_cor")]
        public string Nom { get; set; }
        [JsonProperty("qualite")]
        public string Fonction { get; set; }
        [JsonProperty("internet")]
        public string Email { get; set; }
        [JsonProperty("num_tel")]
        public string Telephone { get; set; }
        [JsonProperty("no_port")]
        public string Telephone2 { get; set; }
    }
}
