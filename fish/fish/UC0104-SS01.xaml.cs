using MySql.Data.MySqlClient;
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
    /// UC0104_SS01.xaml 的互動邏輯
    /// </summary>
    public partial class UC0104_SS01 : Page
    {
        public UC0104_SS01()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
                date.Items.Add(i.ToString("D2"));
            date.SelectedItem = DateTime.Now.ToString("dd");
            for (int i = 1; i <= 12; i++)
                month.Items.Add(i.ToString("D2"));
            month.SelectedItem = DateTime.Now.ToString("MM");
            for (int i = 2010; i <= 2020; i++)
                year.Items.Add(i.ToString("D4"));
            year.SelectedItem = DateTime.Now.ToString("yyyy");
            @long.Items.Add("°E");
            @long.Items.Add("°W");
            @long.SelectedItem = "°E";
            lati.Items.Add("°N");
            lati.Items.Add("°S");
            lati.SelectedItem = "°N";
            latit.Text = "請輸入緯度資訊\r\n最多輸至小數點後三位";
            longtit.Text = "請輸入經度資訊\r\n最多輸至小數點後三位";
        }

        private void Long_enter(object sender, RoutedEventArgs e)
        {
            if (longtit.Text == "請輸入經度資訊\r\n最多輸至小數點後三位")
            {
                longtit.Text = "";
                longtit.Foreground = Brushes.Black;
            }
        }

        private void Lati_enter(object sender, RoutedEventArgs e)
        {
            if (latit.Text == "請輸入緯度資訊\r\n最多輸至小數點後三位")
            {
                latit.Text = "";
                latit.Foreground = Brushes.Black;
            }
        }

        private void Long_leave(object sender, RoutedEventArgs e)
        {
            if (longtit.Text == "")
            {
                longtit.Text = "請輸入經度資訊\r\n最多輸至小數點後三位";
                longtit.Foreground = Brushes.Silver;
            }
        }

        private void Lati_leave(object sender, RoutedEventArgs e)
        {
            if (latit.Text == "")
            {
                latit.Text = "請輸入緯度資訊\r\n最多輸至小數點後三位";
                latit.Foreground = Brushes.Silver;
            }
        }

        private void Long_down(object sender, RoutedEventArgs e)
        {
            if (longtit.Text == "請輸入經度資訊\r\n最多輸至小數點後三位")
            {
                longtit.Text = "";
                longtit.Foreground = Brushes.Black;
            }
        }

        private void Lati_down(object sender, RoutedEventArgs e)
        {
            if (latit.Text == "請輸入緯度資訊\r\n最多輸至小數點後三位")
            {
                latit.Text = "";
                latit.Foreground = Brushes.Black;
            }
        }

        private void table_click(object sender, RoutedEventArgs e)
        {
            if (table.IsChecked.Value)
            {
                history.IsChecked = false;
                type.Visibility = Visibility.Hidden;
                datee.Visibility = Visibility.Hidden;
                LEDid.Visibility = Visibility.Hidden;
                date.Visibility = Visibility.Hidden;
                month.Visibility = Visibility.Hidden;
                year.Visibility = Visibility.Hidden;
            }
            else
            {
                type.Visibility = Visibility.Visible;
                datee.Visibility = Visibility.Visible;
                LEDid.Visibility = Visibility.Visible;
                date.Visibility = Visibility.Visible;
                month.Visibility = Visibility.Visible;
                year.Visibility = Visibility.Visible;
            }
        }

        private void history_click(object sender, RoutedEventArgs e)
        {
            if (history.IsChecked.Value)
            {
                table.IsChecked = false;
                type.Visibility = Visibility.Visible;
                datee.Visibility = Visibility.Visible;
                LEDid.Visibility = Visibility.Visible;
                date.Visibility = Visibility.Visible;
                month.Visibility = Visibility.Visible;
                year.Visibility = Visibility.Visible;
            }
        }

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0104_1.Content = new UC0101_SS03();
        }

        private void type_search(object sender, RoutedEventArgs e)
        {
            String[] d = new string[30];
            d[0] = year.Text + "/" + month.Text + "/" + date.Text;
            String lo = "";
            if (longtit.Text != "請輸入緯度資訊\r\n最多輸至小數點後三位")
                lo = longtit.Text + @long.Text;
            String la = "";
            if(latit.Text != "請輸入緯度資訊\r\n最多輸至小數點後三位")
                la = latit.Text + lati.Text;

            String le = LEDid.Text;
            Boolean tablec = table.IsChecked.Value;
            Boolean historyc = history.IsChecked.Value;

            if (!tablec && !historyc)
            {
                UC0104_1.Content = new UC0104_SS04();
            }
            else
            {
                string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();

                try
                {
                    conn.Open();
                    string sql = "";
                    if (tablec)
                        sql = "SELECT * FROM `uc0104_2` WHERE `latitude` = '" + la + "' and `longitude` = '" + lo + "'";
                    else if (historyc)
                    {
                        sql = "SELECT * FROM `uc0104_3` WHERE (`latitude`='" + la + "' and `longitude`='" + lo + "' and `date`='" + d[0] + "')";
                        int[] monthday = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                        int yy = Int32.Parse(year.Text);
                        int mm = Int32.Parse(month.Text);
                        int dd = Int32.Parse(date.Text);
                        if (yy % 4 == 0 && yy % 100 != 0 || yy % 400 == 0)
                            monthday[2] = 29;
                        for (int i = 1; i <= 29; i++)
                        {
                            dd--;
                            if (dd == 0)
                            {
                                mm--;
                                if (mm == 0)
                                {
                                    yy--;
                                    mm = 12;
                                }
                                dd = monthday[mm];
                            }
                            d[i] = yy.ToString() + "/" + mm.ToString("D2") + "/" + dd.ToString("D2");
                            sql += " or (`latitude`='" + la + "' and `longitude`='" + lo + "' and `date`='" + d[i] + "')";
                        }

                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        UC0104_1.Content = new UC0104_SS04();
                    }
                    else
                    {
                        MainWindow.UC0104date = d;
                        MainWindow.UC0104la = la;
                        MainWindow.UC0104lo = lo;
                        MainWindow.UC0104LED = le;
                        if (tablec)
                            UC0104_1.Content = new UC0104_SS02();
                        else if (historyc)
                            UC0104_1.Content = new UC0104_SS03();
                    }
                }
                catch (Exception ex)
                {
                    UC0104_1.Content = new UC0104_SS04();
                }
                
                conn.Close();
            }
        }
    }
}
