using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livraisons
{
    class livraisons
    {
        static void Main(string[] args)
        {

            //on creer un objet client[] et on assigne dee valeurs
            Client[] clients =
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

            //on creer 2 tableaux pour les version string de mois et lettre
            string[] moisString = {"janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre","octobre","novembre","decembre"};
            string[] jourString = {"lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche"};
            //numero de client saisi par l'utilisateur
            string nClient1;
            //jour de livraison saisi par l'utilisateur en version string
            string jourLivraisonString;
            //mois de livraison impossible pour le client entre
            int moisLivraionImpossible;
            //jour de livraison impossible pour le client entre
            int jourLivraionImpossible;
            //jour de livraison saisi par l'utilisateur en version int
            int jourLivraison = 0;
            //mois de livraison saisi par l'utilisateur en version string
            string moisDeLivraisonString;
            //mois de livraison saisi par l'utilisateur en version int
            int moisDeLivraison;
            // variable ConsoleKeyInfo pour la reponse de l'utilisateur
            ConsoleKeyInfo reponse;

            Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.BackgroundColor = ConsoleColor.Magenta;
            //on initialise un titre
            Console.WriteLine();
            string titre = "CONTROLE DES POSSIBILITES DE LIVRAISONS";

            //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(titre);
            Console.WriteLine();
            Console.Title = titre;

            for(int i = 0; i < clients.Length; i++ )
            {
                Console.WriteLine("client : {0} ---------------- > numero :{1}",clients[i].client, clients[i].numeroClient);
            }

            Console.WriteLine();
            int index = 0;
            string possiliteLivraison;

            do //tant que l'utilisateur souhaite continuer
            {
                do //tant que le client n'existe pas 
                {
                    Console.WriteLine();
                    Console.WriteLine("Veuillez entrer le numero du client");
                    Console.WriteLine();
                    nClient1 = Console.ReadLine();
                    Console.WriteLine();

                    //on recherche l'index de la valeur
                    index = Array.IndexOf(clients, nClient1);     
                    //for (int i = 0; i < clients.Length; i++)
                    //{

                    //    if (clients[i].numeroClient == nClient1)
                    //    {
                    //        index = i;
                    //    }
                    //}
                    //si le client n'existe pas
                    if(clients[index].numeroClient != nClient1)
                    {
                        Console.WriteLine("le client n'existe pas !");
                        Console.WriteLine();
                    }

                } while (clients[index].numeroClient != nClient1);//!tant que le client n'existe pas 

                jourLivraionImpossible = clients[index].jour;
                moisLivraionImpossible = clients[index].mois;

                string jourLivraisonImpossibleString = jourString[(jourLivraionImpossible-1)];
                string moisLivraisonImpossibleString = moisString[(moisLivraionImpossible-1)];




                do // tant que le jour est invalide
                {
                    //on demande le jour
                    Console.WriteLine("Quel jour souhaitez vous livrer ? (1 a 6)" +Environment.NewLine+ "1:Lundi" + Environment.NewLine + "2:Mardi"+Environment.NewLine + "3:Mercredi" + Environment.NewLine + "4:Jeudi" + Environment.NewLine + "5:Vendredi"+Environment.NewLine + "6:Samedi");
                    Console.WriteLine();
                    jourLivraisonString = Console.ReadLine();
                    Console.WriteLine();

                    //on  tente de convertir la valeur en entier
                    if (!int.TryParse(jourLivraisonString, out jourLivraison))
                    {
                        //on demande de rentrer un chiffre si cela n'en est pas un
                        Console.WriteLine("Veuillez entrer un chiffre");
                    }
                    else if (jourLivraison > 6 || jourLivraison < 1)
                    {   //on demande d'entrer un chiffre entre 1 et 6  si il n'est pas compris dedans
                        Console.WriteLine("uniquement un chiffre entre 1 et 6");
                    }
                    Console.WriteLine();

                } while ((!int.TryParse(jourLivraisonString, out jourLivraison)) || (jourLivraison > 6 || jourLivraison < 1)); // !tant que le jour est invalide

                do // tant que le mois est invalide
                {
                    //on demande le mois
                    Console.WriteLine("Quel mois souhaitez vous livrer ? (1 a 12)");
                    Console.WriteLine();
                    moisDeLivraisonString = Console.ReadLine();
                    Console.WriteLine();

                    //on  tente de convertir la valeur en entier
                    if (!int.TryParse(moisDeLivraisonString, out moisDeLivraison))
                    {
                        //on demande de rentrer un chiffre si cela n'en est pas un
                        Console.WriteLine("Veuillez entrer un chiffre");
                    }
                    else if (moisDeLivraison > 12 || moisDeLivraison < 1)
                    {
                        //on demande d'entrer un chiffre entre 1 et 7  si il n'ets pas compris dedans
                        Console.WriteLine("uniquement un chiffre entre 1 et 12");
                    }
                    Console.WriteLine();

                } while ((!int.TryParse(moisDeLivraisonString, out moisDeLivraison)) || (moisDeLivraison > 12 || moisDeLivraison < 1)); // !tant que le mois est invalide



                //on cree des version string des jours et mois en toutes lettres
                string jourEntreString = jourString[(jourLivraison-1)];
                string moisEntreString = moisString[(moisDeLivraison-1)];
                string jourNonLivreString = jourString[(clients[index].jour-1)];
                string moisNonLivreString = moisString[(clients[index].mois-1)];

                //on affiche les differentes valeurs
                Console.WriteLine();
                Console.WriteLine("Numero du client\t\t{0}", nClient1);
                Console.WriteLine();
                Console.WriteLine("Nom de l'utilisateur\t\t{0}", clients[index].client);
                Console.WriteLine();
                Console.WriteLine("Jour de livraison\t\t{0}", jourEntreString);
                Console.WriteLine();
                Console.WriteLine("Mois de livraison\t\t{0}", moisEntreString);
                Console.WriteLine();


                if (clients[index].mois != 0) //si la livraison est impossible un mois dans l'année
                {
                    //On affiche les valeurs possible de livraison
                    Console.WriteLine("La livraison est impossible le {0} et pendant tout le mois de {1}", jourLivraisonImpossibleString, moisLivraisonImpossibleString);

                }
                else //si la livraison est possible tout les mois de l'annee
                {
                    Console.WriteLine("La livraison est impossible le {0} et possible pendant tout les mois de l'annee", jourLivraisonImpossibleString);
                }

                //on regarde si les conditions sont remplie et on affiche le resultat
                if (jourLivraison != clients[index].jour && moisDeLivraison != clients[index].mois)
                {
                    possiliteLivraison = "---->la livraion est possible<----";
                }
                else
                {
                    possiliteLivraison = "---->La livraison est impossible<----";
                }


                //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
                Console.SetCursorPosition((Console.WindowWidth - possiliteLivraison.Length) / 2, Console.CursorTop);
                Console.WriteLine();
                Console.WriteLine(possiliteLivraison);
                //on demande a l'utlisateur s'il souhaite faire un nouveau controle
                Console.WriteLine();
                Console.WriteLine("Voulez-vous faire un autre controle ? (O/N)");
                reponse = Console.ReadKey();
                Console.WriteLine();


            } while (reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y);// !tant que l'utilisateur souhaite continuer
            //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.WriteLine();
            Console.ReadKey();





            // !tant que l'utilisateur souhaite continuer

            //    if (client2

            //    {

            //        Console.WriteLine();


            //    }

            //} while (!nClient.Contains(nClient1)); // !tant que le client n'existe pas

            ////on creer une variable int pour l'index du numero du client
            //int index = Array.IndexOf(nClient, nClient1);
















            //    //on creer un tableau string pour les numeros clients
            //    string[] nClient = { "43A", "54A", "62B", "74B", "85B", "93C", "27C", "33D", "45D", "56F" };
            //    ////on creer un tableau string pour les noms des clients
            //    string[] noms = { "Aristide BARNIT", "Joseph LOSEILLE", "Leon NIDAS", "Gaston CHOCONNOU", "Louise CHIMELLE", "Justin DRIBOU", "Nicolas METREL", "Leontine CARAVANE", "Albert ETBASQUE", "Jules MOCHE" };
            //    //on creer un tableau int pour les jours sans livraison
            //    int[] jour = { 6, 6, 1, 6, 1, 2, 1, 6, 6, 1 };
            //    //on creer une version string des jours sans livraison
            //    string[] jourString = { "samedi", "samedi", "lundi", "samedi", "lundi", "mardi", "lundi", "samedi", "samedi", "lundi" };
            //    //on creer un tableau int pour les mois ou il n'est pas possible de livrer
            //    int[] mois = { 8,7,9,8,7,0,0,8,7,9 };
            //    //on creer une version string des mois sans livraison
            //    string[] moisString = { "Aout", "Juillet", "Septembre", "Aout", "Juillet", "Sans objet", "Sans objet", "Aout", "Juillet", "Septembre" };

            //    //numero de client saisi par l'utilisateur
            //    string nClient1;
            //    //jour de livraison saisi par l'utilisateur en version string
            //    string jourLivraisonString;
            //    //jour de livraison saisi par l'utilisateur en version int
            //    int jourLivraison;
            //    //jour de livraison saisi par l'utilisateur en version string
            //    string moisDeLivraisonString;
            //    //mois de livraison saisi par l'utilisateur en version int
            //    int moisDeLivraison;
            //    // variable ConsoleKeyInfo pour la reponse de l'utilisateur
            //    ConsoleKeyInfo reponse;

            //    //on initialise un titre
            //    Console.WriteLine();
            //    string titre = "CONTROLE DES POSSIBILITES DE LIVRAISONS";

            //    //on passe le curseur du terminal à la moitié de la console puis on ecrit le titre
            //    Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            //    Console.WriteLine(titre);
            //    Console.WriteLine();

            //    do //tant que l'utilisateur souhaite continuer
            //    {
            //        do //tant que le client n'existe pas 
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("Veuillez entrer le numero du client");
            //            Console.WriteLine();
            //            nClient1 = Console.ReadLine();
            //            if (!nClient.Contains(nClient1))
            //            {
            //                Console.WriteLine();
            //                Console.WriteLine("Ce client n’existe pas !");
            //            }

            //        } while (!nClient.Contains(nClient1)); // !tant que le client n'existe pas

            //        //on creer une variable int pour l'index du numero du client
            //        int index = Array.IndexOf(nClient, nClient1);

            //        //on affiche le nom du client
            //        Console.WriteLine();
            //        Console.WriteLine(noms[index]);
            //        Console.WriteLine();
            //        Console.WriteLine();

            //        if (mois[index] != 0) //si la livraison est impossible un mois dans l'année
            //        {
            //            //On affiche les valeurs possible de livraison
            //            Console.WriteLine("La livraison est impossible le {0} et pendant tout le mois de {1}", jourString[index], moisString[index]);

            //        }
            //        else //si la livraison est possible tout les mois de l'annee
            //        {
            //            Console.WriteLine("La livraison est impossible le {0} et possible pendant tout les mois de l'annee", jourString[index]);
            //        }

            //        Console.WriteLine();

            //        do // tant que le jour est invalide
            //        {
            //            //on demande le jour
            //            Console.WriteLine("Quel jour souhaitez vous livrer ? (1 a 6 pour lundi a samedi)");
            //            Console.WriteLine();
            //            jourLivraisonString = Console.ReadLine();
            //            Console.WriteLine();

            //            //on  tente de convertir la valeur en entier
            //            if (!int.TryParse(jourLivraisonString, out jourLivraison))
            //            {   
            //                //on demande de rentrer un chiffre si cela n'en est pas un
            //                Console.WriteLine("Veuillez entrer un chiffre");
            //            }
            //            else if(jourLivraison > 6 || jourLivraison < 1)
            //            {   //on demande d'entrer un chiffre entre 1 et 6  si il n'est pas compris dedans
            //                Console.WriteLine("uniquement un chiffre entre 1 et 6");
            //            }
            //            Console.WriteLine();

            //        } while ((!int.TryParse(jourLivraisonString, out jourLivraison)) || (jourLivraison > 6 || jourLivraison < 1)); // !tant que le jour est invalide


            //        do // tant que le mois est invalide
            //        {
            //            //on demande le mois
            //            Console.WriteLine("Quel mois souhaitez vous livrer ? (1 a 12)");
            //            Console.WriteLine();
            //            moisDeLivraisonString = Console.ReadLine();
            //            Console.WriteLine();

            //            //on  tente de convertir la valeur en entier
            //            if (!int.TryParse(moisDeLivraisonString, out moisDeLivraison))
            //            {
            //                //on demande de rentrer un chiffre si cela n'en est pas un
            //                Console.WriteLine("Veuillez entrer un chiffre");
            //            }
            //            else if (moisDeLivraison > 12 || moisDeLivraison < 1)
            //            {
            //                //on demande d'entrer un chiffre entre 1 et 7  si il n'ets pas compris dedans
            //                Console.WriteLine("uniquement un chiffre entre 1 et 12");
            //            }
            //            Console.WriteLine();

            //        } while ((!int.TryParse(moisDeLivraisonString, out moisDeLivraison)) || (moisDeLivraison > 12 || moisDeLivraison < 1)); // !tant que le mois est invalide



            //        //on regarde si les conditions sont remplie et on affiche le resultat
            //        if (jourLivraison != jour[index] && moisDeLivraison != mois[index])
            //        {
            //            Console.WriteLine("la livraion est possible");
            //        }
            //        else
            //        {
            //            Console.WriteLine("La livraison est impossible");
            //        }

            //        //on demande a l'utlisateur s'il souhaite faire un nouveau controle
            //        Console.WriteLine();
            //        Console.WriteLine("Voulez-vous faire un autre controle ? (O/N)");
            //        reponse = Console.ReadKey();
            //        Console.WriteLine();

            //    } while (reponse.Key == ConsoleKey.O || reponse.Key == ConsoleKey.Y); // !tant que l'utilisateur souhaite continuer

            //    //on demande a l'utilisateur d'appuyer sur une touche pour fermer le programme
            //    Console.WriteLine();
            //    Console.WriteLine("Appuyez sur une touche pour continuer...");
            //    Console.WriteLine();
            //    Console.ReadKey();





        }
    }
}
