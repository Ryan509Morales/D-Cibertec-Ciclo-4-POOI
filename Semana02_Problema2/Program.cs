using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02_Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio Inicial de la computadora");
            
            List<Computadora> listPc = new List<Computadora>();
            Computadora pc = new Computadora(150, "Laptop Hp", "Azul", 3000);
            listPc.Add(pc);

            Computadora pc2 = new Computadora(120, "Laptop Lenovo Gaming", "Rojo", 5000);
            listPc.Add(pc2);

            foreach(Computadora p in listPc)
            {
                p.listarDatos();
            }

            //Disminuir en 10%
            Console.WriteLine("Precio disminuido en un 10%......");
            foreach(Computadora p in listPc)
            {
                p.DisminuirPrecio();
            }
            foreach (Computadora p in listPc)
            {
                p.listarDatos();
            }


            Console.ReadKey();
        }
    }
}
