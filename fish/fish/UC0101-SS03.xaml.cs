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
    /// UC0101_SS03.xaml 的互動邏輯
    /// </summary>
    public partial class UC0101_SS03 : Page
    {
        public UC0101_SS03()
        {
            InitializeComponent();
        }
        private void Search_sea_temperature(object sender, RoutedEventArgs e)
        {
            UC0101_3.Content = new UC0102_SS01();
        }
        private void Search_static(object sender, RoutedEventArgs e)
        {
            UC0101_3.Content = new UC0103_SS01();
        }
        private void Search_fish_type(object sender, RoutedEventArgs e)
        {
            UC0101_3.Content = new UC0104_SS01();
        }
        private void Search_dynamic(object sender, RoutedEventArgs e)
        {
            UC0101_3.Content = new UC0105_SS01();
        }
    }
}
