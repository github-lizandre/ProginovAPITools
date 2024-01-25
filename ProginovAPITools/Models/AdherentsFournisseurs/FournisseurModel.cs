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
        [JsonProperty("internet")]
        public string Internet { get; set; }
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
        [JsonProperty("spe_facebook")]
        public string Facebook { get; set; }
        [JsonProperty("spe_linkedin")]
        public string LinkedIn { get; set; }
        //Type de facturation (« 1 » : Centralisé, « 2 » : Directe, « 3 » : Centralisé et Directe)
        [JsonProperty("spe_typ_fact")]
        public int TypeFacturation { get; set; }
        //Type de livraison (« 1 » : Centralisé, « 2 » : Directe, « 3 » : Centralisé et Directe)
        [JsonProperty("spe_typ_liv")]
        public int TypeLivraison { get; set; }
        [JsonProperty("spe_stockage_cedilog")]
        public bool StockageCedilog { get; set; }
        [JsonProperty("spe_typ_hebdo")]
        public bool CommandeHebdo { get; set; }
        [JsonProperty("spe_typ_messagerie")]
        public bool CommandeMessagerie { get; set; }
        [JsonProperty("spe_typ_express")]
        public bool CommandeExpress { get; set; }
        [JsonProperty("spe_direct_fou")]
        public bool CommandeDirectFournisseur { get; set; }
        [JsonProperty("spe_direct_hors_cedilog")]
        public bool CommandeDirectHorsCedilog { get; set; }
        [JsonProperty("spe_penalite")]
        public string Penalite { get; set; }        
        [JsonProperty("spe_retour_fou")]
        public bool RetourFournisseur { get; set; }        
        [JsonProperty("spe_retour_cedilog")]
        public bool RetourCedilog { get; set; }
        [JsonProperty("spe_garantie_fou")]
        public bool GarantieFournisseur { get; set; }
        [JsonProperty("spe_garantie_cedilog")]
        public bool GarantieCedilog { get; set; }
        [JsonProperty("spe_commentaire")]
        public string Commentaire { get; set; }
        [JsonProperty("spe_rfa")]
        public bool RFA { get; set; }
        [JsonProperty("spe_participation_pmc")]
        public bool PMC { get; set; }
        [JsonProperty("mt_franco")]
        public int MontantFranco { get; set; }
        //libellé franco (Euros ou Kgs)
        [JsonProperty("spe_lib_franco")]
        public string LibelleFranco { get; set; }
        //Remonte la liste des documents GED associes a l'adherent (images, documents...)
        [JsonProperty("spe_lst_geddocs")]
        public List<SpeLstGedDocs> SpeLstGedDocs { get; set; }
        [JsonProperty("spe_lst_conditions")]
        public List<SpeLstConditions> SpeLstConditions { get; set; }
    }
}