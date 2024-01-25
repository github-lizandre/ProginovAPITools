using ProginovAPITools.Models.Consignes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Consignes
    {
        public static async Task<List<ConsigneModel>> GetConsignes(string CodeClient, string dateFrom = null,string dateTo = null)
        {
            CRequest<ConsignesModel> request = new CRequest<ConsignesModel>();
            string url = "/consignetvi/" + CodeClient;
            if (dateFrom != null)
            {
                if (dateTo == null)
                    dateTo = "%";
                url += "?filter=[dat_sor|" + dateFrom + "," + dateTo + "]";
            }
            await request.GetRequest(url);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ConsignesModel root = request.FillCOllectionIgnoreNull();
                return root.Consignes;
            }
            else
            {
                return new List<ConsigneModel>();
            }
        }

        public static async Task<byte[]> GetDocument(int consigne, string cle)
        {
            CRequest<string> request = new CRequest<string>();
            byte[] result = await request.DownloadFile("/document/consigne/" + consigne.ToString() + "/" + cle);
            return result;
        }
    }
}
