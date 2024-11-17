using MySql.Data.MySqlClient;
using QLNH.dao;
using QLNH.Object;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace QLNH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Food> MenuItems { get; set; }
        private DBUtils dbUtils = new DBUtils();

        public MainWindow()
        {
            InitializeComponent();

            using (MySqlConnection connection = dbUtils.GetMySqlConnection())
            {
                connection.Open();
                thucDon.Background = Brushes.LightGray;
                MenuItems = new ObservableCollection<Food>();
                LoadData();
            
                MenuDataGrid.ItemsSource = MenuItems;
                connection.Close();
            }
        }
        private void LoadData()
        {
            using (MySqlConnection connection = dbUtils.GetMySqlConnection())
            {
                connection.Open();
                string query = "SELECT LoaiMon, MaMon, TenMon, NhomThucDon, DonViTinh, Gia FROM products";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    decimal gia = row["Gia"] != DBNull.Value ? Convert.ToDecimal(row["Gia"]) : 0;

                    Food item = new Food(
                        row["LoaiMon"].ToString(),
                        row["MaMon"].ToString(),
                        row["TenMon"].ToString(),
                        row["NhomThucDon"].ToString(),
                        row["DonViTinh"].ToString(),
                        gia
                    );
                    MenuItems.Add(item);
                }
            }
        }
        private void View_ThucDon(object sender, RoutedEventArgs e)
        {
            // Xử lý sự kiện cho nút Thực đơn
            MessageBox.Show("Bạn đã nhấn nút Thực đơn!");
        }
        private void View_AddFood(object sender, RoutedEventArgs e)
        {
            new AddFood().Show();

        }
    }


    }
