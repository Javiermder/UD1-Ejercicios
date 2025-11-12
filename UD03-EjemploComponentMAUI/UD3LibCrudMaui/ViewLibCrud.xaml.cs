namespace UD3LibCrudMaui;

public partial class ViewLibCrud : ContentView
{
	public Button BtnAnadir { get { return btAnadir; } }
	public Button BtnModificar => btModificar;//Esto es un get como el de arriba pero con otra sintaxis
    public Button BtnEliminar => btEliminar;
    public ViewLibCrud()
	{
		InitializeComponent();
	}
}