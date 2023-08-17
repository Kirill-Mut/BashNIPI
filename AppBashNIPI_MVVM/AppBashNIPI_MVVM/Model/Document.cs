using System;

namespace AppBashNIPIMVVM.Model
{
    public class Document : MainItem
    {
        private Guid signature;
        public Guid Signature
        {
            get => signature;
            set
            {
                signature = value;
                OnPropertyChanged("Signature");
            }
        }
        public override string ClassName => "Документ";
    }
}
