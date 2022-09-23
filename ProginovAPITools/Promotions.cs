using ProginovAPITools.Models;
using ProginovAPITools.Models.Promos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Promotions
    {
        public async Task<List<ListePromoModel>> GetPromoList(string categorie_tarifaire)
        {
            CRequest<ListePromoModelRoot> request = new CRequest<ListePromoModelRoot>();
            await request.GetRequest("/promostvi/selection/", categorie_tarifaire);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ListePromoModelRoot root = request.FillCOllectionIgnoreNull();
                List<ListePromoModel> listePromos = root.Promotions;
                return listePromos;
            }

            else
            {
                List<ListePromoModel> listePromos = new List<ListePromoModel>();
                return listePromos;
            }
        }

        public async Task<List<ListePromoProductModel>> GetProductListFromPromo(string categorie_tarifaire, string code_promo, bool filterProducts = true)
        {
            CRequest<ListePromoProductModelRoot> request = new CRequest<ListePromoProductModelRoot>();
            string filterCategorieTarifaire = "?filter=[cat_tar|" + categorie_tarifaire + "]";
            string filterCodePromo = "&filter=[c_promo|" + code_promo + "]";
            string filterNombreProduits = "";
            if (filterProducts)
                filterNombreProduits = "&limit=30&order=stock DESC";
            await request.GetRequest("/promostvi/" + filterCategorieTarifaire + filterCodePromo + filterNombreProduits);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ListePromoProductModelRoot root = request.FillCOllectionIgnoreNull();
                List<ListePromoProductModel> listePromos = root.Promotions;
                return listePromos;
            }

            else
            {
                List<ListePromoProductModel> listePromos = new List<ListePromoProductModel>();
                return listePromos;
            }
        }

        public async Task<List<ListePromoProductModel>> GetProductExceptionnels(string categorie_tarifaire)
        {
            CRequest<ListePromoProductModelRoot> request = new CRequest<ListePromoProductModelRoot>();
            string filterCategorieTarifaire = "?filter=[cat_tar|" + categorie_tarifaire + "]";
            string filter = "&filter=[eve_exc|WEB]";
            await request.GetRequest("/promostvi/" + filterCategorieTarifaire + filter);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ListePromoProductModelRoot root = request.FillCOllectionIgnoreNull();
                List<ListePromoProductModel> listePromos = root.Promotions;
                return listePromos;
            }

            else
            {
                List<ListePromoProductModel> listePromos = new List<ListePromoProductModel>();
                return listePromos;
            }
        }
    }
}
