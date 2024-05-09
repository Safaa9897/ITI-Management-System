using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Project_ITI_Management_System.Commands;
using WPF_Project_ITI_Management_System.Models;
using WPF_Project_ITI_Management_System.Views;

namespace WPF_Project_ITI_Management_System.ViewModel
{
    public class StudentsViewModel : BaseViewModel
    {
        // Properties
        #region Properties
        public ObservableCollection<StudentsModel> students { get; set; }

        public ICommand ShowStudentWindowCommand { get; set; }

        public ICommand DeleteStudentCommand { get; set; }
        #endregion

        // Constructor
        #region Constructor
        public StudentsViewModel()
        {
            students = StudentManageView.GetStudents();
            ShowStudentWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
            DeleteStudentCommand = new RelayCommand(DeleteStudent, CanDeleteStudent);
        }
        #endregion

        // Methods
        #region Methods
        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddStudentWindow AddStudentInformationView = new AddStudentWindow();
            AddStudentInformationView.Show();
        }

        private bool CanDeleteStudent(object obj)
        {
            return true;
        }

        private void DeleteStudent(object obj)
        {
            if (obj is StudentsModel studentToDelete)
            {
                students.Remove(studentToDelete);
            }
        }
        #endregion
    }
}
