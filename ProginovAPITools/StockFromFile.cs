using ApiTools.BUSINESS_LAYER.Articles;
using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Tools;

namespace ProginovAPITools
{
    public static class StockFromFile
    {
        public static List<CArticle> GetStockFromFile(List<CArticle> products)
        {
            string path = ConfigurationManager.AppSettings["stockPath"].ToString();
            string file = FileHelper.GetNewestFileInDirectory(path);

            CStockCSV stockCSV = new CStockCSV(file);
            List<CSVArticle> articlesInStock = stockCSV.Load();

            foreach (CArticle product in products)
            {
                CSVArticle stock = articlesInStock.FirstOrDefault(e => e.Ref == product.ArtNo && e.Brand == product.BrandName);
                if (stock != null)
                {
                    product.stockReel = Int32.Parse(stock.Stock);
                }
            }
            return products;
        }
    }
}
