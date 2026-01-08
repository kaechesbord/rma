namespace MauiApp3.Views;

public partial class CallsPage : ContentPage
{
	public CallsPage()
	{
        BindingContext = new ViewModels.CallViewModel();
        InitializeComponent();
	}
}