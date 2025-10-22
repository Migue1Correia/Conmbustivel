namespace Conmbustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e ) 
        {
            try 
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string resultado = "";

                if (etanol <= (gasolina * 0.7))
                {
                    resultado = "Etanol esta compenssando. ";
                }
                else
                {
                    resultado = "Gasolina esta compenssando. ";
                }

                DisplayAlert("Resultado", resultado, "OK");


            } catch (Exception ex) 
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }

        }

 
    }
}
