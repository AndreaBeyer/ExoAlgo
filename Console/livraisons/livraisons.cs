using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livraisons
{
    class livraisons
    {
        static bool ok = true, ok1 = true, ok2 = true, ok3 = true, ok4 = true;
        static Client[] clients =
            {
                //clients[0]
                new Client("43A", "Aristide BARNIT", 6, 8),
                //clients[1]
                new Client("54A", "Joseph LOSEILLE", 6, 7),
                //clients[2]
                new Client("62B", "Léon NIDAS",1, 9),
                //clients[3]
                new Client("74B", "Gaston CHOCONNOU",6, 8),
                //clients[4]
                new Client("85B", "Louise CHIMELLE",1, 7),
                //clients[5]
                new Client("93C", "Justin DRIBOU", 2, 0),
                //clients[6]
                new Client("27C", "Nicolas METREL",1, 0),
                //clients[7]
                new Client("33D", "Léontine CARAVANE", 6, 8),
                //clients[8]
                new Client("45D", "Albert ETBASQUE", 6, 7),
                //clients[9]
                new Client("56F", "Jules MOCHE",1, 9),
            };
        static string[] moisString = { "janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };
        static string[] jourString = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
        //numero de client saisi par l'utilisateur
        static string nClient1;
        //jour de livraison saisi par l'utilisateur en version string
        static string jourLivraisonString;
        //mois de livraison impossible pour le client entre
        static int moisLivraionImpossible;
        //jour de livraison impossible pour le client entre
        static int jourLivraionImpossible;
        //jour de livraison saisi par l'utilisateur en version int
        static int jourLivraison = 0;
        //mois de livraison saisi par l'utilisateur en version string
        static string moisDeLivraisonString;
        //mois de livraison saisi par l'utilisateur en version int
        static int moisDeLivraison;
        // variable ConsoleKeyInfo pour la reponse de l'utilisateur
        static ConsoleKeyInfo reponse;
        static string titre = "CONTROLE DES POSSIBILITES DE LIVRAISONS";
        static int index = 0;
        static string possiliteLivraison;
        static string jourEntreString;
        static string moisEntreString;
        static string jourNonLivreString;
        static string moisNonLivreString;
        static string jourLivraisonImpossibleString;
        static string moisLivraisonImpossibleString;


        static void Main(string[] args)
        {

            AffichageHalfConsole(titre);
            ChTitreConsole(titre);

            

            do //tant que l'utilisateur souhaite continuer
            {
                AffichageClientsNClients(clients);
                DemandeNClientsValide(nClient1, clients, ref index);

                jourLivraionImpossible = clients[index].jour;
                moisLivraionImpossible = clients[index].mois;

                jourLivraisonImpossibleString = jourString[(jourLivraionImpossible - 1)];
                moisLivraisonImpossibleString = moisString[(moisLivraionImpossible - 1)];

                DemandeJourValide(ref jourLivraison);

                DemandeMoisValide(ref moisDeLivraison);


                //on cree des version string des jours et mois en toutes lettres
                jourEntreString = jourString[(jourLivraison - 1)];
                moisEntreString = moisString[(moisDeLivraison - 1)];
                jourNonLivreString = jourString[(clients[index].jour - 1)];
                moisNonLivreString = moisString[(clients[index].mois - 1)];

                RecapValeurs(nClient1, clients, jourEntreString, moisEntreString);


                AffichePossibliteDeLivraison(clients, index, jourLivraisonImpossibleString, moisLivraisonImpossibleString, jourLivraionImpossible, moisLivraionImpossible);

                HalfConsole(titre);
                Recommencer(ref ok);


            } while (ok);// !tant que l'utilisateur souhaite continuer
            #region on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            EndProgram();
            #endregion
        }


        #region fonctions
        public static void EndProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void AffichageHalfConsole(string _str)
        {
            Console.SetCursorPosition((Console.WindowWidth - _str.Length) / 2, Console.CursorTop);
            Console.WriteLine(_str);
        }
        public static void ChTitreConsole(string _str)
        {
            Console.Title = _str;
        }
        public static void AffichageClientsNClients(Client[] _clients)
        {
            Console.WriteLine();
            for (int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine("client : {0} ---------------- > numero :{1}", _clients[i].client, _clients[i].numeroClient);
            }
        }
        public static void DemandeNClientsValide(string _nClient, Client[] _clients, ref int _index)
        {
            bool ok;
            do
            {
                Console.WriteLine("veuillez entrer le numero de client");
                _nClient = Console.ReadLine();
                ok = false;
                for (int i = 0; i < _clients.Length; i++)
                {
                    if (_clients[i].numeroClient == _nClient)
                    {
                        _index = i;
                        ok = true;
                    }
                   
                }
                if (ok == false)
                {
                    Console.WriteLine("l'entree est invalide");
                }

            } while (!ok);
        }
        public static void DemandeJourValide(ref int _jourLivraison)
        {
            bool okP;
            do // tant que le jour est invalide
            {
                //on demande le jour
                Console.WriteLine("Quel jour souhaitez vous livrer ? (1 a 6)" + Environment.NewLine + "1:Lundi" + Environment.NewLine + "2:Mardi" + Environment.NewLine + "3:Mercredi" + Environment.NewLine + "4:Jeudi" + Environment.NewLine + "5:Vendredi" + Environment.NewLine + "6:Samedi");
                Console.WriteLine();
                string jourLivraisonString = Console.ReadLine();
                Console.WriteLine();
                bool okQ = int.TryParse(jourLivraisonString, out _jourLivraison);
                okP = true;

                //on  tente de convertir la valeur en entier
                if (!okQ)
                {
                    //on demande de rentrer un chiffre si cela n'en est pas un
                    Console.WriteLine("Veuillez entrer un chiffre");
                }
                else if (_jourLivraison > 6 || _jourLivraison < 1)
                {   //on demande d'entrer un chiffre entre 1 et 6  si il n'est pas compris dedans
                    Console.WriteLine("uniquement un chiffre entre 1 et 6");
                    okP = false;
                }
                okP = (okP && okQ);
                Console.WriteLine();


            } while (!okP); // !tant que le jour est invalide

        }
        public static void DemandeMoisValide(ref int _moisLivraison)
        {
            bool okP;
            do // tant que le jour est invalide
            {
                //on demande le jour
                Console.WriteLine("Quel mois souhaitez vous livrer ? (1 a 12)");
                Console.WriteLine();
                string moisLivraisonString = Console.ReadLine();
                Console.WriteLine();
                bool okQ = int.TryParse(moisLivraisonString, out _moisLivraison);
                okP = true;

                //on  tente de convertir la valeur en entier
                if (!okQ)
                {
                    //on demande de rentrer un chiffre si cela n'en est pas un
                    Console.WriteLine("Veuillez entrer un chiffre");
                }
                else if (_moisLivraison > 12 || _moisLivraison < 1)
                {   //on demande d'entrer un chiffre entre 1 et 6  si il n'est pas compris dedans
                    Console.WriteLine("uniquement un chiffre entre 1 et 12");
                    okP = false;
                }
                okP = (okP && okQ);
                Console.WriteLine();



            } while (!okP); // !tant que le jour est invalide


        }
        public static void RecapValeurs(string _nClient1, Client[] _clients, string _jourEntreString, string _moisEntreString)
        {
            //on affiche les differentes valeurs
            Console.WriteLine();
            Console.WriteLine("Numero du client\t\t{0}", _nClient1);
            Console.WriteLine();
            Console.WriteLine("Nom de l'utilisateur\t\t{0}", _clients[index].client);
            Console.WriteLine();
            Console.WriteLine("Jour de livraison\t\t{0}", _jourEntreString);
            Console.WriteLine();
            Console.WriteLine("Mois de livraison\t\t{0}", _moisEntreString);
            Console.WriteLine();
        }
        public static void AffichePossibliteDeLivraison(Client[] _clients, int _index, string jourLivraisonImpossibleString, string moisLivraisonImpossibleString, int _moisDeLivraison, int _jourLivraison)
        {
            if (_clients[_index].mois != 0) //si la livraison est impossible un mois dans l'année
            {
                //On affiche les valeurs possible de livraison
                Console.WriteLine("La livraison est impossible le {0} et pendant tout le mois de {1}", jourLivraisonImpossibleString, moisLivraisonImpossibleString);

            }
            else //si la livraison est possible tout les mois de l'annee
            {
                Console.WriteLine("La livraison est impossible le {0} et possible pendant tout les mois de l'annee", jourLivraisonImpossibleString);
            }

            //on regarde si les conditions sont remplie et on affiche le resultat
            if (_jourLivraison != _clients[index].jour && _moisDeLivraison != _clients[index].mois)
            {
                possiliteLivraison = "---->la livraion est possible<----";
            }
            else
            {
                possiliteLivraison = "---->La livraison est impossible<----";
            }
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
        public static void HalfConsole(string _titre)
        {
            //on passe le curseur du terminal à la moitié de la console
            Console.SetCursorPosition((Console.WindowWidth - _titre.Length) / 2, Console.CursorTop);
        }
        public static void Recommencer(ref bool _c)
        {
            //on demande si l'utilisateur souhaite recommencer
            Console.WriteLine();
            Console.WriteLine("Voulez-vous faire un autre calcul ? (O/N)");

            ConsoleKeyInfo key = Console.ReadKey();
            _c = key.Key == ConsoleKey.O;
            Console.ReadKey();


            #endregion
        }

    }
}


