using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ProginovAPITools
{
    public class CSVArticle
    {
        public string Brand { get; set; }
        public string Ref { get; set; }
        public string Stock { get; set; }
        public CSVArticle()
        {

        }
    }

    public class CStockCSV
    {
        private string CSVPath;
        public CStockCSV(string path)
        {
            CSVPath = path;
        }

        public List<CSVArticle> Load()
        {
            List<CSVArticle> articles = new List<CSVArticle>();
            if (!File.Exists(CSVPath))
            {
                Debug.WriteLine("ERROR CSTOCKCSV - PATH [" + CSVPath + "] does not exist");
                Console.WriteLine("ERROR CSTOCKCSV - PATH [" + CSVPath + "] does not exist");
                return null;
            }

            foreach (string line in File.ReadAllLines(CSVPath))
            {
                string[] l = line.Split(';');
                if (l[2] != "0")
                {
                    CSVArticle article = new CSVArticle();
                    article.Brand = l[1];
                    article.Ref = l[0];
                    article.Stock = l[2];
                    articles.Add(article);
                }
            }
            return articles;
        }

    }
}
