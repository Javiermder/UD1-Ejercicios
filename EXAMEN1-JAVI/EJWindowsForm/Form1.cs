using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJWindowsForm
{
    public partial class Form1 : Form
    {
        List<Pedido> pedidos = new List<Pedido>();
        public Form1()
        {
            InitializeComponent();
        }

        Pedido p1 = new Pedido("Placa Base Asus", DateTime.Now, 10);
        Pedido p2 = new Pedido("Disco Duro SSD", DateTime.Now, 20);
        Pedido p3 = new Pedido("Tarjeta Grafica ATI", DateTime.Now, 30);

        private void btnAñadirClick(object sender, EventArgs e)
        {
            pedidos.Clear();

            pedidos.Add(p1);
            pedidos.Add(p2);
            pedidos.Add(p3);


            recargar();
            
        }

        private void recargar() {
            lvPedidos.Items.Clear();

            foreach (Pedido p in pedidos)
            {
                ListViewItem item = new ListViewItem(p.Descripcion);
                item.SubItems.Add(Convert.ToString(p.Fecha));
                item.SubItems.Add(Convert.ToString(p.Codigo_Pedido));
                lvPedidos.Items.Add(item);

            }

        }

        private void btnEliminarClick(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(number.Value);
            Boolean b = false;
            foreach (Pedido p in pedidos)
            {

                if (p.Codigo_Pedido == numero)
                {
                    b = true;
                    pedidos.Remove(p);
                    recargar();
                    MessageBox.Show("Pedido eliminado correctamente", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            if (!b)
            {
                MessageBox.Show("Codigo de pedido no encontrado", "Mal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void btnLimpiarClick(object sender, EventArgs e)
        {
            pedidos.Clear();
            
            recargar();
        }
    }
}
