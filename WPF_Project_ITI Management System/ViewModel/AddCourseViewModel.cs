using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Project_ITI_Management_System.Commands;
using WPF_Project_ITI_Management_System.Models;

namespace WPF_Project_ITI_Management_System.ViewModel
{
    public class AddCourseViewModel
    {
        // Properties
        #region
        public string? Course_Name { get; set; }
        public int? Course_ID { get; set; }
        public string? CourseStudent_FName { get; set; }
        public string? CourseStudent_LName { get; set; }
        public double? Grade { get; set; }
        public string? CourseInstractor_Name { get; set; }
        public ICommand AddNewCourseCommand { get; set; }
        #endregion

        //constractor
        #region constractor
        public AddCourseViewModel()
        {
            AddNewCourseCommand = new RelayCommand(AddNewCourseMethod, CanAddNewCourseMethod);
        }
        #endregion

        //methods
        #region methods
        private void AddNewCourseMethod(object obj)
        {
            CoursesManageView.AddCourse(new CoursesModel()
            {
                Course_Name = Course_Name,
                Course_ID = (int)Course_ID,
                CourseStudent_FName = CourseStudent_FName,
                CourseStudent_LName = CourseStudent_LName,
                Grade = (double)Grade,
                CourseInstractor_Name = CourseInstractor_Name
            });
        }

        private bool CanAddNewCourseMethod(object obj)
        {
            return true;
        }
        #endregion
    }
}
