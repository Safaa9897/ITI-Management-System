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

namespace WPF_Project_ITI_Management_System.Views
{
    /// <summary>
    /// Interaction logic for StudentsView.xaml
    /// </summary>
    public partial class StudentsView : UserControl
    {
        public StudentsView()
        {
            InitializeComponent();
        }
        private void FilterTextBoxStudent_TextChanged(object sender, TextChangedEventArgs e)
        {
            Data_Grid_Students.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var student = obj as StudentsModel;
            return student.Student_FName.Contains(FilterTextBoxStudents.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
