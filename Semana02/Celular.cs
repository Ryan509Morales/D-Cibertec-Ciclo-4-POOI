using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    internal class Celular
    {
        private int numero { get; set; }
        private string usuario { get; set; }
        private int segundos { get; set; }
        private double precio { get; set; }

        public Celular(int numero, string usuario, int segundos, double precio)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundos = segundos;
            this.precio = precio;
        }

        public double calcularCostoConsumo()
        {
            return segundos * precio;
        }

        public double calcularIGV()
        {
            return calcularCostoConsumo() * 0.18;
        }

        public double calcularTotalPagar()
        {
            return calcularCostoConsumo() + calcularIGV();
        }

        public void mostrarDatos()
        {
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Usuario: {usuario}");
            Console.WriteLine($"Segundos: {segundos}");
            Console.WriteLine($"Precio por segundo: {precio:C}");
            Console.WriteLine($"Costo por consumo: {calcularCostoConsumo():C}");
            Console.WriteLine($"Impuesto IGV: {calcularIGV():C}");
            Console.WriteLine($"Total a pagar: {calcularTotalPagar():C}");
            Console.WriteLine();
        }

        public void actualizarDatos()
        {
            this.segundos += 20;
            this.precio *= 0.95;
        }
    }
}
