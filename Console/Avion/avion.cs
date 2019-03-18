using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avion
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            #region initialisation des variables
            //on initialise un titre
            string titre = "Statistiques avions";
            bool recommence = false;
            //on creer 2 variables consolekeyinfo pour les 2 reponses de l'utilisateur
            ConsoleKeyInfo reponse, reponse1;
            //on creer une variable pour le code de l'avion
            string code = "";
            //on creer 2 variables pour la vitesse maximum et pour l'avion le plus rapide
            int max = 0;
            string avionMax = "";
            double moyenne;
            #endregion

            #region initialisation des tableaux
            //on declare les 4 tableaux
            string[] avion = new string[] { "BOING747", "AIRBUSA380", "LEARJET45", "DC10", "CONCORDE", "ANTONOV32" };
            string[] codeAvion = new string[] { "B0", "AB", "LJ", "DC", "CO", "AN" };
            int[] vitesse = new int[] { 800, 950, 700, 900, 1400, 560 };
            int[] rayon = new int[] { 10000, 12000, 4500, 8000, 16000, 2500 };
            #endregion

            #region passage a la moitie de la console
            HalfConsole(titre);
            #endregion

            #region affichage des differents codes d'avion
            AfficherCodesAvions(avion, codeAvion);
            #endregion

            #region main tant que l'utilsateur souhaite recommancer
            do
            {
                #region recherche du code
                RechercheCodeAvion(ref code, codeAvion);
                #endregion

                #region recherche de l'index
                int index = Array.IndexOf(codeAvion, code);
                #endregion

                #region affichage des caracteristiques de l'avion
                AfficherCaracteristiquesAvions(avion, index, vitesse, rayon);
                #endregion

                #region calcul de la vitesse
                CalculDeLaVitesse(avion, vitesse, ref max, ref avionMax);
                #endregion

                #region AskUser editer statistiques?
                AskStats(out reponse1);
                #endregion

                #region affichage de la moyenne
                moyenne = Moyenne(rayon,avion);
                #endregion

                #region afficher statistiques de l'avion
               
                if (reponse1.Key == ConsoleKey.O)
                {
                    Console.WriteLine();
                    Console.WriteLine("L'avion le plus rapide (" + avionMax + ") vole a " + max + " km/h");

                    Console.WriteLine("La moyenne des rayons d'actions est de " + moyenne + " km");
                    Console.WriteLine();
                }
                
                #endregion

                #region AskUser recommencer?
                AskRecommencer(out reponse, out recommence);
                #endregion


            } while (recommence);
            #endregion

            #region fermer le programme
            Console.WriteLine();
            FermerLeProgramme();
            #endregion
        }
        #endregion
        #region fonctions
        public static void AfficherCodesAvions(string[] _avion, string[] _codeAvion)
        {
            for (int i1 = 0; i1 < _avion.Length; i1++)
            {
                Console.WriteLine();
                Console.WriteLine(_avion[i1] + Environment.NewLine + "code avion :" + _codeAvion[i1]);
            }
        }
        public static void RechercheCodeAvion(ref string _code, string[] _codeAvion)
        {
            do //tant que l'avion n'existe pas
            {
                Console.WriteLine();

                //on demande le code de l'avion
                Console.WriteLine("entrez le code de l'avion");
                _code = Console.ReadLine();

                //on indique si l'avion n'existe pas
                if (!(_codeAvion.Contains(_code)))
                {
                    Console.WriteLine();
                    Console.WriteLine("L'avion n'existe pas");
                }

            } while (!(_codeAvion.Contains(_code))); // !tant que l'avion n'existe pas
        }
        public static void CalculDeLaVitesse(string[] _avion, int[] _vitesse, ref int _max, ref string _avionMax)
        {
            for (int i = 0; i < _avion.Length; i++)
            {
                if (_vitesse[i] > _max)
                {
                    _max = _vitesse[i];
                    _avionMax = _avion[i];
                }
            }
        }
        public static void AfficherCaracteristiquesAvions(string[] _avion, int _index, int[] _vitesse, int[] _rayon)
        {
            Console.WriteLine();
            Console.WriteLine("avion : " + _avion[_index] + Environment.NewLine + "vitesse : " + _vitesse[_index] + " km/h " + Environment.NewLine + "Rayon : " + _rayon[_index] + " km");
        }
        public static void HalfConsole(string _titre)
        {
            //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
            Console.SetCursorPosition((Console.WindowWidth - _titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(_titre);
            Console.WriteLine();
        }

        public static void AfficherAvionVitesseMax( string _avionMax, int _max)
        {
            //on indique la vitesse de l'avion le + rapide
            Console.WriteLine();
            Console.WriteLine("L'avion le plus rapide (" + _avionMax + ") vole a " + _max + " km/h");
        }

        public static void AfficherRayonDActionMoyAvion(double moyenne)
        {
            Console.WriteLine("La moyenne des rayons d'actions est de " + moyenne + " km");
        }

        public static double Moyenne(int[] _valeur , string[] _avion)
        {
            int somme = 0;
            for (int i=0; i < _avion.Length; i++)
            {
                somme += _valeur[i];
            }
            return somme / _avion.Length;
            
        }
        public static void AskRecommencer(out ConsoleKeyInfo _reponse,out bool _recommence)
        {
            //on demande a l'utilisateur s'il souhaite recommencer
            Console.WriteLine("Voulez-vous faire une autre recherche (O/N)");
            _reponse = Console.ReadKey();
            Console.WriteLine();
            _recommence = (_reponse.Key == ConsoleKey.O || _reponse.Key == ConsoleKey.Y);

        }
        public static void FermerLeProgramme()
        {
            //on affiche Au revoir et a bientot suivant l'enonce
            Console.WriteLine("Au revoir et a bientot");

            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void AskStats(out ConsoleKeyInfo _reponse1)
        {
            Console.WriteLine();
            Console.WriteLine("Voulez-vous éditer les statistiques (O/N)");
            _reponse1 = Console.ReadKey();
            Console.WriteLine();
        }
        #endregion
    }
}
