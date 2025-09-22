using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej2_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar la clase
            Person persona1 = new Person();
            persona1.MostrarInformacion();

            persona1.name = "Alberto";
            persona1.SetSalary(-3000);

            persona1.MostrarInformacion();
        }

        
    }
}
