using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_ITI_Management_System.Models
{
    public class TeacherManageView
    {
        //Add Teachers by defualt
        #region prop
        public static ObservableCollection<TeachersModel> _DataBaseTeachers = new ObservableCollection<TeachersModel>()
        {
            new TeachersModel {Instractor_ID = 1 , Instractor_Name ="Ahmed Mohey    " , Instractor_DepartmentName="  AEC Informatics Track  " ,
                Instractor_CourseName=new CoursesModel { Course_Name = "Data Structure" } , Instractor_Mail= "Ahmed_Mohy_2023@gmail.com  " ,
                Instractor_Number= 01020103010 , Instractor_Salary=1000000},
            new TeachersModel {Instractor_ID = 2 , Instractor_Name ="Ahmed Gamil    " , Instractor_DepartmentName="  AEC Informatics Track  " ,
                Instractor_CourseName=new CoursesModel { Course_Name = "BIM |||" }, Instractor_Mail= "Ahmed_Gamil_2023@gmail.com  " ,
                Instractor_Number= 01020103010 , Instractor_Salary=1000000},
            new TeachersModel {Instractor_ID = 3 , Instractor_Name ="Ahmed Adel    " , Instractor_DepartmentName="  AEC Informatics Track  " ,
                Instractor_CourseName=new CoursesModel { Course_Name = "Data base" }, Instractor_Mail= "Ahmed_Adel_2023@gmail.com  " ,
                Instractor_Number= 01020103010 , Instractor_Salary=1000000},
            new TeachersModel {Instractor_ID = 4 , Instractor_Name ="Ahmed Gamil    " , Instractor_DepartmentName="  AEC Informatics Track  " ,
                Instractor_CourseName=new CoursesModel { Course_Name = "WPF" }, Instractor_Mail= "Ahmed_Gamil_2023@gmail.com" ,
                Instractor_Number= 01020103010 , Instractor_Salary=1000000},
            new TeachersModel {Instractor_ID = 5 , Instractor_Name ="Asmaa Ahmed    " , Instractor_DepartmentName="  AEC Informatics Track  " ,
                Instractor_CourseName=new CoursesModel { Course_Name = "English" }, Instractor_Mail= "Asmaa_Ahmed_2023@gmail.com  " ,
                Instractor_Number= 01020103010 , Instractor_Salary=1000000},
            new TeachersModel {Instractor_ID = 6 , Instractor_Name ="Mahmoud Oaf    " , Instractor_DepartmentName="  AEC Informatics Track  " ,
                Instractor_CourseName=new CoursesModel { Course_Name = "Programming Fundumental c#    " }, Instractor_Mail= "Mahmoud_2023@gmail.com  " ,
                Instractor_Number= 01020103010 , Instractor_Salary=1000000},
        };
        #endregion


        //methods
        #region methods
        public static ObservableCollection<TeachersModel> GetTeachers()
        {
            return _DataBaseTeachers;
        }

        public static void AddTeacher(TeachersModel teachersModel)
        {
            _DataBaseTeachers.Add(teachersModel);
        }
        #endregion
    }
}
