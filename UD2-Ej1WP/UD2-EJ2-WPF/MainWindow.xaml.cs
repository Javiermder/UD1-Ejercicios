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

namespace UD2_EJ2_WPF
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String color = ((ComboBoxItem)cbColor.SelectedItem).Content.ToString();

            if (color == "Rojo")
                panel.Background = Brushes.Red;
            else if (color == "Verde")
                panel.Background = Brushes.Green;
            else if (color == "Azul")
                panel.Background = Brushes.Blue;

        }
    }
}
