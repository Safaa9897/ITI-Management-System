using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_ITI_Management_System.Models
{
    public class StudentManageView
    {
        //Add Students by defualt
        #region prop
        public static ObservableCollection<StudentsModel> _DataBaseStudents = new ObservableCollection<StudentsModel>()
        {
            new StudentsModel {Student_ID = 1 , Student_FName = "Safaa" , Student_LName = "Khaled" , Student_Number = 01050093542 ,
                Student_Mail = "SafaaKhaled284@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "BIM |||" }} },

            new StudentsModel {Student_ID = 2 , Student_FName = "Wafaa" , Student_LName = "Khaled" , Student_Number = 01050093542 ,
                Student_Mail = "WafaaKhaled284@gmail.com" , Student_TrackName = "AEC Informatics", SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = true , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data baase" },new CoursesModel { Course_Name = "C#" }} },

            new StudentsModel {Student_ID = 3 , Student_FName = "Mostafa" , Student_LName = "Mohamed" , Student_Number = 01050093542 ,
                Student_Mail = "MostafaMohamed@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "GIS" }} },

            new StudentsModel {Student_ID = 3 , Student_FName = "Alaa" , Student_LName = "Mahmoud" , Student_Number = 01050093542 ,
                Student_Mail = "MostafaMohamed@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "GIS" }} },

            new StudentsModel {Student_ID = 3 , Student_FName = "Alaa" , Student_LName = "Magdy" , Student_Number = 01050093542 ,
                Student_Mail = "MostafaMohamed@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "GIS" }} },
            new StudentsModel {Student_ID = 3 , Student_FName = "Salma" , Student_LName = "Hamed" , Student_Number = 01050093542 ,
                Student_Mail = "MostafaMohamed@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "GIS" }} },

            new StudentsModel {Student_ID = 3 , Student_FName = "Shams" , Student_LName = "Hisham" , Student_Number = 01050093542 ,
                Student_Mail = "MostafaMohamed@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "GIS" }} },

            new StudentsModel {Student_ID = 3 , Student_FName = "Hania" , Student_LName = "Diaa" , Student_Number = 01050093542 ,
                Student_Mail = "MostafaMohamed@gmail.com" , Student_TrackName = "AEC Informatics" , SupperVisour = new TeachersModel
                { Instractor_Name = "Ahmed Mohey" } , Student_IsGraduated = false , Student_Courses = new List<CoursesModel>
                {new CoursesModel { Course_Name = "Data Structure" },new CoursesModel { Course_Name = "GIS" }} },
        };
        #endregion


        //methods
        #region methods
        public static ObservableCollection<StudentsModel> GetStudents()
        {
            return _DataBaseStudents;
        }

        public static void AddStudent(StudentsModel studentsModel)
        {
            _DataBaseStudents.Add(studentsModel);
        }
        #endregion
    }
}
