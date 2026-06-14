namespace QLNongSan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var sqlServerFactory = new Databases.SQLServerFactory(
                serverName: ".",
                databaseName: "QuanLyNongSan"
            );
            var userRepository = new Authentication.Repositories.UserRepository
            {
                factory = sqlServerFactory,
            };
            var salesRepository = new Repositories.BanHangDAL
            {
                factory = sqlServerFactory,
            };
            var categoryRepository = new Repositories.LoaiHangDAL
            {
                factory = sqlServerFactory,
            };
            var customerRepository = new Repositories.KhachHangDAL
            {
                factory = sqlServerFactory,
            };
            var purchaseRepository = new Repositories.NhapHangDAL
            {
                factory = sqlServerFactory,
            };
            var productRepository = new Repositories.SanPhamDAL
            {
                factory = sqlServerFactory,
            };
            var batchRepository = new Repositories.ThongTinLoDAL
            {
                factory = sqlServerFactory,
            };
            var reportRepository = new Repositories.BaoCaoDAL
            {
                factory = sqlServerFactory,
            };
            var employeeRepository = new Repositories.NhanVienDAL
            {
                factory = sqlServerFactory,
            };
            var authenticationService = new Authentication.Services.AuthenticationService
            {
                userRepository = userRepository
            };
            var application = new Application
            {
                authenticationService = authenticationService,
                salesRepository = salesRepository,
                categoryRepository = categoryRepository,
                customerRepository = customerRepository,
                purchaseRepository = purchaseRepository,
                productRepository = productRepository,
                batchRepository = batchRepository,
                reportRepository = reportRepository,
                employeeRepository = employeeRepository,
                database = sqlServerFactory
            };

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new UI.LoginForm(application));
        }
    }
}