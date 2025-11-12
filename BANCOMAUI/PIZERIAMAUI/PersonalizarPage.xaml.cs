namespace PIZERIAMAUI;

public partial class PersonalizarPage : ContentPage
{
    PizzaPedido pedido;

    public PersonalizarPage(PizzaPedido pedidoRecibido)
    {
        InitializeComponent();
        pedido = pedidoRecibido;
    }



    private async void OnSiguienteClicked(object sender, EventArgs e)
    {
        var ingredientes = new List<string>();
        if (quesoExtra.IsChecked) ingredientes.Add("Queso extra");
        if (jamon.IsChecked) ingredientes.Add("Jamón");
        if (champinones.IsChecked) ingredientes.Add("Champiñones");
        if (aceitunas.IsChecked) ingredientes.Add("Aceitunas");
        if (pimientos.IsChecked) ingredientes.Add("Pimientos");

        pedido.Ingredientes = ingredientes;

        await Navigation.PushAsync(new ConfirmarPage(pedido));
    }
}