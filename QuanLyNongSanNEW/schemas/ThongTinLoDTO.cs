namespace QLNongSan.Models
{
    /// <summary>
    /// Đại diện cho một lô hàng nông sản trong cơ sở dữ liệu.
    /// Các trường khớp chính xác với bảng ThongTinLo.
    /// </summary>
    public class ThongTinLo
    {
        public string MaLo { get; set; } = string.Empty;
        public string TenLo { get; set; } = string.Empty;
        public decimal SoLuong { get; set; }
        public string DonVi { get; set; } = string.Empty;

        // Khóa ngoại — nullable vì ComboBox có thể chưa chọn
        public int? MaKH { get; set; }
        public int? MaSP { get; set; }
        public int? MaPN { get; set; }

        public DateTime NgayNhap { get; set; } = DateTime.Now;
        public DateTime NgayMua { get; set; } = DateTime.Now;
        public string GhiChu { get; set; } = string.Empty;
        public string LienHe { get; set; } = string.Empty;
        public string TrangThai { get; set; } = string.Empty;
    }
}
