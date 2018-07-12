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
using System.IO;

namespace fish
{
    /// <summary>
    /// UC0103_SS01.xaml 的互動邏輯
    /// </summary>
    public partial class UC0103_SS01 : Page
    {
        public UC0103_SS01()
        {
            InitializeComponent();
        }
        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0103_1.Content = new UC0101_SS03();
        }

        private void now_click(object sender, RoutedEventArgs e)
        {
            five.IsChecked = false;
        }

        private void five_click(object sender, RoutedEventArgs e)
        {
            now.IsChecked = false;
        }

        
        private void static_search(object sender, RoutedEventArgs e)
        {
            if (MainWindow.UC0103path == null)
            {
                UC0103_1.Content = new UC0103_SS03();
            }
            else
            {
                UC0103_1.Content = new UC0103_SS02();
            }
        }

        private void static_select(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Users\\Taco\\Desktop\\魚魚";
            openFileDialog1.Filter = "(*.jpg;*.png)|*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string filename = System.IO.Path.GetFileName(path);
                filenameT.Text = filename;
                MainWindow.UC0103path = path;
            }
        }

    }
}
