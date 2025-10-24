using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EJBebidas
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            String bebida = txtNombreBebida.Text;
            lstBebidas.Items.Add(bebida);
            txtNombreBebida.Text = "";
        }

        private void lstBebidas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstBebidas != null) {
                btnEliminar.IsEnabled = true;
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            lstBebidas.Items.Remove(lstBebidas.SelectedItem);
        }
    }
}
