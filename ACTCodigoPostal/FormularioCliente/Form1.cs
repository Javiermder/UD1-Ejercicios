using BibliotecaWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioCliente
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = txtNombre.Text;
            lblApellido.Text = txtApellido.Text;
            //AQUI HAY Q PONER EL NAME DEL USERCONTROL QUE TENGAMOS EN EL DISEÑADOR
            lblCodigo.Text = userControl12.CodigoSeleccionado;
            groupBox1.Visible = true;
        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
