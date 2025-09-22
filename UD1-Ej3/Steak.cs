using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej3
{
    public class Steak : Ingredient
    {
        public Steak(string name, double count) : base(name, count){}

        public void MakeFood() {
            Console.WriteLine($"haciend {Count} a la brasa de filete de {Name}");
        }
    }
}
