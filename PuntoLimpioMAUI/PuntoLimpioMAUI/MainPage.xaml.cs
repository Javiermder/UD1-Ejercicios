using System.Collections.ObjectModel;

namespace PuntoLimpioMAUI
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Residuo> residuos = new ObservableCollection<Residuo>();
        public MainPage()
        {
            InitializeComponent();
            residuosCollectionView.ItemsSource = residuos;
        }

        private void agregarResiduoClicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(nombreResiduo.Text) || string.IsNullOrWhiteSpace(tipoResiduo.Text) 
                || string.IsNullOrEmpty(tipoCantidad.Text))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            if(!int.TryParse(tipoCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                DisplayAlert("Error", "Por favor, ingrese una cantidad válida.", "OK");
                return;
            }

            string nombre = nombreResiduo.Text;
            string tipo = tipoResiduo.Text;
            Residuo nuevoResiduo = new Residuo(nombre, tipo, cantidad);
            foreach (Residuo r in residuos ){

                if (r.Nombre.Equals(nuevoResiduo.Nombre)){ 
                    r.Cantidad += nuevoResiduo.Cantidad;
                    return;
                }
                    
            }
            residuos.Add(nuevoResiduo);

            nombreResiduo.Text = "";
            tipoResiduo.Text = "";
            tipoCantidad.Text = "";
        }

        private async void borrarResiduoClicked(object sender, EventArgs e)
        {
            string nombreABorrar = nombreResiduo.Text;

            
            if (string.IsNullOrWhiteSpace(nombreABorrar))
            {
                await DisplayAlert("Error", "Por favor, ingrese el nombre del residuo a borrar.", "OK");
                return;
            }

            bool encontradoYBorrado = false;

            
            for (int i = residuos.Count - 1; i >= 0; i--)
            {
                
                Residuo r = residuos[i];

                if (r.Nombre.Equals(nombreABorrar))
                {
                    residuos.RemoveAt(i);
                    encontradoYBorrado = true;
                    break;
                }
            }

            if (encontradoYBorrado)
            {
                await DisplayAlert("Éxito", $"Residuo '{nombreABorrar}' eliminado.", "OK");
            }
            else
            {
                await DisplayAlert("Aviso", $"No se encontró ningún residuo con el nombre '{nombreABorrar}'.", "OK");
            }

            nombreResiduo.Text = "";
            tipoResiduo.Text = "";
            tipoCantidad.Text = "";

        }
        private void ResiduoSeleccionado(object sender, SelectionChangedEventArgs e)
        {
            // 1. Verificar si realmente se seleccionó un elemento
            if (e.CurrentSelection.FirstOrDefault() is Residuo residuoSeleccionado)
            {
                // 2. Si hay un elemento seleccionado, desglosar su información

                // Asignar los valores del objeto Residuo a los campos Entry.
                // Asumo que tus Entrys se llaman: nombreResiduo, tipoResiduo, y tipoCantidad.

                nombreResiduo.Text = residuoSeleccionado.Nombre;
                tipoResiduo.Text = residuoSeleccionado.Tipo;

                // La cantidad es un 'int' en la clase Residuo, pero el Entry espera un 'string'.
                // Usamos .ToString() para la conversión.
                tipoCantidad.Text = residuoSeleccionado.Cantidad.ToString();
            }

            // 3. Deseleccionar el elemento inmediatamente (Opcional, pero recomendado)
            // Esto es útil para que el usuario pueda volver a hacer clic en el mismo elemento 
            // y para que la lista no se quede con un elemento resaltado.
            if (sender is CollectionView collectionView)
            {
                collectionView.SelectedItem = null;
            }
        }
    }
}
