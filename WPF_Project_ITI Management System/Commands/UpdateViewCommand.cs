using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Project_ITI_Management_System.ViewModel;

namespace WPF_Project_ITI_Management_System.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "Teachers")
            {
                viewModel.SelectedViewModel = new TeachersViewModel();
            }
            else if (parameter.ToString() == "Students")
            {
                viewModel.SelectedViewModel = new StudentsViewModel();
            }
            else if (parameter.ToString() == "Courses")
            {
                viewModel.SelectedViewModel = new CoursesViewModel();
            }
            else if (parameter.ToString() == "Calculator")
            {
                viewModel.SelectedViewModel = new CalculatorViewModel();
            }
        }
    }
}
