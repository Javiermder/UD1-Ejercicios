using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej9_Gimnasio
{
    public class Cliente
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int CodigoCliente { get; set; }

        public Cliente() { }

        public Cliente(String nombre, String apellidos, int codigo) {

            Nombre = nombre;
            Apellidos = apellidos;
            CodigoCliente = codigo;

        }
    }
}
