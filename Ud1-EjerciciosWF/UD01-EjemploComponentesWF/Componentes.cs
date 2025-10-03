using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD01_EjemploComponentesWF
{
    public partial class Form1 : Form
    {

        private int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //Uso del componente errorProvider

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                errorUser.SetError(txtUser, "En este campo debes de escribir un nombre");
            }
            else {
                errorUser.Clear();
                lbUser.Text = txtUser.Text;
                lbUser.Visible = true;
                lvUser.Items.Add(txtUser.Text);

                txtUser.Clear();
                txtUser.Focus();
                timer1.Start();
                
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvUser_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void lvUser_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            seconds++;

            if (seconds == 5) {
                lbTimer.Visible = false;
                timer1.Stop();
                seconds = 0;
            }
            lbTimer.Text = DateTime.Now.ToString("hh:mm:ss");
            lbTimer.Visible = true;
        }
    }
}
