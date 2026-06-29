using BezorgerApp.Models;
using BezorgerApp.Views;

namespace BezorgerApp.Views;

public partial class DeliveryComplete : ContentPage
{
    private Rit _rit;
    public DeliveryComplete(Rit rit)
	{
		InitializeComponent();
        _rit = rit;
	}

    public async Task ToonVolgendeStop()
    {
        _rit._stopCount++;

        if (_rit.AfleverStops != null && _rit._stopCount < _rit.AfleverStops.Count)
        {
            await Shell.Current.GoToAsync(nameof(DeliveryRegistration));
        }
        else
        {
            await Shell.Current.GoToAsync(nameof(RitAfrondenPage));
        }
    }
}