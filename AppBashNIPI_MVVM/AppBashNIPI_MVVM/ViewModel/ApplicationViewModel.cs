using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppBashNIPI_MVVM.Model;
using AppBashNIPIMVVM.Model;

namespace AppBashNIPIMVVM.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {

        private MainItem selectedMainItem;
        public ObservableCollection<MainItem> MainItems { get; private set; }
        public MainItem SelectedMainItem
        {
            get => selectedMainItem;
            set
            {
                selectedMainItem = value;
                OnPropertyChanged("SelectedMainItem");
                OpenSelectedMainItem();
            }
        }

        public ApplicationViewModel()
        {
            MainItems = new ObservableCollection<MainItem>
            {
                new Document{ Id= 2, Name= "Тест.doc", Body = "Тест"},
                new Mission{ Id= 1, Name= "Тест", Body = "Тест", Status = EnumStatus.InProgress}
            };
        }
        private RelayCommand createMainItemCommand;
        public RelayCommand CreateMainItemCommand
        {
            get
            {
                return createMainItemCommand ??
                       (createMainItemCommand = new RelayCommand(obj =>
                       {
                           string className = obj.ToString();
                           IMainItemFactory factory;
                           switch (className)
                           {
                               case "Document":
                                   factory = new DocumentFactory();
                                   break;
                               case "Mission":
                                   factory = new MissionFactory();
                                   break;
                               default:
                                   throw new Exception(
                                       $"Attempt to create a factory for a non-existent class: {className}");
                           }

                           MainItem mainItem = factory.CreateMainItem("Новая запись");
                           mainItem.Id = MainItems.Count + 1;
                           MainItems.Insert(0, mainItem);
                           SelectedMainItem = mainItem;
                       }));
            }
        }
        private RelayCommand openMainItemCommand;
        public RelayCommand OpenMainItemCommand
        {
            get
            {
                return openMainItemCommand ??
                       (openMainItemCommand = new RelayCommand(obj =>
                       {
                           SelectedMainItem = (MainItem)obj;
                       }));
            }
        }
        private void OpenSelectedMainItem()
        {
            string className = SelectedMainItem.ClassName;
            ViewFactory viewFactory;
            switch (className)
            {
                case "Документ":
                    viewFactory = new DocumentViewFactory();
                    break;
                case "Задача":
                    viewFactory = new MissionViewFactory();
                    break;
                default:
                    throw new Exception("{className}");
            }

            viewFactory.CreateView(SelectedMainItem);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
