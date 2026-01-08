using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.ViewModels
{
    using System.Collections.ObjectModel;
    using MauiApp3.Modeli;


    public class ChatViewModel
    {
        public ObservableCollection<Chat> Chats { get; set; }

        public ChatViewModel()
        {
            Chats = new ObservableCollection<Chat>
        {
            new Chat { Name = "Andrew Parker", LastMessage = "What kind of strategy is better?", Time = "11/16/19", AvatarUrl = "https://picsum.photos/100/100?random=1", IsRead = false, MessageType = "text" },
            new Chat { Name = "Karen Castillo", LastMessage = "0:14", Time = "11/15/19", AvatarUrl = "https://picsum.photos/100/100?random=2", MessageType = "voice" },
            new Chat { Name = "Maximillian Jacobson", LastMessage = "Bro, I have a good idea!", Time = "10/30/19", AvatarUrl = "https://picsum.photos/100/100?random=3", MessageType = "text" },
            new Chat { Name = "Martha Craig", LastMessage = "Photo", Time = "10/28/19", AvatarUrl = "https://picsum.photos/100/100?random=4", MessageType = "photo" },
            new Chat { Name = "Tabitha Potter", LastMessage = "Actually I wanted to check with you about...", Time = "8/25/19", AvatarUrl = "https://picsum.photos/100/100?random=5", MessageType = "text" }
        };
        }
    }
}
