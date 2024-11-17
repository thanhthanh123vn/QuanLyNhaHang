using Microsoft.Win32;
using QLNH.services;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace QLNH
{
    /// <summary>
    /// Interaction logic for AddFood.xaml
    /// </summary>
    public partial class AddFood : Window
    {
        public string LoaiMon { get; set; }        // Loại món
        public string MaMon { get; set; }          // Mã món
        public string TenMon { get; set; }         // Tên món
        public string NhomThucDon { get; set; }    // Nhóm thực đơn
        public string DonViTinh { get; set; }      // Đơn vị tính
        public decimal Gia { get; set; }
        bool isDoUong = false;
        bool isMonAn = false;
        AddFoodDao addFoodDao;
        public AddFood()
        {
            addFoodDao = new AddFoodDao();
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }


        private void rdMonAn_Checked(object sender, RoutedEventArgs e)
        {
            isMonAn = true;
        }

        private void rdDoUong_Checked(object sender, RoutedEventArgs e)
        {
            isDoUong = true;

        }

        private void Button_Luu(object sender, RoutedEventArgs e)
        {
            if (isMonAn)
            {
                LoaiMon = "Món ăn";
            }
            else if (isDoUong)
            {
                LoaiMon = "Đồ uống";
            }

            if (tbMaMon.Text == "" || tbTenMon.Text == "" || tbThucDon.Text == "" || tbDVT.Text == "" || tbGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MaMon = tbMaMon.Text;
            TenMon = tbTenMon.Text;
            NhomThucDon = tbThucDon.Text;
            DonViTinh = tbDVT.Text;
            Gia = decimal.Parse(tbGia.Text);
            try
            {
                string input = "abc"; // Giả sử người dùng nhập một giá trị không phải số
                decimal price = Convert.ToDecimal(input); // Cố gắng chuyển đổi chuỗi thành số
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Vui lòng nhập giá tiền là số!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            addFoodDao.AddFood(LoaiMon, MaMon, TenMon, NhomThucDon, DonViTinh, Gia);
         





        }
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            // Tạo một hộp thoại OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Chỉ chọn các ảnh có định dạng này

            // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn file không
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    // Lấy đường dẫn file ảnh đã chọn
                    string filePath = openFileDialog.FileName;

                    // Tạo một đối tượng BitmapImage từ file ảnh
                    BitmapImage bitmap = new BitmapImage(new Uri(filePath));

                    // Đặt hình ảnh vào PictureBox (Image control)
                    pictureBox.Source = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở file ảnh: " + ex.Message);
                }
            }
        }
    }
}
