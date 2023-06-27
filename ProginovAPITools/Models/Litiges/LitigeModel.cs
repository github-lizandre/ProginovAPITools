using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models.Litiges
{
    public class LitigeModelRoot
    {
        [JsonProperty("listelitige")]
        public List<LitigeModel> Litiges { get; set; }
    }
    public class LitigeModel
    {
        [JsonProperty("av_a_rec")]
        public bool av_a_rec { get; set; }
        [JsonProperty("av_recu")]
        public bool av_recu { get; set; }
        [JsonProperty("cod_lit")]
        public int CodeLitige { get; set; }
        [JsonProperty("cod_cf")]
        public int CodeClient { get; set; }
        [JsonProperty("dat_lit")]
        public string DateLitige { get; set; }
        [JsonProperty("dat_liv")]
        public string DateLivraison { get; set; }
        [JsonProperty("histo")]
        public bool Histo { get; set; }
        [JsonProperty("int_lit")]
        public string IntituleLitige { get; set; }
        [JsonProperty("interv")]
        public int interv { get; set; }
        [JsonProperty("motif")]
        public string Motif { get; set; }
        [JsonProperty("mt_a_rec")]
        public double mt_a_rec { get; set; }
        [JsonProperty("mt_recu")]
        public double mt_recu { get; set; }
        [JsonProperty("no_avoir")]
        public int NumAvoir { get; set; }
        [JsonProperty("no_bl")]
        public int NumBL { get; set; }
        [JsonProperty("no_cde")]
        public int NumCommande { get; set; }
        [JsonProperty("no_fact")]
        public string NumFacture { get; set; }
        [JsonProperty("no_ligavoir")]
        public int no_ligavoir { get; set; }
        [JsonProperty("no_ligne")]
        public int no_ligne { get; set; }
        [JsonProperty("no_ligretour")]
        public int no_ligretour { get; set; }
        [JsonProperty("no_ligtrans")]
        public int no_ligtrans { get; set; }
        [JsonProperty("no_trsf")]
        public bool no_trsf { get; set; }
        [JsonProperty("qte_lit")]
        public int QuantiteLitige { get; set; }
        [JsonProperty("qte_ret")]
        public int qte_ret { get; set; }
        [JsonProperty("recept")]
        public bool recept { get; set; }
        [JsonProperty("resolu")]
        public bool Resolu { get; set; }
        [JsonProperty("sur_fact")]
        public bool sur_fact { get; set; }
        [JsonProperty("tabpart_litlig")]
        public int tabpart_litlig { get; set; }
        [JsonProperty("uid_litlig")]
        public int uid_litlig { get; set; }
        [JsonProperty("uni_ach")]
        public string uni_ach { get; set; }
        [JsonProperty("uni_lit")]
        public string uni_lit { get; set; }
        [JsonProperty("vente")]
        public bool Vente { get; set; }
        [JsonProperty("kmmont")]
        public int KmAuMontage { get; set; }
        [JsonProperty("immat")]
        public string Immatriculation { get; set; }
        [JsonProperty("chassis")]
        public string Chassis { get; set; }
        [JsonProperty("typeveh")]
        public string TypeVehicule { get; set; }
        [JsonProperty("annee")]
        public short Annee { get; set; }
        [JsonProperty("nocorresp")]
        public int NumCorrespondant { get; set; }
        [JsonProperty("reference")]
        public string Reference { get; set; }
        [JsonProperty("dat_cde")]
        public string DateCommande { get; set; }
        [JsonProperty("dat_fac")]
        public string DateFacture { get; set; }
        [JsonProperty("statut")]
        public string Statut { get; set; }
    }
}
