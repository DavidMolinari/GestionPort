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
        private List<Navire> Navires;

        public Port()
        {
            Stockages = new List<Stockage>();
            Stockages.Add(new Stockage(150, 150));
            Stockages.Add(new Stockage(250, 250));
            Stockages.Add(new Stockage(300, 300));
            Navires = new List<Navire>();
            Navires.Add(new Navire("80", "BlackPearls", "80", 600));
            this.dechargement(Navires.ElementAt(0));
        }
        public void dechargement(Navire unNavire)
        {
            int i = 0;
            Stockage unStockage;
            while (!unNavire.estDecharge() && i < this.Stockages.Count())
            {
                unStockage = this.Stockages.ElementAt(i);
                if(unNavire.obtenirQteFret() >= unStockage.obtenirCapaDispo())
                {
                    unNavire.decharger(unStockage.obtenirCapaDispo());
                    unStockage.stocker(unStockage.obtenirCapaDispo());
                }
                else
                {
                    unStockage.stocker(unStockage.obtenirCapaDispo() - unNavire.obtenirQteFret());
                    unNavire.decharger(unNavire.obtenirQteFret()); 
                }
                i++;
            }
            if (unNavire.estDecharge())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Le navire est déchargé");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Toutes les zones de stockages sont pleines et le bateau n'est pas vide");
            }
        }
    }
     
}
