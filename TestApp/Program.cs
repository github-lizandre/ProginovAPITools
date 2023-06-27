﻿using ProginovAPITools;
using ProginovAPITools.Models.Litiges;
using ProginovAPITools.Models.Transporteurs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestApp
{
    internal class Program
    {
        public static async Task TestTransporteur()
        {
            ParamTransporteurRoot root = new ParamTransporteurRoot();
            ParamTransporteur oParams = new ParamTransporteur();
            oParams.CodeClient = 260;
            oParams.Departement = 75;
            oParams.Enlevement = false;
            oParams.Samedi = false;

            List<ParamTransporteurProducts> products = new List<ParamTransporteurProducts>();
            ParamTransporteurProducts product = new ParamTransporteurProducts();
            product.CodeProduit = 1515490;
            product.Quantite = 10;
            products.Add(product);

            oParams.Products = products;

            root.Params = oParams;
            //Transporteurs transporteurs = new Transporteurs();
            List<ModelTransporteur> transporteurs =  await Transporteurs.GetTransporteurs(root);
            foreach (ModelTransporteur modelTransporteur in transporteurs)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine(modelTransporteur.Position.ToString() + " - " + modelTransporteur.CodeTransporteur.ToString());
                Console.WriteLine(modelTransporteur.NomTransporteur);
                Console.WriteLine(modelTransporteur.LibelleTransporteur);
                Console.WriteLine(modelTransporteur.Delai);
                Console.WriteLine("Prix : " + modelTransporteur.Prix.ToString());
                Console.WriteLine("---------------------------------------------------");
            }
        }

        public static async Task TestLitiges()
        {
            Litiges litiges = new Litiges();

            List<MotifLitigeModel> motifs;
            List<TypeLitigeModel> types;

            types = await litiges.GetListTypeLitiges();
            foreach (TypeLitigeModel type in types)
            {
                Console.WriteLine("------------------------ TYPES --------------------");
                Console.WriteLine(type.Code);
                Console.WriteLine(type.Intitule);
                Console.WriteLine("---------------------------------------------------");
            }

            motifs = await litiges.GetListMotifLitiges();
            foreach (MotifLitigeModel motif in motifs)
            {
                Console.WriteLine("----------------------- MOTIFS ---------------------");
                Console.WriteLine(motif.TypeLitige);
                Console.WriteLine(motif.LibelleLong);
                Console.WriteLine(motif.LibelleCourt);
                Console.WriteLine(motif.CodeMotif);
                Console.WriteLine("---------------------------------------------------");
            }
        }


        static async Task Main(string[] args)
        {
           await TestLitiges();
        }
    }
}
