using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Project_ITI_Management_System.Commands;

namespace WPF_Project_ITI_Management_System.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //SELECTED VIEW MODEL
        #region
        //fileds
        private BaseViewModel _selectedViewModel;

        //property
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }

        }

        public ICommand UpdateViewCommand
        { get; set; }

        //cconstractor
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
        #endregion

        //close app
        #region close
        private CloseRelayCommand _closeCommand;

        public CloseRelayCommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new CloseRelayCommand(param => Close());
                }
                return _closeCommand;
            }
        }

        private void Close()
        {
            App.Current.MainWindow.Close();
        }
        #endregion

    }
}
