using System;
using System.Collections.Generic;
using System.Data;
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
using MySql.Data.MySqlClient;


namespace fish
{
    /// <summary>
    /// UC0102_SS02.xaml 的互動邏輯
    /// </summary>
    /// 

    
    public partial class UC0102_SS02 : Page
    {
        public UC0102_SS02()
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

        private void Search_click(object sender, RoutedEventArgs e)
        {
            String[] d = new string[5];
            d[0] = year.Text + "/" + month.Text + "/" + date.Text;
            String lo = longtit.Text + @long.Text;
            String la = latit.Text + lati.Text;
            Boolean LEDc = LED.IsChecked.Value;
            Boolean ARGOc = ARGO.IsChecked.Value;
            //Console.WriteLine(d);
            int[] monthday = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int yy = Int32.Parse(year.Text);
            int mm = Int32.Parse(month.Text);
            int dd = Int32.Parse(date.Text);
            if (yy % 4 == 0 && yy % 100 != 0 || yy % 400 == 0)
                monthday[2] = 29;
            for(int i = 1; i <= 4; i++)
            {
                dd--;
                if(dd == 0)
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
                Console.WriteLine(d[i]);
            }
            string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            try
            {
                conn.Open();

                string sql_time = "SELECT * FROM `uc0102` WHERE `date` = '" + d[0] + "'";
                for (int i = 1; i < 5; i++)
                {
                    sql_time += " or `date` = '" + d[i] + "'";
                }
                //string sql = @" SELECT `temperature` FROM `uc0102`";
                MySqlCommand cmd = new MySqlCommand(sql_time, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read() || (!LEDc && !ARGOc))
                {
                    Console.WriteLine("NULL");
                    UC0102_2.Content = new UC0102_SS04();
                }
                else
                {
                    Console.WriteLine("YES");
                    MainWindow.UC0102date = d;
                    MainWindow.UC0102LED = LEDc;
                    MainWindow.UC0102ARGO = ARGOc;
                    UC0102_2.Content = new UC0102_SS03();
                }
            }
            catch (Exception ex)
            {
                UC0102_2.Content = new UC0102_SS04();
            }
            
            conn.Close();
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

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0102_2.Content = new UC0101_SS03();
            MainWindow.UC0102date = null;
            MainWindow.UC0102lo = null;
            MainWindow.UC0102la = null;
            MainWindow.UC0102LED = false;
            MainWindow.UC0102ARGO = false;
        }
        private void gotoSea(object sender, RoutedEventArgs e)
        {
            UC0102_2.Content = new UC0102_SS01();
            MainWindow.UC0102date = null;
            MainWindow.UC0102lo = null;
            MainWindow.UC0102la = null;
            MainWindow.UC0102LED = false;
            MainWindow.UC0102ARGO = false;
        }
        
    }
}
