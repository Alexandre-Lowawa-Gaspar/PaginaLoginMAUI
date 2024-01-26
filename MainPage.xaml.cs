namespace PaginaLoginMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void EntrarBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UtilizadorTxt.Text) || string.IsNullOrEmpty(PalavraPasseTxt.Text))
            {
               await DisplayAlert("Erro", "Os campos devem ser preenchidos!", "Ok");
            }
            else
            {
               await DisplayAlert("Mensagem", "Login Bem Sucedido!", "Ok");
                UtilizadorTxt.Text=string.Empty;
                PalavraPasseTxt.Text=string.Empty;
            }

        }
    }

}
