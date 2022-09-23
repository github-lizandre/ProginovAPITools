using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Documents
{
    public class DocumentsModelRoot
    {
        [JsonProperty("resultats")]
        public DocumentsModel Resultats { get; set; }
    }
    public class DocumentsModel
    {
        //Nombre de resultat correspondant a la recherche.
        //Si le nombre de resultat est superieur au nombre de documents demandé il faudra gerer de la pagination.
        //Pour la page 2 par exemple il faudra rappeler la meme recherche en indiquant 10 au niveau du parametre start si le nombre d'element par page demandé est de 10
        [JsonProperty("nbresults")]
        public int NombreResultats { get; set; }
        [JsonProperty("documents")]
        public List<DocumentModel> Documents { get; set; }
    }

    public class DocumentModel
    {
        //Cle du document GED
        [JsonProperty("cle_doc")]
        public string CleDocument { get; set; }
        [JsonProperty("inti_doc")]
        public string IntituleDocument { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        [JsonProperty("ext")]
        public string Extentsion { get; set; }
        //cle du dossier dans lequel se trouve le document
        [JsonProperty("cle_dos")]
        public string CleDossier { get; set; }
        //date de derniere modification du document
        [JsonProperty("dathmod")]
        public string DateModification { get; set; }
    }
}
