using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace QLNH.Object
{
    public class Food
    {
    
        // Thuộc tính tương ứng với các cột trong bảng products
        public string LoaiMon { get; set; }        // Loại món
        public string MaMon { get; set; }          // Mã món
        public string TenMon { get; set; }         // Tên món
        public string NhomThucDon { get; set; }    // Nhóm thực đơn
        public string DonViTinh { get; set; }      // Đơn vị tính
        public decimal Gia { get; set; }           // Giá

        // Constructor không tham số
        public Food() { }

        // Constructor đầy đủ tham số
        public Food(string loaiMon, string maMon, string tenMon, string nhomThucDon, string donViTinh, decimal gia)
        {
            LoaiMon = loaiMon;
            MaMon = maMon;
            TenMon = tenMon;
            NhomThucDon = nhomThucDon;
            DonViTinh = donViTinh;
            Gia = gia;
        }

        // Phương thức ghi đè ToString() (tuỳ chọn)
        public override string ToString()
        {
            return $"Mã món: {MaMon}, Tên món: {TenMon}, Loại món: {LoaiMon}, Nhóm thực đơn: {NhomThucDon}, Đơn vị tính: {DonViTinh}, Giá: {Gia:N0} VND";
        }
    
}


}
