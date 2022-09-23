using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class DroitsWeb
    {
        public DroitsWebModel oDroits { get; set; }

        public async Task LoadDroitsAsync(int no_corresp)
        {
            CRequest<DroitsWebModel> request = new CRequest<DroitsWebModel>();
            await request.GetRequest("/data/contact/", no_corresp.ToString() + "/DROITWEB?fields=zt0");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                oDroits = request.FillCOllectionIgnoreNull();
            }

            else
            {
                oDroits = new DroitsWebModel();
            }
        }
    }
}
