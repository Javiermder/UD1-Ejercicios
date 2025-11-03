using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjGimnasio
{
    public class Cliente
    {

        public String codigo { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNac { get; set; }
        public String ciudad { get; set; }

        public String telefono { get; set; }

        public Cliente(String Codigo, String Nombre, String Apellidos, DateTime FechaNac, String Ciudad, String Telefono) {
        
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.apellidos = Apellidos;
            this.fechaNac = FechaNac;
            this.ciudad = Ciudad;
            this.telefono = Telefono;
        
        }

    }
}
