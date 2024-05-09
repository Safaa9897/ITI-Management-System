using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Project_ITI_Management_System.Commands
{
    public class RelayCommand : ICommand
    {
        //event
        public event EventHandler? CanExecuteChanged;

        //Constractor
        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {
            _Excute = ExcuteMethod;

            _CanExcute = CanExcuteMethod;

        }

        //Proparties
        private Action<Object> _Excute { get; set; }
        private Predicate<object> _CanExcute { get; set; }

        public bool CanExecute(object? parameter)
        {
            return _CanExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Excute(parameter);
        }
    }
}
