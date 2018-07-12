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
    /// UC0102_SS03.xaml 的互動邏輯
    /// </summary>
    public partial class UC0102_SS03 : Page
    {
        public UC0102_SS03()
        {
            InitializeComponent();
            //textdate.Text = MainWindow.UC0102date;
            string connString = "server=127.0.0.1;port=3306;user id=root;password=taco;database=fish;charset=utf8;SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            conn.Open();
            string sql_time = "";

            if (MainWindow.UC0102LED && MainWindow.UC0102ARGO)
            {
                sql_time = "SELECT * FROM `uc0102` WHERE `date` = '" + MainWindow.UC0102date[0] + "'";
                for (int n = 1; n < 5; n++)
                {
                    sql_time += " or '" + MainWindow.UC0102date[n] + "'";
                }
            }
            else if (MainWindow.UC0102LED)
            {
                sql_time = "SELECT * FROM `uc0102` WHERE (`date` = '" + MainWindow.UC0102date[0] + "' and `source` = 1)";
                for (int n = 1; n < 5; n++)
                {
                    sql_time += " or (`date` = '" + MainWindow.UC0102date[n] + "' and `source` = 1)";
                }
            }
            else if (MainWindow.UC0102ARGO)
            {
                sql_time = "SELECT * FROM `uc0102` WHERE `date` = '" + MainWindow.UC0102date[0] + "' and `source` = 2";
                for (int n = 1; n < 5; n++)
                {
                    sql_time += " or (`date` = '" + MainWindow.UC0102date[n] + "' and `source` = 2)";
                }
            }
            //string sql = @" SELECT `temperature` FROM `uc0102`";
            MySqlCommand cmd = new MySqlCommand(sql_time, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            int number = 1;
            int total = 7;
            int[] span = { 1, 2, 2, 4, 3, 3, 2 };
            String[] paragraph = new String[total];
            String[] title = {"\r\n順\r\n序\r\n", "\r\n距離現在\r\n位置(KM)\r\n", "\r\n方位\r\n\r\n", "\r\n經緯度(緯,經)\r\n\r\n", "\r\n海溫\r\n\r\n", "\r\n資料日期\r\n\r\n", "\r\n資料\r\n來源\r\n" };
            while (reader.Read())
            {
                if(i%6 == 0)
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
                paragraph[0] = "  " + number.ToString();
                string sla = reader["latitude"].ToString();
                string slo = reader["longitude"].ToString();
                Console.WriteLine(sla[sla.Length - 1] + " " + slo[slo.Length - 1]);
                double la = sla[sla.Length - 1].Equals('N') ? double.Parse(sla.Substring(0, sla.Length - 2)) : -double.Parse(sla.Substring(0, sla.Length - 2));
                double lo = slo[slo.Length - 1].Equals('E') ? double.Parse(slo.Substring(0, slo.Length - 2)) : -double.Parse(slo.Substring(0, slo.Length - 2));
                //double la = sla[sla.Length - 1].Equals('N') ? 90-double.Parse(sla.Substring(0, sla.Length - 2)) : 90+double.Parse(sla.Substring(0, sla.Length - 2));
                //double lo = slo[slo.Length - 1].Equals('E') ? double.Parse(slo.Substring(0, slo.Length - 2)) : -double.Parse(slo.Substring(0, slo.Length - 2));
                paragraph[1] = distance(la, lo).ToString();
                paragraph[2] = " ";
                paragraph[3] = "(" + reader["latitude"] + ", " + reader["longitude"] + ")";
                paragraph[5] = reader["date"] + "  " + reader["time"];
                if ((int)reader["source"] == 1)
                {
                    paragraph[4] = reader["temperature"].ToString() + "\r\n\r\n\r\n";
                    paragraph[6] = "集魚燈";
                }
                else
                {
                    MySqlConnection conn_argo = new MySqlConnection(connString);
                    MySqlCommand command_argo = conn_argo.CreateCommand();
                    conn_argo.Open();
                    string sql_argo = "SELECT * FROM `uc0102_argo` WHERE `date` = '" + reader["date"] + "' and `time` = '" + reader["time"] + "'";
                    MySqlCommand cmd_argo = new MySqlCommand(sql_argo, conn_argo);
                    MySqlDataReader reader_argo = cmd_argo.ExecuteReader();
                    for(int m = 0; m < 4; m++)
                    {
                        reader_argo.Read();
                        if (m == 0)
                            paragraph[4] = reader_argo["temperature"] + "(" + reader_argo["meter"] + ")";
                        else
                            paragraph[4] += "\r\n" + reader_argo["temperature"] + "(" + reader_argo["meter"] + ")";
                    }
                    conn_argo.Close();
                    paragraph[6] = "ARGO";
                }

                tablerowgroup.Rows.Add(new TableRow());
                TableRow currentRow = tablerowgroup.Rows[i];
                if(i%2 == 1)
                    currentRow.Background = Brushes.PowderBlue;
                else
                    currentRow.Background = Brushes.SkyBlue;
                currentRow.FontSize = 16;
                for(int j = 0; j < total; j++)
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

        private void Return_click(object sender, RoutedEventArgs e)
        {
            UC0102_3.Content = new UC0102_SS02();
            MainWindow.UC0102date = null;
            MainWindow.UC0102lo = null;
            MainWindow.UC0102la = null;
            MainWindow.UC0102LED = false;
            MainWindow.UC0102ARGO = false;
        }
        private void gotoHome(object sender, RoutedEventArgs e)
        {
            UC0102_3.Content = new UC0101_SS03();
            MainWindow.UC0102date = null;
            MainWindow.UC0102lo = null;
            MainWindow.UC0102la = null;
            MainWindow.UC0102LED = false;
            MainWindow.UC0102ARGO = false;
        }
        private void gotoSea(object sender, RoutedEventArgs e)
        {
            UC0102_3.Content = new UC0102_SS01();
            MainWindow.UC0102date = null;
            MainWindow.UC0102lo = null;
            MainWindow.UC0102la = null;
            MainWindow.UC0102LED = false;
            MainWindow.UC0102ARGO = false;
        }

        //Latitude: 1 deg = 110.574 km
        //Longitude: 1 deg = 111.320* cos(latitude) km

        //C = sin(MLatA)*sin(MLatB)*cos(MLonA-MLonB) + cos(MLatA)*cos(MLatB)
        //Distance = R* Arccos(C)*Pi/180
        private double distance(double la, double lo)
        {
            double R = 6371.004;
            double dis = 0;
            double nowlo = 120.55;
            double nowla = 67.58;
            //double nowla = 90-67.58;
            Console.WriteLine(la + " " + lo);
            double dla = Math.Round(Math.Abs(nowla - la));
            double dlo = Math.Round(Math.Abs(nowlo - lo));
            dlo = dlo >= 180 ? (360 - dlo) : dlo;
            Console.WriteLine(dla + " " + dlo);
            dis = dlo * (111.230 * Math.Cos(dla * 110.574));
            //double C = Math.Sin(nowla) * Math.Sin(la) * Math.Cos(nowlo - lo) + Math.Cos(nowla) * Math.Cos(la);
            //dis = R * Math.Acos(C) * Math.PI / 180;
            return Math.Round(dis);
        }
    }
}
