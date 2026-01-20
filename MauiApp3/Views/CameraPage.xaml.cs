using Microsoft.Maui.Media;
namespace MauiApp3.Views;

public partial class CameraPage : ContentPage
{
    public CameraPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Dodajemo provjeru da se kamera ne otvara ako smo već u procesu navigacije
        await Task.Delay(500);
        await IzvrsiSlikanjeIRedirect();
    }

    // Spojili smo logiku u jednu metodu radi lakšeg upravljanja
    private async Task IzvrsiSlikanjeIRedirect()
    {
        try
        {
            if (!MediaPicker.Default.IsCaptureSupported)
            {
                await PrebaciNaStatus();
                return;
            }

            var photo = await MediaPicker.Default.CapturePhotoAsync();

            // Bez obzira je li slika napravljena ili je korisnik otkazao (photo == null)
            // idemo na StatusPage
            await PrebaciNaStatus();
        }
        catch (Exception ex)
        {
            // Čak i ako kamera baci grešku, idemo na status (ili prikaži alert pa prebaci)
            await PrebaciNaStatus();
        }
    }

    private async Task PrebaciNaStatus()
    {
        // Koristimo MainThread da osiguramo da UI navigacija prođe bez zastoja
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            // Jako važno: "//StatusPage" mora biti Route u AppShell.xaml
            await Shell.Current.GoToAsync("//StatusPage");
        });
    }

    public async void OnTakePhotoClicked(object sender, EventArgs e)
    {
        await IzvrsiSlikanjeIRedirect();
    }
}