using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej4_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car();
            c.Name = "juanele";
            c.TurnOn();


            //Ejemplo 2

            IVehicle motorbike1 = new Motorbike();
            Motorbike motorbike2 = new Motorbike();

            motorbike1.Name = "pepillo";
            motorbike2.Name = "locotron";

            motorbike1.TurnOn();

            motorbike1.Acerelate();

        }
    }
}
