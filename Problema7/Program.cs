using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> lstEmp = new List<Empleado>();
            Empleado emp = new Empleado(03, "Raul", 934720921, 4000);
            lstEmp.Add(emp);

            emp.listarDatos();
            emp.modificarDatos();
            emp.listarDatos();
            Console.ReadKey();
        }
    }
}
