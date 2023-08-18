using AppBashNIPIMVVM.Model;
using AppBashNIPIMVVM.View;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace AppBashNIPIMVVM.ViewModel
{
    public class ViewFactory
    {
        public Window GetView(INotifyPropertyChanged view)
        {
            if (view is DocumentViewModel doc)
            {
                return new DocumentView { DataContext = doc };
            }
            else if (view is MissionViewModel mis)
            {
                return new MissionView { DataContext = mis };
            }
            else
            {
                throw new NotSupportedException($"Не поддерживаемый тип объекта: {view.GetType().Name}.");
            }
        }
    }
}