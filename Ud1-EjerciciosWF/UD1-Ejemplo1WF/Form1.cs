using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_Ejemplo1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (!cbMovie.Items.Contains(txtMovie.Text))
            {

                cbMovie.Items.Add(txtMovie.Text);
                txtMovie.Clear();
            }
            else {

                MessageBox.Show("Esta pelicula ya esta en el listado");

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
