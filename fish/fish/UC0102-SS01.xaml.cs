﻿using System;
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
    /// UC0102_SS01.xaml 的互動邏輯
    /// </summary>
    public partial class UC0102_SS01 : Page
    {
        public UC0102_SS01()
        {
            InitializeComponent();
        }
        private void Search_sea_temperature(object sender, RoutedEventArgs e)
        {
            UC0102_1.Content = new UC0102_SS02();
        }
        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0102_1.Content = new UC0101_SS03();
            MainWindow.UC0102date = null;
            MainWindow.UC0102lo = null;
            MainWindow.UC0102la = null;
            MainWindow.UC0102LED = false;
            MainWindow.UC0102ARGO = false;
        }
    }
}
