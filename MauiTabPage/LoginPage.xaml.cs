namespace MauiTabPage;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Aqui voc� poderia implementar a l�gica de autentica��o
        // Por enquanto, vamos apenas navegar para a p�gina principal
        App.Current.MainPage = new NavigationPage(new MenuPrincipal());
        //await Navigation.PushAsync(new MenuPrincipal());
        //Navigation.RemovePage(this);
    }
}