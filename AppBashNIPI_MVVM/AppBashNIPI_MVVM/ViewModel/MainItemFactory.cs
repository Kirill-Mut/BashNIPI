using AppBashNIPIMVVM.Model;

namespace AppBashNIPIMVVM.ViewModel
{
    
    public interface IMainItemFactory
    {
        public MainItem CreateMainItem(string name);
    }

    public class MissionFactory : IMainItemFactory
    {
        public MainItem CreateMainItem(string name)
        {
            return new Mission() { Name = name };
        }
    }

    public class DocumentFactory : IMainItemFactory
    {
        public MainItem CreateMainItem(string name)
        {
            return new Document() { Name = name };
        }
    }
}