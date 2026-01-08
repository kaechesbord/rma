using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp3.Modeli;
using System.Collections.ObjectModel;

namespace MauiApp3.ViewModels
{

    public class CallViewModel
    {
        public ObservableCollection<Call> Calls { get; set; }

        public CallViewModel()
        {
            Calls = new ObservableCollection<Call>
        {
            new Call { Name = "Martin Randolph", CallType = "outgoing", Date = new DateTime(2019, 10, 13), ProfileImage = "p1.jpg" },
            new Call { Name = "Karen Castillo", CallType = "outgoing", Date = new DateTime(2019, 10, 11), ProfileImage = "p2.jpg" },
            new Call { Name = "Kieron Dotson", CallType = "outgoing", Date = new DateTime(2019, 10, 8), ProfileImage = "p3.jpg" },
            new Call { Name = "Karen Castillo", CallType = "missed", Date = new DateTime(2019, 9, 30), ProfileImage = "p2.jpg" },
            new Call { Name = "Zack John", CallType = "incoming", Date = new DateTime(2019, 9, 24), ProfileImage = "p4.jpg" }
        };
        }
    }
}
