using Newtonsoft.Json;

namespace ProginovAPITools.Models.AdherentsFournisseurs
{
    public class SpeLstGedDocs
    {
        //Cle unique du document dans la GED Proginov
        [JsonProperty("cle_doc")]
        public string CleDocument { get; set; }
        //Intitule du docuement (modifiable dans l'ERP)
        [JsonProperty("inti_doc")]
        public string InituleDocument { get; set; }
        //Nom du fichier
        [JsonProperty("nom")]
        public string Nom { get; set; }
        //Extension du fichier
        [JsonProperty("ext")]
        public string Extension { get; set; }
        //Type de docuemnt (type de docuemts parametrables par TVI)
        [JsonProperty("typ_doc")]
        public string TypeDocument { get; set; }
    }
}