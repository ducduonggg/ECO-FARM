using System;

namespace QLNongSan
{
    // DTO cho Phiếu nhập
    public class PhieuNhapDTO
    {
        public string MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string GhiChu { get; set; }
    }

    // DTO cho Chi tiết phiếu nhập
    public class ChiTietPhieuNhapDTO
    {
        public string MaPN { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public DateTime HanSuDung { get; set; }
        public decimal ThanhTien => SoLuong * GiaNhap;
    }

    // DTO cho Sản phẩm (dùng để đổ vào combobox)
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public object LoaiHang { get; internal set; }
        public object SoLuongTon { get; internal set; }
        public object GiaBan { get; internal set; }
        public string? DVT { get; internal set; }
        public string? MaLoai { get; internal set; }
    }

    // DTO cho Nhân viên
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; internal set; }
        public string GioiTinh { get; internal set; }
        public string SDT { get; internal set; }
        public string Email { get; internal set; }
        public string ChucVu { get; internal set; }
        public string HopDong { get; internal set; }
        public string TrangThai { get; internal set; }
        public string DiaChi { get; internal set; }
    }
}