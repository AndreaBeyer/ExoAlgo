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
            ConsoleKeyInfo reponse;
            
            Dictionary<string, Avions> avionsList = new Dictionary<string, Avions>
            {
                { "BO", new Avions("BO", "BOING747", 800, 10000) },
                { "AB", new Avions("AB", "AIRBUSA380", 950, 12000) },
                { "LJ", new Avions("LJ", "LEARJET45", 700, 4500) },
                { "DC", new Avions("DC", "DC10", 900, 8000) },
                { "CO", new Avions("CO", "CONCORDE", 1400, 16000) },
                { "AN", new Avions("AN", "ANTONOV32", 560, 2500) }
            };
            
            Console.WriteLine("Statistique avions");

            do
            {
                Console.WriteLine();
                foreach (Avions v in avionsList.Values)
                {
                    Console.WriteLine(v.NomAvion + " ----->" + v.CodeAvion);
                }

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Entrez le code avion");
                    string code = Console.ReadLine();
                    valide = avionsList.ContainsKey(code);
                    if (!valide)
                    {
                        Console.WriteLine("l'entree est invalide");
                    }
                    else
                    {
                        Console.WriteLine("Avion : {0} Vitesse : {1} km/h Rayon : {2} km", avionsList[code].NomAvion, avionsList[code].VitesseCroisiere, avionsList[code].RayonDAction);
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
                    indexAvionMaxRapid = GetIndexAvionMax(avionsList);
                    Console.WriteLine("l'avion le plus rapide est le {0} avec une vitesse de {1} km/h", avionsList[indexAvionMaxRapid].NomAvion, avionsList[indexAvionMaxRapid].VitesseCroisiere);
                    Console.WriteLine("la moyenne des rayons d'action est de : {0} km/h", GetMoyenne(avionsList));
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
        public static double GetMoyenne(Dictionary<string, Avions> avionList)
        {
            double sommeRA = 0;
            foreach (Avions v in avionList.Values)
            {
               sommeRA += v.RayonDAction;
            }
            return sommeRA / avionList.Count;
        }
        public static string GetIndexAvionMax(Dictionary<string, Avions> avionList)
        {
            string indexAvionMaxRapid = null;
            int w = 0;
            foreach (Avions v in avionList.Values)
            {
                if (v.VitesseCroisiere > w)
                {
                    indexAvionMaxRapid = v.CodeAvion;
                }
                w = v.VitesseCroisiere;
            }
            return indexAvionMaxRapid;
        }

        
    }
}
