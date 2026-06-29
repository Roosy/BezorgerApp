using BezorgerApp.Views;

namespace BezorgerApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void GoToScanPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ScanPage());
    }

    private async void GoToDeliveryRegistration(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeliveryRegistration());
    }

    private async void GoToWerkdagAfgerondPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WerkdagAfgerondPage());
    }
}
