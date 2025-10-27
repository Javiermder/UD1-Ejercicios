namespace EJ_COLORMAKER
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void blue_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            actualizarColor();
        }

        private void green_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            actualizarColor();
        }

        private void red_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            actualizarColor();
        }

        private void actualizarColor() {

            int red = Convert.ToInt32(redS.Value);
            int green = Convert.ToInt32(greenS.Value);
            int blue = Convert.ToInt32(blueS.Value);

            Color micolor = new Color(red, green, blue);

            backcolor.BackgroundColor = micolor;

            string colorHexadecimal = $"{ red:X2}{green:X2}{blue:X2}";


            hexadecimal.Text = colorHexadecimal;
        }




        private void RandomColor(object sender, EventArgs e)
        {
            Random rand = new Random();

            int red = Convert.ToInt32(rand.NextInt64(0, 255));
            int green = Convert.ToInt32(rand.NextInt64(0, 255));
            int blue = Convert.ToInt32(rand.NextInt64(0, 255));

            Color colorAleatorio = new Color(red, green, blue);

            backcolor.BackgroundColor = colorAleatorio;

            string colorHexadecimal = $"{red:X2}{green:X2}{blue:X2}";


            hexadecimal.Text = colorHexadecimal;
        }
    }
}
