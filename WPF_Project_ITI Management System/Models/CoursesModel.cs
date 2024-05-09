using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_ITI_Management_System.Models
{
    public class CoursesModel
    {
        // Properties
        #region
        public string Course_Name { get; set; }
        public int Course_ID { get; set; }
        public String CourseStudent_FName { get; set; }
        public String CourseStudent_LName { get; set; }
        public double Grade { get; set; }
        public String CourseInstractor_Name { get; set; }
        #endregion

        // Constructor
        #region constractor
        public CoursesModel()  //defualt
        {

        }
        #endregion

    }
}
