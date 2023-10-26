using Newtonsoft.Json;
using ProginovAPITools.Models;
using ProginovAPITools.Models.Litiges;
using ProginovAPITools.Models.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Produits
    {
        public List<ProduitModel> oProduits { get; set; }
        public bool TimeOut { get; set; }
        public async Task GetProductList(List<ProductRequestModel> products)
        {
            ProductRequestRootModel rootRequest = new ProductRequestRootModel();
            rootRequest.Produits = products;
            string body = JsonConvert.SerializeObject(rootRequest, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            CRequest<ProduitRootModel> request = new CRequest<ProduitRootModel>();
            await request.PostRequest("/produittvi?stock=true", body);
            if (request.m_strSearchResult != "" && request.m_strSearchResult != null)
            {
                if (request.m_bTimeOut)
                {
                    TimeOut = true;
                    oProduits = new List<ProduitModel>();
                }
                else
                {
                    ProduitRootModel root = request.FillCOllectionIgnoreNull();
                    oProduits = root.Produits;
                    TimeOut = false;
                }
            }

            else
            {
                oProduits = new List<ProduitModel>();
                TimeOut = false;
            }
        }

        public async Task<List<ProduitLiesModel>> GetLinkedProductList(string CodeProduit)
        {
            CRequest<ProduitLiesModelRoot> request = new CRequest<ProduitLiesModelRoot>();
            await request.GetRequest("/produits-lies/", CodeProduit);
            if (request.m_strSearchResult != null && request.m_strSearchResult != "")
            {
                ProduitLiesModelRoot root = request.FillCOllectionIgnoreNull();
                if (root.Products != null)
                {
                    return root.Products;
                }
            }
            return new List<ProduitLiesModel>();
        }

        public async Task<List<ProduitModel>> GetProduitsEquivalents(string CodeProduit)
        {
            CRequest<ProduitRootModel> request = new CRequest<ProduitRootModel>();
            await request.GetRequest("/produits-equivalents/", CodeProduit + "?stock=true");
            if (request.m_strSearchResult != null && request.m_strSearchResult != "")
            {
                ProduitRootModel root = request.FillCOllectionIgnoreNull();
                if (root.Produits != null)
                {
                    return root.Produits;
                }
            }
            return new List<ProduitModel>();
        }

        public async Task<List<ProduitModel>> GetProduitsComplementaire(string CodeProduit)
        {
            CRequest<ProduitRootModel> request = new CRequest<ProduitRootModel>();
            await request.GetRequest("/produits-complementaires/", CodeProduit + "?stock=true");
            if (request.m_strSearchResult != null && request.m_strSearchResult != "")
            {
                ProduitRootModel root = request.FillCOllectionIgnoreNull();
                if (root.Produits != null)
                {
                    return root.Produits;
                }
            }
            return new List<ProduitModel>();
        }
    }
}
