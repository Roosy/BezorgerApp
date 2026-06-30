using BezorgerApp.Models;
using BezorgerApp.Views;
using System.Collections.ObjectModel;

namespace BezorgerApp.Views;

public partial class DeliveryRegistration : ContentPage
{

    private ObservableCollection<Pakket> pakketten = new ObservableCollection<Pakket>();
    public DeliveryRegistration()
    {
        InitializeComponent();

        PakkettenList.ItemsSource = pakketten;


        pakketten.Add(new Pakket("PKT10002345"));
        pakketten.Add(new Pakket("PKT10002346"));
        pakketten.Add(new Pakket("PKT10002347"));

        AantalLabel.Text = $"Gescande pakketten ({pakketten.Count}/3)";
    }

    private async void GoToDeliveryComplete(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeliveryComplete());
    }


    private async void ScanPakket_Clicked(object sender, EventArgs e)
    {
        string barcode = BarcodeEntry.Text;

        if (string.IsNullOrWhiteSpace(barcode))
        {
            await DisplayAlert("Geen barcode", "Voer eerst een barcode in.", "OK");
            return;
        }

        pakketten.Add(new Pakket(barcode));

        BarcodeEntry.Text = "";
        AantalLabel.Text = $"Gescande pakketten ({pakketten.Count}/3)";
    }

    private async void GoToProbleemMeldingPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProbleemMeldingPage());
    }
}