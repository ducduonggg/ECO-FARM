namespace QLNongSan.schemas
{
    // Hóa đơn bán hàng (header)
    public class PhieuBanDTO
    {
        public string MaPB { get; set; }          // -> MaHD trong DB
        public string MaKH { get; set; }          // Mã khách hàng (id)
        public string KhachHang { get; set; }      // Tên khách hàng (hiển thị)
        public string MaNV { get; set; }          // Mã nhân viên bán (id)
        public string NhanVienBan { get; set; }    // Tên nhân viên (hiển thị)
        public string NgayBan { get; set; }
        public string PhuongThucTT { get; set; }
        public decimal TongThanhToan { get; set; }
        public string GhiChu { get; set; }
    }

    // Chi tiết từng sản phẩm trong hóa đơn
    public class ChiTietBanDTO
    {
        public string MaPB { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public decimal ChietKhau { get; set; }
        public decimal ThanhTien { get; set; }
    }
}