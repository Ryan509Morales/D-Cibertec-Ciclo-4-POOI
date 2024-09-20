using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Celular> listCel = new List<Celular>();
            Celular cel1 = new Celular(923572981, "Camila Torrez", 300, 20);
            listCel.Add(cel1);
            Celular cel2 = new Celular(981700431, "Thiago Perez", 400, 40);
            listCel.Add(cel2);

            foreach(Celular cel in listCel)
            {
                cel.mostrarDatos();
            }

            Console.WriteLine("Aumentando los segundos en 20 y reduciendo el precio en 5%");
            foreach(Celular cel in listCel)
            {
                cel.actualizarDatos();
                cel.mostrarDatos();
            }
            Console.ReadKey();
           
        }
    }
}
