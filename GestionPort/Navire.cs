using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Port_classes_console
{
    class Navire
    {
        private string noLloyds;
        private string nomNavire;
        private string libelleFret;
        private int qteFret;
        public Navire(string pNoLloyds, string pNomNavire, string pLibelleFret, int pQteFret)
        {
            this.noLloyds = pNoLloyds;
            this.nomNavire = pNomNavire;
            this.libelleFret = pLibelleFret;
            this.qteFret = pQteFret;
        }

        public int obtenirQteFret()
        {
            return this.qteFret;
        }
        public void decharger(int qte)
        {
            if (qte <= 0)
            {
                throw new Exception("la quantité a decharger est inférieur ou égale à zero");
            }
            else if(qte > this.qteFret)
            {
                throw new Exception("la quantité a decharger est supérieur à la quantité sur le bateau");
            }
            else{
                this.qteFret -= qte;
            }
        }
        public bool estDecharge()
        {
            return this.qteFret==0;
        }
    }
}
