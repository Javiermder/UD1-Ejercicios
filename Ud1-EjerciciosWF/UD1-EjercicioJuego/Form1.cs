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
        int numeroSecreto;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (txNumber.Text == "")
            {
                MessageBox.Show("Debe de introducir un numero");
            }
            else {

                int numeroSecreto = Convert.ToInt32(txNumber.Text);
                if (numeroSecreto < 0 || numeroSecreto > 99)
                {
                    MessageBox.Show("El numero debe de estar entre 0 y 100");
                }
                else
                {

                    panel1.Visible = false;
                    panel2.Visible = true;

                    


                   
                }

            }


         
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            int intentos = 5;

            do
            {
                number.Text = intentos.ToString();

                if (!testNumber.Text.Equals(numeroSecreto))
                {
                    intentos--;
                    int n = Convert.ToInt32(testNumber.Text);
                    if (n > numeroSecreto)
                    {
                        MessageBox.Show("El numero introducido es mas grande que el numero secreto, te" +
                            $"quedan {intentos}");

                    }
                    else
                    {
                        MessageBox.Show("El numero introducido es mas chico que el numero secreto, te" +
                            $"quedan {intentos}");

                    }
                }
            }
            while (!number.Text.Equals(0));
        }
    }
}
