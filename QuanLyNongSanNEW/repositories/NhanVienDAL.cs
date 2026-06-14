using System;
using System.Data;
using Microsoft.Data.SqlClient;
using QLNongSan.schemas;

namespace QLNongSan.Repositories
{
    using Databases;

    public class NhanVienDAL
    {
        // BUG FIX: factory phải được inject từ bên ngoài, không thể để null
        // Thêm constructor nhận SQLServerFactory để tránh NullReferenceException khi gọi GetConnection()
        public SQLServerFactory factory;

        public NhanVienDAL() { }

        public NhanVienDAL(SQLServerFactory factory)
        {
            this.factory = factory;
        }

        // Lấy danh sách nhân viên — đã có SDT, DiaChi
        public DataTable GetListNhanVien()
        {
            DataTable dt = new DataTable();
            // BUG FIX: Thêm SDT, DiaChi vào SELECT. Dùng VaiTro làm ChucVu vì DB không có cột ChucVu riêng
            string query = "SELECT MaNV, HoTen, SDT, VaiTro AS ChucVu, DiaChi FROM NhanVien";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                adapter.Fill(dt);
            return dt;
        }

        public string AddNhanVien(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                return "Vui lòng nhập Tên nhân viên!";

            // Bỏ MaNV ra khỏi INSERT — để DB tự tăng
            string query = @"INSERT INTO NhanVien (HoTen, Username, Password, VaiTro, SDT, DiaChi)
                     VALUES (@HoTen, @Username, @Password, @VaiTro, @SDT, @DiaChi)";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@HoTen", nv.TenNV);
                    cmd.Parameters.AddWithValue("@Username", nv.TenNV.Replace(" ", "").ToLower());
                    cmd.Parameters.AddWithValue("@Password", "123456");
                    cmd.Parameters.AddWithValue("@VaiTro", nv.ChucVu ?? "Nhân viên");
                    cmd.Parameters.AddWithValue("@SDT", (object)nv.SDT ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", (object)nv.DiaChi ?? DBNull.Value);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Thêm thất bại!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string UpdateNhanVien(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.MaNV)) return "Vui lòng chọn nhân viên!";

            // BUG FIX: Thêm SDT và DiaChi vào câu UPDATE (trước đây bị bỏ qua)
            string query = @"UPDATE NhanVien 
                             SET HoTen=@HoTen, VaiTro=@VaiTro, SDT=@SDT, DiaChi=@DiaChi
                             WHERE MaNV=@MaNV";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.TenNV);
                    cmd.Parameters.AddWithValue("@VaiTro", nv.ChucVu ?? "Nhân viên");
                    cmd.Parameters.AddWithValue("@SDT", (object)nv.SDT ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", (object)nv.DiaChi ?? DBNull.Value);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy nhân viên!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV)) return "Vui lòng chọn nhân viên!";
            string query = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0 ? "SUCCESS" : "Không tìm thấy nhân viên!";
                }
                catch (Exception ex) { return "Lỗi: " + ex.Message; }
            }
        }
    }
}