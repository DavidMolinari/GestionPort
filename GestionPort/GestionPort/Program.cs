using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Port_classes_console;
namespace GestionPort
{
    class Program
    {
        static void Main(string[] args)
        {

            Navire monNavire = new Navire("2321", "BlackPearl", "BP", 200);



            Console.WriteLine(monNavire.NomNavire + " " + monNavire.QteFret);

            List<Stockage> Stockages = new List<Stockage>();
            Stockages.Add(new Stockage(200));
            Stockages.Add(new Stockage(200));
            Stockages.Add(new Stockage(200));


            Port unPort = new Port(Stockages);

            unPort.dechargement(monNavire);

            Console.WriteLine(monNavire.NomNavire + " " + monNavire.QteFret);

            Console.WriteLine("End.");
            Console.Read();
        }
    }
}
