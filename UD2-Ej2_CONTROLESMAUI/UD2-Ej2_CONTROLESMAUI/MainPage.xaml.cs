namespace UD2_Ej2_CONTROLESMAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("BOTON DE LA IMAGEN", "Boton de la imagen pulsao", "ACEPTAR");

        }
    }
}
