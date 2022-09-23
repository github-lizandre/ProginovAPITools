using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Constructeurs
    {
        public List<ConstructeurModel> oConstructeurs { get; set; }
        public async Task LoadConstructeurs()
        {
            CRequest<ConstructeurRoot> request = new CRequest<ConstructeurRoot>();
            await request.GetRequest("/data/constructeurstvi/");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                ConstructeurRoot root = request.FillCOllectionIgnoreNull();
                oConstructeurs = root.Constructeurs;
            }
            else
            {
                oConstructeurs = new List<ConstructeurModel>();
            }
        }
    }
}
