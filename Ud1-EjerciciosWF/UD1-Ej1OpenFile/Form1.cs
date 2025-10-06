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

namespace UD1_Ej1OpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                //Recogmos el nombre del fichero y lo leeemoss
                string pathfile = openFileDialog.FileName;

                string[] lines = File.ReadAllLines(pathfile);

                //Vamos a ir leyemdpo linmea a linea el fichero y lo cargamos en el listbox
                listBox.Items.Clear();
                foreach(string line in lines){
                    listBox.Items.Add(line);
                }
            }
        }
    }
}
