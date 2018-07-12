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

namespace fish
{
    /// <summary>
    /// UC0105_SS03.xaml 的互動邏輯
    /// </summary>
    public partial class UC0105_SS03 : Page
    {
        public UC0105_SS03()
        {
            InitializeComponent();
        }

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            MainWindow.UC0105path = null;
            UC0105_3.Content = new UC0101_SS03();
        }

        private void gotoDynamic(object sender, RoutedEventArgs e)
        {
            MainWindow.UC0105path.Clear();
            UC0105_3.Content = new UC0105_SS01();
        }
    }
}
