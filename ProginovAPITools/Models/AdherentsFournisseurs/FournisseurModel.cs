using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class AdherentModelRoot
    {
        [JsonProperty("customers")]
        public List<AdherentModel> Adherents { get; set; }
    }

    public class AdherentModel
    {
        [JsonProperty("cod_cli")]
        public int CodeClient { get; set; }
        [JsonProperty("nom_cli")]
        public string NomClient { get; set; }
        //Remonte la liste des adresses qui pourront etre affcihes sur le site
        [JsonProperty("spe_lst_adresses")]
        public List<SpeLstAdresses> SpeLstAdresses { get; set; }
        //Remonte la liste des specificite de l'adherent
        [JsonProperty("spe_lst_specificites")]
        public List<SpeLstSpecificites> SpeLstSpecificites { get; set; }
        //Remonte la liste des documents GED associes a l'adherent (images, documents...)
        [JsonProperty("spe_lst_geddocs")]
        public List<SpeLstGedDocs> SpeLstGedDocs { get; set; }
        //Permet de savoir si il sagit d'un centre
        [JsonProperty("spe_centre")]
        public bool SpeCentre { get; set; }
        //Permet de savoir si il sagit d'une agence
        [JsonProperty("spe_agence")]
        public bool SpeAgence { get; set; }
        [JsonProperty("internet")]
        public string Internet { get; set; }       
        [JsonProperty("spe_mails")]
        public string Email { get; set; }

    }
}
