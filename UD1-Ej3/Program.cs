using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Steak pig = new Steak("solomillo", 350.50);
            pig.MakeFood();
        }
    }
}
