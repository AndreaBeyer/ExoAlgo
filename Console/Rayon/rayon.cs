using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayon
{
    class Rayon
    {
        static void Main(string[] args)
        {
            #region initialisation des variables
            double rayon = 0, circonference = 0, surface=0;
            bool recommencer = true;
            string titre = "Calcul d'un cercle";
            #endregion

            #region moitie de la console
            HalfConsole(titre);
            #endregion

            #region affichage du titre
            Console.WriteLine(titre);
            #endregion

            #region Main tant que l'utilisateur souhaite recommencer
            do
            {
                #region AskUser rayon
                DemandeDuRayon(ref rayon);
                #endregion

                #region calcul de l'aire
                CalculAireSurface(rayon, ref circonference, ref surface);
                #endregion

                #region recapitulatif
                Recap(rayon, circonference, surface);
                #endregion

                #region askUser recommencer?
                Recommencer(ref recommencer);
                #endregion

            } while (recommencer);
            #endregion

            #region arret du programme
            ArretDuProgramme();
            #endregion
        }
        #region fonctions
        public static void ArretDuProgramme()
        {
            //on termine le programme suivant l'ennoncé
            Console.WriteLine(Environment.NewLine + "Au revoir et à bientôt");
            Console.WriteLine();
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();

        }
        public static void Recommencer(ref bool _c)
        {
            //on demande si l'utilisateur souhaite recommencer
            Console.WriteLine("Voulez-vous faire un autre calcul ? (O/N)");

            ConsoleKeyInfo key = Console.ReadKey();
            _c =  key.Key == ConsoleKey.O;
            Console.ReadKey();
            
        }
        public static void Recap(double _rayon, double _circonference , double _surface)
        {
            //on recapitule les differentes valeurs
            String recap = "Recapitulatif des valeurs";
            HalfConsole(recap);
            Console.WriteLine(recap);
            Console.WriteLine();
            Console.WriteLine(Environment.NewLine + "Le rayon est de " + string.Format("{0:0.00}", _rayon) + " cm");
            Console.WriteLine();
            Console.WriteLine("la circonference est de " + string.Format("{0:0.00}", _circonference) + " cm");
            Console.WriteLine();
            Console.WriteLine("Sa surface est de " + string.Format("{0:0.00}", _surface) + " cm2");
            Console.WriteLine();
        }
        public static void CalculAireSurface(double _rayon, ref double _circonference, ref double _surface )
        {
            //on calcule la surface et la circonference
            _circonference = 2 * _rayon * Math.PI;
            _surface = Math.Pow(_rayon, 2) * Math.PI;
        }
        public static void DemandeDuRayon(ref double _rayon)
        {
            bool ok = true;
            do
            {
                Console.WriteLine(Environment.NewLine + "veuillez entrer le rayon du cercle");
                string stringRayon = Console.ReadLine();
                //on regarde si rayon est convertible en double on ferme le programme sinon
                ok = double.TryParse(stringRayon, out _rayon);

                if (!ok)
                {
                    Console.WriteLine("l'entrée est invalide");
                    Console.WriteLine();
                }

            } while (!ok);

        }
        public static void HalfConsole(string _titre)
        {
            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - _titre.Length) / 2, Console.CursorTop);
        }
        #endregion
    }
}
