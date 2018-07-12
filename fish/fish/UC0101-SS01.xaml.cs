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
    /// UC0101_SS01.xaml 的互動邏輯
    /// </summary>
    public partial class UC0101_SS01 : Page
    {
        public UC0101_SS01()
        {
            InitializeComponent();
        }

        private void leave(object sender, RoutedEventArgs e)
        {
            //if (code.Text == "")
            //{
            //    code.Text = "請輸入代碼，由7位英文和數字組成";
            //    code.Foreground = Brushes.Silver;
            //}
        }

        private void enter(object sender, RoutedEventArgs e)
        {
            //if (code.Text == "請輸入代碼，由7位英文和數字組成")
            //{
            //    code.Text = "";
            //    code.Foreground = Brushes.Black;
            //}
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            MainWindow.UC0101id = code.Text;
            UC0101_1.Content = new UC0101_SS02();
        }

        private void code_down(object sender, RoutedEventArgs e)
        {
            if (code.Text == "請輸入代碼，由7位英文和數字組成")
            {
                code.Text = "";
                code.Foreground = Brushes.Black;
            }
        }
    }
}
