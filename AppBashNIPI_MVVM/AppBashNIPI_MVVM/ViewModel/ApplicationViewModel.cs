using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using AppBashNIPI_MVVM.Model;
using AppBashNIPIMVVM.Model;

namespace AppBashNIPIMVVM.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {

        private INotifyPropertyChanged selectedMainItem;
        public ObservableCollection<INotifyPropertyChanged> Views { get; private set; }
        public INotifyPropertyChanged SelectedView
        {
            get => selectedMainItem;
            set
            {
                if (value == null) return;
                selectedMainItem =  value;
                OnPropertyChanged("SelectedView");
                OpenSelectedView();
            }
        }

        public ApplicationViewModel()
        {
            Views = new ObservableCollection<INotifyPropertyChanged>
            {
                new DocumentViewModel(new Document{ Id= 2, Name= "Тест.doc", Body = "Тест"}),
                 new MissionViewModel(new Mission{ Id= 1, Name= "Тест", Body = "Тест", Status = EnumStatus.InProgress})
            };
        }

        private RelayCommand _createDocumentView;
        public RelayCommand CreateDocumentViewCommand => _createDocumentView ??= new(obj  =>
        {
            var view = new DocumentViewModel (new Document { Name = "Новая запись" });
            view.Id = Views.Count + 1;
            Views.Insert(0, view);
            SelectedView = view;

        });
        private RelayCommand _createMissionView;
        public RelayCommand CreateMissionViewCommand => _createMissionView ??= new(obj =>
        {
            var view = new MissionViewModel(new Mission { Name = "Новая запись" });
            view.Id = Views.Count + 1;
            Views.Insert(0, view);
            SelectedView = view;

        });
        private RelayCommandOfT<INotifyPropertyChanged> openViewCommand;
        public RelayCommandOfT<INotifyPropertyChanged> OpenViewCommand => openViewCommand ??= new (obj => SelectedView = obj);

        private void OpenSelectedView()
        {
            var view = new ViewFactory().GetView(selectedMainItem);
            view.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
