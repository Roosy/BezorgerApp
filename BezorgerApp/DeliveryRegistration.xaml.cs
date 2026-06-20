namespace BezorgerApp;

public partial class DeliveryRegistration : ContentPage
{
	public DeliveryRegistration()
	{
		InitializeComponent();
	}

    private async void GoToDeliveryComplete(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeliveryComplete());
    }

    private async void GoToDeliveryPackages(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageNonExistent());
    }

    private async void GoToPackageScan(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageNonExistent());
    }

    private async void GoToDeliveryNotComplete(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PageNonExistent());
    }
}