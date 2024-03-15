using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using praktikaodin.PraktikaodinDataSetTableAdapters;

namespace praktikaodin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void EFButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageEF();
        }

        private void DataSetButton_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new PageDataSet();
        }
    }
}
