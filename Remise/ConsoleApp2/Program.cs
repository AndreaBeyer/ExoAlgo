using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// remise appliquée par tranche de 10
        /// </summary>
        static readonly float remiseParTranche = 0.05f;
        /// <summary>
        /// nombre d'achats
        /// </summary>
        static int nbAchats;
        /// <summary>
        /// remise calculée
        /// </summary>
        static float remise;
        ConsoleKeyInfo confirmation;


        static void Main(string[] args)
        {
            //on creer une variable string pour le nombre d'achats
            string nbAchatsString = "";
            //on creer une variable consolekeyinfo
            ConsoleKeyInfo confirmation;


                //on creer une boucle tant que le nombre d'achats saisie n'est pas un entier
            do
             {
                    //on creer une boucle  tant que la touche confimation n'est pas O
                    do
                    {
                    //on demande a l'utilisateur d'entrer le nombre d'achats
                    Console.WriteLine(Environment.NewLine + "Saisissez le nombre d'achats : ");
                    //version string du nombre d'achat
                    nbAchatsString = Console.ReadLine();
                    Console.WriteLine("etes vous sûr ?");
                    confirmation = Console.ReadKey();
                    Console.ReadLine();
                    } while(confirmation.Key != ConsoleKey.O);

                    //on teste si la saisie est convertible en int
                    if (!int.TryParse(nbAchatsString, out nbAchats))
                    {
                        Console.WriteLine("l'entree est invalide");
                    }

             } while (!int.TryParse(nbAchatsString, out nbAchats));

            
            

            //on affiche le nombre choisi à l'utilisateur
            Console.WriteLine(Environment.NewLine +"Vous avec saisi : " + nbAchats + " achats.");
            
            //On commence le calcul de la remise

            //si le nombre d'achats est supérieur et égal à 10
            if (nbAchats >= 10)
            {
                //si le nombre d'achats est supérieur et égal à 60 la remise est égale à 30%
                if (nbAchats >= 60)
                {
                    remise = 0.3f;
                }
                //sinon on calcule la remise suivant la methode indiquée
                else
                {
                    remise = (nbAchats / 10 * remiseParTranche);
                }
            }

            //on affiche la remise à l'utilisateur
            Console.WriteLine("la remise effective est de : " + (remise*100) + " %");
            //on creer une variable pour le montant du panier
            float montantPanier;
            //on creer une variable sstring pour le montant du panier
            string montantPanierString;
            //on creer une boucle tant que le montant saisie n'est pas convertible en float
            do
            {
                do
                {
                    //on demande le montant et on l'entre dans montantPanierString
                    Console.WriteLine(Environment.NewLine + "Veuillez entrer le montant de votre panier en euros");
                    montantPanierString = Console.ReadLine();
                    Console.WriteLine("etes vous sûr ?");
                    confirmation = Console.ReadKey();
                    Console.ReadLine();
                } while (confirmation.Key != ConsoleKey.O);


                //on teste si on peut convertir la saisie en float
                if (!float.TryParse(montantPanierString, out montantPanier))
                    {
                        Console.WriteLine("l'entree est invalide");
                    }

            } while (!float.TryParse(montantPanierString, out montantPanier));
            

            //on calcule le prix final
            float reductionEuros = montantPanier * remise;
            //on calcul la reduction
            float prixFinal = montantPanier - reductionEuros;
            //on affiche la reduction
            Console.WriteLine(Environment.NewLine + "la reduction est de : " + reductionEuros + " euros");
            //on affiche le prix final
            Console.WriteLine("le prix final est de : " + prixFinal + " euros");
            //on demande à l'utilisateur d'appuyer sur une touche pour mettre fin au programme
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();

        }

    }
}
