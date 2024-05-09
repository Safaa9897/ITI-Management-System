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
using System.Windows.Shapes;
using WPF_Project_ITI_Management_System.ViewModel;

namespace WPF_Project_ITI_Management_System.Views
{
    /// <summary>
    /// Interaction logic for AddCoursesWindow.xaml
    /// </summary>
    public partial class AddCoursesWindow : Window
    {
        public AddCoursesWindow()
        {
            InitializeComponent();
            AddCourseViewModel addCourseViewModel = new AddCourseViewModel();
            this.DataContext = addCourseViewModel;
        }
    }
}
