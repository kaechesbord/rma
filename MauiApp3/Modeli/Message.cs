using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Modeli
{
    public class Message
    {
        public string Text { get; set; }
        public string Time { get; set; }
        public bool IsIncoming { get; set; }
        public bool IsImage { get; set; } // Za simulaciju onih fajlova u chatu
        public string FileName { get; set; }
    }
}
