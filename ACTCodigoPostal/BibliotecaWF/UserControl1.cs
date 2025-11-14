using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaWF
{
    public partial class UserControl1 : UserControl
    {
        // Lista de códigos postales válidos
        private List<string> codigosValidos = new List<string> { "14001", "14002", "14003", "14004", "14005" };

        public UserControl1()
        {
            InitializeComponent();
            InicializarComboBox();
            btnBuscar.Click += BtnBuscar_Click;
            lstResultados.SelectedIndexChanged += LstResultados_SelectedIndexChanged;
        }

        private void InicializarComboBox()
        {
            cmbCodigos.Items.Clear();
            cmbCodigos.Items.AddRange(codigosValidos.ToArray());
            cmbCodigos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBuscar.Text.Trim();
            lstResultados.Items.Clear();


            var resultados = codigosValidos.Where(c => c.Contains(termino)).ToList();

          
                foreach (var codigo in resultados)
                {
                    lstResultados.Items.Add(codigo);
                }
            
        }

        private void LstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
     

            string seleccionado = lstResultados.SelectedItem.ToString();

            cmbCodigos.SelectedItem = seleccionado;
        }

  

    

        private void cbCodigos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
