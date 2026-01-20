using MauiApp3.Modeli;

public class ChatDetailViewModel : BindableObject
{
    private string _contactName;
    public string ContactName
    {
        get => _contactName;
        set { _contactName = value; OnPropertyChanged(); }
    }

    private string _profilePicture;
    public string ProfilePicture
    {
        get => _profilePicture;
        set { _profilePicture = value; OnPropertyChanged(); }
    }

    // Lista statičnih poruka (kao na tvojoj slici)
    public List<Message> StaticMessages { get; set; }

    public ChatDetailViewModel()
    {
        StaticMessages = new List<Message>
        {
            new Message { Text = "Good bye!", Time = "17:47", IsIncoming = false },
            new Message { Text = "Good morning!", Time = "10:10", IsIncoming = false },
            new Message { Text = "Japan looks amazing!", Time = "10:10", IsIncoming = false },
            new Message { FileName = "IMG_0475", Time = "10:15", IsIncoming = false, IsImage = true },
            new Message { Text = "Do you know what time is it?", Time = "11:40", IsIncoming = true },
            new Message { Text = "It's morning in Tokyo 😎", Time = "11:43", IsIncoming = false }
        };
    }
}