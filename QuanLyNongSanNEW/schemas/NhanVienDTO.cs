namespace QLNongSan.schemas
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }    // BUG FIX: Bị thiếu hoàn toàn trong file gốc
        public string TenNV { get; set; }   // BUG FIX: Bị thiếu hoàn toàn trong file gốc
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public string HopDong { get; set; }
        public string TrangThai { get; set; }
    }
}