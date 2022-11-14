using Newtonsoft.Json;
using ProginovAPITools.Models.Transporteurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Transporteurs
    {
        public static async Task<List<ModelTransporteur>> GetTransporteurs(ParamTransporteurRoot paramsRoot)
        {
            CRequest<ModelTransporteurRoot> request = new CRequest<ModelTransporteurRoot>();
            string body = JsonConvert.SerializeObject(paramsRoot, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            await request.PostRequest("/transporteurstvi/", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ModelTransporteurRoot root = request.FillCOllectionIgnoreNull();
                if (root.Transporteurs != null && root.Transporteurs.Count() > 0)
                    root.Transporteurs = root.Transporteurs.OrderBy(e => e.Position).ToList();
                return root.Transporteurs;
            }
            else
            {
                return new List<ModelTransporteur>();
            }
        }
    }
}
