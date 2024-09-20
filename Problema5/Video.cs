using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    internal class Video
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private double duracion { get; set; }
        private double psoles { get; set; }
        private double tipo_cambio { get; set; }

        public Video(int codigo, string nombre, double duracion, double psoles, double tipo_cambio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.duracion = duracion;
            this.psoles = psoles;
            this.tipo_cambio = tipo_cambio;
        }

        public double calcularPrecioDolar()
        {
            return psoles / tipo_cambio;
        }

        public void listado()
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Duración video: {duracion}");
            Console.WriteLine($"Precio en soles: {psoles}");
            Console.WriteLine($"Tipo de cambio: ${tipo_cambio}");
            Console.WriteLine($"Precio del video en dolares: ${calcularPrecioDolar():F2}");
        }

        public void modificarPrecio()
        {
            this.psoles += 5.50;
        }


    }
}
