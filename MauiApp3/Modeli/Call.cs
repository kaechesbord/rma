using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Modeli
{
    public class Call
    {
        public string Name { get; set; }
        public string ProfileImage { get; set; }
        public string CallType { get; set; } // "incoming", "outgoing", "missed"
        public DateTime Date { get; set; }
        public bool IsMissed => CallType.ToLower() == "missed";

        // Pomoćna svojstva za ikone i boje
        public string CallIcon => IsMissed || CallType == "incoming" ? "phone_incoming.png" : "phone_outgoing.png";
        public Color NameColor => IsMissed ? Colors.Red : Colors.Black;
    }
}
