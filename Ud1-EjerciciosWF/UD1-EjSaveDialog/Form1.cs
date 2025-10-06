using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjSaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                saveFileDialog.Filter = "Text files(*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    //Recogemos el nombre del fichero y lo guardamos

                    string filename = saveFileDialog.FileName;
                    StreamWriter file = new StreamWriter(filename);

                    file.WriteLine($"Usuario:{txtName.Text} y contraseña:{txtPassword.Text}");
                    file.Close();


                    txtName.Clear();
                    txtPassword.Clear();
                }

            }
            catch (Exception ex) {

                MessageBox.Show($"Error al guardar el fuchero : " + ex.Message);
            }
            }

        private void btnFontUser_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK) 
            {
                label2.Font = fontDialog.Font;
                label3.Font = fontDialog.Font;
            }
        }
    }
}
