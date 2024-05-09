using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Project_ITI_Management_System.Commands;
using WPF_Project_ITI_Management_System.Models;

namespace WPF_Project_ITI_Management_System.ViewModel
{
    public class AddStudentViewModel
    {
        private ObservableCollection<StudentsModel> _students;

        // Properties
        #region Properties
        public int? Student_ID { get; set; }
        public string? Student_FName { get; set; }
        public string? Student_LName { get; set; }
        public TeachersModel? SupperVisour { get; set; }
        public string? Student_TrackName { get; set; }
        public double? Student_Number { get; set; }
        public string? Student_Mail { get; set; }
        public List<CoursesModel>? Student_Courses { get; set; }
        public bool? Student_IsGraduated { get; set; }
        public ICommand AddNewStudentCommand { get; set; }
        #endregion

        // Constructor
        #region Constructor
        public AddStudentViewModel()
        {
            //_students = students;
            AddNewStudentCommand = new RelayCommand(AddNewStudentMethod, CanAddNewStudentMethod);
        }
        #endregion

        // Methods
        #region Methods
        private void AddNewStudentMethod(object obj)
        {
            StudentManageView.AddStudent(new StudentsModel()
            {
                Student_ID = (int)Student_ID,
                Student_Courses = Student_Courses,
                Student_FName = Student_FName,
                Student_IsGraduated = (bool)Student_IsGraduated,
                Student_LName = Student_LName,
                Student_Mail = Student_Mail,
                Student_Number = (int)Student_Number,
                Student_TrackName = Student_TrackName,
                SupperVisour = SupperVisour
            });

            //_students.Add(newStudent);

            //// Clear input fields after adding a new student
            //Student_ID = null;
            //Student_Courses = null;
            //Student_FName = null;
            //Student_IsGraduated = null;
            //Student_LName = null;
            //Student_Mail = null;
            //Student_Number = null;
            //Student_TrackName = null;
            //SupperVisour = null;
        }

        private bool CanAddNewStudentMethod(object obj)
        {
            return true;
        }
        #endregion
    }
}
