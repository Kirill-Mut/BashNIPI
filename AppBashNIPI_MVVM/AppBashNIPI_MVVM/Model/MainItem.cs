using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppBashNIPIMVVM.Model
{
    public abstract class MainItem : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string? body;
        public abstract string ClassName { get;}

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value == "" ? ".doc" : value;
                OnPropertyChanged("Name");
            }
        }
        public string? Body
        {
            get => body;
            set
            {
                body = value;
                OnPropertyChanged("Value");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
