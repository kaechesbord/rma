namespace MauiApp3.Views;

public partial class SpecificChatPage : ContentPage
{
	public SpecificChatPage()
	{
		BindingContext = new ViewModels.ChatViewModel();
        InitializeComponent();
	}

}