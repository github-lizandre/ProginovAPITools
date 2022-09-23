using Newtonsoft.Json;
using ProginovAPITools.Models.AdherentsFournisseurs;
using ProginovAPITools.Models.Documents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Document
    {
        public List<DossiersArborescenceModel> oDossiers { get; set; }
        public DocumentsModel oDocuments { get; set; }
        public async Task LoadArborescence()
        {
            CRequest<DossiersArborescenceModelRoot> request = new CRequest<DossiersArborescenceModelRoot>();
            await request.GetRequest("/document/dossierstvi/");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                DossiersArborescenceModelRoot root = request.FillCOllectionIgnoreNull();
                oDossiers = root.Dossiers;
            }
            else
            {
                oDossiers = new List<DossiersArborescenceModel>();
            }
        }

        public async Task SearchDocument(int start, int rows, int fonction, string cle_dossier, string recherche = "")
        {
            DocumentRequestModelRoot rootRequest = new DocumentRequestModelRoot();
            DocumentRequestModel Params = new DocumentRequestModel {
                Start = start,
                Rows = rows,
                Fonction = fonction,
                Dossier = cle_dossier
            };
            if (recherche != null && recherche != "")
                Params.Recherche = recherche;
            rootRequest.Params = Params;
            string body = JsonConvert.SerializeObject(rootRequest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            CRequest<DocumentsModelRoot> request = new CRequest<DocumentsModelRoot>();
            await request.PostRequest("/document/documentstvi", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                DocumentsModelRoot root = request.FillCOllectionIgnoreNull();
                oDocuments = root.Resultats;
            }

            else
            {
                oDocuments = new DocumentsModel();
            }
        }

        public async Task<byte[]> GetDocument(string fonction, string cle)
        {
            CRequest<string> request = new CRequest<string>();
            byte[] result = await request.DownloadFile("/document/documentstvi/" + fonction + "/" + cle);
            return result;
        }
    }
}
