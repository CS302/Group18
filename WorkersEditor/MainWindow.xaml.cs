using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WorkersLibrary;

namespace WorkersEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Worker> Workers { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Workers = new ObservableCollection<Worker>();
            Workers.Add(new Manager("Svetlana", 23, 785461, 15));
            Workers.Add(new Driver("John", 45, 463564, "BMW", 686));
            Workers.Add(new Manager("Alice", 25, 79991, 9));
            Workers.Add(new Driver("Hulk", 31, 65471, "Audi", 686));

            DataContext = this;
        }

        private void workersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Worker worker = (sender as ListBox).SelectedItem as Worker;
            if (worker != null)
            {
                detailsPanel.DataContext = worker;
                if (worker is Driver)
                {
                    ManInfo.Visibility = System.Windows.Visibility.Collapsed;
                    DrInfo.Visibility = System.Windows.Visibility.Visible;
                }
                if (worker is Manager)
                {
                    ManInfo.Visibility = System.Windows.Visibility.Visible;
                    DrInfo.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Worker delWorker = workersList.SelectedItem as Worker;
            if (delWorker != null)
            {
                Workers.Remove(delWorker);
                workersList.SelectedIndex = 0;
            }
        }
    }
}
