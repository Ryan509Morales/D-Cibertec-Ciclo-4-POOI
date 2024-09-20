using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    internal class Edificio
    {
        private int codigo { get; set; }
        private int nDpto { get; set; }
        private int canPisos { get; set; }
        private double precioDpto { get; set; }

        public Edificio(int codigo, int nDpto, int canPisos, double precioDpto)
        {
            this.codigo = codigo;
            this.nDpto = nDpto;
            this.canPisos = canPisos;
            this.precioDpto = precioDpto;
        }

        public double calcularPrecioDolarEdificio()
        {
            return nDpto * precioDpto;
        }

        public void listado()
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Número de Departamentos: {nDpto}");
            Console.WriteLine($"Cantidad de Pisos: {canPisos}");
            Console.WriteLine($"Precio por Departamento: ${precioDpto:F2}");
            Console.WriteLine($"Precio Total del Edificio: ${calcularPrecioDolarEdificio():F2}");
        }

        public void IncrementarPrecio()
        {
            precioDpto *= 0.2;
        }

    }
}
