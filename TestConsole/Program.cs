using ProginovAPITools;
using ProginovAPITools.Models.AdherentsFournisseurs;
using ProginovAPITools.Models.Commande;
using ProginovAPITools.Models.Documents;
using ProginovAPITools.Models.TopVentes;
using System;
using System.Collections.Generic;
using System.Linq;
using ProginovAPITools.Models.Transporteurs;

namespace TestConsole
{
    class Program
    {
        public void TestTransporteur()
        {
            int i = 5;
        }
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //Adherents adherents = new Adherents();
            //await adherents.LoadAdherents();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Adherents");
            //Console.WriteLine("------------------------");
            //if (adherents.oAdherents != null && adherents.oAdherents.Count() > 0)
            //{
            //    AdherentModel adherent = adherents.oAdherents.First();
            //    Console.WriteLine("Code" + adherent.CodeClient);
            //    Console.WriteLine("Nom Client" + adherent.NomClient);
            //    Console.WriteLine("Adresses");
            //    Console.WriteLine("------------------------");
            //    if (adherent.SpeLstAdresses != null && adherent.SpeLstAdresses.Count() > 0)
            //    {
            //        SpeLstAdresses lstAdresses = adherent.SpeLstAdresses.First();
            //        Console.WriteLine(lstAdresses.NomAdresse);
            //        foreach (string line in lstAdresses.Adresse)
            //        {
            //            Console.WriteLine(line);
            //        }
            //        Console.WriteLine(lstAdresses.CodePostal + " " + lstAdresses.Ville);
            //    }
            //    Console.WriteLine("------------------------");
            //    Console.WriteLine("Code" + adherent.CodeClient);
            //    Console.WriteLine("Code" + adherent.CodeClient);
            //            }

            //string code_client = "3642";
            //Order order = new Order();
            //await order.LoadOrders(code_client);

            //foreach (OrderModel model in order.oOrders)
            //{
            //    Console.WriteLine("------ ORDER #" + model.NumeroCommande.ToString() + "------");
            //    OrderModel oo = await order.LoadSingleOrder(model.NumeroCommande);
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("Adresse de livraison");
            //    foreach (string line in oo.AdresseLivraison)
            //    {
            //        Console.WriteLine(line);
            //    }
            //    Console.WriteLine(oo.AdresseLivraisonLigne4);
            //    Console.WriteLine(oo.CodePostalLivraison + " " + oo.VilleLivraison);
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("Adresse de facturation");
            //    foreach (string line in oo.AdresseFacturation)
            //    {
            //        Console.WriteLine(line);
            //    }
            //    Console.WriteLine(oo.AdresseFaturationLigne4);
            //    Console.WriteLine(oo.CodePostalFacturation + " " + oo.VilleFacturation);
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("Detail");
            //    Console.WriteLine("------------------------------");
            //    if (oo.Lignes != null)
            //    {
            //        foreach (var ligne in oo.Lignes)
            //        {
            //            Console.WriteLine(ligne.MarqueTecDoc + " " + ligne.NomProduit + ": " + ligne.PrixNet + " " + ligne.Devise + " x" + ligne.Quantite + " = " + ligne.MontantHorsTaxes);
            //        }
            //    }
            //}

            //Fournisseur fournisseurs = new Fournisseur();
            //await fournisseurs.LoadFournisseurs();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Fournisseurs");
            //foreach (FournisseurModel fournisseur in fournisseurs.oFournisseurs)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine("#" + fournisseur.CodeFournisseur + " " + fournisseur.NomFournisseur + " : " + fournisseur.SIRET);
            //    Console.WriteLine(fournisseur.NumeroTelephone + "-" + fournisseur.NumeroFax);
            //    foreach (string ligne in fournisseur.Adresse)
            //        Console.WriteLine(ligne);
            //    Console.WriteLine(fournisseur.CodePostal + " " + fournisseur.Ville);
            //    if (fournisseur.SpeLstGedDocs != null)
            //        Console.WriteLine("NbDocuments: " + fournisseur.SpeLstGedDocs.Count);
            //    Console.WriteLine("------------------------------");
            //}

            //Order order = new Order();
            //byte[] doc = await order.GetBL("761783", "3642");
            //System.IO.File.WriteAllBytes("C:/temp/testBL.pdf", doc);

            //Document document = new Document();
            //await document.LoadArborescence();
            //foreach (DossiersArborescenceModel dossier in document.oDossiers)
            //{
            //    Console.WriteLine(dossier.Nom);
            //    if (dossier.Dossiers != null)
            //        printFolder(dossier, 1);
            //}

            //TopVentes topVentes = new TopVentes();
            //List<ModelMarquesTopVentes> marquesTopVentes = await topVentes.GetTopVentes();
            //ModelMarquesTopVentes marque = marquesTopVentes.First();
            //ModelFamillesTopVente famille = marque.Familles.First();
            //ModelSousFamillesTopVente sousfamille = famille.SousFamilles.First();

            //Console.WriteLine(marque.Marque + " - " + famille.Libelle + " - " + sousfamille.Libelle);
            //List<ModelProduitTopVente> produits = await topVentes.GetProduitTopVentes(famille.Identifiant, sousfamille.Identifiant, marque.Marque);
            //foreach (ModelProduitTopVente produit in produits)
            //{
            //    Console.WriteLine(produit.Reference);
            //}
        }


        static void printFolder(DossiersArborescenceModel dossier, int level)
        {
            foreach (DossiersArborescenceModel d in dossier.Dossiers)
            {
                string pad = new string('-', level);
                Console.WriteLine(pad + d.Nom + " " + d.Cle + " " + d.FonctionsAutorisees);
                if (d.Dossiers != null)
                    printFolder(d, level + 1);
            }
        }
    }
}
