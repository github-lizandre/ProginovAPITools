using ProginovAPITools.Models.AdherentsFournisseurs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Adherents
    {
        public List<AdherentModel> oAdherents { get; set; }
        public async Task LoadAdherents()
        {
            CRequest<AdherentModelRoot> request = new CRequest<AdherentModelRoot>();
            await request.GetRequest("/adherentstvi/");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                AdherentModelRoot root = request.FillCOllectionIgnoreNull();
                oAdherents = root.Adherents;
            }
            else
            {
                oAdherents = new List<AdherentModel>();
            }
        }

        public async Task<byte[]> GetDocument(string code_client, string cle)
        {
            CRequest<string> request = new CRequest<string>();
            byte[] result = await request.DownloadFile("/document/docadherent/" + code_client + "/" + cle);
            return result;
        }
    }
}
