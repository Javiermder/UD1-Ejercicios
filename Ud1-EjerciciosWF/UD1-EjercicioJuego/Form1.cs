using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjercicioJuego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            int numeroSecreto = Convert.ToInt32(number.Text);

            if (numeroSecreto < 0 || numeroSecreto > 100)
            {
                MessageBox.Show("El numero debe de estar entre 0 y 100");
            }
            else {
            
                

            }

                panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
