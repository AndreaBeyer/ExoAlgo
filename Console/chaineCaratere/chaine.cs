using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaineCaratere
{
    class chaine
    {
        static void Main(string[] args)
        {
            //on initialise les differentes valeurs
            int nbreSpec;
            int nbreLow;
            int nbreUP;
            int nbreNum;
            int nbrelettre;
            int nbreVoyelles;
            int nbreConsonnes;
            
            //on creer un tableau comportant les voyelles accentuees ou non
            char[] voyelles = { 'a', 'e', 'i', 'o', 'u', 'y','A', 'E', 'I', 'O', 'U', 'Y' };
            
            //on creer une valeur consolekeyinfo pour le cas ou l'utilisateur veut recommencer le calcul
            ConsoleKeyInfo reponse;
            bool reponseContinuer = true;
            while(reponseContinuer)//tant que l'utilisateur souhaite continuer
            {
                //on (re-)initialise les valeurs à 0
                nbreSpec = 0;
                nbreLow = 0;
                nbreUP = 0;
                nbreNum = 0;
                nbrelettre = 0;
                nbreVoyelles = 0;
                nbreConsonnes = 0;
                
                //on initialise un titre
                Console.WriteLine();
                string titre = "ANALYSE LEXICALE D’UNE CHAINE DE CARACTERES";
                
                //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
                Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
                Console.WriteLine(titre);
                Console.WriteLine();


                //on demande et on initialise une chaine de caracteres
                Console.WriteLine();
                Console.WriteLine("Tapez une chaîne de caractères (inférieure à 255)");
                Console.WriteLine();
                string chaine = Console.ReadLine();

                //on creer un tableau comportant les differents mots en les separant avec espaces ainsi que l'apostrophe
                string[] listeDeMots = chaine.Split(' ', '\'');

                //on creer une variable pour le nombre de mots
                int nbreDeMots = listeDeMots.Length;

                //on creer une variable pour le nombre de caractere
                int nbreCaractere = chaine.Length;

                
                foreach (char c in chaine)//pour chaque caracteres de la chaine
                {
                    
                    //caracteres speciaux
                    if (!char.IsLetter(c) && !char.IsNumber(c))
                    {
                        nbreSpec++;
                    }
                    
                    //nombre
                    else if (char.IsNumber(c))
                    {
                        nbreNum++;
                    }
                    
                    //voyelles
                    else if (voyelles.Contains(c))
                    {
                        nbreVoyelles++;
                    }
                    
                    //consonnes par elimination
                    else
                    {
                        nbreConsonnes++;
                    }
                    
                    //lettre
                    if (char.IsLetter(c))
                    {
                        nbrelettre++;
                    }
                    
                    //minuscules
                    if (char.IsLower(c))
                    {
                        nbreLow++;
                    }
                    
                    //majuscules
                    if (char.IsUpper(c))
                    {
                        nbreUP++;
                    }


                }


                //on creer une variable String "affichage" renvoyant a l'utilisateur les differentes valeurs
                string affichage = string.Format("Cette chaine comprends {0} mots, {1} caracteres, {2} chiffre, {3} caracteres alphabetiques, {4} consonnes, {5} voyelles, {6} caracteres speciaux, {7} majuscules, {8} minuscules", nbreDeMots, nbreCaractere, nbreNum, nbrelettre, nbreConsonnes, nbreVoyelles, nbreSpec, nbreUP, nbreLow);
                Console.WriteLine();


                //on affiche la chaine String "affichage"
                Console.WriteLine(affichage);
                Console.WriteLine();
                
                
                //on demande a l'utilisateur s'il souhaite recommencer
                Console.WriteLine("Voulez-vous faire une autre Analyse ? (O/N)");
                reponse = Console.ReadKey();
                Console.ReadKey();
                reponseContinuer = reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y;


            }

            
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }   
    }
}
