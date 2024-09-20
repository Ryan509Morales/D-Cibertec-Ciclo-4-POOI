using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------Precio inicial-----------");

            Video vd = new Video(21, "Los pitufos", 1.30, 50, 3.77);
            List<Video> lstVd = new List<Video>();
            lstVd.Add(vd);

            vd.listado();

            Console.WriteLine("------Precio aumentado en 5.50------");
            vd.modificarPrecio();
            vd.listado();

            Console.ReadKey();
        }
    }
}
