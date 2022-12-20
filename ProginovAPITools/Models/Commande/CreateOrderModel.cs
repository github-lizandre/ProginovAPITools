using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProginovAPITools.Models.Commande
{
    public class CreateOrderLineModel
    {
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("qte")]
        public int Quantite { get; set; }
        [JsonProperty("no_ligne")]
        public int NoLigne { get; set; }
    }

    public class CreateOrderModelRoot
    {
        [JsonProperty("entetcli")]
        public CreateOrderModel Order { get; set; }
    }
    public class CreateOrderModel
    {
        //Permet d'achever la commande. Elle pourra alors suivre le flux mis en place par TVI.
        [JsonProperty("achev")]
        public bool Acheve { get; set; }
        [JsonProperty("cod_cli")]
        public int CodeClient { get; set; }
        //Origine de commande indiquer WEB
        [JsonProperty("ori_cde")]
        public string OrigineCommande { get; set; }
        [JsonProperty("mod_liv")]
        public string ModeLivraison { get; set; }
        [JsonProperty("transpor")]
        public int? CodeTransporteur { get; set; }
        [JsonProperty("typ_con")]
        public string typ_con { get; set; }
        [JsonProperty("typ_cde")]
        public int TypeCommande { get; set; }
        [JsonProperty("adr_liv")]
        public List<string> AdresseLivraison { get; set; }
        [JsonProperty("adrliv4")]
        public string ComplementAdresse { get; set; }
        [JsonProperty("villel")]
        public string VilleLivraison { get; set; }
        [JsonProperty("k_post2l")]
        public string CodePostalLivraison { get; set; }
        [JsonProperty("paysl")]
        public string PaysLivraison { get; set; }
        [JsonProperty("k_postl")]
        public int? CodeAdresse { get; set; }
        //Permet d'indiquer une reference sur la commande (max 30 characteres)
        [JsonProperty("ref_cde")]
        public string ReferenceCommande { get; set; }
        //Depot de commande. Depot 1 pour TVI et Cedilog
        [JsonProperty("depot")]
        public int Depot { get; set; }
        //[JsonProperty("zlo3")]
        //public bool EnlevementSurPlace { get; set; }
        [JsonProperty("zlo4")]
        public bool LivraisonLeSamediMatin { get; set; }
        [JsonProperty("edt_bp")]
        public string CommentairePreparation { get; set; }
        [JsonProperty("edt_bl")]
        public string CommentaireLivraison { get; set; }
        [JsonProperty("lignes")]
        public List<CreateOrderLineModel> Lignes { get; set; }

    }
}
