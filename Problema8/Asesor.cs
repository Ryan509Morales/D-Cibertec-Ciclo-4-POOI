using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    internal class Asesor
    {
        private int codigo { get; set; }

        private string nombre { get; set; }
        private int horas { get; set; }
        private double tarifa { get; set; }

        public Asesor(int codigo, string nombre, int horas, double tarifa)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horas = horas;
            this.tarifa = tarifa;
        }

        public double calcularSueldoBruto()
        {
            return horas * tarifa;
        }

        public double calcularDesc()
        {
            return calcularSueldoBruto() * 0.15;
        }

        public double calcularSueldoNeto()
        {
            return calcularSueldoBruto() - calcularDesc();
        }

        public void modificarDatos()
        {
            this.horas += 10;
            this.tarifa -= 0.15;
        }

        public void listado()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Codigo del asesor: {codigo}");
            Console.WriteLine($"Nombre del asesor: {nombre}" );
            Console.WriteLine($"Horas trabajadas: {horas}");
            Console.WriteLine($"Tarifa por hora: {tarifa}");
            Console.WriteLine($"Sueldo Bruto: {calcularSueldoBruto()}");
            Console.WriteLine($"Descuento: {calcularDesc()}");
            Console.WriteLine($"Sueldo Neto: {calcularSueldoNeto()}");
        }


    }
}
