using MauiApp3.Modeli;

namespace MauiApp3.Views;

public partial class ChatsPage : ContentPage
{
	public ChatsPage()
	{
        BindingContext = new ViewModels.ChatViewModel();
        InitializeComponent();
	}
    private async void OnChatSelected(object sender, SelectionChangedEventArgs e)
    {
        // 1. Dohvati selektovani chat objekat
        var selectedChat = e.CurrentSelection.FirstOrDefault() as Chat; // Zameni ChatModel imenom svoje klase

        if (selectedChat == null)
            return;

        // 2. Kreiraj instancu stranice za poruke
        var messagePage = new SpecificChatPage();

        // 3. Prosledi podatke kroz ViewModel te stranice
        // Pretpostavljamo da MessageDetailPage ima MessageViewModel
        messagePage.BindingContext = new ChatDetailViewModel
        {
            ContactName = selectedChat.Name,
            ProfilePicture = selectedChat.AvatarUrl
        };

        // 4. Navigacija na tu stranicu
        await Navigation.PushAsync(messagePage);

        // 5. Očisti selekciju (da ne ostane sivo kad se vratiš nazad)
        ((CollectionView)sender).SelectedItem = null;
    }
}