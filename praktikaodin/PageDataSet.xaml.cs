using praktikaodin.PraktikaodinDataSetTableAdapters;
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
using praktikaodin.PraktikaodinDataSetTableAdapters;

namespace praktikaodin
{
    public partial class PageDataSet : Page
    {
        ShoeInventoryTableAdapter shoeInventoryTableAdapter = new ShoeInventoryTableAdapter();
        ColorTableAdapter colorTableAdapter = new ColorTableAdapter();
        SizeTableAdapter sizeTableAdapter = new SizeTableAdapter();
        ShoeTableAdapter shoeTableAdapter = new ShoeTableAdapter();
        public PageDataSet()
        {
            InitializeComponent();
            ShoeInventoryDataGrid.ItemsSource = shoeInventoryTableAdapter.GetData();
            PageDataSetComboBox1.ItemsSource = colorTableAdapter.GetData();
            PageDataSetComboBox1.DisplayMemberPath = "Color";
            PageDataSetComboBox2.ItemsSource = sizeTableAdapter.GetData();
            PageDataSetComboBox2.DisplayMemberPath = "Size";
            PageDataSetComboBox3.ItemsSource = shoeTableAdapter.GetData();
            PageDataSetComboBox3.DisplayMemberPath = "ShoeType";
        }
    }
}
