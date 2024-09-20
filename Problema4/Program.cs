using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datos iniciales........");
            Console.WriteLine("------------------------");
            Obrero ob = new Obrero(01, "Juan Quispe", 45, 30);
            List<Obrero> lstObreo = new List<Obrero>();
            lstObreo.Add(ob);

            Obrero ob2 = new Obrero(07, "Paola Loaiza", 55, 30);
            lstObreo.Add(ob2);

            foreach(Obrero obo in lstObreo)
            {
                obo.listado();
            }

            Console.WriteLine("Aumento de un 8 número de horas y reducción de 1.5% la tarifa");
            Console.WriteLine("------------------------");
            foreach (Obrero obo in lstObreo)
            {
                obo.modificar();
            }

            foreach (Obrero obo in lstObreo)
            {
                obo.listado();
            }

            Console.ReadKey();
        }
    }
}
