using ProginovAPITools.Models.AdherentsFournisseurs;
using ProginovAPITools.Models.Documents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Fournisseur
    {
        public List<FournisseurModel> oFournisseurs { get; set; }
        public async Task LoadFournisseurs()
        {
            CRequest<FournisseurModelRoot> request = new CRequest<FournisseurModelRoot>();
            await request.GetRequest("/fournisseurstvi/");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                FournisseurModelRoot root = request.FillCOllectionIgnoreNull();
                oFournisseurs = root.Fournisseurs;
            }
            else
            {
                oFournisseurs = new List<FournisseurModel>();
            }
        }

        public async Task<byte[]> GetDocument(string code_fournisseur, string cle)
        {
            CRequest<string> request = new CRequest<string>();
            byte[] result = await request.DownloadFile("/document/docfournisseur/" + code_fournisseur + "/" + cle);
            return result;
        }
    }
}
