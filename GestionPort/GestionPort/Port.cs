using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Port_classes_console
{
    class Port
    {
        private List<Stockage> Stockages;


        public Port(List<Stockage> Stockages)
        {
            this.Stockages = Stockages;
        }


        /// <summary>
        /// TODONFINIR MEH
        /// </summary>
        /// <param name="unNavire"></param>
        public void dechargement(Navire unNavire)
        {
            int i = 0;

            while (!unNavire.EstDecharge() && i < this.Stockages.Count)
            {
                var temp = this.Stockages.ElementAt(i);
                Stockages.RemoveAt(i);
               if(unNavire.QteFret >= unStockage.CapaDispo)
                {
                    unNavire.Decharger(unStockage.CapaDispo);
                    unStockage.Stocker(unStockage.CapaDispo);
                }
               else
                {
                    unStockage.Stocker(unStockage.CapaDispo - unNavire.QteFret);
                    unNavire.Decharger(unNavire.QteFret);
                }
                i++;
                if (unNavire.EstDecharge()) Console.WriteLine("Le navire est déjà dechargé.");
                else throw new Exception("Les stocks sont plein et le Navire n'est pas vide.");
            }
        }

        public Port(List<Stockage> Stockages)
        {
        }
    }
}
