using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej4_Interfaces
{
    internal class Car : IVehicle

    {
        public string Name { get; set; }

        public void TurnOff()
        {
            Console.WriteLine($"El coche {Name} esta parando");        
        }

        public void TurnOn()
        {
            Console.WriteLine($"El coche {Name} esta arrancando");         
        }
}
}
