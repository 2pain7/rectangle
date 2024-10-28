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

namespace Menu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Findcolor.Visibility = Visibility.Hidden;
            Paint.Visibility = Visibility.Hidden;
           Findsize.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Paint.Visibility = Visibility.Hidden;
            Findsize.Visibility = Visibility.Hidden;
            Findcolor.Visibility= Visibility.Visible;
        }
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Findcolor.Visibility = Visibility.Hidden;
            Findsize.Visibility = Visibility.Hidden;
            Paint.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void color_Click(object sender, RoutedEventArgs e)
        {
            
            Rectangle rectangle = new Rectangle();
            int a = Convert.ToInt32(aa.Text);
            int b = Convert.ToInt32(bb.Text);
            Color color = Colors.Black; ;
            if (red.IsChecked==true)
            {
                rectangle.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (green.IsChecked == true)
            {
                rectangle.Fill = new SolidColorBrush(Colors.Green);
            }
            else if (blue.IsChecked == true)
            {
                rectangle.Fill = new SolidColorBrush(Colors.Blue);
            }
            else
            {
                MessageBox.Show("Выберите цвет");
            }
            rectangle.Width = b; 
            rectangle.Height = a;
            if (a >250 || b>600)
            {
                MessageBox.Show("Превышение размеров");
            }
            else
            { 
                MyCanvas.Children.Add(rectangle);
            }
        }
    }
}
