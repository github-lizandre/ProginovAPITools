using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Documents
{
    public class DossiersArborescenceModelRoot
    {
        [JsonProperty("dossierstvi")]
        public List<DossiersArborescenceModel> Dossiers { get; set; }
    }
    public class DossiersArborescenceModel
    {
        //code du dossier
        [JsonProperty("cle")]
        public string Cle { get; set; }
        [JsonProperty("nom")]
        public string Nom { get; set; }
        //Liste des fonctions (fonction de l'internaute) autorisées à voir le dossier. Le separateur entre les fonctions est la virgule.
        [JsonProperty("fct_autorisees")]
        public string FonctionsAutorisees { get; set; }
        //Liste des sous dossiers
        [JsonProperty("dossiers")]
        public List<DossiersArborescenceModel> Dossiers { get; set; }
    }
}
