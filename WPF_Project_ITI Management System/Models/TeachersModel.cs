using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_ITI_Management_System.Models
{
    public class TeachersModel
    {
        //properties
        #region prop
        public int Instractor_ID { get; set; }
        public string Instractor_Name { get; set; }
        public double Instractor_Salary { get; set; }
        public string Instractor_DepartmentName { get; set; }
        public CoursesModel Instractor_CourseName { get; set; }
        public string Instractor_Mail { get; set; }
        public double Instractor_Number { get; set; }
        #endregion

        //constractors
        #region constractor
        public TeachersModel() //defualt
        {

        }
        #endregion
    }
}
