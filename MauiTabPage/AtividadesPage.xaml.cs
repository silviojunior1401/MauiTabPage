namespace MauiTabPage;

public partial class AtividadesPage : ContentPage
{
	public AtividadesPage()
	{
		InitializeComponent();
	}

    private async void OnAddActivityClicked(object sender, EventArgs e)
    {
        // Aqui voc� implementaria a l�gica para adicionar uma nova atividade
        // Por enquanto, vamos apenas mostrar um alerta
        await DisplayAlert("Adicionar Atividade", "Funcionalidade para adicionar nova atividade f�sica", "OK");
    }
}