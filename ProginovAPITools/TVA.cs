using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class TVA
    {
        public List<TVAModel> oTVAs { get; set; }
        public async Task GetTVAs()
        {
            CRequest<TVAModelRoot> request = new CRequest<TVAModelRoot>();
            await request.GetRequest("/tvatvi?fields=code_tva,tx_tva,tva_libe");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                TVAModelRoot root = request.FillCOllectionIgnoreNull();
                oTVAs = root.TVAs;
            }

            else
            {
                oTVAs = new List<TVAModel>();
            }
        }
    }
}
