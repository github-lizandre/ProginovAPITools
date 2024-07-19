using ApiTools;
using ApiTools.BUSINESS_LAYER.Articles;
using ArticleNoTecdoc;
using DataBase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProginovAPITools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProginovAPITools
{
    public class Articles : CArticles
    {
        private bool                        m_blnRechercheIntelligente = false;
        private List<CArticle>              m_lstArticles = new List<CArticle>();
        private List<Article>               lstArticleNoTecDoc = new List<Article>();
        private List<CArticle>              olstNoTecDocArticle = new List<CArticle>();
        private string                      m_strReference;
        private List<CArticle>              lstBrand = new List<CArticle>();
        private List<CModelCustomBrands>    customBrands = new List<CModelCustomBrands>();
        private List<CModelBrandLevels>     brands = new List<CModelBrandLevels>();
        private int                         progiDlnrIndex = 2;

        public string hasTecDoc { get; set; }

        public bool RechercheIntelligente
        {
            get { return m_blnRechercheIntelligente; }
            set { m_blnRechercheIntelligente = value; }
        }


        public List<CArticle> lstArticles
        {
            get { return m_lstArticles; }
            set { m_lstArticles = value; }
        }

        public new List<CArticle> articles()
        {
            return m_lstArticles;
        }
        private async void InitNoTecDocArticles()
        {
            // Liste article non tecdoc à concaténer avec la liste d'article

            
            using (var context = new EntityContext())
            {
                ArticleService articleService = new ArticleService(context);

                try
                {
                    if (RechercheIntelligente)
                    {
                        lstArticleNoTecDoc = await articleService.GetExactArticles(m_strReference);
                    }
                    else
                    {
                        lstArticleNoTecDoc = await articleService.GetArticlesByKeyWord(m_strReference);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e.Message);
                }

                // Convert Non TecDoc list in TecDoc Format
                foreach (Article oNoTecDocArticle in lstArticleNoTecDoc)
                {
                    CArticle oArticle = new CArticle();

                    int? proginovDlnr = null;
                    if (oNoTecDocArticle.MarqueTecalliance != "" && oNoTecDocArticle.MarqueTecalliance != null)
                    {
                        //Les dlnr tecdoc sont tous posiitifs donc on passe les non-tecdoc en negatif pour les diferencier
                        foreach (CModelCustomBrands custombrand in customBrands)
                        {
                            if (oNoTecDocArticle.CodeMarqueProginov == custombrand.BrandName)
                            {
                                proginovDlnr = custombrand.BrandNo;
                                break;
                            }
                        }
                        if (proginovDlnr == null)
                        {
                            foreach (CModelBrandLevels brand in brands)
                            {
                                if (brand.Name == oNoTecDocArticle.CodeMarqueProginov)
                                {
                                    proginovDlnr = brand.Dlnr;
                                    break;
                                }
                            }
                            if (proginovDlnr == null)
                                proginovDlnr = progiDlnrIndex * -1;
                        }
                    }

                    //todo CHECK HERE
                    // REGLE REF VISIBLE : 
                    // IF BRAND IS CEDILOG THE VISIBLE REF HAS TO BE INTERNAL REF ELSE THAT MUST BE THE EXTERNAL REF
                    if (oNoTecDocArticle.CodeMarqueProginov.ToUpper() == "CEDILOG")
                    {
                        oArticle.ArtNo = oNoTecDocArticle.RefInterne;
                        oArticle.reference = oNoTecDocArticle.RefInterne;
                    }
                    else
                    {
                        oArticle.ArtNo = oNoTecDocArticle.RefExterne;
                        oArticle.reference = oNoTecDocArticle.RefExterne;
                    }

                    oArticle.BrandNo = proginovDlnr.ToString();
                    if (proginovDlnr > 0 && hasTecDoc == "True")
                    {
                        oArticle.tecdoc = true;
                        oArticle.isArticleTecDoc = true;
                    }
                    else
                    {
                        oArticle.tecdoc = false;
                        oArticle.isArticleTecDoc = false;
                    }
                    oArticle.SetDescription(oNoTecDocArticle.Designation);
                    oArticle.CodeProgi = oNoTecDocArticle.CodeProduit;
                    oArticle.BrandName = oNoTecDocArticle.CodeMarqueProginov;
                    oArticle.CodeMarqueExterne = oNoTecDocArticle.CodeMarqueProginov;

                    // Ajout de l'article PROGINOV dans la liste
                    if (oArticle.ArtNo != null)
                        olstNoTecDocArticle.Add(oArticle);

                    //Ajout de la marque a la liste si elle n'existe pas encore
                    if (!brands.Any(e => e.Dlnr == proginovDlnr))
                    {
                        brands.Add(new CModelBrandLevels
                        {
                            Dlnr = (int)proginovDlnr,
                            Name = oNoTecDocArticle.CodeMarqueProginov,
                            Level = 0 //Par defaut on les affiche en premier
                        });
                        progiDlnrIndex++;
                    }
                }

                //Ajout des equivalences non-tecdoc
                if (lstArticleNoTecDoc != null && lstArticleNoTecDoc.Count() > 0)
                {
                    Produits produits = new Produits();
                    List<ProduitModel> equivalencesPROGI = new List<ProduitModel>();
                    foreach (Article article in lstArticleNoTecDoc)
                    {
                        if (article.Equivalence != null && article.Equivalence != "")
                        {
                            List<ProduitModel> equivalences = await produits.GetProduitsEquivalents(article.CodeProduit);
                            if (produits.TimeOut)
                            {
                               // await JS.InvokeVoidAsync("showTimeOutMessage");
                                return;
                            }
                            equivalencesPROGI.AddRange(equivalences);
                        }
                    }


                    foreach (ProduitModel equivalence in equivalencesPROGI)
                    {
                        CArticle oArticle = new CArticle();
                        int? proginovDlnr = null;

                        //Les dlnr tecdoc sont tous posiitifs donc on passe les non-tecdoc en negatif pour les diferencier
                        foreach (CModelBrandLevels brand in brands)
                        {
                            if (brand.Name == equivalence.MarqueTecDoc)
                            {
                                proginovDlnr = brand.Dlnr;
                                break;
                            }
                        }

                        if (proginovDlnr == null)
                            proginovDlnr = progiDlnrIndex * -1;

                        oArticle.ArtNo = equivalence.RefExterne;
                        oArticle.reference = equivalence.RefExterne;
                        oArticle.BrandNo = proginovDlnr.ToString();
                        oArticle.tecdoc = false;
                        oArticle.isArticleTecDoc = false;
                        oArticle.SetDescription(equivalence.NomProduit);
                        oArticle.CodeProgi = equivalence.CodeProduit.ToString();
                        if (equivalence.MarqueTecDoc != null)
                            oArticle.BrandName = equivalence.MarqueTecDoc;
                        else
                            oArticle.BrandName = equivalence.Marque;
                        oArticle.CodeMarqueExterne = equivalence.Marque;

                        // Ajout de l'article PROGINOV dans la liste si doit etre visible sur le web
                        if (equivalence.ProduitWeb && oArticle.BrandName != null && oArticle.ArtNo != null)
                        {
                            olstNoTecDocArticle.Add(oArticle);
                        }

                        //Ajout de la marque a la liste si elle n'existe pas encore
                        if (!brands.Any(e => e.Dlnr == proginovDlnr))
                        {
                            brands.Add(new CModelBrandLevels
                            {
                                Dlnr = (int)proginovDlnr,
                                Name = equivalence.MarqueTecDoc,
                                Level = 0 //Par defaut on les affiche en premier
                            });
                            progiDlnrIndex++;
                        }
                    }

                }

            }


            // Add Non TecDoc elements
            lstArticles.AddRange(olstNoTecDocArticle);
            //Pour enlever les doublons
            lstArticles = lstArticles.GroupBy(p => new { p.ArtNo, p.BrandNo })
                                     .Select(g => g.First())
                                     .ToList();
        }
    }
}
