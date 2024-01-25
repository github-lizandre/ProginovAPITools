using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class SpeLstConditions
    {
        [JsonProperty("spe_lib_condition")]
        public string LibelleRemise { get; set; }
        [JsonProperty("rem_app")]
        public bool[] RemisesApparentes { get; set; }         
        [JsonProperty("remise1")]
        public double[] Remises { get; set; }
        [JsonProperty("fam_tar")]
        public string Famille { get; set; }        
        [JsonProperty("sf_tar")]
        public string SousFamille { get; set; }
    }
}
