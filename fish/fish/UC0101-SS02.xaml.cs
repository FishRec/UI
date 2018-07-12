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
    /// UC0101_SS02.xaml 的互動邏輯
    /// </summary>
    public partial class UC0101_SS02 : Page
    {
        public UC0101_SS02()
        {
            InitializeComponent();
            string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            try
            {
                conn.Open();

                string sql_time = "SELECT * FROM `uc0101_1` WHERE `companyid` = '" + MainWindow.UC0101id + "'";
                MySqlCommand cmd = new MySqlCommand(sql_time, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()){
                    tid.Text = reader["companyid"].ToString();
                    tname.Text = reader["company"].ToString();
                }
            }
            catch (Exception ex)
            {
                //UC0101_2.Content = new UC0102_SS01();
            }

            conn.Close();


        }
        private void id_leave(object sender, RoutedEventArgs e)
        {
            if (uid.Text == "")
            {
                uid.Text = "請輸入帳號，由6~10位英文和數字組成";
                uid.Foreground = Brushes.Silver;
            }
        }

        private void id_enter(object sender, RoutedEventArgs e)
        {
            if (uid.Text == "請輸入帳號，由6~10位英文和數字組成")
            {
                uid.Text = "";
                uid.Foreground = Brushes.Black;
            }
        }

        private void pwd_leave(object sender, RoutedEventArgs e)
        {
            if (pwd.Text == "")
            {
                pwd.Text = "請輸入密碼，由6~10位英文和數字組成";
                pwd.Foreground = Brushes.Silver;
            }
        }

        private void pwd_enter(object sender, RoutedEventArgs e)
        {
            if (pwd.Text == "請輸入密碼，由6~10位英文和數字組成")
            {
                pwd.Text = "";
                pwd.Foreground = Brushes.Black;
            }
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            MainWindow.UC0101id = null;
            UC0101_2.Content = new UC0101_SS01();
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            UC0101_2.Content = new UC0101_SS02();
        }

        private void login_click(object sender, RoutedEventArgs e)
        {
            if(uid.Text == "" || pwdp.Password == "")
            {
                UC0101_2.Content = new UC0101_SS04();
            }
            string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            try
            {
                conn.Open();

                string sql_time = "SELECT * FROM `uc0101_2` WHERE `companyid` = '" + MainWindow.UC0101id + "' and `userid` = '" + uid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql_time, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                
                if(!reader.Read())
                    UC0101_2.Content = new UC0101_SS04();

                if (reader["password"].ToString() == pwdp.Password)
                {
                    UC0101_2.Content = new UC0101_SS03();
                }
                else
                {
                    UC0101_2.Content = new UC0101_SS04();
                }
            }
            catch (Exception ex)
            {
                //UC0101_2.Content = new UC0102_SS01();
            }

            conn.Close();
        }

        private void pwd_down(object sender, RoutedEventArgs e)
        {
            pwd.Visibility = Visibility.Hidden;
            pwdp.Visibility = Visibility.Visible;
            pwdp.Focus();
        }

        private void uid_down(object sender, RoutedEventArgs e)
        {
            if (uid.Text == "請輸入帳號，由6~10位英文和數字組成")
            {
                uid.Text = "";
                uid.Foreground = Brushes.Black;
            }
        }
    }
}
