namespace PaginaLoginMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void EntrarBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UtilizadorTxt.Text) || string.IsNullOrEmpty(PalavraPasseTxt.Text))
            {
                DisplayAlert("Erro", "Os campos devem ser preenchidos!", "Ok");
            }
            else
            {
                DisplayAlert("Mensagem", "Login Bem Sucedido!", "Ok");
                UtilizadorTxt.Text=string.Empty;
                PalavraPasseTxt.Text=string.Empty;
            }

        }
    }

}
