using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class equation
    {
        static void Main(string[] args)
        {
            //on creer une variable reponse dans le cas ou l'utilisateur souhaite recommencer
            ConsoleKeyInfo reponse;
            //on creer des variables doubles pour les differents paramètres
            double x1, x2, a, b, c;
            Console.WriteLine();
            string titre = "Racine de l'equation du second degree";
            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(titre);
            Console.WriteLine();

            //tant que l'utilisateur souhaite recommencer
            do
            {

                //on demande les differentes valeurs et on teste leur convertibilité
                Console.WriteLine(Environment.NewLine + "veuillez entrer la valeur de a");
                string strA = Console.ReadLine();
                if (!double.TryParse(strA, out a))
                {
                    Console.WriteLine();
                    Console.WriteLine("l'entree est invalide");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("veuillez entrer la valeur de b");
                string strB = Console.ReadLine();
                if (!double.TryParse(strB, out b))
                {
                    Console.WriteLine();
                    Console.WriteLine("l'entree est invalide");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("veuillez entrer la valeur de c");
                string strC = Console.ReadLine();
                if (!double.TryParse(strC, out c))
                {
                    Console.WriteLine();
                    Console.WriteLine("l'entree est invalide");
                    Console.ReadLine();
                    return;
                }
                //on recapitule les valeurs a, b et c
                Console.WriteLine("valeur de a = " + a + Environment.NewLine + "valeur de b = " + b + Environment.NewLine + "valeur de c = " + c + Environment.NewLine);
                //on calcule delta
                double delta = Math.Pow(b, 2) - 4 * a * c;

                //on verifie les 4 differentes possibilités

                //pas de racine reelle
                if (delta < 0)
                {
                    Console.WriteLine("l'equation n'a pas de racine reelle ");
                    Console.WriteLine("d = " + delta);
                }
                //racine double
                else if (delta == 0 && !(a == 0 || b == 0 || c == 0))
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("L'equation possède une racine double");
                    Console.WriteLine("d = " + delta);
                    Console.WriteLine("l'equation s'annule pour x1 = x2 = " + x1);

                }
                //pas d'equation
                else if ((a == 0 && b == 0) || (a == 0 && c == 0) || (b == 0 && c == 0))
                {
                    Console.WriteLine("L'equation n'en est plus une");
                }
                //2 racines distinctes
                else if (!(a == 0 || b == 0 || c == 0))
                {
                    x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                    x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("l'equation possède deux racines distinctes");
                    Console.WriteLine("d = " + delta);
                    Console.WriteLine("x1 = " + x1 + " et x2 = " + x2);
                }
                //equation du premier degree
                else
                {
                    Console.WriteLine("L'equation est du premier degré");
                    double x = -(c / b);
                    Console.WriteLine();
                    Console.WriteLine("l'equation s'annule pour x = -(c/b) = " + x);
                }
                //on demande si l'utilisateur souhaite recommencer
                Console.WriteLine("Voulez-vous faire un autre calcul ? (O/N)");
                reponse = Console.ReadKey();
                Console.ReadKey();
            } while (reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y);
            //on tape la phrase de l'enoncé
            Console.WriteLine("Au revoir et à bientôt !");
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}
