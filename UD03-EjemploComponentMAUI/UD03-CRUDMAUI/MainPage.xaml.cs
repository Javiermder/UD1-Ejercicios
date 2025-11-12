namespace UD03_CRUDMAUI
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            ButtonBox.BtnAnadir.Clicked += BtnAnadir_Clicked;
            ButtonBox.BtnModificar.Pressed += BtnModificar_Pressed;
            ButtonBox.BtnModificar.Released += BtnModificar_Released;
            ButtonBox.BtnEliminar.Focused += BtnEliminar_Focused;
            ButtonBox.BtnEliminar.Unfocused += BtnEliminar_Unfocused;
        }

        private void BtnEliminar_Unfocused(object? sender, FocusEventArgs e)
        {
            ImgBot.IsVisible = true;
        }

        private void BtnEliminar_Focused(object? sender, FocusEventArgs e)
        {
            ImgBot.IsVisible = false;
        }

        private void BtnModificar_Released(object? sender, EventArgs e)
        {
            ButtonBox.BtnModificar.TextColor = Colors.Black;
            lbTitle.Text = "Ejemplo Componente MAUI";
        }

        private void BtnModificar_Pressed(object? sender, EventArgs e)
        {
            ButtonBox.BtnModificar.TextColor = Colors.Orange;
            lbTitle.Text = "Boton Modificar pulsado";
        }

        private  void BtnAnadir_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Primer elemento", "Boton 1 pulsao","ACEPTAR");
        }

    }
}
