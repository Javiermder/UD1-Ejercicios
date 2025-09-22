using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjPrueba_AplicacionCasaTerror
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CasaDelTerror c = new CasaDelTerror("Casa Pepe", 14, 130, 5.50, 5);

            Console.WriteLine("CASA DEL TERROR");
            Console.WriteLine("introduzca su edad");
            int Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca su altura");
            int Altura = Convert.ToInt32(Console.ReadLine());
            if (c.AdmitirVisitante(Edad, Altura)) {
                Console.WriteLine("Bienvenido a la casa del terror");
                Console.WriteLine($"{c.Nombre}");
            }else
            {
                Console.WriteLine("No cumples los requisitos");
            }

        }
    }
}
