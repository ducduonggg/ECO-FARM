using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;
using QLNongSan.Databases;

namespace QLNongSan.Repositories
{
    public class BanHangDAL
    {
        public required SQLServerFactory factory;

        public DataTable GetDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaKH, HoTen AS TenKH FROM KhachHang";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        public DataTable GetDanhSachNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaNV, HoTen AS TenNV FROM NhanVien";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        public DataTable GetDanhSachSanPham()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaSP, TenSP, DVT, GiaBan, SoLuongTon FROM SanPham";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        public DataRow GetSanPhamByTen(string tenSP)
        {
            string query = "SELECT MaSP, TenSP, DVT, GiaBan, SoLuongTon FROM SanPham WHERE TenSP = @TenSP";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenSP", tenSP);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        public string LuuPhieuBan(PhieuBanDTO phieu, DataTable chiTiet)
        {
            if (string.IsNullOrWhiteSpace(phieu.MaPB))
                return "Vui lòng nhập Mã hóa đơn!";
            if (chiTiet == null || chiTiet.Rows.Count == 0)
                return "Chưa có sản phẩm trong phiếu!";
            if (string.IsNullOrWhiteSpace(phieu.MaNV))
                return "Vui lòng chọn nhân viên bán!";

            using (SqlConnection conn = factory.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Kiểm tra mã hóa đơn đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM HoaDon WHERE MaHD = @MaHD";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@MaHD", phieu.MaPB);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            transaction.Rollback();
                            return "Mã hóa đơn đã tồn tại!";
                        }
                    }

                    // Insert HoaDon — chỉ dùng các cột thực tế trong DB:
                    // MaHD, NgayLap, MaNV, TongTien, PhanHoi, MaKH
                    string insertHD = @"INSERT INTO HoaDon (MaHD, NgayLap, MaNV, TongTien, PhanHoi, MaKH)
                                        VALUES (@MaHD, @NgayLap, @MaNV, @TongTien, @PhanHoi, @MaKH)";
                    using (SqlCommand cmd = new SqlCommand(insertHD, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaHD", phieu.MaPB);
                        cmd.Parameters.AddWithValue("@NgayLap", phieu.NgayBan);
                        cmd.Parameters.AddWithValue("@MaNV", phieu.MaNV);
                        cmd.Parameters.AddWithValue("@TongTien", phieu.TongThanhToan);
                        cmd.Parameters.AddWithValue("@PhanHoi", phieu.GhiChu ?? "");
                        cmd.Parameters.AddWithValue("@MaKH",
                            string.IsNullOrEmpty(phieu.MaKH) ? (object)DBNull.Value : phieu.MaKH);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert ChiTietHoaDon + Trừ tồn kho
                    string insertCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                                          VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                    string updateTon = @"UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";

                    foreach (DataRow row in chiTiet.Rows)
                    {
                        int soLuong = Convert.ToInt32(row["SoLuong"]);
                        decimal thanhTien = Convert.ToDecimal(row["ThanhTien"]);
                        decimal donGia = soLuong > 0 ? thanhTien / soLuong : 0;

                        using (SqlCommand cmd = new SqlCommand(insertCT, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@MaHD", phieu.MaPB);
                            cmd.Parameters.AddWithValue("@MaSP", row["MaSP"]);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.Parameters.AddWithValue("@DonGia", donGia);
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdTon = new SqlCommand(updateTon, conn, transaction))
                        {
                            cmdTon.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdTon.Parameters.AddWithValue("@MaSP", row["MaSP"]);
                            cmdTon.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return "SUCCESS";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return "Lỗi: " + ex.Message;
                }
            }
        }
    }
}