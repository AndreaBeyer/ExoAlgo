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
            //on initialise un titre
            string titre = "Statistiques avions";
            
            //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(titre);
            Console.WriteLine();

            //on creer 3 variables consolekeyinfo pour les 2 reponses de l'utilisateur
            ConsoleKeyInfo reponse, reponse1;
            //on creer une variable pour le code de l'avion
            string code;
            

            //on declare les 4 tableaux
            string[] avion = new string[] { "BOING747", "AIRBUSA380", "LEARJET45", "DC10", "CONCORDE", "ANTONOV32" };
            string[] codeAvion = new string[] { "B0", "AB", "LJ", "DC", "CO", "AN" };
            int[] vitesse = new int[] { 800, 950, 700, 900, 1400, 560 };
            int[] rayon = new int[] { 10000, 12000, 4500, 8000, 16000, 2500 };

            //on creer une variable i pour lire les tableaux
            int i;

            //on creer 2 variables pour la vitesse maximum et pour l'avion le plus rapide
            int max = 0;
            string avionMax = "";


                for(int i1 = 0; i1< avion.Length;i1++)
                {
                    Console.WriteLine();
                    Console.WriteLine(avion[i1] + Environment.NewLine+ "code avion :" + codeAvion[i1]);
                }



            do //tant que l'utilisateur souhaite continuer
            {
                do //tant que l'avion n'existe pas
                {
                    Console.WriteLine();
                    
                    //on demande le code de l'avion
                    Console.WriteLine("entrez le code de l'avion");
                    code = Console.ReadLine();

                    //on indique si l'avion n'existe pas
                    if (!(codeAvion.Contains(code)))
                    {
                        Console.WriteLine();
                        Console.WriteLine("L'avion n'existe pas");
                    }

                } while (!(codeAvion.Contains(code))); // !tant que l'avion n'existe pas


                //on cherche a quel index du tableau codeAvion se trouve la valeur entrée par l'utilisateur
                int index = Array.IndexOf(codeAvion, code);

                //on affiche les differetes caracteristiques de l'avion
                Console.WriteLine();
                Console.WriteLine("avion : " + avion[index] + Environment.NewLine + "vitesse : " + vitesse[index] + " km/h " + Environment.NewLine + "Rayon : " + rayon[index] + " km");
                
                //on calcule la vitesse max
                for (i = 0; i < avion.Length; i++)
                {
                    if (vitesse[i] > max)
                    {
                        max = vitesse[i];
                        avionMax = avion[i];
                    }
                }

                //on demande a l'utilisateur s'il souhaite les stats
                Console.WriteLine();
                Console.WriteLine("Voulez-vous éditer les statistiques (O/N)");
                reponse1 = Console.ReadKey();
                Console.WriteLine();

                //si l'utilisateur souhaite les stats
                if (reponse1.Key == ConsoleKey.O)
                {
                    //on indique la vitesse de l'avion le + rapide
                    Console.WriteLine();
                    Console.WriteLine("L'avion le plus rapide (" + avionMax + ") vole a " + max + " km/h");
                    
                    //on initialise et calcul la somme des differents rayons d'action
                    int sommeRayon = 0;
                    for (i = 0; i < avion.Length; i++)
                    {
                        sommeRayon += rayon[i];
                    }

                    //on calcule la moyenne et on l'affiche
                    double moyenne = sommeRayon / avion.Length;
                    Console.WriteLine("La moyenne des rayons d'actions est de " + moyenne + " km");
                }

                Console.WriteLine();
                
                //on demande a l'utilisateur s'il souhaite recommencer
                Console.WriteLine("Voulez-vous faire une autre recherche (O/N)");
                reponse = Console.ReadKey();
                Console.WriteLine();

            } while (reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y); // !tant que l'utilisateur souhaite continuer


            Console.WriteLine();
            
            //on affiche Au revoir et a bientot suivant l'enonce
            Console.WriteLine("Au revoir et a bientot");
            
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
