using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Modeli
{
    public class Chat
    {
        public string Name { get; set; }
        public string LastMessage { get; set; }
        public string Time { get; set; }
        public string AvatarUrl { get; set; }
        public bool IsRead { get; set; }
        public string MessageType { get; set; } 
    }
}
