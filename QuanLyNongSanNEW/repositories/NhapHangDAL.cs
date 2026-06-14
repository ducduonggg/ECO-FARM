using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.Repositories
{
    using Databases;

    public class NhapHangDAL
    {
        public required SQLServerFactory factory;

        // ─── Danh sách sản phẩm ───
        public List<SanPhamDTO> GetSanPhamList()
        {
            var list = new List<SanPhamDTO>();
            string query = "SELECT MaSP, TenSP FROM SanPham";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        list.Add(new SanPhamDTO
                        {
                            MaSP = reader["MaSP"].ToString(),
                            TenSP = reader["TenSP"].ToString()
                        });
            }
            return list;
        }

        // ─── Danh sách nhân viên ───
        public List<NhanVienDTO> GetNhanVienList()
        {
            var list = new List<NhanVienDTO>();
            string query = "SELECT MaNV, HoTen FROM NhanVien";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        list.Add(new NhanVienDTO
                        {
                            MaNV = reader["MaNV"].ToString(),
                            TenNV = reader["HoTen"].ToString()
                        });
            }
            return list;
        }

        // ─── Danh sách nhà cung cấp ───
        public DataTable GetNhaCungCapList()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaNCC, TenNCC FROM NhaCungCap";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                da.Fill(dt);
            return dt;
        }

        // ─── Tự sinh mã phiếu nhập (PN001, PN002, ...) ───
        public string TaoMaPhieuNhap()
        {
            string newCode = "PN001";
            string query = "SELECT TOP 1 MaPN FROM PhieuNhap ORDER BY MaPN DESC";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string last = result.ToString();
                    if (last.Length >= 2 && int.TryParse(last.Substring(2), out int num))
                        newCode = "PN" + (num + 1).ToString("D3");
                }
            }
            return newCode;
        }

        // ─── Lưu phiếu nhập + chi tiết + cập nhật tồn kho ───
        public bool LuuPhieuNhap(PhieuNhapDTO phieuNhap, List<ChiTietPhieuNhapDTO> chiTietList)
        {
            using (SqlConnection conn = factory.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // 1. Insert PhieuNhap
                    string sqlPhieu = @"INSERT INTO PhieuNhap (MaPN, NgayNhap, MaNV, GhiChu)
                                        VALUES (@MaPN, @NgayNhap, @MaNV, @GhiChu)";
                    using (SqlCommand cmd = new SqlCommand(sqlPhieu, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPN", phieuNhap.MaPN);
                        cmd.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayNhap);
                        cmd.Parameters.AddWithValue("@MaNV", phieuNhap.MaNV);
                        cmd.Parameters.AddWithValue("@GhiChu", phieuNhap.GhiChu ?? "");
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert ChiTietPhieuNhap + Cộng tồn kho
                    string sqlCT = @"INSERT INTO ChiTietPhieuNhap (MaPN, MaSP, SoLuong, DonGiaNhap, HanSuDung)
                                      VALUES (@MaPN, @MaSP, @SoLuong, @DonGiaNhap, @HanSuDung)";
                    string sqlTon = @"UPDATE SanPham SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaSP = @MaSP";

                    foreach (var ct in chiTietList)
                    {
                        using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, transaction))
                        {
                            cmdCT.Parameters.AddWithValue("@MaPN", ct.MaPN);
                            cmdCT.Parameters.AddWithValue("@MaSP", ct.MaSP);
                            cmdCT.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdCT.Parameters.AddWithValue("@DonGiaNhap", ct.GiaNhap);
                            cmdCT.Parameters.AddWithValue("@HanSuDung", ct.HanSuDung);
                            cmdCT.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdTon = new SqlCommand(sqlTon, conn, transaction))
                        {
                            cmdTon.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdTon.Parameters.AddWithValue("@MaSP", ct.MaSP);
                            cmdTon.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}