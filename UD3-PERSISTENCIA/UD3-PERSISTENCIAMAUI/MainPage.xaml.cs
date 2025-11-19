using System.Threading.Tasks;

namespace UD3_PERSISTENCIAMAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLoad_Clicked(object sender, EventArgs e)
        {
            TxtName.Text = Preferences.Get("UserName", string.Empty);
            TxtEmail.Text = Preferences.Get("UserMail", string.Empty);
            var budget = Preferences.Get("UserBudget", 0.0);
            
             TxtBudget.Text = budget.ToString();
            
            var destiny = Preferences.Get("UserDestiny", string.Empty);
            if (!string.IsNullOrEmpty(destiny))
            {
                //ESTO FUNCIONA DIRECTAMENTE
                //PickDestiny.SelectedItem = destiny;

                //Vamos a sacar de la lista pickdestiny los elementos en una lista de string
                var list = PickDestiny.ItemsSource.Cast<string>().ToList();

                //Buscamos el indice del elemento que coincide con destiny
                var index = list.IndexOf(destiny);
                if (index != -1)
                {
                    PickDestiny.SelectedIndex = index;
                }

            }

        }

        private void BtnDeleteForm_Clicked(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtBudget.Text = string.Empty;
            PickDestiny.SelectedIndex = -1;
        }

        private async void BtnDeleteSesion_Clicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("CONFIRMACIÓN", "¿Estás seguro de eliminar la configuración guardada?", "SI", "NO");

            if (confirm)
            {
                Preferences.Clear();
            }
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            //Vamos a guardar los datos del formulario en el dispositivo
            Preferences.Set("UserName", TxtName.Text ?? string.Empty);
            Preferences.Set("UserMail", TxtEmail.Text ?? string.Empty);

            var numberBudget = double.TryParse(TxtBudget.Text, out double budget);

            if (numberBudget)
            {
                Preferences.Set("UserBudget", TxtBudget.Text ?? string.Empty);

            }
            else
            {

                await DisplayAlert("ERROR", "El presupuesto debe ser un valor numérico", "OK");
                return;
            }

            if (PickDestiny.SelectedIndex != -1)
            {
                Preferences.Set("UserDestiny", PickDestiny.SelectedItem.ToString() ?? string.Empty);
            }
            else
            {

                await DisplayAlert("ERROR", "No se a elegido destino", "OK");
                return;
            }

            await DisplayAlert("INFORMACION", "Configuración guardada", "OK");
        }
    }
}
