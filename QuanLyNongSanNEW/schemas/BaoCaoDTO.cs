namespace QLNongSan.schemas
{
    public class BaoCaoDTO
    {
        public int MaBaoCao { get; set; }
        public string NgayBaoCao { get; set; }
        public string LoaiBaoCao { get; set; }
        public string NoiDung { get; set; }

        public BaoCaoDTO() { }

        public BaoCaoDTO(int maBaoCao, string ngayBaoCao, string loaiBaoCao, string noiDung)
        {
            MaBaoCao = maBaoCao;
            NgayBaoCao = ngayBaoCao;
            LoaiBaoCao = loaiBaoCao;
            NoiDung = noiDung;
        }
    }
}
