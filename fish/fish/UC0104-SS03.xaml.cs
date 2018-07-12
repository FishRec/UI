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
    /// UC0104_SS03.xaml 的互動邏輯
    /// </summary>
    public partial class UC0104_SS03 : Page
    {
        public UC0104_SS03()
        {
            InitializeComponent();
            string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            string sql = "SELECT * FROM `uc0104_3` WHERE (`latitude`='" + MainWindow.UC0104la + "' and `longitude`='" + MainWindow.UC0104lo + "' and `date`='" + MainWindow.UC0104date[0] + "')";
            for(int j = 1; j < 30; j++)
            {
                sql += " or (`latitude`='" + MainWindow.UC0104la + "' and `longitude`='" + MainWindow.UC0104lo + "' and `date`='" + MainWindow.UC0104date[j] + "')";
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            int number = 1;
            int total = 7;
            int[] span = { 1, 3, 3, 3, 2, 1, 1 };
            String[] paragraph = new String[total];
            String[] title = { "\r\n順\r\n序\r\n", "\r\n經緯度(緯,經)\r\n\r\n", "\r\n集魚燈型號\r\n\r\n", "\r\n時間(YYYY/MM/\r\nDD hh:mm:ss\r\n", "\r\n波長\r\n\r\n", "\r\n魚種\r\n\r\n", "\r\n次數\r\n\r\n" };
            while (reader.Read())
            {
                if (i % 6 == 0)
                {
                    tablerowgroup.Rows.Add(new TableRow());
                    TableRow titleRow = tablerowgroup.Rows[i];
                    titleRow.Background = Brushes.SteelBlue;
                    titleRow.Foreground = Brushes.White;
                    titleRow.FontSize = 18;
                    for (int j = 0; j < total; j++)
                    {
                        titleRow.Cells.Add(new TableCell(new Paragraph(new Run(title[j]))));
                        titleRow.Cells[j].ColumnSpan = span[j];
                        titleRow.Cells[j].TextAlignment = TextAlignment.Center;
                        titleRow.Cells[j].BorderBrush = Brushes.White;
                        titleRow.Cells[j].BorderThickness = new Thickness(0.5);
                    }
                    i++;
                }
                paragraph[0] = "\r\n  " + number.ToString() + "\r\n";
                paragraph[1] = "\r\n(" + reader["latitude"] + ", " + reader["longitude"] + ")";
                paragraph[2] = "\r\n" + reader["ledtype"].ToString();
                paragraph[3] = "\r\n" + reader["date"] + "  " + reader["time"] + "\r\n";
                paragraph[4] = "\r\n" + reader["wave"].ToString();
                paragraph[5] = "\r\n" + reader["fish"].ToString();
                paragraph[6] = "\r\n  " + reader["times"].ToString();

                tablerowgroup.Rows.Add(new TableRow());
                TableRow currentRow = tablerowgroup.Rows[i];
                if (i % 2 == 1)
                    currentRow.Background = Brushes.PowderBlue;
                else
                    currentRow.Background = Brushes.SkyBlue;
                currentRow.FontSize = 16;
                for (int j = 0; j < total; j++)
                {
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(paragraph[j]))));
                    currentRow.Cells[j].ColumnSpan = span[j];
                    currentRow.Cells[j].TextAlignment = TextAlignment.Left;
                    currentRow.Cells[j].BorderBrush = Brushes.White;
                    currentRow.Cells[j].BorderThickness = new Thickness(0.5);
                }
                i++;
                number++;
            }

            conn.Close();
        }

        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0104_3.Content = new UC0101_SS03();
        }

        private void gotoType(object sender, RoutedEventArgs e)
        {
            UC0104_3.Content = new UC0104_SS01();
        }
    }
}
