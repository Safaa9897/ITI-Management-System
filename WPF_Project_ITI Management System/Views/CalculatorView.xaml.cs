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
using WPF_Project_ITI_Management_System.ViewModel;

namespace WPF_Project_ITI_Management_System.Views
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : UserControl
    {
        //variables
        int _first;
        int _second;

        char _operation;
        public CalculatorView()
        {
            CalculatorViewModel calculatorViewModel = new CalculatorViewModel();
            this.DataContext = calculatorViewModel;

            InitializeComponent();

        }

        private void number(object sender, RoutedEventArgs e)
        {
            Button _button = (Button)sender;
            Text_Result.Text += _button.Content.ToString();
            _second = Int32.Parse(Text_Result.Text);
        }

        private void Divid_click(object sender, RoutedEventArgs e)
        {
            _first = Int32.Parse(Text_Result.Text);
            _operation = '/';
            Text_Result.Clear();

        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            _first = Int32.Parse(Text_Result.Text);
            _operation = '^';
            Text_Result.Clear();
        }

        private void Multyply_click(object sender, RoutedEventArgs e)
        {
            _first = Int32.Parse(Text_Result.Text);
            _operation = '*';
            Text_Result.Clear();
        }

        private void Sub_click(object sender, RoutedEventArgs e)
        {
            _first = Int32.Parse(Text_Result.Text);
            _operation = '-';
            Text_Result.Clear();
        }

        private void Add_click(object sender, RoutedEventArgs e)
        {
            _first = Int32.Parse(Text_Result.Text);
            _operation = '+';
            Text_Result.Clear();
        }



        private void Equal_click(object sender, RoutedEventArgs e)
        {
            _second = Int32.Parse(Text_Result.Text);
            int result = 0;
            if (_operation == '+')
            {
                result = _first + _second;
            }
            else if (_operation == '-')
            {
                result = _first - _second;
            }
            else if (_operation == '*')
            {
                result = _first * _second;
            }
            else if (_operation == '/')
            {
                result = _first / _second;
            }
            else if (_operation == '^')
            {
                result = (int)Math.Pow(_first, _second);
            }

            if (Text_Result.Text == "0")
            {
                Text_Result.Clear();
            }
            Text_Result.Text = result.ToString();
        }

        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            // Clear the text box
            Text_Result.Clear();
            // Reset variables
            _first = 0;
            _second = 0;
            _operation = '\0';
        }
    }
}
