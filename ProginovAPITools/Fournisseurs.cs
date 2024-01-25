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

        public async Task<List<ContactFournisseurModel>> LoadContact(int CodeFournisseur)
        {
            CRequest<ContactFournisseurModelRoot> request = new CRequest<ContactFournisseurModelRoot>();
            await request.GetRequest("/contact/supplier/" + CodeFournisseur.ToString() + "?filter=[zlo1|true]");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ContactFournisseurModelRoot root = request.FillCOllectionIgnoreNull();
                return root.ContactsFournisseurs;
            }
            else
            {
                return new List<ContactFournisseurModel>();
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
