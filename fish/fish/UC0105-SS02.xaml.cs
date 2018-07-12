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
    /// UC0105_SS02.xaml 的互動邏輯
    /// </summary>
    public partial class UC0105_SS02 : Page
    {
        private bool play = true;
        public UC0105_SS02()
        {
            InitializeComponent();
            showpath.Text = MainWindow.UC0105path[0];
            for(int i = 1; i < MainWindow.UC0105path.Count; i++)
            {
                showpath.Text += "\r\n" + MainWindow.UC0105path[i];
            }
            mediaElement.Source = new Uri(MainWindow.UC0105path[0], UriKind.Relative);
            mediaElement.Play();
        }

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            MainWindow.UC0105path.Clear();
            UC0105_2.Content = new UC0101_SS03();
        }

        private void gotoDynamic(object sender, RoutedEventArgs e)
        {
            MainWindow.UC0105path.Clear();
            UC0105_2.Content = new UC0105_SS01();
        }

        private void mediaElement_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (play)
            {
                mediaElement.Pause();
                play = false;
            }
            else
            {
                mediaElement.Play();
                play = true;
            }
            
        }
    }
}
