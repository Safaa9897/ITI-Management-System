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
    public class AddTeacherViewModel
    {
        //properties
        #region prop
        public int? Instractor_ID { get; set; }
        public string? Instractor_Name { get; set; }
        public double? Instractor_Salary { get; set; }
        public string? Instractor_DepartmentName { get; set; }
        public CoursesModel? Instractor_CourseName { get; set; }
        public string? Instractor_Mail { get; set; }
        public double? Instractor_Number { get; set; }
        public ICommand AddNewTeacherCommand { get; set; }
        #endregion

        //constractor
        #region constractor
        public AddTeacherViewModel()
        {
            AddNewTeacherCommand = new RelayCommand(AddNewTeacherMethod, CanAddNewTeacherMethod);
        }
        #endregion

        //methods
        #region methods
        private void AddNewTeacherMethod(object obj)
        {
            TeacherManageView.AddTeacher(new TeachersModel()
            {
                Instractor_ID = (int)Instractor_ID,
                Instractor_Name = Instractor_Name,
                Instractor_DepartmentName = Instractor_DepartmentName,
                Instractor_CourseName = Instractor_CourseName,
                Instractor_Mail = Instractor_Mail,
                Instractor_Number = (double)Instractor_Number,
                Instractor_Salary = (double)Instractor_Salary
            });
        }

        private bool CanAddNewTeacherMethod(object obj)
        {
            return true;
        }
        #endregion
    }
}
