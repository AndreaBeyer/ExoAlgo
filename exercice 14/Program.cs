using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_14
{
    class Program
    {
        public static void Main(string[] args)
        {

            double a = 6, b = 10, c = 5, aire = 0, perimetre = 0;
            Console.WriteLine(a + " " + b);
            InverserNombres(a, b); 
            Console.WriteLine(a + " " + b);
            AirePerimetreTriangle(a, b, c, out aire, out perimetre);
            Console.WriteLine(aire + " " + perimetre);
            Console.WriteLine(MoyenneDeuxNombres(a, b));
            Console.WriteLine(Bisextile(2104));
            Console.WriteLine(JourDeLaSemaine(2019, 03, 11));
            string texte = "hello world!";
            
            Console.WriteLine(InverserCaractere(texte));




        }


        public static void InverserNombres(double _a, double _b)
        {
            double temp;
            temp = _a;
            _a = _b;
            _b = temp;

        }
        public static void AirePerimetreTriangle(double _a, double _b, double _c, out double _aire, out double _perimetre)
        {
            _perimetre = _a + _b + _c;
            _aire = (_perimetre/2-_a)*(_perimetre/2-_b)*(_perimetre/2-_c);

        }
        public static double MoyenneDeuxNombres(double _a, double _b)
        {
            return (_a + _b) / 2;
        }
        public static bool Bisextile(int _annee)
        {
            bool ok = true;
            if(_annee%4 == 0)
            {
                if (_annee%400 != 0)
                {
                    ok = false;
                }  
            }
            else
            {
                ok = false;
            }

            return ok;
        }
        public static string JourDeLaSemaine(int _y, int _m, int _d)
        {
            System.DateTime date1 = new System.DateTime(_y, _m, _d);
            string day = date1.DayOfWeek.ToString();
            return day;
        }
        public static string InverserCaractere(string _texte)
        {

            char[] texte1 = _texte.ToCharArray();
            Array.Reverse(texte1);
            
            return new string(texte1);
            
        }





    }
        

}
