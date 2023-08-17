using AppBashNIPI_MVVM.Model;

namespace AppBashNIPIMVVM.Model
{
    public class Mission : MainItem
    {
       
        private EnumStatus status;
        public EnumStatus Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }
        public override string ClassName => "Задача";

        public Mission() : base()
        {
            Status = EnumStatus.InProgress;
        }
    }
}
