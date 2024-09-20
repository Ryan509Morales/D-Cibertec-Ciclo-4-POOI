using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor asr = new Asesor(03, "Carlos Carranza", 45, 15);
            List<Asesor> lstAse = new List<Asesor>();
            lstAse.Add(asr);

            Asesor asr2 = new Asesor(05, "Jeremy Poma", 50, 13);
            lstAse.Add(asr2);

            foreach(Asesor s in lstAse)
            {
                s.listado();
            }

            Console.WriteLine("------Datos modificados-------");
            foreach(Asesor s in lstAse)
            {
                s.modificarDatos();
            }

            foreach (Asesor s in lstAse)
            {
                s.listado();
            }

            Console.ReadKey();

        }
    }
}
