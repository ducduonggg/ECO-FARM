using System;

namespace QLNongSan.schemas
{
    public class LoaiHangDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LoaiHangDTO() { }

        public LoaiHangDTO(string maLoai, string tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
        }
    }
}