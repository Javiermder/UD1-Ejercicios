using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos una lista que permite almacenar
            //elementos de diferentes tipos pero esto puede
            //provocar errores en tiempo de ejecuvcion y estan obsoletos

            ArrayList list = new ArrayList();
            Console.WriteLine("Lista de elementos:");
            list.Add("hola");
            list.Add(1);
            list.Add(DateTime.Now);

            Console.WriteLine($"Elemento 0: {list[0]}");

            Console.WriteLine($"Elemento 1: {list[1]}");
            Console.WriteLine($"Elemento 2: {list[2]}");
        }
    }
}
