using System.Collections.ObjectModel;

namespace BezorgerApp.Views;

public partial class ProbleemMeldingPage : ContentPage
{
    private ObservableCollection<ImageSource> _photos = new();
    public ProbleemMeldingPage()
	{
        InitializeComponent();
    }

    private async void BackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }



}