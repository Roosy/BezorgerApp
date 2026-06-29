using BezorgerApp.Models;
using BezorgerApp.Views;

namespace BezorgerApp.Views;

public partial class DeliveryComplete : ContentPage
{
    public DeliveryComplete()
	{
		InitializeComponent();
    }
    private async void GoToDeliveryRegistration(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeliveryRegistration());
    }
    
    private async void GoToRitAfrondenPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RitAfrondenPage());
    }

}