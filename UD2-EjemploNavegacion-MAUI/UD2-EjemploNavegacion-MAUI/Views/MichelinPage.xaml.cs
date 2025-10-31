using System.Threading.Tasks;

namespace UD2_EjemploNavegacion_MAUI.Views;

public partial class MichelinPage : ContentPage
{
	public MichelinPage()
	{
		InitializeComponent();
	}

  

    private async void btnBack_Clicked(object sender, EventArgs e)
    {
       // await Navigation.PopAsync();
        await Shell.Current.GoToAsync("..");

    }

    private async void btnRoot_Clicked(object sender, EventArgs e)
    {
        //await Navigation.PopToRootAsync();

        await Shell.Current.GoToAsync("//MainPage");
    }
}