using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.Repositories
{
    using Databases;

    public class SanPhamDAL
    {
        public required SQLServerFactory factory;

        // Lấy toàn bộ sản phẩm (Form gọi method này)
        public DataTable GetListSanPham()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT MaSP as [Mã SP], TenSP as [Tên sản phẩm], DVT as [ĐVT],
                             GiaBan as [Giá bán], SoLuongTon as [Tồn kho], MaLoai as [Loại hàng]
                             FROM SanPham";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        // Thêm sản phẩm
        public string AddSanPham(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                return "Vui lòng nhập Tên sản phẩm!";

            string query = @"INSERT INTO SanPham (TenSP, DVT, GiaBan, SoLuongTon, MaLoai)
                     VALUES (@TenSP, @DVT, @GiaBan, @SoLuongTon, @MaLoai)";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@DVT", sp.DVT ?? "");
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Sửa sản phẩm
        public string UpdateSanPham(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP)) return "Vui lòng chọn sản phẩm!";
            string query = @"UPDATE SanPham SET TenSP=@TenSP, DVT=@DVT, GiaBan=@GiaBan,
                             SoLuongTon=@SoLuongTon, MaLoai=@MaLoai WHERE MaSP=@MaSP";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@DVT", sp.DVT ?? "");
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
                    cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Xóa sản phẩm
        public string DeleteSanPham(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP)) return "Vui lòng chọn sản phẩm!";
            string query = "DELETE FROM SanPham WHERE MaSP=@MaSP";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        // Lấy danh sách loại hàng cho ComboBox
        public DataTable GetDanhSachLoaiHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaLoai, TenLoai FROM LoaiHang";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }
    }
}