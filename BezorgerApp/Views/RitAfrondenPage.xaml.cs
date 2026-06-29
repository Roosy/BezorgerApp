namespace BezorgerApp.Views;

public partial class RitAfrondenPage : ContentPage
{
	public RitAfrondenPage()
	{
		InitializeComponent();
	}

	private async void GoToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}