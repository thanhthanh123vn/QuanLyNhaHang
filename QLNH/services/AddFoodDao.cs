using MySql.Data.MySqlClient;
using QLNH.dao;
using QLNH.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace QLNH.services
{
    public  class AddFoodDao
    {
        DBUtils dBUtils = new DBUtils();
        MySqlConnection conn = null;
        public AddFoodDao()
        {
            dBUtils = new DBUtils();
            conn = dBUtils.GetMySqlConnection(); // Gán giá trị cho biến thành viên
            conn.Open(); // Mở kết nối
        }

        public void AddFood(string loaiMon, string maMon, string tenMon, string nhomThucDon, string donViTinh, decimal gia)
        {
            // Code thêm món ăn vào cơ sở dữ liệu
            string query = "INSERT INTO products (LoaiMon, MaMon, TenMon, NhomThucDon, DonViTinh, Gia) " +
               "VALUES (@LoaiMon, @MaMon, @TenMon, @NhomThucDon, @DonViTinh, @Gia)";
            
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Thêm tham số
                cmd.Parameters.AddWithValue("@LoaiMon", loaiMon);
                cmd.Parameters.AddWithValue("@MaMon", maMon);
                cmd.Parameters.AddWithValue("@TenMon", tenMon);
                cmd.Parameters.AddWithValue("@NhomThucDon", nhomThucDon);
                cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                cmd.Parameters.AddWithValue("@Gia", gia);

                // Thực thi truy vấn
                int rowsAffected = cmd.ExecuteNonQuery();

                // Thông báo thành công
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }
     

    }

    }

