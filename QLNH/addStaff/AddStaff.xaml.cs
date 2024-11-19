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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using Microsoft.Win32;

namespace QLNH
{
    /// <summary>
    /// Interaction logic for AddStaff.xaml
    /// </summary>
    public partial class AddStaff : Window
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            // Mở hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.png, *.jpeg, *.gif)|*.jpg;*.png;*.jpeg;*.gif";
            if (openFileDialog.ShowDialog() == true)
            {
                // Tạo ImageBrush và đặt hình ảnh vừa chọn vào
                var brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                brush.Stretch = Stretch.UniformToFill;

                // Đặt ImageBrush vào Ellipse
                AvatarEllipse.Fill = brush;
            }
        }


        private void CancelImage_Click(object sender, RoutedEventArgs e)
        {
            // Đặt lại ảnh mặc định hoặc xóa ảnh hiện tại
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/icon/avt.png"));
            brush.Stretch = Stretch.UniformToFill;

            AvatarEllipse.Fill = brush;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Lấy thông tin từ các trường nhập liệu
            string userId = MaNhanVen.Text;         
            string fullName = TenNhanVien.Text;       
            string email = MailTextBox.Text;         
            string role = RoleTextBox.Text;          
            string phoneNumber = SDTTextBox.Text;
            string shift = shiftTextBox.Text;
            string address = AddressTextBox.Text;
            DateTime? createdAt = DateTime.Now;       // Ngày tạo (lấy thời gian hiện tại)

            
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
            string connectionString = "Server=localhost;Database=quanlynhahang;Username=root;Password=;";

            // Kiểm tra sự tồn tại của UserID
            string checkQuery = "SELECT COUNT(*) FROM employees WHERE UserID = @userId;";
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    // Kiểm tra sự tồn tại của UserID
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connect);
                    checkCmd.Parameters.AddWithValue("@userId", userId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());  

                    if (count > 0)
                    {
                        MessageBox.Show("Nhân viên với Mã nhân viên này đã tồn tại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;  
                    }

                   
                    string query = "INSERT INTO employees (UserID, FullName, Email, PasswordHash, PhoneNumber, Address, Role, CreatedAt) " +
                                   "VALUES (@userId, @fullName, @email, @fullName, @phoneNumber, @address, @role, @createdAt);";

                    
                    MySqlCommand cmd = new MySqlCommand(query, connect);

                    
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@role", role);


                    
                    cmd.Parameters.AddWithValue("@createdAt", createdAt.Value);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm nhân viên.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi (nếu có)
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MaNhanVen.Clear();
            TenNhanVien.Clear();
            MailTextBox.Clear();
            RoleTextBox.Clear();
            AddressTextBox.Clear();
            SDTTextBox.Clear();

            // Đặt lại ảnh về ảnh mặc định
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/icon/avt.png"));
            brush.Stretch = Stretch.UniformToFill;

            AvatarEllipse.Fill = brush;
            //this.Close();
        }
    }
}
