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
    /// UC0105_SS01.xaml 的互動邏輯
    /// </summary>
    public partial class UC0105_SS01 : Page
    {
        public UC0105_SS01()
        {
            InitializeComponent();
        }
        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0105_1.Content = new UC0101_SS03();
        }

        private void dynamic_search(object sender, RoutedEventArgs e)
        {
            if (MainWindow.UC0105path.Count < 1)
            {
                UC0105_1.Content = new UC0105_SS03();
            }
            else
            {
                UC0105_1.Content = new UC0105_SS02();
            }
        }

        private void dynamic_select(object sender, RoutedEventArgs e)
        {
            if (MainWindow.UC0105path.Count < 5)
            {
                System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                openFileDialog1.InitialDirectory = "C:\\Users\\Taco\\Desktop\\魚魚";
                openFileDialog1.Filter = "(*.mp4;*.avi)|*.mp4;*.avi";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    string filename = System.IO.Path.GetFileName(path);
                    listView.Items.Add(filename);
                    MainWindow.UC0105path.Add(path);
                }
            }
        }

        private void dynamic_delete(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedValue != null)
            {
                MainWindow.UC0105path.RemoveAt(listView.SelectedIndex);
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }
    }
}
