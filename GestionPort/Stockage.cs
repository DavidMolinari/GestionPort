using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Port_classes_console
{
    class Stockage
    {
        private int capaDispo;
        private int capaTotal;

        public int CapaDispo
        {
            get
            {
                return capaDispo;
            }

            set
            {
                capaDispo = value;
            }
        }

        public Stockage(int pCapaDispo, int pCapaTotal)
        {
            this.CapaDispo = pCapaDispo;
            this.capaTotal = pCapaTotal;
        }
        public int obtenirCapaDispo()
        {
            return this.CapaDispo;
        }
        public void stocker(int qte)
        {
            this.CapaDispo = this.CapaDispo - qte;
        }
        public bool estVide()
        {
            return this.CapaDispo == this.capaTotal;
        }
        public bool estRemplie()
        {
            return this.CapaDispo == 0;
        }
    }
}
