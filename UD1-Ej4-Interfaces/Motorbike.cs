using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej4_Interfaces
{
    internal class Motorbike : IVehicle
    {
        public string Name { get ; set ; }

        public void TurnOff()
        {
            Console.WriteLine($"El moto {Name} esta parrando");
        }

        public void TurnOn()
        {
            Console.WriteLine($"El moto {Name} esta arrancando");
        }

        //A parte de los metodos de la interfaz podemos crear nuestros propios metodos (este metodo no es accesible)
        public void Acerelate() {
            Console.WriteLine($"Moto {Name} acelerando");
        }
    }
}
