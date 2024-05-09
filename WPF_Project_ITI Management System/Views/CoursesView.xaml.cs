using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Project_ITI_Management_System.Models;
using WPF_Project_ITI_Management_System.ViewModel;

namespace WPF_Project_ITI_Management_System.Views
{
    /// <summary>
    /// Interaction logic for CoursesView.xaml
    /// </summary>
    public partial class CoursesView : UserControl
    {
        public CoursesView()
        {
            InitializeComponent();
            CoursesViewModel courseviewmodel = new CoursesViewModel();
            this.DataContext = courseviewmodel;
        }
        private void FilterCoursesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Data_GridCourses.Items.Filter = FilterCoursesMethod;
        }

        private bool FilterCoursesMethod(object obj)
        {
            var course = obj as CoursesModel;
            return course.Course_Name.Contains(FilterCoursesTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
