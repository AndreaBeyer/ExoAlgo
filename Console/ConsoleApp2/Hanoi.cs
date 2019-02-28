using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hanoi
    {
        static void Main(string[] args)
        {
            
            
            string nbreDeDisqueString = Console.ReadLine();
            if(double.TryParse(nbreDeDisqueString, out double nbreDeDisque))
            {
                Console.WriteLine("l'entrée est invalide");
            }
            double nbreDeplacement = Math.Pow(2, nbreDeDisque);

            bool d, i, a;







            






        }
    }
}
