using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pelota plt = new Pelota("Walon", 4.0, 3.0, 15, 55);
            List<Pelota> lstPel = new List<Pelota>();
            lstPel.Add(plt);

            plt.listado();

            Console.WriteLine("----------Datos Modificados---------");

            plt.datosModificados();
            plt.listado();
            Console.ReadKey();
        }
    }
}
