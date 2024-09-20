using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    internal class Paciente
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int edad { get; set; }
        private double talla { get; set; }
        private double peso { get; set; }

        public Paciente(string nombre, string apellido, int edad, double talla, double peso)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.talla = talla;
            this.peso = peso;
        }

        public string rangoEdad()
        {
            if(edad <= 17)
            {
                return "menor de edad";
            }
            else
            {
                return "mayor de edad";
            }
        }

        public void modificarDatos()
        {
            this.edad += 5;
            this.talla -= 0.05;
            this.peso += 1;
        }

        public void listarDatos()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Nombre del paciente:{nombre}");
            Console.WriteLine($"Apellido del paciente:{apellido}");
            Console.WriteLine($"Edad del paciente:{edad}");
            Console.WriteLine($"Talla del paciente:{talla}");
            Console.WriteLine($"Peso del paciente:{peso}");
            Console.WriteLine($"Rango de edad del paciente:{rangoEdad()}");
            Console.WriteLine("----------------------------");
        }
    }
}
