namespace UD2_EjemploNavegacion_MAUI.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void imgBtnTire_Clicked(object sender, EventArgs e)
    {
        // await Navigation.PushAsync(new TirePage());

        await Shell.Current.GoToAsync(nameof(TirePage));
    }

    private async void imgBtnQuote_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(QuotePage));

    }

    private async void imgBtnContact_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ContactPage));

    }
}