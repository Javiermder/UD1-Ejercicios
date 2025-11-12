using ButtonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_Component1WF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void chbMessage_CheckedChanged(object sender, EventArgs e)
        {
         //chbMessage.Checked ? "buttonControl1.Result = Casilla marcada" : "buttonControl1.Result";

            if(chbMessage.Checked)
            {
                userControl11.Result = "Casilla marcada";
            }
            else
            {
                userControl11.Result = "Casilla desmarcadaa ";
            }

        }
    }
}
