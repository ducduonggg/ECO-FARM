namespace QLNongSan.schemas
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string MaLoai { get; set; }

        public SanPhamDTO() { }
    }
}