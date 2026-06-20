namespace BezorgerApp;

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
}