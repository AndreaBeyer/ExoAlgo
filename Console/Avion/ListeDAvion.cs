using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace avion
{
    public class ListeDAvion
    {
        public Dictionary<string, Avion> avions;

        public ListeDAvion()
        {
            avions = new Dictionary<string, Avion>();
        }

        public void AddAvion(string s, Avion v)
        {
            avions.Add(s, v);
        }

        public double GetMoyenne()
        {
            double sommeRA = 0;
            foreach (Avion v in avions.Values)
            {
                sommeRA += v.RayonDAction;
            }
            return sommeRA / avions.Count;
        }

        public string GetIndexAvionMax()
        {
            string indexAvionMaxRapid = null;
            int w = 0;
            foreach (Avion v in avions.Values)
            {
                if (v.VitesseCroisiere > w)
                {
                    indexAvionMaxRapid = v.CodeAvion;
                }
                w = v.VitesseCroisiere;
            }
            return indexAvionMaxRapid;
        }
    }
}
