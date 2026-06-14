using Microsoft.Data.SqlClient;
using QLNongSan.Models;
using System.Data;

namespace QLNongSan.Repositories
{
    /// <summary>
    /// Lớp truy cập dữ liệu cho ThongTinLo.
    /// Chịu trách nhiệm toàn bộ giao tiếp với SQL Server.
    /// </summary>
    public class ThongTinLoDAL
    {
        public required Databases.SQLServerFactory factory { get; set; }

        // ─── READ ────────────────────────────────────────────────────────────

        /// <summary>Lấy toàn bộ danh sách lô hàng.</summary>
        public DataTable GetAll()
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();
            string query = "SELECT * FROM ThongTinLo";
            SqlDataAdapter da = new(query, conn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        /// <summary>Lấy danh sách combo cho KhachHang (MaKH, HoTen).</summary>
        public DataTable GetKhachHangCombo()
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();
            SqlDataAdapter da = new("SELECT MaKH, HoTen FROM KhachHang ORDER BY HoTen", conn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        /// <summary>Lấy danh sách combo cho SanPham (MaSP, TenSP).</summary>
        public DataTable GetSanPhamCombo()
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();
            SqlDataAdapter da = new("SELECT MaSP, TenSP FROM SanPham ORDER BY TenSP", conn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        /// <summary>Lấy danh sách combo cho PhieuNhap (MaPN).</summary>
        public DataTable GetPhieuNhapCombo()
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();
            SqlDataAdapter da = new("SELECT MaPN FROM PhieuNhap ORDER BY MaPN", conn);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        // ─── CREATE ──────────────────────────────────────────────────────────

        /// <summary>Thêm một lô hàng mới vào cơ sở dữ liệu.</summary>
        public void Insert(ThongTinLo lo)
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();

            const string query = @"
                INSERT INTO ThongTinLo
                    (MaLo, SoLuong, DonVi, MaKH, MaSP, MaPN,
                     TenLo, NgayNhap, GhiChu, NgayMua, LienHe, TrangThai)
                VALUES
                    (@MaLo, @SoLuong, @DonVi, @MaKH, @MaSP, @MaPN,
                     @TenLo, @NgayNhap, @GhiChu, @NgayMua, @LienHe, @TrangThai)";

            using SqlCommand cmd = new(query, conn);
            MapParameters(cmd, lo);
            cmd.ExecuteNonQuery();
        }

        // ─── UPDATE ──────────────────────────────────────────────────────────

        /// <summary>Cập nhật thông tin lô hàng đã tồn tại.</summary>
        public void Update(ThongTinLo lo)
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();

            const string query = @"
                UPDATE ThongTinLo SET
                    SoLuong  = @SoLuong,
                    DonVi    = @DonVi,
                    MaKH     = @MaKH,
                    MaSP     = @MaSP,
                    MaPN     = @MaPN,
                    TenLo    = @TenLo,
                    NgayNhap = @NgayNhap,
                    GhiChu   = @GhiChu,
                    NgayMua  = @NgayMua,
                    LienHe   = @LienHe,
                    TrangThai= @TrangThai
                WHERE MaLo = @MaLo";

            using SqlCommand cmd = new(query, conn);
            MapParameters(cmd, lo);
            cmd.ExecuteNonQuery();
        }

        // ─── DELETE ──────────────────────────────────────────────────────────

        /// <summary>Xóa lô hàng theo mã.</summary>
        public void Delete(string maLo)
        {
            using SqlConnection conn = factory.GetConnection();
            conn.Open();

            using SqlCommand cmd = new("DELETE FROM ThongTinLo WHERE MaLo = @MaLo", conn);
            cmd.Parameters.AddWithValue("@MaLo", maLo);
            cmd.ExecuteNonQuery();
        }

        // ─── PRIVATE HELPERS ─────────────────────────────────────────────────

        /// <summary>Gán tham số SQL dùng chung cho Insert và Update.</summary>
        private static void MapParameters(SqlCommand cmd, ThongTinLo lo)
        {
            cmd.Parameters.AddWithValue("@MaLo", lo.MaLo);
            cmd.Parameters.AddWithValue("@SoLuong", lo.SoLuong);
            cmd.Parameters.AddWithValue("@DonVi", lo.DonVi);
            cmd.Parameters.AddWithValue("@MaKH", (object?)lo.MaKH ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MaSP", (object?)lo.MaSP ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MaPN", (object?)lo.MaPN ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@TenLo", lo.TenLo);
            cmd.Parameters.AddWithValue("@NgayNhap", lo.NgayNhap);
            cmd.Parameters.AddWithValue("@GhiChu", lo.GhiChu);
            cmd.Parameters.AddWithValue("@NgayMua", lo.NgayMua);
            cmd.Parameters.AddWithValue("@LienHe", lo.LienHe);
            cmd.Parameters.AddWithValue("@TrangThai", lo.TrangThai);
        }
    }
}