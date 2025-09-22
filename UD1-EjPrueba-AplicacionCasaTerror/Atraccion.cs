using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjPrueba_AplicacionCasaTerror
{
    public class Atraccion
    {
         public string Nombre { get; set; }
         public int EdadMinima;
         public int AlturaMinima;
         double Precio;


        
        public Atraccion(string nombre, int edadMinima, int alturaMinima, double precio)
        {
            Nombre = nombre;
            EdadMinima = edadMinima;
            AlturaMinima = alturaMinima;
            Precio = precio;
        }

        public bool AdmitirVisitante(int Edad, int Altura)
        {
            bool booleana = true;

            if (Edad < EdadMinima && Altura < AlturaMinima) {
                booleana = false;
            }

            return booleana;
        }
    }
}
