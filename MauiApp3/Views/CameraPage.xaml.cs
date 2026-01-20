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

        await OpenCameraAsync();
    }

    private async Task OpenCameraAsync()
    {
        try
        {
            if (!MediaPicker.Default.IsCaptureSupported)
                return;

            var photo = await MediaPicker.Default.CapturePhotoAsync();

            if (photo == null)
                await Navigation.PopAsync(); // user canceled
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}
