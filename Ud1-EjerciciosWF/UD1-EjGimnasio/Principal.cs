using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjGimnasio
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
       
        private void enlaceClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaClientes ventana = new VentanaClientes();
            ventana.ShowDialog();
        }

        private void enlace2Clikao(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentanaActividades ventana = new VentanaActividades();
            ventana.Show();
            this.Close();
        }
    }
}
