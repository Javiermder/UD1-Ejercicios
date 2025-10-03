using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej6_list
{
    internal class Program
    {
        static List<Chrome> listchromes = new List<Chrome>();
        static void Main(string[] args) {

            //Queremos crear una lista auziliar
            List<Chrome> auxiliarList = new List<Chrome>()
            {
                new Chrome(6, "a", Chrome.CategoryChrome.Silver),
                new Chrome(7, "b", Chrome.CategoryChrome.Silver),
             new Chrome(8, "c", Chrome.CategoryChrome.Silver)
            };



            //VAmos a crear un listado de cromos
            Chrome chrome1 = new Chrome(1, "Pikachu", Chrome.CategoryChrome.Silver);

            listchromes.Add(chrome1);

            Chrome chrome2 = new Chrome();

            chrome2.CodeChrome = 5;
            chrome2.NameChrome = "Vegeta";
            chrome2.Categories = Chrome.CategoryChrome.Bronze;

            listchromes.Add(chrome2);

            //Vamos a mostrar los cromos adaptando la interfaz de consola
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"Lista de cromos iniciales:");

            foreach (Chrome cromo in listchromes)
            {

                Console.WriteLine($"Cromo con codigo {cromo.CodeChrome}, nombre {cromo.NameChrome} y categoria {cromo.Categories}");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Lista de cromos finales:");

            listchromes.Remove(chrome1);

            MarchChromes();

            //Comprobar si existe un chromo
            bool existChrome = listchromes.Contains(chrome1);
            Console.WriteLine($"Existe el cromo 1 :  {existChrome}");


            listchromes.AddRange(auxiliarList);

            MarchChromes();

        }
            static void MarchChromes()
            {
                foreach (Chrome cromo in listchromes)
                {

                    Console.WriteLine($"Cromo con codigo {cromo.CodeChrome}, nombre {cromo.NameChrome} y categoria {cromo.Categories}");
                }
            }


        }
    }

