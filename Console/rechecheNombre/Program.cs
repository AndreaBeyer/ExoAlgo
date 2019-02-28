using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechecheNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer une chaine de caracteres");
            string reponse = Console.ReadLine();

            Console.WriteLine("Veuille entrer le caractere à chercher");
            char reponseChar = Console.ReadKey().KeyChar;
            int n = 0;

            if(reponse == "" || reponse == ".")
            {
                Console.WriteLine("la chaine est vide");
            }
            foreach (var ch in reponse)
            {
                if(ch == reponseChar)
                {
                    n++;

                }

            }
            if(n == 0)
            {
                Console.WriteLine("La phrase est vide");
            }


            Console.WriteLine();
            Console.WriteLine("Le caractere est  présent {0} fois.",n);


            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
