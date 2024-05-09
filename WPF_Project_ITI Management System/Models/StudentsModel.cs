using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_ITI_Management_System.Models
{
    public class StudentsModel
    {
        //properties
        #region prop
        public int Student_ID { get; set; }
        public string Student_FName { get; set; }
        public string Student_LName { get; set; }
        public TeachersModel SupperVisour { get; set; }
        public string Student_TrackName { get; set; }
        public double Student_Number { get; set; }
        public string Student_Mail { get; set; }
        public List<CoursesModel> Student_Courses { get; set; }
        public bool Student_IsGraduated { get; set; }
        #endregion

        //constractors
        #region constractor
        public StudentsModel() //defualt
        {

        }
        #endregion
    }
}
