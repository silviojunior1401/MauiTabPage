namespace MauiTabPage;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Aqui você poderia implementar a lógica de autenticação
        // Por enquanto, vamos apenas navegar para a página principal
        App.Current.MainPage = new NavigationPage(new MenuPrincipal());
        //await Navigation.PushAsync(new MenuPrincipal());
        //Navigation.RemovePage(this);
    }
}