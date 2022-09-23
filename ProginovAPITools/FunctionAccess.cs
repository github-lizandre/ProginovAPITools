using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public enum FonctionsTVI
    {
        //Direction
        PDG = 200,
        DIRECTEUR_GENERAL = 205,
        RESPONSABLE_DE_SITE = 206,
        //Commerce
        DIRECTEUR_COMMERCIAL = 210,
        CHEF_DES_VENTES = 215,
        RESPONSABLE_GRAND_COMPTE = 220,
        COMMERCIAL = 225,
        ASSISTANT_COMMERCIALE = 230,
        RESPONSABLE_MARKETING_COMMUNICATION = 235,
        ASSISTANT_MARKETING = 240,
        //Administratif
        RESPONSABLE_ADMINISTRATIF = 245,
        ASSISTANT_ADMINISTRATIF = 250,
        COMPTABLE = 255,
        RH = 260,
        //Atelier
        CHEF_D_ATELIER = 265,
        CHEF_D_EQUIPE = 270,
        MECANICIEN = 275,
        RECEPTIONNISTE = 280,
        RESPONSABLE_TECHNIQUE = 285,
        //Magasin
        RESPONSABLE_MAGASIN = 290,
        ACHETEUR = 295,
        HOTLINER = 300,
        COMMANDE = 305,
        SAV = 310,
        LOGISTICIEN = 315,
        MAGASINIER_ATELIER = 320,
        COMMERCIAL_SEDENTAIRE = 325,
        AGENTS_TVI = 400,
        BUSINESS = 500,
        DEFAULT = 0
    }
    public static class FunctionAccess
    {
        //Liste des droits d'acces bases sur le fichier EXCEL ACCES-DROITS-PAR-FONCTIONS
        static List<FonctionsTVI> RECHERCHE_PRODUIT = new List<FonctionsTVI>
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.CHEF_DES_VENTES,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.COMMERCIAL,
            FonctionsTVI.ASSISTANT_COMMERCIALE,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.ASSISTANT_MARKETING,
            FonctionsTVI.CHEF_D_ATELIER,
            FonctionsTVI.RESPONSABLE_TECHNIQUE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.SAV,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE,
            FonctionsTVI.AGENTS_TVI,
            FonctionsTVI.BUSINESS
        };
        static List<FonctionsTVI> PRODUITS_AVEC_PRIX = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> PROMOTIONS = new List<FonctionsTVI>
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.COMMANDE,
        };
        static List<FonctionsTVI> TOP_VENTES = new List<FonctionsTVI>
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.COMMANDE
        };
        static List<FonctionsTVI> COMMANDES = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_ADMINISTRATIF,
            FonctionsTVI.COMPTABLE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.LOGISTICIEN,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> SAV = new List<FonctionsTVI>
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_ADMINISTRATIF,
            FonctionsTVI.COMPTABLE,
            FonctionsTVI.RESPONSABLE_TECHNIQUE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.SAV,
            FonctionsTVI.LOGISTICIEN,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> GOODIES = new List<FonctionsTVI>
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.ASSISTANT_MARKETING,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.COMMANDE
        };
        static List<FonctionsTVI> PANIER = new List<FonctionsTVI>
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> CARNET_ADRESSES = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> NUMERO_HOTLINE = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.CHEF_DES_VENTES,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.COMMERCIAL,
            FonctionsTVI.ASSISTANT_COMMERCIALE,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.ASSISTANT_MARKETING,
            FonctionsTVI.RESPONSABLE_ADMINISTRATIF,
            FonctionsTVI.ASSISTANT_ADMINISTRATIF,
            FonctionsTVI.COMPTABLE,
            FonctionsTVI.RH,
            FonctionsTVI.CHEF_D_ATELIER,
            FonctionsTVI.CHEF_D_EQUIPE,
            FonctionsTVI.MECANICIEN,
            FonctionsTVI.RECEPTIONNISTE,
            FonctionsTVI.RESPONSABLE_TECHNIQUE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.SAV,
            FonctionsTVI.LOGISTICIEN,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> PNEUS = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.COMMANDE
        };
        static List<FonctionsTVI> OUVERTTURE_PDF_OPE = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.CHEF_DES_VENTES,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.COMMERCIAL,
            FonctionsTVI.ASSISTANT_COMMERCIALE,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.ASSISTANT_MARKETING,
            FonctionsTVI.RESPONSABLE_ADMINISTRATIF,
            FonctionsTVI.ASSISTANT_ADMINISTRATIF,
            FonctionsTVI.COMPTABLE,
            FonctionsTVI.RH,
            FonctionsTVI.CHEF_D_ATELIER,
            FonctionsTVI.CHEF_D_EQUIPE,
            FonctionsTVI.MECANICIEN,
            FonctionsTVI.RECEPTIONNISTE,
            FonctionsTVI.RESPONSABLE_TECHNIQUE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.SAV,
            FonctionsTVI.LOGISTICIEN,
            FonctionsTVI.MAGASINIER_ATELIER,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        static List<FonctionsTVI> OUVERTURE_PDF_CAHIER_MENSUEL = new List<FonctionsTVI> 
        {
            FonctionsTVI.PDG,
            FonctionsTVI.DIRECTEUR_GENERAL,
            FonctionsTVI.RESPONSABLE_DE_SITE,
            FonctionsTVI.DIRECTEUR_COMMERCIAL,
            FonctionsTVI.RESPONSABLE_GRAND_COMPTE,
            FonctionsTVI.ASSISTANT_COMMERCIALE,
            FonctionsTVI.RESPONSABLE_MARKETING_COMMUNICATION,
            FonctionsTVI.ASSISTANT_MARKETING,
            FonctionsTVI.RESPONSABLE_ADMINISTRATIF,
            FonctionsTVI.ASSISTANT_ADMINISTRATIF,
            FonctionsTVI.COMPTABLE,
            FonctionsTVI.RESPONSABLE_TECHNIQUE,
            FonctionsTVI.RESPONSABLE_MAGASIN,
            FonctionsTVI.ACHETEUR,
            FonctionsTVI.HOTLINER,
            FonctionsTVI.COMMANDE,
            FonctionsTVI.SAV,
            FonctionsTVI.COMMERCIAL_SEDENTAIRE
        };
        public static bool HasAccessFor(string access, FonctionsTVI userFunction)
        {
            bool isAuthorized;
            switch (access)
            {
                case "RECHERCHE PRODUIT":
                    isAuthorized = RECHERCHE_PRODUIT.Contains(userFunction);
                    break;
                case "PRODUITS_AVEC_PRIX":
                    isAuthorized = PRODUITS_AVEC_PRIX.Contains(userFunction);
                    break;
                case "PROMOTIONS":
                    isAuthorized = PROMOTIONS.Contains(userFunction);
                    break;
                case "TOP_VENTES":
                    isAuthorized = TOP_VENTES.Contains(userFunction);
                    break;
                case "COMMANDES":
                    isAuthorized = COMMANDES.Contains(userFunction);
                    break;
                case "SAV":
                    isAuthorized = SAV.Contains(userFunction);
                    break;
                case "GOODIES":
                    isAuthorized = GOODIES.Contains(userFunction);
                    break;
                case "PANIER":
                    isAuthorized = PANIER.Contains(userFunction);
                    break;
                case "CARNET_ADRESSES":
                    isAuthorized = CARNET_ADRESSES.Contains(userFunction);
                    break;
                case "NUMERO_HOTLINE":
                    isAuthorized = NUMERO_HOTLINE.Contains(userFunction);
                    break;
                case "PNEUS":
                    isAuthorized = PNEUS.Contains(userFunction);
                    break;
                case "OUVERTTURE_PDF_OPE":
                    isAuthorized = OUVERTTURE_PDF_OPE.Contains(userFunction);
                    break;
                case "OUVERTURE_PDF_CAHIER_MENSUEL":
                    isAuthorized = OUVERTURE_PDF_CAHIER_MENSUEL.Contains(userFunction);
                    break;
                default:
                    isAuthorized = false;
                    break;
            }
            return isAuthorized;
        }
    }
}
