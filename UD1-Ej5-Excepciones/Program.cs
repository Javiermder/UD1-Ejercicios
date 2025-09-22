using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej5_Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ruta de un archivo que se encuentra en el ejecutable /bin/debug   

            string rutafichero;


            try
            {
                Console.WriteLine("Escribe el nombre del fichero");

                rutafichero = Console.ReadLine();

                string fichero = File.ReadAllText(rutafichero);
                Console.WriteLine($"{fichero}");

                Console.WriteLine("Operacion realizada correctamente");
                Console.ReadKey();
            }
            catch (UnauthorizedAccessException)
            {
            }


            catch (Exception ex)
            {
                Console.WriteLine($"Error en el fichero: {ex.Message}");
            }
            finally {

                Console.WriteLine("Esta linea se ejecuta siempre por estar en el bloque del finally");
            }

            
        }
    }
}
