using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class ClientRootModel
    {
        [JsonProperty("customer")]
        public ClientModel Client { get; set; }
    }

    public class ClientModel
    {
        [JsonProperty("cod_cli")]
        public int CodeClient {get; set;}
        [JsonProperty("cat_tar")]
        public string CategorieTarifaire { get; set; }
        [JsonProperty("nom_cli")]
        public string Nom { get; set; }
        [JsonProperty("siret")]
        public string Siret { get; set; }

        // Un client à un statut :
        //0 – RAS 
        //1 – Interdit commande
        //2 – Interdit livraison
        //3 – Contentieux
        //4 – Interdit commande et livraison
        //9 – A supprimer
        [JsonProperty("statut")]
        public int Statut { get; set; }
        [JsonProperty("civilite")]
        public string Civilite { get; set; }
        [JsonProperty("num_tel")]
        public string NumeroTelephone { get; set; }
        [JsonProperty("idcee")]
        public string IdCEE { get; set; }
    }
}
