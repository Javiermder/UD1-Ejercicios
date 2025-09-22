using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjPrueba_AplicacionCasaTerror
{
    public class CasaDelTerror : Atraccion
    {
        private int NivelDeMiedo;

        public CasaDelTerror(string Nombre, int EdadMinima, int AlturaMinima, double Precio, int NivelDeMiedo)
            : base(Nombre, EdadMinima, AlturaMinima, Precio)
        {
            this.NivelDeMiedo = NivelDeMiedo;
        }

        public new bool AdmitirVisitante(int Edad, int Altura)
        {
            bool aceptado= false;
            if (Edad > EdadMinima && Altura > AlturaMinima) {
                aceptado = true;
            }

            return  aceptado;
        }
    }
}

