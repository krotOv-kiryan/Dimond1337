using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Dimond1337
{
    internal class SpamVM : INotifyPropertyChanged
    {
        public Page CurrentPage { get; set; }


        // public ObservableCollection<name> names { get; set; }

        public SpamVM()
        {
            // db = Db.GetDb();
           
        }

        void SignalChanged([CallerMemberName] string prop = null) =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}