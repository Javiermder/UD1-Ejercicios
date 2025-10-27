namespace UD2_BIDING_INOTIFYPROPERTYCHANGED
{
    public partial class MainPage : ContentPage
    {

        //VAMOS A DEFINIR UN OBJETO JOINFULLNAME
        private JoinFullName joinfullname; 

        public MainPage()
        {
            InitializeComponent();
            joinfullname = new JoinFullName("Javi", "Martinez");

            //Una vez creado el objeto establecemos la conexion entre el control y la clase
            BindingContext = joinfullname;

        }

       
    }
}
