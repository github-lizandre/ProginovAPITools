using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Stocks
    {
        public StockModel oStock { get; set; }
        public async Task GetStock(int code_produit)
        {
            CRequest<StockModelRoot> request = new CRequest<StockModelRoot>();
            await request.GetRequest("/stock/", code_produit.ToString() + "?warehouse=1,2");
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                StockModelRoot root = request.FillCOllectionIgnoreNull();
                oStock = root.Stock;
            }

            else
            {
                oStock = new StockModel();
            }
        }
    }
}
