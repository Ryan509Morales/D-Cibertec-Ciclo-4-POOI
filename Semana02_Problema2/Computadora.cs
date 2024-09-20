using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02_Problema2
{
    internal class Computadora
    {
        private int codigo { get; set; }
        private string marca { get; set; }
        private string color { get; set; }
        private double pdolar { get; set; }

        public Computadora(int codigo, string marca, string color, double pdolar)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.pdolar = pdolar;
        }

        public double precioSoles()
        {
            return pdolar * 3.35;
        }

        public double precioEuros()
        {
            return pdolar / 1.20;
        }

        public void listarDatos()
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Precio en dólares: {pdolar}");
            Console.WriteLine($"Precio en soles: {precioSoles()}");
            Console.WriteLine($"Precio en euros: {precioEuros()}");
        }

        public void DisminuirPrecio()
        {
            this.pdolar -= 0.1;
        }
    }
}
