using System.Collections.ObjectModel;

namespace EJEMPLOS_MAUI
{
    public partial class MainPage : ContentPage
    {
        // Usamos ObservableCollection por si en el futuro quieres añadir/quitar elementos dinámicamente
        public ObservableCollection<string> Transactions { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Lista de operaciones
            var operaciones = new ObservableCollection<string>
        {
            "Compra supermercado - $50.75 - 08/08/2024",
            "Pago servicios - $100.00 - 09/08/2024",
            "Transferencia recibida - $200.00",
            "Retiro cajero - $80.00",
            "Depósito - $500.00",
            "Pago tarjeta - $150.00",
            "Compra online - $75.00",
            "Transferencia enviada - $120.00",
            "Recarga móvil - $20.00",
            "Pago servicios - $90.00"
        };

            // Asignar la lista directamente al CollectionView
            OperacionesView.ItemsSource = operaciones;


        }


    }
}

