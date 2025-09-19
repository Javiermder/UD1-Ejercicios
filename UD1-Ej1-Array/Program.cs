using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej1_Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declaración de un Array de Palabras
            string[] words = new string[3];
            int count = 0;

            //Introducimos datos en el array
            while (count < words.Length) {
                
                Console.WriteLine($"Escribe la palabra numero  {count+1}  : ");
                words[count] = Console.ReadLine();
                count++;
            }

            Console.WriteLine("Contenido del array:");

            foreach (string word in words) {
                Console.WriteLine(word);
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

        }
    }
}
