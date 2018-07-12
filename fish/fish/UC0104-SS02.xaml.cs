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
    /// UC0104_SS02.xaml 的互動邏輯
    /// </summary>
    public partial class UC0104_SS02 : Page
    {
        public UC0104_SS02()
        {
            InitializeComponent();
            string[] fishname = { "大目鰱", "鯖魚", "鬼頭刀", "白帶魚" };
            int[] fishnum = new int[4];
            textl.Text = MainWindow.UC0104la + ", " + MainWindow.UC0104lo;
            textd.Text = MainWindow.UC0104date[0];
            string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            string sql = "SELECT * FROM `uc0104_2` WHERE `latitude` = '" + MainWindow.UC0104la + "' and `longitude` = '" + MainWindow.UC0104lo + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            fishnum[0] = Int32.Parse(reader["big"].ToString());
            fishnum[1] = Int32.Parse(reader["clear"].ToString());
            fishnum[2] = Int32.Parse(reader["ghost"].ToString());
            fishnum[3] = Int32.Parse(reader["white"].ToString());
            for(int i = 0; i < 4; i++)
            {
                int largest = fishnum[0];
                int larindex = 0;
                for(int j = 1; j < 4; j++)
                {
                    if(largest < fishnum[j])
                    {
                        largest = fishnum[j];
                        larindex = j;
                    }
                    
                }
                switch (i)
                {
                    case 0:
                        text1.Text = fishname[larindex];
                        text1p.Text = fishnum[larindex].ToString() + "%";
                        bar1.Value = fishnum[larindex];
                        break;
                    case 1:
                        text2.Text = fishname[larindex];
                        text2p.Text = fishnum[larindex].ToString() + "%";
                        bar2.Value = fishnum[larindex];
                        break;
                    case 2:
                        text3.Text = fishname[larindex];
                        text3p.Text = fishnum[larindex].ToString() + "%";
                        bar3.Value = fishnum[larindex];
                        break;
                    case 3:
                        text4.Text = fishname[larindex];
                        text4p.Text = fishnum[larindex].ToString() + "%";
                        bar4.Value = fishnum[larindex];
                        break;
                }
                fishnum[larindex] = -1;
            }
            conn.Close();
        }

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0104_2.Content = new UC0101_SS03();
        }

        private void gotoType(object sender, RoutedEventArgs e)
        {
            UC0104_2.Content = new UC0104_SS01();
        }
    }
}
