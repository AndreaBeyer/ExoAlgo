using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avion
{
    public class Avion
    {
        public string NomAvion;
        public string CodeAvion;
        public int VitesseCroisiere;
        public int RayonDAction;

        public Avion(string _codeAvion,string _NomAvion,int _VitesseCroisiere,int _RayonDAction)
        {
            CodeAvion = _codeAvion;
            NomAvion = _NomAvion;
            VitesseCroisiere = _VitesseCroisiere;
            RayonDAction = _RayonDAction;
        }


    }
}
