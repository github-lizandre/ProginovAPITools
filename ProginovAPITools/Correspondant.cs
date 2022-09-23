using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public enum Fonction
    {
        PDG = 200,
        DIRECTEUR_GENERAL = 205,
        DIRECTEUR_COMMERCIAL = 210,
        CHEF_DES_VENTES = 220,
        RESPONSABLE_GRAND_COMPTE = 220,
        COMMERCIAL = 225,
        ASSISTANT_COMMERCIALE = 230,
        RESPONSABLE_MARKETING_COM = 235,
        RESPONSABLE_ADMINISTRATIF = 245,
        COMPTABLE = 255,
        CHEF_DATELIER = 265,
        RECEPTIONISTE = 280,
        RESPONSABLE_TECHNIQUE = 285,
        RESPONSABLE_MAGASIN = 290,
        ACHETEUR = 295,
        HOTLINER = 300,
        COMMANDE = 305,
        SAV = 310,
        LOGISTICIEN = 315,
        COMMERCIAL_SEDENTAIRE = 325
    }
    public class Correspondant
    {
        public List<CorrespondantModel> oContacts { get; set; }
        public async Task LoadCorrespondantAsync(string strEmail)
        {
            CRequest<CorrespondantsModel> request = new CRequest<CorrespondantsModel>();
            string filter = "?filter=[internet|" + strEmail + "]";
            await request.GetRequest("/contact/customer", filter);
            if (request.m_strSearchResult != null && request.m_strSearchResult != "")
            {
                CorrespondantsModel contacts = request.FillCOllectionIgnoreNull();
                if (contacts.Contacts.Count() > 0)
                {
                    oContacts = contacts.Contacts;
                }

                else
                {
                    oContacts = new List<CorrespondantModel>();
                }
            }
        }

        public async Task<CorrespondantsModel> LoadCorrespondantFromType(string cod_tiers, Fonction fonction)
        {
            CRequest<CorrespondantsModel> request = new CRequest<CorrespondantsModel>();
            string filter = "?filter=[fct_emp|" + Convert.ToInt32(fonction).ToString() + "]";
            await request.GetRequest("/contact/customer/", cod_tiers + filter);
            if (request.m_strSearchResult != null && request.m_strSearchResult != "")
            {
                CorrespondantsModel contacts = request.FillCOllectionIgnoreNull();
                return contacts;
            }
            return new CorrespondantsModel();
        }
    }
}
