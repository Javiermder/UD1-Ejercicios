namespace EjMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void CantidadSlider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            var slider = (Microsoft.Maui.Controls.Slider)sender;
            int cant = Convert.ToInt32(slider.Value);
            if (cantidadLabel != null)
                cantidadLabel.Text = $"{cant} pizzas";
        }
    }

}
