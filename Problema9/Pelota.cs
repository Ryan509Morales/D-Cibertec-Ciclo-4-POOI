using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    internal class Pelota
    {
        private string marca { get; set; }
        private double peso { get; set; }
        private double presion { get; set; }
        private double diametro { get; set; }
        private double precio { get; set; }

        public Pelota(string marca, double peso, double presion, double diametro, double precio)
        {
            this.marca = marca;
            this.peso = peso;
            this.presion = presion;
            this.diametro = diametro;
            this.precio = precio;
        }

        public double calcularRadio()
        {
            return diametro / 2;
        }

        public double calcularVolumen()
        {
            double radio = calcularRadio(); 
            double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);  
            return volumen;
        }

        public double calcularDesc()
        {
            return precio * 0.10;
        }

        public double importaPagar()
        {
            return precio - calcularDesc();
        }

        public void datosModificados()
        {
            this.precio -= 0.25;
            this.diametro += 1;
        }

        public void listado()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Marca de la pelota: {marca}");
            Console.WriteLine($"Peso en gramos: {peso}");
            Console.WriteLine($"Presión en libras: {presion}");
            Console.WriteLine($"Diametro en centimetro {diametro} cm");
            Console.WriteLine($"Precio: {precio}");
            Console.WriteLine($"Radio de la pelota: {calcularRadio()}");
            Console.WriteLine($"Volumen del balón: {calcularVolumen()}");
            Console.WriteLine($"Descuento: {calcularDesc()}");
            Console.WriteLine($"Importe a pagar: {importaPagar()}");
        }

    }
}
