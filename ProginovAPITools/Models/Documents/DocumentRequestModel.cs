using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Documents
{
    public class DocumentRequestModelRoot
    {
        [JsonProperty("params")]
        public DocumentRequestModel Params { get; set; }

    }

    public class DocumentRequestModel
    {
        //Indice de debut de lecture des resultats
        [JsonProperty("start")]
        public int Start { get; set; }
        //Nombre de documents a renvoyer
        [JsonProperty("rows")]
        public int Rows { get; set; }
        //Terme de recherche (non obligatoire)
        [JsonProperty("recherche")]
        public string Recherche { get; set; }
        //Fonction de l'internaute pour verification des drouts
        [JsonProperty("fonction")]
        public int Fonction { get; set; }
        //dossier Cle du dossier dans lequel la recherche doit-etre effectuée (non obligatoire)
        //La recherche porte sur le dossier renseigné et ses sous dossiers
        [JsonProperty("dossier")]
        public string Dossier { get; set; }

    }
}
