using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    //Pour l'ajout et la modification
    public class AdresseModelRoot
    {
        [JsonProperty("adresse")]
        public AdresseModel Adresse { get; set; }
    }

    public class AdressesModelRoot
    {
        [JsonProperty("adresses")]
        public List<AdresseModel> Adresses { get; set; }
    }

    public class AdresseModel
    {
        //Adresse par défaut
        [JsonProperty("adr_def")]
        public bool AdrDef { get; set; }
        //Adresse de facturation
        [JsonProperty("adr_fac")]
        public bool AdrFac { get; set; }
        //Adresse de facturation par défaut
        [JsonProperty("adr_fdef")]
        public bool AdrFDef { get; set; }
        //Adresse de livraison
        [JsonProperty("adr_liv")]
        public bool AdrLiv { get; set; }
        //Adresse(Ligne 1 et ligne 2)
        [JsonProperty("adresse")]
        public List<string> Adresse { get; set; }
        //3ème ligne d’adresse
        [JsonProperty("adresse4")]
        public string Adresse2 { get; set; }
        [JsonProperty("civilite")]
        public string Civilite { get; set; }
        //Un code unique pour le client ou le fournisseur → 1,2,3
        [JsonProperty("cod_adr")]
        public int? CodeAdresse { get; set; }
        //Code du client
        [JsonProperty("cod_tiers")]
        public int CodeTiers { get; set; }
        [JsonProperty("desactive")]
        public bool Desactive { get; set; }
        [JsonProperty("k_post2")]
        public string CodePostal { get; set; }
        //N° unique de l’adresse
        [JsonProperty("no_lieu")]
        public int? NoLieu { get; set; }
        //Nom de l’adresse
        [JsonProperty("nom_adr")]
        public string NomAdr { get; set; }
        //Numero de Fax
        [JsonProperty("num_fax")]
        public string NumFax { get; set; }
        //Numero de Telephone
        [JsonProperty("num_tel")]
        public string NumTel { get; set; }
        [JsonProperty("pays")]
        public string Pays { get; set; }
        // il s’agira de C pour les clients et F pour les fournisseurs
        [JsonProperty("typ_fich")]
        public string TypeFiche { get; set; }
        [JsonProperty("ville")]
        public string Ville { get; set; }
        [JsonProperty("mel")]
        public string Email { get; set; }
        [JsonProperty("zal2")]
        public string NumPortable { get; set; }
        [JsonProperty("zal1")]
        public string CodeClientExterne { get; set; }
    }
}
