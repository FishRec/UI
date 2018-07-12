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
    /// UC0104_SS04.xaml 的互動邏輯
    /// </summary>
    public partial class UC0104_SS04 : Page
    {
        public UC0104_SS04()
        {
            InitializeComponent();
        }
        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0104_4.Content = new UC0101_SS03();
        }

        private void gotoType(object sender, RoutedEventArgs e)
        {
            UC0104_4.Content = new UC0104_SS01();
        }
    }
}
