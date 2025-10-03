using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_Ejemplo2WF
{
    public partial class Componentes : Form
    {
        public Componentes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Crear una variable para guardar todo el mensaje
            string message = "Tu sistema opertivo preferido es ";

            //Comprobamos los radio buttons de los SO
            message += checkRadioButton(rbWindows);
            message += checkRadioButton(rbLinux);
            message += checkRadioButton(rbMac);

            //Comprobamos los checksbox
            message += "tus especialidades son :";

            message += checkCheckBox(chkbIa);
            message += checkCheckBox(chkbMovile);
            message += checkCheckBox(chkbWeb);



            message += message.TrimEnd(new char[] { ' ', ',' });

            //Por ultimo ponemos el numero de horas

            message += " y el numero de horas en el ordenador son ";
            message += $"{nudHour.Value} horas";



            //con esto mostramos el mensaje final
            MessageBox.Show(message);

        }

        private string checkRadioButton(RadioButton rbButton)
        {

            if (rbButton.Checked) {
                return rbButton.Text + ", ";
            }
            return "";


            throw new NotImplementedException();
        }

        private string checkCheckBox(CheckBox chckButton)
        {

            if (chckButton.Checked)
            {
                return chckButton.Text + ", ";
            }
            return "";


            throw new NotImplementedException();
        }
    }
}
