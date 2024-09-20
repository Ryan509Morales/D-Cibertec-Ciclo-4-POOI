using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    internal class Empleado
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private int n_celular { get; set; }
        private double sueldo { get; set; }

        public Empleado(int codigo, string nombre, int n_celular, double sueldo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.n_celular = n_celular;
            this.sueldo = sueldo;
        }

        public string indicarSueldo()
        {
            if(sueldo > 3500)
            {
                return "sueldo mayor a 3500";
            }else if(sueldo < 3500)
            {
                return "sueldo menor a 3500";
            }
            else
            {
                return "sueldo es igual a 3500";
            }
        }

        public void modificarDatos()
        {
            this.n_celular = 999888777;
            this.sueldo += 200;
        }

        public void listarDatos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Codigo del empleado: {codigo}");
            Console.WriteLine($"Nombre del empleado: {nombre}");
            Console.WriteLine($"Número de celular del empleado: {n_celular}");
            Console.WriteLine($"Sueldo en soles: {sueldo}");
            Console.WriteLine($"Estado del sueldo:{indicarSueldo()}");
            Console.WriteLine("----------------------");
        }
    }
}
