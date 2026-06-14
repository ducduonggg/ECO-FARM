using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.Repositories
{
    using Databases;

    public class KhachHangDAL
    {
        public required SQLServerFactory factory;

        public DataTable GetListKhachHang()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaKH, HoTen, SDT, DiaChi, Email, GhiChu FROM KhachHang";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                adapter.Fill(dt);
            return dt;
        }

        public string AddKhachHang(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.MaKH) || string.IsNullOrWhiteSpace(kh.HoTen))
                return "Vui lòng nhập Mã và Họ tên khách hàng!";
            string query = @"INSERT INTO KhachHang (MaKH, HoTen, SDT, DiaChi, Email, GhiChu)
                             VALUES (@MaKH, @HoTen, @SDT, @DiaChi, @Email, @GhiChu)";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT ?? "");
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? "");
                    cmd.Parameters.AddWithValue("@Email", kh.Email ?? "");
                    cmd.Parameters.AddWithValue("@GhiChu", kh.GhiChu ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string UpdateKhachHang(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.MaKH)) return "Vui lòng chọn khách hàng!";
            string query = @"UPDATE KhachHang SET HoTen=@HoTen, SDT=@SDT,
                             DiaChi=@DiaChi, Email=@Email, GhiChu=@GhiChu WHERE MaKH=@MaKH";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT ?? "");
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi ?? "");
                    cmd.Parameters.AddWithValue("@Email", kh.Email ?? "");
                    cmd.Parameters.AddWithValue("@GhiChu", kh.GhiChu ?? "");
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string DeleteKhachHang(string maKH)
        {
            if (string.IsNullOrWhiteSpace(maKH)) return "Vui lòng chọn khách hàng!";
            string query = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }
    }
}