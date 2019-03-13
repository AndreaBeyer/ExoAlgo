using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusFarenheit
{
    class celcius
    {
        static void Main(string[] args)
        {
            #region declaration des variables
            int min, max = 0, pas = 0;
            string min1, max1, pas1;
            ConsoleKeyInfo reponse;
            ConsoleKeyInfo reponse1;
            string titre = "conversion de degres celcius vers degres farenheit";
            string titre1 = "table de conversion celcius vers farenheit";
            bool recommence, surDesValeurs, valeurValide;
            #endregion

            #region passage a la moitie de la console
            HalfConsole(titre);
            #endregion

            #region affichage du titre
            Console.WriteLine();
            Console.WriteLine(titre);
            Console.WriteLine();
            #endregion

            #region main tant que l'utilisateur souhaite recommencer
            do 
            {
                #region tant que les valeurs sont invalides
                do
                {
                    #region tant que l'utilisateur ne confirme pas ses entrees
                    do
                    {
                        #region demande des variables
                        Console.WriteLine();
                        Console.WriteLine("veuillez entrer le minimum");
                        min1 = Console.ReadLine();
                        Console.WriteLine("veuillez entrer le maximun");
                        max1 = Console.ReadLine();
                        Console.WriteLine("veuillez entrer le pas");
                        pas1 = Console.ReadLine();
                        #endregion
                        #region askUser surDesValeurs?
                        Console.WriteLine("si vous etes sur taper sur 'o'");
                        reponse = Console.ReadKey();
                        Console.WriteLine();
                        surDesValeurs = (reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y);
                        #endregion

                    } while (!surDesValeurs);
                    #endregion


                    #region verification validite des valeurs
                    valeurValide = int.TryParse(min1, out min) && int.TryParse(max1, out max) && int.TryParse(pas1, out pas);
                    #endregion

                    if (!valeurValide)
                    {
                        Console.WriteLine("l'entrée est invalide");
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                } while (!valeurValide);
                #endregion

                #region recapitulatif
                Recap(min, max, pas);
                #endregion

                #region moitie de la console
                HalfConsole(titre1);
                #endregion

                #region affichage du titre
                Console.WriteLine(titre1);
                Console.WriteLine();
                #endregion

                #region affichage des temperatures
                afficheCelciusFarenheit(min, max);
                #endregion

                #region AskUser recommencer?
                AskRecommencer(out recommence, out reponse1);
                #endregion

            } while (recommence);
            #endregion

            #region fermeture du programme
            EndProgram();
            #endregion
        }
        #region fonctions
        public static void HalfConsole(string _titre)
        {
            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - _titre.Length) / 2, Console.CursorTop);
        }
        public static void Recap(int _min, int _max, int _pas)
        {
            //on recapitule les valeurs suivant l'enoncé
            Console.WriteLine("A partir de : " + _min);
            Console.WriteLine();
            Console.WriteLine("Jusqu'a : " + _max);
            Console.WriteLine();
            Console.WriteLine("par pas de : " + _pas);
            Console.WriteLine();
            Console.WriteLine("Assurez vous que l'imprimante soit prete");
            Console.WriteLine();
        }
        public static void afficheCelciusFarenheit(int _min, int _max)
        {
            Console.WriteLine("Celcius\tFarenheit");

            //on calcule la temperature f dans l'intervalle puis on l'affiche avec une tabulation
            for (int i = _min; i <= _max; i++)
            {
                double f = i * 9 / 5 + 32;
                Console.WriteLine(i + "\t" + f);
            }
            Console.WriteLine();
        }
        public static void AskRecommencer(out bool _recommence, out ConsoleKeyInfo _reponse1)
        {
            Console.WriteLine("si vous voulez recommencer taper sur 'o'");
            _reponse1 = Console.ReadKey();
            Console.WriteLine();
            _recommence = (_reponse1.Key == ConsoleKey.O || _reponse1.Key == ConsoleKey.Y);
        }
        public static void EndProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
        #endregion
    }
}
