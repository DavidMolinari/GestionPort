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
        //Stockage unStockage = new Stockage(200);
        public void dechargement(Navire unNavire)
        {
            int i = 0;
            Stockage unStockage;
            
            while (!(unNavire.EstDecharge()) && (i < Stockages.Count))
            {
                unStockage = this.Stockages.ElementAtOrDefault(i);
                Stockages.RemoveAt(i);
               if (unNavire.QteFret >= unStockage.CapaDispo)
                {
                    unNavire.Decharger(unStockage.CapaDispo);
                    unStockage.Stocker(unStockage.CapaDispo);
                }
               else
                {
                    unStockage.Stocker(unStockage.CapaDispo - unNavire.QteFret);
                    unNavire.Decharger(unNavire.QteFret);
                }
                i += 1;
                if (unNavire.EstDecharge()) Console.WriteLine("Le navire est déjà dechargé.");
                else if(i < Stockages.Count) throw new Exception("Les stocks sont plein et le Navire n'est pas vide.");
            }

        }
    }
}