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
            //on declare les variables
            int min, max, pas, f;
            //on declare leurs versions string
            string min1, max1, pas1;
            //on creer 2 variables consolekeyinfo
            ConsoleKeyInfo reponse;
            ConsoleKeyInfo reponse1;
            Console.WriteLine();
            string titre = "conversion de degres celcius vers degres farenheit";
            //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(titre);
            Console.WriteLine();
            do //tant que l'utilisateur souhaite recommencer
            {

                do //tant que l'utilisateur ne confirme pas ses entrees
                {
                    //On demande les variables
                    Console.WriteLine();
                    Console.WriteLine("veuillez entrer le minimum");
                    min1 = Console.ReadLine();
                    Console.WriteLine("veuillez entrer le maximun");
                    max1 = Console.ReadLine();
                    Console.WriteLine("veuillez entrer le pas");
                    pas1 = Console.ReadLine();
                    //on demande si l'utilisateur est sur
                    Console.WriteLine("si vous etes sur taper sur 'o'");
                    reponse = Console.ReadKey();
                    Console.WriteLine();

                } while (!(reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y));

                //On verifie que les valeurs entrees sont valide, on quitte le programme sinon
                if (!int.TryParse(min1, out min))
                {
                    Console.WriteLine("l'entrée est invalide");
                    Console.WriteLine();
                    //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
                    Console.WriteLine("Appuyer sur une touche pour continuer...");
                    Console.WriteLine();
                    Console.ReadKey();
                    return;
                }
                if (!int.TryParse(max1, out max))
                {
                    Console.WriteLine("l'entrée est invalide");
                    Console.WriteLine();
                    //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
                    Console.WriteLine("Appuyer sur une touche pour continuer...");
                    Console.WriteLine();
                    Console.ReadKey();
                    return;
                }
                if (!int.TryParse(pas1, out pas))
                {
                    Console.WriteLine("l'entrée est invalide");
                    Console.WriteLine();
                    //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
                    Console.WriteLine("Appuyer sur une touche pour continuer...");
                    Console.WriteLine();
                    Console.ReadKey();
                    return;
                }

                //on recapitule les valeurs suivant l'enoncé
                Console.WriteLine("A partir de : " + min);
                Console.WriteLine();
                Console.WriteLine("Jusqu'a : " + max);
                Console.WriteLine();
                Console.WriteLine("par pas de : " + pas);
                Console.WriteLine();
                Console.WriteLine("Assurez vous que l'imprimante soit prete");
                Console.WriteLine();
                string titre1 = "table de conversion celcius vers farenheit";
                //on passe le curseur du terminal à la moitié de la console
                Console.SetCursorPosition((Console.WindowWidth - titre1.Length) / 2, Console.CursorTop);
                Console.WriteLine(titre1);
                Console.WriteLine();
                Console.WriteLine("Celcius\tFarenheit");

                //on calcule la temperature f dans l'intervalle puis on l'affiche avec une tabulation
                for (int i = min; i <= max; i++)
                {
                    f = i * 9 / 5 + 32;
                    Console.WriteLine(i + "\t" + f);
                }
                Console.WriteLine();
                //on demande a l'utilisateur s'il souhaite recommencer
                Console.WriteLine("si vous voulez recommencer taper sur 'o'");
                reponse1 = Console.ReadKey();
                Console.WriteLine();
            } while (reponse1.Key == ConsoleKey.O || reponse1.Key == ConsoleKey.Y);
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
