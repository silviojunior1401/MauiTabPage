using System.Globalization;

namespace MauiTabPage;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();

		DateTime d = DateTime.Now;

        lblTodayDate.Text = $"Hoje, {d.Day} de {d.ToString("MMMM", new CultureInfo("pt-BR"))} de {d.Year}";
    }
}