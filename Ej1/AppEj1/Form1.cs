using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = userControl11.Usuario;
            String contraseña = userControl11.Contraseña;

            Regex soloLetras = new Regex("^[a-zA-Z]+$");

            if (soloLetras.IsMatch(usuario))
            {
            
            }

            }
        }
}
