using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livraisons
{
    class Client
    {
        public string numeroClient;
        public string client;
        public int jour;
        public int mois;


        public Client(string _num, string _nom, int _jour, int _mois)
        {
            numeroClient = _num;
            client = _nom;
            jour = _jour;
            mois = _mois;
        }


    }
}
