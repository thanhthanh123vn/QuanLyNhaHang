using MySql.Data.MySqlClient;
using QLNH.dao;
using QLNH.Object;

using QLNH.Views;
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
        public User users { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        
        

            ActionPanel.Visibility = Visibility.Collapsed;


         
                this.offButton();
                thucDon.Background = Brushes.LightGray;
                MenuItems = new ObservableCollection<Food>();
                MenuItemsUpdate = new ObservableCollection<Food>();
                LoadData();
              
            
        }
        public MainWindow(User user)
        {
            this.users = users;
            InitializeComponent();
          
            {
                if (user.Role != null && user.FullName != null)
                {
                    this.onButton();
                    string account = $"({user.Role}) {user.FullName}";
                    accountUser.Text = account; // Đảm bảo 'accountUser'
                 
                }

            }

            ActionPanel.Visibility = Visibility.Collapsed;


       
                thucDon.Background = Brushes.LightGray;
                MenuItems = new ObservableCollection<Food>();
                MenuItemsUpdate = new ObservableCollection<Food>();
                LoadData();

         

               
            
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
                MenuDataGrid.ItemsSource = MenuItems;
                connection.Close();
            }
        }
        private void View_ThucDon(object sender, RoutedEventArgs e)
        {
            // Xử lý sự kiện cho nút Thực đơn
          
        }
        private void View_AddFood(object sender, RoutedEventArgs e)
        {
            OffActionPanel();
            new AddFood().Show();

        }

        private void buttonSua_Click(object sender, RoutedEventArgs e)
        {

            OnActionPanel();

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
                    removeData();
                    LoadData();
                    MessageBox.Show("Cập nhật món ăn thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật món ăn thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                connection.Close();
            }

        }

        private void ButtonHuySua_Click(object sender, RoutedEventArgs e)
        {
           removeData();
            LoadData();

       
     
         


        }

        private void power_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);

        
            if (result == MessageBoxResult.Yes)
            {
              
                DangNhap dn = new DangNhap();
                this.Hide();
                dn.Show();
   
            }
            else
            {


            }

           



        }
        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection connection = dbUtils.GetMySqlConnection())
            {
                connection.Open();
                OffActionPanel();
                Food selectedRow = MenuDataGrid.SelectedItem as Food;
                if (selectedRow != null)
                {
                    MenuItemsUpdate.Add(selectedRow);
                }

                string query = "DELETE FROM products WHERE MaMon = @MaMon";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (selectedRow.MaMon == null)
                {
                    MessageBox.Show("Vui lòng chọn món để xóa!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                cmd.Parameters.AddWithValue("@MaMon", selectedRow.MaMon);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    removeData();
                    LoadData();
                    MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Xóa món ăn thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                connection.Close();
            }

        }
        public void removeData()
        {
            MenuItems.Clear();
            MenuDataGrid.ItemsSource = new List<object>();
        }
        public void onButton()
        {
            this.buttonSua.IsEnabled = true;
            this.buttonThem.IsEnabled = true;
            this.ButtonXoa.IsEnabled = true;
        }
        public void offButton()
        {
            this.buttonSua.IsEnabled = false;
            this.buttonThem.IsEnabled = false;
            this.ButtonXoa.IsEnabled = false;
        }
        public void OffActionPanel()
        {
            ActionPanel.Visibility = Visibility.Hidden;
        }
        public void OnActionPanel()
        {
            ActionPanel.Visibility = Visibility.Visible;
        }

    }


}
