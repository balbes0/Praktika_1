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
    public partial class PageEF : Page
    {
        private PraktikaodinEntities context = new PraktikaodinEntities();
        public PageEF()
        {
            InitializeComponent();
            ShoeInventoryEF.ItemsSource = context.ShoeInventory.ToList();
            PageEFComboBox1.ItemsSource = context.Color.ToList();
            PageEFComboBox1.DisplayMemberPath = "Color1";
            PageEFComboBox2.ItemsSource = context.Size.ToList();
            PageEFComboBox2.DisplayMemberPath = "Size1";
            PageEFComboBox3.ItemsSource = context.Shoe.ToList();
            PageEFComboBox3.DisplayMemberPath = "ShoeType";
        }
    }
}
