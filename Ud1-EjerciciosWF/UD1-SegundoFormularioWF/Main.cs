using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_SegundoFormularioWF
{
    public partial class Main : Form
    {
        private Form formstudent, formteachers, formfamily;
        public Main()
        {
            InitializeComponent();
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                if (formstudent == null || formstudent.IsDisposed)
                {
                    //Creamos a ventana de alumnado

                    formstudent = new FormStudent();
                    formstudent.Show();

                }
                else {

                    formstudent.BringToFront();

                }
            }
            if (rbTeacher.Checked)
            {
                if (formteachers == null || formteachers.IsDisposed)
                {

                    //Creamos a ventana de profezo

                    formteachers = new FormTeachers();
                    formteachers.Show();
                }
                else
                {

                    formteachers.BringToFront();

                }
            }


            if (rbFamily.Checked) {

                formfamily = new Form();
                formfamily.Show();
            
            }
        }
    }
}
