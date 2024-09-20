using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    internal class Obrero
    {
        private int codigo { get; set; }
        private string nombre { get; set; }
        private int htrabajado { get; set; }
        private double tarifa { get; set; }

        public Obrero(int codigo, string nombre, int htrabajado, double tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.htrabajado = htrabajado;
            this.tarifa = tarifa;
        }

        public double calcularSueldoBruto()
        {
            return htrabajado * tarifa;
        }

        public double calcularDescAFP()
        {
            return calcularSueldoBruto() * 0.1;
        }

        public double calcularDescEPS()
        {
            return calcularSueldoBruto() * 0.05;
        }

        public double calcularSueldoNeto()
        {
            return calcularSueldoBruto() - calcularDescAFP() - calcularDescEPS();
        }

        public void listado()
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Horas Trabajadas: {htrabajado}");
            Console.WriteLine($"Tarifa por Hora: ${tarifa:F2}");
            Console.WriteLine($"Sueldo Bruto: ${calcularSueldoBruto():F2}");
            Console.WriteLine($"Descuento AFP: ${calcularDescAFP():F2}");
            Console.WriteLine($"Descuento EPS: ${calcularDescEPS():F2}");
            Console.WriteLine($"Sueldo Neto: ${calcularSueldoNeto():F2}");
        }

        public void modificar()
        {
            this.htrabajado += 8;
            this.tarifa -= 0.015;
        }
    }
}
