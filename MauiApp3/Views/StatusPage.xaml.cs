namespace MauiApp3.Views;

public partial class StatusPage : ContentPage
{
    private async void OnMyStatusTapped(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new AddStatusPage());
    }
    public StatusPage()
	{
        BindingContext = this;
        InitializeComponent();
	}
}