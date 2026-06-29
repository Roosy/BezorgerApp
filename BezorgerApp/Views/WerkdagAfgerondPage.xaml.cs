namespace BezorgerApp.Views;

public partial class WerkdagAfgerondPage : ContentPage
{
	public WerkdagAfgerondPage()
	{
		InitializeComponent();
	}

	private async void GoToMainPage(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}
		
}