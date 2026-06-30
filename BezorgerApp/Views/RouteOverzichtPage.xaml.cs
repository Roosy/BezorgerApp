namespace BezorgerApp.Views;

public partial class RouteOverzichtPage : ContentPage
{
    public RouteOverzichtPage()
    {
        InitializeComponent();
    }

    private async void RouteStarten_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeliveryRegistration());
    }
}