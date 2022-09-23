using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Client
    {
        public ClientModel oClient { get; set; }
        public async Task LoadClient(int CodeTiers)
        {
            CRequest<ClientRootModel> request = new CRequest<ClientRootModel>();
            await request.GetRequest("/customer/", CodeTiers.ToString());
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ClientRootModel clientRoot = request.FillCOllectionIgnoreNull();
                oClient = clientRoot.Client;
            }

            else
            {
                oClient = new ClientModel();
            }
        }
    }
}
