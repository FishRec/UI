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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string UC0101id = null;

        public static string[] UC0102date = new string[5];
        public static string UC0102lo = null;
        public static string UC0102la = null;
        public static Boolean UC0102LED = false;
        public static Boolean UC0102ARGO = false;

        public static string UC0103path = null;

        public static string[] UC0104date = new string[30];
        public static string UC0104lo = null;
        public static string UC0104la = null;
        public static string UC0104LED = null;

        public static List<string> UC0105path = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            home.Content = new UC0101_SS01();
        }
    }
}
