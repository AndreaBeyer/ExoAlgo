using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayon
{
    class rayon
    {
        static void Main(string[] args)
        {
            //on initialise les variables decimal
            double rayon, circonference, surface;

            //on creer une valeur string pour le titre
            string titre = "Calcul d'un cercle";
            //on creer une valeur consolekey pour le cas ou l'utilisateur veut recommencer le calcul
            ConsoleKeyInfo reponse;

            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            //on ecrit le titre
            Console.WriteLine(titre);
            //tant que l'utilisateur souhaite continuer le calcul
            do
            {
                Console.WriteLine(Environment.NewLine +"veuillez entrer le rayon du cercle");
                string stringRayon = Console.ReadLine();
                //on regarde si rayon est convertible en double on ferme le programme sinon
                if (!double.TryParse(stringRayon, out rayon))
                {
                    Console.WriteLine("l'entrée est invalide");
                    Console.WriteLine("Appuyer sur une touche pour terminer le programme...");
                    Console.ReadKey();
                    Console.WriteLine();
                    return;
                }
                
                //on calcule la surface et la circonference
                circonference = 2 * rayon * Math.PI;
                surface = Math.Pow(rayon, 2) * Math.PI;
                //on recpaitule les differentes valeurs
                String recap = "Recapitulatif des valeurs";
                Console.SetCursorPosition((Console.WindowWidth - recap.Length) / 2, Console.CursorTop);
                Console.WriteLine(recap);
                Console.WriteLine();
                Console.WriteLine(Environment.NewLine + "Le rayon est de " + string.Format("{0:0.00}", rayon) + " cm");
                Console.WriteLine();
                Console.WriteLine("la circonference est de " + string.Format("{0:0.00}", circonference) + " cm");
                Console.WriteLine();
                Console.WriteLine("Sa surface est de " + string.Format("{0:0.00}", surface) + " cm2");
                Console.WriteLine();
                //on demande si l'utilisateur souhaite recommencer
                Console.WriteLine("Voulez-vous faire un autre calcul ? (O/N)");
                reponse = Console.ReadKey();
                Console.ReadKey();




            } while (reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y);

            //on termine le programme suivant l'ennoncé
            Console.WriteLine(Environment.NewLine + "Au revoir et à bientôt");
            Console.WriteLine();
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
