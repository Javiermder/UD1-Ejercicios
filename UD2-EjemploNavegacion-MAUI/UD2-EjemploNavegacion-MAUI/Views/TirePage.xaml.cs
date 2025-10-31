namespace UD2_EjemploNavegacion_MAUI.Views;

public partial class TirePage : ContentPage
{
	public TirePage()
	{
		InitializeComponent();
	}

    private async void btnMichelin_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MichelinPage());


    }

    private async void btnPirelli_Cliked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PirelliPage());

    }
}