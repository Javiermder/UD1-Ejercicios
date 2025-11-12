using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZERIAMAUI
{
    public class PizzaPedido
    {
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public List<string> Ingredientes { get; set; } = new();
    }
}
