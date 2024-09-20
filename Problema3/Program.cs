using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Edificio> listEd = new List<Edificio>();
            Edificio ed = new Edificio(201, 20, 10, 8000);
            listEd.Add(ed);

            Console.WriteLine("Precio inicial del edificio");
            ed.listado();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Precio aumentado en un 20%");
            ed.IncrementarPrecio();
            ed.listado();

            Console.ReadKey();

        }
    }
}
