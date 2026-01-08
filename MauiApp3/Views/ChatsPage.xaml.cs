namespace MauiApp3.Views;

public partial class ChatsPage : ContentPage
{
	public ChatsPage()
	{
        BindingContext = new ViewModels.ChatViewModel();
        InitializeComponent();
	}
}