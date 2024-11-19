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
        public ObservableCollection<Food> MenuItemsUpdate { get; set; }
        private DBUtils dbUtils = new DBUtils();

        public MainWindow()
        {
            InitializeComponent();
            ActionPanel.Visibility = Visibility.Collapsed;


            using (MySqlConnection connection = dbUtils.GetMySqlConnection())
            {
                connection.Open();
                thucDon.Background = Brushes.LightGray;
                MenuItems = new ObservableCollection<Food>();
                MenuItemsUpdate = new ObservableCollection<Food>();
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
                {MySqlException: 'Unknown column 'LoaiMon
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
          
        }
        private void View_AddFood(object sender, RoutedEventArgs e)
        {
            new AddFood().Show();

        }

        private void buttonSua_Click(object sender, RoutedEventArgs e)
        {
           
            ActionPanel.Visibility = Visibility.Visible;

            MenuDataGrid.IsReadOnly = false;
            Food  selectedRow =  MenuDataGrid.SelectedItem as Food;
            if (selectedRow != null)
            {
                MenuItemsUpdate.Add(selectedRow);
            }










        }

        private void buttonUpdateSua_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connection = dbUtils.GetMySqlConnection())
            {
                connection.Open();
                Food selectedRow = MenuDataGrid.SelectedItem as Food;
                if (selectedRow != null)
                {
                    MenuItemsUpdate.Add(selectedRow);
                }

                string query = "UPDATE products SET LoaiMon = @LoaiMon, TenMon = @TenMon, NhomThucDon = @NhomThucDon, DonViTinh = @DonViTinh, Gia = @Gia WHERE MaMon = @MaMon";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LoaiMon", selectedRow.LoaiMon);
                cmd.Parameters.AddWithValue("@MaMon", selectedRow.MaMon);
                cmd.Parameters.AddWithValue("@TenMon", selectedRow.TenMon);
                cmd.Parameters.AddWithValue("@NhomThucDon", selectedRow.NhomThucDon);
                cmd.Parameters.AddWithValue("@DonViTinh", selectedRow.DonViTinh);
                cmd.Parameters.AddWithValue("@Gia", selectedRow.Gia);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void ButtonHuySua_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.buttonSua_Click(sender, e);
            main.Show();


        }
    }


    }
