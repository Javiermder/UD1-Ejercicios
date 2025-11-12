namespace PIZERIAMAUI;

public partial class ConfirmarPage : ContentPage
{
    PizzaPedido pedido;
    public ConfirmarPage(PizzaPedido pedidoRecibido)
    {
        InitializeComponent();
        pedido = pedidoRecibido;

        resumenLabel.Text = $"Tipo de pizza: {pedido.Tipo}\n" +
                            $"Cantidad: {pedido.Cantidad}\n" +
                            $"Ingredientes adicionales: {string.Join(", ", pedido.Ingredientes)}\n" +
                            $"Fecha de entrega: {DateTime.Now.AddDays(1):MM/dd/yyyy}";
    }
   

    

    private async void OnConfirmarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Pedido Confirmado", resumenLabel.Text, "OK");
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}