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
    /// UC0103_SS03.xaml 的互動邏輯
    /// </summary>
    public partial class UC0103_SS03 : Page
    {
        public UC0103_SS03()
        {
            InitializeComponent();
        }

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0103_3.Content = new UC0101_SS03();
        }

        private void gotoStatic(object sender, RoutedEventArgs e)
        {
            UC0103_3.Content = new UC0103_SS01();
        }
    }
}
