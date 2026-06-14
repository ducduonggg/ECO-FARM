namespace QLNongSan
{
    // A composible collection for BLL interfaces - entry point should declare implementations
    public class Application
    {
        public required Authentication.Services.IAuthenticationService authenticationService;
        public required Repositories.BanHangDAL salesRepository;
        public required Repositories.LoaiHangDAL categoryRepository;
        public required Repositories.KhachHangDAL customerRepository;
        public required Repositories.NhapHangDAL purchaseRepository;
        public required Repositories.SanPhamDAL productRepository;
        public required Repositories.ThongTinLoDAL batchRepository;
        public required Repositories.BaoCaoDAL reportRepository;
        public required Repositories.NhanVienDAL employeeRepository;
        public required Databases.SQLServerFactory database;

        // ĐÃ SỬA: Thay 'object' thành 'Repositories.NhanVienDAL' (Hoặc Repositories.NhanVienRepository nếu bạn đặt tên class như vậy)
        public Repositories.NhanVienDAL nhanVienRepository { get; set; } = new Repositories.NhanVienDAL();
    }
}