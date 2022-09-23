using ProginovAPITools.Models.TopVentes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class TopVentes
    {
        public async Task<List<ModelMarquesTopVentes>> GetTopVentes(string codcli = "0")
        {
            CRequest<ModelMarquesTopVentesRoot> request = new CRequest<ModelMarquesTopVentesRoot>();
            await request.GetRequest("/topvente/selection?codcli=" + codcli);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ModelMarquesTopVentesRoot root = request.FillCOllectionIgnoreNull();
                return root.Marques;
            }
            else
            {
                return new List<ModelMarquesTopVentes>();
            }
        }

        public async Task<List<ModelProduitTopVente>> GetProduitTopVentes(string codcli, string marque, int identifiantFamille = 0, int identifiantSousFamille = 0)
        {
            CRequest<ModelProduitTopVenteRoot> request = new CRequest<ModelProduitTopVenteRoot>();
            marque = marque.Replace('\'', '%');
            marque = marque.Replace('+', '%');
            string url = "/topvente";
            string fields = "?fields=famille,s_famille,marque_cds,cod_pro,nom_pro,refext,classement";
            string code_client = "&filter=[cod_cli|" + codcli + "]";
            string type_classement = "MRQ";
            if (identifiantFamille != 0)
                type_classement = "FA";
            if (identifiantSousFamille != 0)
                type_classement = "SF";
            string filters = "&filter=[marque_cds|" + marque + "]";
            filters += "&filter=[famille|" + identifiantFamille.ToString() + "]";
            filters += "&filter=[s_famille|" + identifiantSousFamille.ToString() + "]";
            filters += "&filter=[typ_classement|" + type_classement + "]";
            await request.GetRequest(url + fields + code_client + filters);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ModelProduitTopVenteRoot root = request.FillCOllectionIgnoreNull();
                return root.TopVentes;
            }
            else
            {
                return new List<ModelProduitTopVente>();
            }
        }
    }
}
