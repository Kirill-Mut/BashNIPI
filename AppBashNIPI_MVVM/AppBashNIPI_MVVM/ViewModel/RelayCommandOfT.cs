using System;
using System.Windows.Input;

namespace AppBashNIPIMVVM.ViewModel;

public class RelayCommandOfT<TValue> : ICommand
{
    private Action<TValue> execute;
    private Func<TValue, bool>? canExecute;
 
    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
 
    public RelayCommandOfT(Action<TValue> execute, Func<TValue, bool>? canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }
 
    public bool CanExecute(object? parameter) => parameter is TValue val && (canExecute == null || canExecute(val));
    
 
    public void Execute(object? parameter) => execute((TValue)parameter!);
    
}