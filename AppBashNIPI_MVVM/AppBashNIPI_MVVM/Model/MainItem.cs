using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppBashNIPIMVVM.Model
{
    public abstract class MainItem 
    {
        private int id;
        private string name;
        private string body;
        public abstract string ClassName { get; }

        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value == "" ? ".doc" : value;
            }
        }
        public string? Body
        {
            get => body;
            set
            {
                body = value;
            }
        }
    }
}
