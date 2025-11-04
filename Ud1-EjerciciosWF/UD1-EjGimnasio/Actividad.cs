using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjGimnasio
{
    internal class Actividad
    {
        public String Codigo { get; set; }

        public String Nombre { get; set; }
        public String Sala { get; set; }
        public String Descripcion { get; set; }

        public Actividad(String codigo, String nombre, String sala, String descripcion)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Sala = sala;
            this.Descripcion = descripcion;
        }
    }
}
