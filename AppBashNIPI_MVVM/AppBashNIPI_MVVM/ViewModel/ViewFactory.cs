using AppBashNIPIMVVM.Model;
using AppBashNIPIMVVM.View;

namespace AppBashNIPIMVVM.ViewModel
{

    public interface ViewFactory
    {
        public void CreateView(MainItem MainItem);
    }

    public class MissionViewFactory : ViewFactory
    {
        public void CreateView(MainItem MainItem)
        {

            var missionView = new MissionView
            {
                DataContext = new MissionViewModel((Mission)MainItem)
            };
            missionView.Show();
        }
    }

    public class DocumentViewFactory : ViewFactory
    {
        public void CreateView(MainItem MainItem)
        {
            var documentView = new DocumentView
            {
                DataContext = new DocumentViewModel((Document)MainItem)
            };
            documentView.Show();
        }
    }
}