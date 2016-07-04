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

namespace WpfSample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int X { get; set; } //первый 
        public int Y { get; set; } //второй
        public MainWindow()
        {
            InitializeComponent();
            
            X = 0;
            Y = 0;
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Z = 0;
            try
            {
                checked
                {
                    Z = X + Y;
                }
            }
            catch (OverflowException)
            { }
            result.Text = Z.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text = (X - Y).ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            result.Text = (X * Y).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            result.Text = (X / Y).ToString();
        }
    }
}
