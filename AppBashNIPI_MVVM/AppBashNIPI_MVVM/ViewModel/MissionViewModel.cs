using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using AppBashNIPI_MVVM.Model;
using AppBashNIPIMVVM.Model;


namespace AppBashNIPIMVVM.ViewModel
{
    public class MissionViewModel : INotifyPropertyChanged
    {
        private Mission mission;

        public int Id
        {
            get => mission.Id;
            set
            {
                mission.Id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Name
        {
            get => mission.Name;
            set
            {
                mission.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Body
        {
            get => mission.Body;
            set
            {
                mission.Body = value;
                OnPropertyChanged("Body");
            }
        }
        public string ClassName => mission.ClassName;
        public EnumStatus Status
        {
            get => mission.Status;
            set
            {
                mission.Status = value;
                OnPropertyChanged("Status");
            }
        }

        public MissionViewModel(Mission missions)
        {
            mission = missions;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}