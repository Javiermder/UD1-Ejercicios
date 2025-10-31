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
    public partial class VentanaClientes : Form
    {
        List<Cliente> Clientes = new List<Cliente>();
        

        public VentanaClientes()
        {
            InitializeComponent();
        }

        

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Boolean camposCorrectos = comprobarCampos();
            Boolean codigoExiste = comprobarCodigo();

            if( camposCorrectos && codigoExiste)
            {


            }


        }

        private Boolean comprobarCodigo() {

            String codigo = txtCodigo.Text;

            foreach (Cliente c in Clientes) {
                if (c.
            }

            return false;
        }
        

        private Boolean comprobarCampos() {

            if (string.IsNullOrEmpty(txtApellidos.Text)) { return false; }
            if (string.IsNullOrEmpty(txtCiudad.Text)) { return false; }
            if (string.IsNullOrEmpty(txtCodigo.Text)) { return false; }
            if (string.IsNullOrEmpty(txtNombre.Text)) { return false; }
            if (string.IsNullOrEmpty(dtpFecha.Text)) { return false; }

            return true;
        }
    }
}
