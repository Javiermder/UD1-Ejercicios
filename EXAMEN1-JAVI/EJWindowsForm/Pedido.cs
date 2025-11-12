using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJWindowsForm
{
    public class Pedido
    {
        public String Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int Codigo_Pedido { get; set; }

        public Pedido(string descripcion, DateTime fecha, int codigo_Pedido)
        {
            Descripcion = descripcion;
            Fecha = fecha;
            Codigo_Pedido = codigo_Pedido;
        }
    }
}
