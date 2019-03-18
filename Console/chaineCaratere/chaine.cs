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
            #region declaration des variables
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

            string chaine = null;
            bool reponseContinuer = true;

            string titre = "ANALYSE LEXICALE D’UNE CHAINE DE CARACTERES";
            #endregion

            #region tant que l'utilisateur souhaite continuer
            while (reponseContinuer)//tant que l'utilisateur souhaite continuer
            {
                #region reinistialisation des variables a zero
               
                nbreSpec = 0;
                nbreLow = 0;
                nbreUP = 0;
                nbreNum = 0;
                nbrelettre = 0;
                nbreVoyelles = 0;
                nbreConsonnes = 0;

                #endregion

                #region halfconsole

                HalfConsole(titre);

                #endregion

                #region on demande et on initialise une chaine de caracteres
                AskTitle(ref chaine);
                #endregion

                #region on creer un tableau comportant les differents mots en les separant avec espaces ainsi que l'apostrophe
                string[] listeDeMots = chaine.Split(' ', '\'');
                #endregion

                #region variable longueur des tableaux
                //on creer une variable pour le nombre de mots
                int nbreDeMots = listeDeMots.Length;

                //on creer une variable pour le nombre de caractere
                int nbreCaractere = chaine.Length;
                #endregion

                #region analyse de la chaine de caracteres
                AnalyseChaineCaracteres(chaine, ref nbreSpec, ref nbreNum, ref nbreVoyelles, ref voyelles, ref nbreConsonnes, ref nbrelettre, ref nbreLow, ref nbreUP);
                #endregion

                #region on creer une variable String "affichage" renvoyant a l'utilisateur les differentes valeurs
                string affichage = string.Format("Cette chaine comprends {0} mots, {1} caracteres, {2} chiffre, {3} caracteres alphabetiques, {4} consonnes, {5} voyelles, {6} caracteres speciaux, {7} majuscules, {8} minuscules", nbreDeMots, nbreCaractere, nbreNum, nbrelettre, nbreConsonnes, nbreVoyelles, nbreSpec, nbreUP, nbreLow);
                Console.WriteLine();
                #endregion

                #region on affiche la chaine String "affichage"
                Console.WriteLine(affichage);
                Console.WriteLine();
                #endregion


                #region on demande a l'utilisateur s'il souhaite recommencer
                DemandeContinuer(ref reponseContinuer);
                #endregion


            }
            #endregion


            #region on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            EndProgram();
            #endregion

        }
        #region fonctions
        public static void AskTitle(ref string _chaine)
        {
            Console.WriteLine();
            Console.WriteLine("Tapez une chaîne de caractères (inférieure à 255)");
            Console.WriteLine();
            _chaine = Console.ReadLine();
        }
        public static void HalfConsole(string _titre)
        {
            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - _titre.Length) / 2, Console.CursorTop);
        }
        public static void AnalyseChaineCaracteres(string _chaine,ref int _nbreSpec,ref int _nbreNum,ref int _nbreVoyelles,ref char[] _voyelles,ref int _nbreConsonnes,ref int _nbrelettre,ref int _nbreLow, ref int _nbreUP)
        {
            foreach (char c in _chaine )//pour chaque caracteres de la chaine
            {

                //caracteres speciaux
                if (!char.IsLetter(c) && !char.IsNumber(c))
                {
                    _nbreSpec++;
                }

                //nombre
                else if (char.IsNumber(c))
                {
                    _nbreNum++;
                }

                //voyelles
                else if (_voyelles.Contains(c))
                {
                    _nbreVoyelles++;
                }

                //consonnes par elimination
                else
                {
                    _nbreConsonnes++;
                }

                //lettre
                if (char.IsLetter(c))
                {
                    _nbrelettre++;
                }

                //minuscules
                if (char.IsLower(c))
                {
                    _nbreLow++;
                }

                //majuscules
                if (char.IsUpper(c))
                {
                    _nbreUP++;
                }


            }
        }
        public static void DemandeContinuer(ref bool _reponseContinuer)
        {
            Console.WriteLine("Voulez-vous faire une autre Analyse ? (O/N)");
            ConsoleKeyInfo _reponse = Console.ReadKey();
            Console.ReadKey();
            _reponseContinuer = _reponse.Key == ConsoleKey.O || _reponse.Key == ConsoleKey.Y;
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
