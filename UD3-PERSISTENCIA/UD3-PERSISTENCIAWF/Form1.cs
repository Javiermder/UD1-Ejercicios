using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_PERSISTENCIAWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Al iniciar la aplicacion cargamos las propiedades guardadas
            txtUser.Text = Properties.Settings.Default.UserName;
            this.BackColor = Properties.Settings.Default.ColorUser;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            //Vamos a guardar la configuracion del usuario y color 
            //en las propiedades de la aplicacion

            Properties.Settings.Default.UserName = txtUser.Text;
            Properties.Settings.Default.ColorUser = this.BackColor;
            Properties.Settings.Default.Save();

            MessageBox.Show("Configuración guardada","INFORMACION", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }
    }
}
