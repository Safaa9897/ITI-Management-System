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
    public class CoursesViewModel : BaseViewModel
    {
        //properties
        #region prop
        public ObservableCollection<CoursesModel> courses { get; set; }

        public ICommand ShowCoursesWindowCommand { get; set; }

        public ICommand DeleteCourseCommand { get; set; }
        #endregion

        //Constractors
        #region Constractors
        public CoursesViewModel()
        {
            courses = CoursesManageView.GetCourses();
            ShowCoursesWindowCommand = new RelayCommand(ShowCoursesWindow, CanShowCoursesWindow);
            DeleteCourseCommand = new RelayCommand(DeleteCourse, CanDeleteCourse);
        }
        #endregion

        //Methods
        #region Methods
        private bool CanShowCoursesWindow(object obj)
        {
            return true;
        }

        private void ShowCoursesWindow(object obj)
        {
            AddCoursesWindow AddCourseInformationView = new AddCoursesWindow();
            AddCourseInformationView.Show();
        }

        private bool CanDeleteCourse(object obj)
        {
            return true;
        }

        private void DeleteCourse(object obj)
        {
            if (obj is CoursesModel courseToDelete)
            {
                courses.Remove(courseToDelete);
            }
        }
        #endregion
    }
}
