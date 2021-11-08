using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Dimond1337
{
    internal class MainVM : INotifyPropertyChanged
    {
        public Page CurrentPage { get; set; }


        // public ObservableCollection<name> names { get; set; }

        public Command OpenInbox { get; set; }
        public Command OpenTrash { get; set; }
        public Command OpenSent { get; set; }
        public Command OpenSpam { get; set; }
        public Command OpenMessage { get; set; }



        public MainVM()
        {
            // db = Db.GetDb();
            OpenInbox = new Command(() => { CurrentPage = new PageInbox(); SignalChanged("CurrentPage"); });
            OpenTrash = new Command(() => { CurrentPage = new PageTrash(); SignalChanged("CurrentPage"); });
            OpenSent = new Command(() => { CurrentPage = new PageSent(); SignalChanged("CurrentPage"); });
            OpenSpam = new Command(() => { CurrentPage = new PageSpam(); SignalChanged("CurrentPage"); });
            OpenMessage = new Command(() => { CurrentPage = new PageMessage(); SignalChanged("CurrentPage"); });

        }

        void SignalChanged([CallerMemberName] string prop = null) =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
