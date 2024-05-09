using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Project_ITI_Management_System.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }
        private void color_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Red;
                    break;
                case "Green":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Green;
                    break;
                case "Blue":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
                case "Yellow":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Yellow;
                    break;
                case "Orange":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Orange;
                    break;
                case "Black":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Black;
                    break;
                case "Cyan":
                    InkCanvas1.DefaultDrawingAttributes.Color = Colors.Cyan;
                    break;
            }
        }

        private void modes_Checked(object sender, RoutedEventArgs e)
        {
            InkCanvasEditingMode edit;
            string str;
            if (sender is RadioButton)
            {
                str = ((RadioButton)sender).Content.ToString();
                edit = (InkCanvasEditingMode)Enum.Parse(typeof(InkCanvasEditingMode), str);

                InkCanvas1.EditingMode = edit;
            }
        }



        private void Drawing_Checked(object sender, RoutedEventArgs e)
        {
            var draw = (RadioButton)sender;
            var Shape_Draw = draw.Content.ToString();
            if (sender is RadioButton)
            {
                switch (Shape_Draw)
                {
                    case "Ellipse":
                        this.InkCanvas1.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Ellipse;
                        break;
                    case "Rectangle":
                        this.InkCanvas1.DefaultDrawingAttributes.StylusTip = System.Windows.Ink.StylusTip.Rectangle;
                        break;
                }
            }
        }

        private void SetBrushSize(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton)
            {
                double newSize;
                switch (((RadioButton)sender).Content.ToString())
                {
                    case "Small":
                        newSize = 5;
                        InkCanvas1.DefaultDrawingAttributes.Width = newSize;
                        InkCanvas1.DefaultDrawingAttributes.Height = newSize;
                        break;
                    case "Normal":
                        newSize = 10;
                        InkCanvas1.DefaultDrawingAttributes.Width = newSize;
                        InkCanvas1.DefaultDrawingAttributes.Height = newSize;
                        break;
                    case "Large":
                        newSize = 15;
                        InkCanvas1.DefaultDrawingAttributes.Width = newSize;
                        InkCanvas1.DefaultDrawingAttributes.Height = newSize;
                        break;
                    default:
                        newSize = 10;
                        InkCanvas1.DefaultDrawingAttributes.Width = newSize;
                        InkCanvas1.DefaultDrawingAttributes.Height = newSize;
                        break;
                }
            }

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            this.InkCanvas1.Strokes.Clear();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "Ink files (*.isf)|*.isf",
                DefaultExt = ".isf"
            };

            if (saveDialog.ShowDialog() == true)
            {
                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    this.InkCanvas1.Strokes.Save(fs);
                }
                MessageBox.Show("Save File Successfully");
            }
        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Ink files (*.isf)|*.isf",
                DefaultExt = ".isf"
            };

            if (openDialog.ShowDialog() == true)
            {
                string filePath = openDialog.FileName;

                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        StrokeCollection loadedStrokes = new StrokeCollection(fs);
                        this.InkCanvas1.Strokes = loadedStrokes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading strokes: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if (this.InkCanvas1.GetSelectedStrokes().Count > 0)
                this.InkCanvas1.CopySelection();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            if (this.InkCanvas1.GetSelectedStrokes().Count > 0)
                this.InkCanvas1.CutSelection();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            if (this.InkCanvas1.CanPaste())
                this.InkCanvas1.Paste();
        }

        private void SaveAsPicture_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "PNG files (*.png)|*.png",
                DefaultExt = ".png"
            };

            if (saveDialog.ShowDialog() == true)
            {
                RenderTargetBitmap renderBitmap = new RenderTargetBitmap(
                    (int)InkCanvas1.ActualWidth,
                    (int)InkCanvas1.ActualHeight,
                    96d,
                    96d,
                    PixelFormats.Pbgra32);

                renderBitmap.Render(InkCanvas1);

                PngBitmapEncoder pngEncoder = new PngBitmapEncoder();

                pngEncoder.Frames.Add(BitmapFrame.Create(renderBitmap));

                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    pngEncoder.Save(fs);
                    MessageBox.Show("Save Image Successfully");
                }
            }
        }
    }
}
