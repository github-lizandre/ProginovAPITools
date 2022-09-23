using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Livraison
    {
        public List<TypeLivraisonModel> oTypesLivraison { get; set; }
        public async Task LoadTypesLivraison(string codesite, string codeclient)
        {
            CRequest<TypeLivraisonModelRoot> request = new CRequest<TypeLivraisonModelRoot>();
            await request.GetRequest("/typlivtvi/" + codesite + "/" + codeclient);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                TypeLivraisonModelRoot root = request.FillCOllectionIgnoreNull();
                oTypesLivraison = root.Types;
            }
            else
            {
                oTypesLivraison = new List<TypeLivraisonModel>();
            }
        }
    }
}
