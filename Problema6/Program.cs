using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Paciente> lstPa = new List<Paciente>();
            Paciente p1 = new Paciente("Guillero", "Hurtado", 45, 1.80, 80.5);
            lstPa.Add(p1);

            Paciente p2 = new Paciente("Andres", "Pariona", 37, 1.75, 70.5);
            lstPa.Add(p2);

            Paciente p3 = new Paciente("Silvana", "Aguero", 16, 1.50, 60.0);
            lstPa.Add(p3);

            Paciente p4 = new Paciente("Marisol", "Rios", 14, 1.55, 50.5);
            lstPa.Add(p4);

            Console.WriteLine("---------Datos sin modificar-------");

            foreach(Paciente pat in lstPa)
            {
                pat.listarDatos();
            }

            Console.WriteLine("---------Datos modificados-------");

            foreach (Paciente pat in lstPa)
            {
                pat.modificarDatos();
            }

            foreach (Paciente pat in lstPa)
            {
                pat.listarDatos();
            }

            Console.ReadKey();
        }
    }
}
