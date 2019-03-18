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
            #region declaration de variables
            string reponse = null;
            char reponseChar = ' ';
            int n;
            #endregion

            #region demande chaine de caracteres
            AskChaine(ref reponse);
            #endregion

            #region demande du caractere a chercher
            AskCaractere(ref reponseChar);
            #endregion

            #region recherche et affichage du nombre de fois ou le caractere est present
            SearchAndDisplayNbCaracteres(out n, reponse, reponseChar);
            #endregion

            #region on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            EndProgram();
            #endregion

        }
        #region fonctions
        public static void AskChaine(ref string _reponse)
        {
            Console.WriteLine("Veuillez entrer une chaine de caracteres");
            _reponse = Console.ReadLine();
        }
        public static void AskCaractere(ref char _reponseChar)
        {
            Console.WriteLine("Veuille entrer le caractere à chercher");
            _reponseChar = Console.ReadKey().KeyChar;
        }
        public static void SearchAndDisplayNbCaracteres(out int _n, string _reponse, char _reponseChar)
        {
            _n = 0;
            if (_reponse == "" || _reponse == ".")
            {
                Console.WriteLine("la chaine est vide");
            }
            foreach (var ch in _reponse)
            {
                if (ch == _reponseChar)
                {
                    _n++;

                }

            }
            if (_n == 0)
            {
                Console.WriteLine("La phrase est vide");
                
            }
            Console.WriteLine();
            Console.WriteLine("Le caractere est  présent {0} fois.", _n);
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
