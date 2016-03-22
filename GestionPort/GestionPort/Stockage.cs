using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Port_classes_console
{
    class Stockage
    {
        private int _capaDispo;
        public int CapaDispo
        {
            get
            {
                return _capaDispo;
            }
            set
            {
                _capaDispo = value;
            }
        }
        public void Stocker(int qte)
        {
            if (qte > this.CapaDispo) throw new Exception("Quantité supérieure à la capacité disponible.");            
            else if (qte < 0) throw new Exception("La quantitée à stocker ne peux pas être inférieur à 0");
            else this.CapaDispo -= qte;
        }
        public bool estVide()
        {
            return this.CapaDispo == 0;
        }
        public Stockage(int capa)
        {
            this.CapaDispo = capa;
        }
    }
}