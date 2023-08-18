using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppBashNIPIMVVM.Model;

namespace AppBashNIPIMVVM.ViewModel
{
    public class DocumentViewModel : INotifyPropertyChanged
    {
        private readonly Document document;
        private bool canEdited;
        public bool CanEdited
        {
            get => canEdited;
            set
            {
                canEdited = value;
                OnPropertyChanged("CanEdited");
            }
        }
        public int Id
        {
            get => document.Id;
            set
            {
                if (CanEdited)
                {
                    document.Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Name
        {
            get => document.Name;
            set
            {
                if (CanEdited)
                {
                    document.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Body
        {
            get => document.Body;
            set
            {
                if (CanEdited)
                {
                    document.Body = value;
                    OnPropertyChanged("Body");
                }
            }
        }
        public string ClassName => document.ClassName;
            
        public string Signature
        {
            get => document.Signature == Guid.Empty ? "" : document.Signature.ToString();
            set
            {
                if (CanEdited)
                {
                    document.Signature = Guid.Parse(value);
                    OnPropertyChanged("Signature");
                    CanEdited = false;
                }
            }
        }

        public DocumentViewModel(Document documents)
        {
            document = documents;
            CanEdited = Signature == "";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        private RelayCommand signCommand;
        public RelayCommand SignCommand
        {
            get
            {
                return signCommand ??
                       (signCommand = new RelayCommand(obj =>
                       {
                           Signature = Guid.NewGuid().ToString();
                       }));
            }
        }
    }
}
