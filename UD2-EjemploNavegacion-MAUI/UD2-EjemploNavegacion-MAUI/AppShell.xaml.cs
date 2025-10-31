namespace UD2_EjemploNavegacion_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.ContactPage), typeof(Views.ContactPage));
            Routing.RegisterRoute(nameof(Views.MichelinPage), typeof(Views.MichelinPage));
            Routing.RegisterRoute(nameof(Views.PirelliPage), typeof(Views.PirelliPage));
            Routing.RegisterRoute(nameof(Views.QuotePage), typeof(Views.QuotePage));
            Routing.RegisterRoute(nameof(Views.TirePage), typeof(Views.TirePage));
        }
    }
}
