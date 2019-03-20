using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avion
{

    class Program
    {

        static void Main(string[] args)
        {
            bool recommence, valide, stats = false;
            string indexAvionMaxRapid = null;

            ListeDAvion listeDAvion = new ListeDAvion();

            //listeDAvion.AddAvion("BO", new Avion("BO", "BOING747", 800, 10000));
            //listeDAvion.AddAvion("AB", new Avion("AB", "AIRBUSA380", 950, 12000));
            //listeDAvion.AddAvion("LJ", new Avion("LJ", "LEARJET45", 700, 4500));
            //listeDAvion.AddAvion("DC", new Avion("DC", "DC10", 900, 8000));
            //listeDAvion.AddAvion("CO", new Avion("CO", "CONCORDE", 1400, 16000));
            //listeDAvion.AddAvion("AN", new Avion("AN", "ANTONOV32", 560, 2500));



            ConsoleKeyInfo reponse;
            
            //Dictionary<string, Avion> AvionList = new Dictionary<string, Avion>
            //{
            //    { "BO", new Avion("BO", "BOING747", 800, 10000) },
            //    { "AB", new Avion("AB", "AIRBUSA380", 950, 12000) },
            //    { "LJ", new Avion("LJ", "LEARJET45", 700, 4500) },
            //    { "DC", new Avion("DC", "DC10", 900, 8000) },
            //    { "CO", new Avion("CO", "CONCORDE", 1400, 16000) },
            //    { "AN", new Avion("AN", "ANTONOV32", 560, 2500) }
            //};

            listeDAvion.avions = new Dictionary<string, Avion>
            {
                { "BO", new Avion("BO", "BOING747", 800, 10000) },
                { "AB", new Avion("AB", "AIRBUSA380", 950, 12000) },
                { "LJ", new Avion("LJ", "LEARJET45", 700, 4500) },
                { "DC", new Avion("DC", "DC10", 900, 8000) },
                { "CO", new Avion("CO", "CONCORDE", 1400, 16000) },
                { "AN", new Avion("AN", "ANTONOV32", 560, 2500) }
            };

            Console.WriteLine("Statistique Avion");

            do
            {
                
                Console.WriteLine();
                foreach (Avion v in listeDAvion.avions.Values)
                {
                    Console.WriteLine(v.NomAvion + " ----->" + v.CodeAvion);
                }

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Entrez le code avion");
                    string code = Console.ReadLine();
                    valide = listeDAvion.avions.ContainsKey(code);
                    if (!valide)
                    {
                        Console.WriteLine("l'entree est invalide");
                    }
                    else
                    {
                        Console.WriteLine("Avion : {0} Vitesse : {1} km/h Rayon : {2} km", listeDAvion.avions[code].NomAvion, listeDAvion.avions[code].VitesseCroisiere, listeDAvion.avions[code].RayonDAction);
                    }
                } while (!valide);


                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Voulez-vous éditer les statistiques (O/N)");
                    reponse = Console.ReadKey();
                    Console.ReadKey();
                    stats = (reponse.Key == ConsoleKey.O);

                } while (!(reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.N));

                    if (stats)
                {
                    indexAvionMaxRapid = listeDAvion.GetIndexAvionMax();
                    Console.WriteLine("l'avion le plus rapide est le {0} avec une vitesse de {1} km/h", listeDAvion.avions[indexAvionMaxRapid].NomAvion, listeDAvion.avions[indexAvionMaxRapid].VitesseCroisiere);
                    Console.WriteLine("la moyenne des rayons d'action est de : {0} km/h", listeDAvion.GetMoyenne());
                }
                do
                {
                    Console.WriteLine("Voulez-vous faire une autre recherche (O/N)");
                    reponse = Console.ReadKey();
                    Console.WriteLine();
                    Console.ReadKey();
                    recommence = (reponse.Key == ConsoleKey.O);
                } while (!(reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.N));

            } while (recommence);

            Console.WriteLine("Au revoir et à bientot");
            Console.ReadKey();

        }
        //public static double GetMoyenne(Dictionary<string, Avion> avionList)
        //{
        //    double sommeRA = 0;
        //    foreach (Avion v in avionList.Values)
        //    {
        //       sommeRA += v.RayonDAction;
        //    }
        //    return sommeRA / avionList.Count;
        //}
        //public static string GetIndexAvionMax(Dictionary<string, Avion> avionList)
        //{
        //    string indexAvionMaxRapid = null;
        //    int w = 0;
        //    foreach (Avion v in avionList.Values)
        //    {
        //        if (v.VitesseCroisiere > w)
        //        {
        //            indexAvionMaxRapid = v.CodeAvion;
        //        }
        //        w = v.VitesseCroisiere;
        //    }
        //    return indexAvionMaxRapid;
        //}

        
    }
}
