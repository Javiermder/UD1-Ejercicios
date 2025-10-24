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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UD2_EJ1_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cbPeli.Items.Add(tbPeli.Text);
            tbPeli.Text = "";
        }

        private void cbPeli_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Has seleccionado la pelicula: " +cbPeli.SelectedItem);
        }
    }
}
