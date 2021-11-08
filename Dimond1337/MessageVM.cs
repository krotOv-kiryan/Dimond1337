using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Dimond1337
{
    internal class MessageVM : INotifyPropertyChanged
    {
        public Page CurrentPage { get; set; }


        // public ObservableCollection<name> names { get; set; }

        public MessageVM()
        {
            // db = Db.GetDb();

        }

        void SignalChanged([CallerMemberName] string prop = null) =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}