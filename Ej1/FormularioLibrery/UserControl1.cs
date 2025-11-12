using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLibrery
{
    public partial class UserControl1 : UserControl
    {
        public String Usuario { get { return tbUsuario.Text; } set { tbUsuario.Text = value; } }
        public String Contraseña { get { return tbContraseña.Text; } set { tbContraseña.Text = value; } }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length > 0)
            {

                tbContraseña.Enabled = true;

            }
            else
            {
                tbContraseña.Enabled = false;
                tbContraseña.Text = "";
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if(tbUsuario.Text.Length <5 || tbUsuario.Text.Length > 15)
            {
                MessageBox.Show("El usuario debe tener entre 5 y 15 caracteres");
                tbUsuario.Focus();
            }
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
