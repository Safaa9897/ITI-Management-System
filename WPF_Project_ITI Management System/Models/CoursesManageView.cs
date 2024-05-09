using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_ITI_Management_System.Models
{
    public class CoursesManageView
    {
        //Add Courses by defualt
        #region prop
        public static ObservableCollection<CoursesModel> _DataBaseCouesrs = new ObservableCollection<CoursesModel>()
        {
            //data base
            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name =
            "Ahmed Adel"  , CourseStudent_FName = "Safaa" , CourseStudent_LName = "Khaled"  , Grade= 90},

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name ="Ahmed Adel"  ,
            CourseStudent_FName ="Wafaa" , CourseStudent_LName ="Khaled"  , Grade= 90},

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name ="Ahmed Adel" ,
            CourseStudent_FName ="Mostafa" , CourseStudent_LName ="Mohamed"  , Grade= 90},

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name ="Ahmed Adel" ,
            CourseStudent_FName ="Alaa" , CourseStudent_LName ="Magdy" , Grade= 90 },

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name ="Ahmed Adel"  ,
            CourseStudent_FName ="Alaa" , CourseStudent_LName ="Mahmoud" , Grade= 90 },

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name = "Ahmed Adel"  ,
            CourseStudent_FName ="Salma" , CourseStudent_LName ="Hamed"  , Grade= 90},

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name ="Ahmed Adel"  ,
            CourseStudent_FName ="Shams" , CourseStudent_LName ="Hisham"  , Grade= 90},

            new CoursesModel {Course_ID= 1 , Course_Name=  "DataBase", CourseInstractor_Name = "Ahmed Adel"  ,
            CourseStudent_FName ="Hania", CourseStudent_LName ="Diaa"  , Grade= 90},

            //WPF
            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name ="Ahmed Gamil" ,
            CourseStudent_FName ="Safaa" , CourseStudent_LName ="Khaled"  , Grade= 90},

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name ="Ahmed Gamil"  ,
            CourseStudent_FName ="Wafaa" , CourseStudent_LName ="Khaled"  , Grade= 90},

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name ="Ahmed Gamil" ,
            CourseStudent_FName ="Mostafa" , CourseStudent_LName = "Mohamed" , Grade= 90 },

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name = "Ahmed Gamil"  ,
            CourseStudent_FName ="Alaa" , CourseStudent_LName ="Magdy"  , Grade= 90},

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name ="Ahmed Gamil" ,
            CourseStudent_FName ="Alaa" , CourseStudent_LName ="Mahmoud" , Grade= 90 },

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name ="Ahmed Gamil" ,
            CourseStudent_FName ="Salma" , CourseStudent_LName ="Hamed" , Grade= 90 },

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name = "Ahmed Gamil" ,
            CourseStudent_FName ="Shams" , CourseStudent_LName ="Hisham", Grade= 90 },

            new CoursesModel {Course_ID= 2 , Course_Name=  "Windows Presentation Foundation", CourseInstractor_Name = "Ahmed Gamil" ,
            CourseStudent_FName ="Hania" , CourseStudent_LName ="Diaa" , Grade= 90  },
        };
        #endregion

        //methods
        #region methods
        public static ObservableCollection<CoursesModel> GetCourses()
        {
            return _DataBaseCouesrs;
        }

        public static void AddCourse(CoursesModel coursesModel)
        {
            _DataBaseCouesrs.Add(coursesModel);
        }
        #endregion
    }
}
