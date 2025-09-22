using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej4_Interfaces
{
    internal interface IVehicle
    {
        //Propiedades

         string Name { get; set; }
        //Metodos
        void TurnOn();
        void TurnOff();

    }
}
