namespace PIZERIAMAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSiguienteClicked(object sender, EventArgs e)
        {
            var pedido = new PizzaPedido
            {
                Tipo = tipoPizzaPicker.SelectedItem?.ToString(),
                Cantidad = (int)cantidadStepper.Value
            };

            await Navigation.PushAsync(new PersonalizarPage(pedido));
        }
    }
}
