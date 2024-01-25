using Newtonsoft.Json;
using ProginovAPITools.Models.Documents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.Consignes
{
    public class ConsignesModel
    {
        [JsonProperty("listeconsigne")]
        public List<ConsigneModel> Consignes { get; set; }
    }
    public class ConsigneModel
    {
        [JsonProperty("cod_cli")]
        public int CodeClient { get; set; }
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("consigne")]
        public int Consigne { get; set; }
        [JsonProperty("dat_ret")]
        public string DateRetour { get; set; }
        [JsonProperty("dat_sor")]
        public string DateSor { get; set; }
        [JsonProperty("dat_liv")]
        public string DateLivraison { get; set; }
        [JsonProperty("depot")]
        public int Depot { get; set; }
        [JsonProperty("gratuit")]
        public bool Gratuit { get; set; }
        [JsonProperty("lien_cor")]
        public int LienCor { get; set; }
        [JsonProperty("lien_cos")]
        public int LienCos { get; set; }        
        [JsonProperty("ndos")]
        public int NDos { get; set; }
        [JsonProperty("nom_cli")]
        public string NomClient { get; set; }
        [JsonProperty("nom_pro")]
        public string NomProduit { get; set; }
        [JsonProperty("tabpart_consigne")]
        public int TableauPartConsigne { get; set; }
        [JsonProperty("traitee")]
        public bool Traitee { get; set; }
        [JsonProperty("refext")]
        public string Reference { get; set; }
        [JsonProperty("marque")]
        public string Marque { get; set; }
        [JsonProperty("ref_boite")]
        public string ReferenceBoite { get; set; }
        [JsonProperty("no_cde")]
        public int NumeroCommande { get; set; }
        [JsonProperty("no_bl")]
        public int NumeroBL { get; set; }
        [JsonProperty("no_fact")]
        public int NumeroFacture { get; set; }
        [JsonProperty("poids")]
        public double Poids { get; set; }
        [JsonProperty("conforme")]
        public bool Conforme { get; set; }
        [JsonProperty("avoir_fait")]
        public bool AvoirFait { get; set; }
        [JsonProperty("cle_doc")]
        public string CleDocument { get; set; }

    }
}
