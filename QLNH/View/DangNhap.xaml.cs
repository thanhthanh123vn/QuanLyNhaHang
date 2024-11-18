using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;


namespace QLNH.View
{
    /// <summary>
    /// Interaction logic for DangNhap.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string username = tendangnhap.Text;
            string password = matkhau.Password;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }

            // kết nối với cơ sở dữ liệu
            string connectionString = "Server=localhost;Database=quanlynhahang;Username=root;Password=;";
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {

                try
                {

                    connect.Open();
                    string query = "SELECT Role FROM employees WHERE Username = @username AND PasswordHash = @password";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object role = cmd.ExecuteScalar();
                    if (role != null)
                    {
                        // chuyển hướng đến các giao diện khác
                        switch (role.ToString())
                        {

                            case "phuc vu": new PhucVu().Show(); break;

                            case "thu ngan": new ThuNgan().Show(); break;

                            default:
                                MessageBox.Show("Vai trò không xác định.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                                break;
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }




            }

        }
    }
}

    

