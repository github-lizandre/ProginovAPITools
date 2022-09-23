using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class FournisseurModelRoot
    {
        [JsonProperty("suppliers")]
        public List<FournisseurModel> Fournisseurs { get; set; }
    }

    public class FournisseurModel
    {
        [JsonProperty("cod_fou")]
        public int CodeFournisseur { get; set; }
        [JsonProperty("nom_fou")]
        public string NomFournisseur { get; set; }
        //adresse principale
        [JsonProperty("adresse")]
        public List<string> Adresse { get; set; }
        [JsonProperty("k_post2")]
        public string CodePostal { get; set; }
        [JsonProperty("ville")]
        public string Ville { get; set; }
        [JsonProperty("siret")]
        public string SIRET { get; set; }
        [JsonProperty("spe_num_tel")]
        public string NumeroTelephone { get; set; }
        [JsonProperty("spe_num_fax")]
        public string NumeroFax { get; set; }
        //Remonte la liste des documents GED associes a l'adherent (images, documents...)
        [JsonProperty("spe_lst_geddocs")]
        public List<SpeLstGedDocs> SpeLstGedDocs { get; set; }

    }
}
