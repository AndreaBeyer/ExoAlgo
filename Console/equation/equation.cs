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
            double x1, x2, a=0, b=0, c=0;
            string strA, strB, strC;
            bool ok=false;
            Console.WriteLine();
            string titre = "Racine de l'equation du second degree";
            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(titre);
            Console.WriteLine();

            //tant que l'utilisateur souhaite recommencer
            do
            {
                do
                {
                    AskValeurUser(out strA, "a");
                    VerificationValiditeEntreeUser(strA, out a, out ok);
                } while (!ok);


                do
                {
                    AskValeurUser(out strB, "b");
                    VerificationValiditeEntreeUser(strB, out b, out ok);
                } while (!ok);

                do
                {
                    AskValeurUser(out strC, "c");
                    VerificationValiditeEntreeUser(strC, out c, out ok);
                } while (!ok);

                //on recapitule les valeurs a, b et c
                RecapitulatifDesValeurs(a, b, c, "a", "b", "c");
                //on calcule delta
                double delta = CalculDeDelta(a, b, c);

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
            FermerLeProgram();



        }
        public static void FermerLeProgram()
        {
            //on tape la phrase de l'enoncé
            Console.WriteLine("Au revoir et à bientôt !");
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void VerificationValiditeEntreeUser(string _strA, out double _a, out bool _ok )
        {
            
            _ok = double.TryParse(_strA, out _a);

            if (!_ok)
            {
                
                Console.WriteLine("l'entree est invalide");
                
                
            }
            else
            {
                _ok = true;
            }
            Console.WriteLine();
            

        }
        public static string AskValeurUser(out string _valeur, string _nomDeLaValeur)
        {
            Console.WriteLine("Veuillez entrer la valeur de {0}", _nomDeLaValeur);
            _valeur = Console.ReadLine();
            return _valeur;
        }
        public static void RecapitulatifDesValeurs(double _a, double _b, double _c, string a, string b, string c)
        {
            Console.WriteLine("valeur de {0} = " + _a + Environment.NewLine + "valeur de {1} = " + _b + Environment.NewLine + "valeur de {2} = " + _c + Environment.NewLine,_a,_b,_c);
        }
        public static double CalculDeDelta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
