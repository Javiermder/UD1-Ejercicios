using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonLibrary
{
    public partial class UserControl1: UserControl
    {
        public string Result { get => lbResult.Text; set
            {
                lbResult.Text = value;
             }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }

        private void lbResult_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnPost_MouseHover(object sender, EventArgs e)
        {
            btnPost.ForeColor = Color.Red;
            btnPost.BackColor = Color.Orange;
        }

        private void btnPost_MouseLeave(object sender, EventArgs e)
        {
            btnPost.ForeColor = Color.Black;
            btnPost.BackColor = Control.DefaultBackColor;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            lbResult.Text = "Formulario enviado";
            lbResult.Visible = true;
        }
    }
}
