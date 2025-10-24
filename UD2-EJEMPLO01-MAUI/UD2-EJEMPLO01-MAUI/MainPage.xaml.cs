
namespace UD2_EJEMPLO01_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSend_Clicked(object sender, EventArgs e) {

            DisplayAlert("Advertencia", "Entrando en el sistenma ", "Aceptar");
        }
      
    }
}
