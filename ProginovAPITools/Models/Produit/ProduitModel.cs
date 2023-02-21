using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools.Models
{
    public class ProduitRootModel
    {
        [JsonProperty("products")]
        public List<ProduitModel> Produits { get; set; } 
    }

    public class ProduitModel
    {
        [JsonProperty("cod_pro")]
        public int CodeProduit { get; set; }
        [JsonProperty("nom_pro")]
        public string NomProduit { get; set; }
        [JsonProperty("nom_pr2")]
        public string NomProduit2 { get; set; }
        [JsonProperty("refext")]
        public string RefExterne { get; set; }
        [JsonProperty("s_famille")]
        public int SousFamille { get; set; }
        [JsonProperty("s3_famille")]
        public int SousSousFamille { get; set; }
        [JsonProperty("s4_famille")]
        public int SousSousSousFamille { get; set; }
        [JsonProperty("art_remp")]
        public int ArticleRemplacement { get; set; }
        [JsonProperty("dat_remp")]
        public string DateRemplacement { get; set; }
        [JsonProperty("code_tva")]
        public int CodeTVA { get; set; }
        [JsonProperty("famille")]
        public int Famille { get; set; }
        [JsonProperty("marque")]
        public string Marque { get; set; }
        [JsonProperty("poid_brut")]
        public List<double?> PoidsBrut { get; set; }
        [JsonProperty("poid_net")]
        public int PoidsNet { get; set; }
        //prix renseigné pour le pp_uv renseigné (ex : si prix de 50€ renseigné sur le produit et que pp_uv = 50 le prix à l’unite 
        //est de 1€) Dans ce cas là le multiple de vente est généralement égal au pp_uv.
        [JsonProperty("pp_uv")]
        public int PP_UV { get; set; }
        //le multiple de vente (ex : si 2, le produit ne peut être vendu que par 2)
        [JsonProperty("mult_vte")]
        public int MultipleVente { get; set; }
        // statut
        //le statut du produit :
        //0 → RAS
        //1 → Interdit achat
        //2 → Interdit vente(donc non commandable)
        //9 → A supprimer(donc non commandable)
        [JsonProperty("statut")]
        public int Statut { get; set; }
        [JsonProperty("spe_marque_tec")]
        public string MarqueTecDoc { get; set; }
        [JsonProperty("equiv")]
        public string Equivalence { get; set; }
        [JsonProperty("spe_lst_stock")]
        public List<LstStockModel> LstStock { get; set; }
        //Indique qu'il y a des produits lies. Permet de gerer la TGAP et l'ECO TAXE
        [JsonProperty("spe_prlie")]
        public bool ProduitsLies { get; set; }
        //Code produit de la consigne associe a l'article
        [JsonProperty("art_cs_u")]
        public int? ConsigneCodeProduit { get; set; }
        //Indique si le produit doit etre visible sur le web ou non
        [JsonProperty("w_produit")]
        public bool ProduitWeb { get; set; }

    }
}
