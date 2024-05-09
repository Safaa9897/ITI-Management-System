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
    public class TeachersViewModel : BaseViewModel
    {
        //properties
        #region prop
        public ObservableCollection<TeachersModel> teachers { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public ICommand DeleteTeacherCommand { get; set; }
        #endregion

        //Constractors
        #region Constractors
        public TeachersViewModel()
        {
            teachers = TeacherManageView.GetTeachers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
            DeleteTeacherCommand = new RelayCommand(DeleteTeacher, CanDeleteTeacher);
        }
        #endregion

        //Methods
        #region Methods
        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddTeacherWindow AddTeacherInformationView = new AddTeacherWindow();
            AddTeacherInformationView.Show();
        }

        private bool CanDeleteTeacher(object obj)
        {
            return true;
        }

        private void DeleteTeacher(object obj)
        {
            if (obj is TeachersModel teacherToDelete)
            {
                teachers.Remove(teacherToDelete);
            }
        }
        #endregion
    }
}
