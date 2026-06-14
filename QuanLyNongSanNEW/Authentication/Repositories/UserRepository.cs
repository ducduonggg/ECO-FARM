namespace QLNongSan.Authentication.Repositories
{
    // Use and link via invoking "dotnet package add Microsoft.Data.SqlClient"
    using Microsoft.Data.SqlClient;
    using Databases;
    using System.Diagnostics;

    public class UserRepository : IUserRepository
    {
        public required SQLServerFactory factory;

        Entities.User? IUserRepository.GetUserByUsername(string username)
        {
            using var conn = factory.GetConnection();
            conn.Open();

            // Truy vấn chính xác vào bảng NhanVien theo cột Username thực tế
            string sql = "SELECT * FROM NhanVien WHERE Username = @user";

            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // VÌ MaNV là INT nhưng thực thể User.Id cần GUID, ta sẽ đổi int thành mã chuỗi tạm thời:
                int intId = (int)reader["MaNV"];

                // Tạo một mã Guid giả lập từ số int này để không làm lỗi cấu trúc các file khác của nhóm bạn
                byte[] bytes = new byte[16];
                BitConverter.GetBytes(intId).CopyTo(bytes, 0);
                Guid pseudoGuid = new Guid(bytes);

                // Đọc chính xác tên cột Username và Password (viết hoa)
                var fetched_username = reader["Username"].ToString();
                var fetched_password = reader["Password"].ToString();

                return new Entities.User
                {
                    Id = pseudoGuid,
                    Username = fetched_username,
                    Password = fetched_password
                };
            }
            return null;
        }

        Entities.User IUserRepository.CreateUser(CreateUserParams create_params)
        {
            using var conn = factory.GetConnection();
            conn.Open();

            // Câu lệnh chèn tài khoản mới (Bỏ qua MaNV nếu nó tự tăng, hoặc thêm số ngẫu nhiên)
            // Ở đây tạm thời gán lấy một số int ngẫu nhiên để tránh trùng lặp
            int newIntId = new Random().Next(1000, 99999);

            string sql = "INSERT INTO NhanVien (MaNV, Username, Password, VaiTro) VALUES (@id, @user, @pass, @vaitro)";

            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", newIntId);
            cmd.Parameters.AddWithValue("@user", create_params.Username);
            cmd.Parameters.AddWithValue("@pass", create_params.Password);
            cmd.Parameters.AddWithValue("@vaitro", "NhanVien"); // Vai trò mặc định

            cmd.ExecuteNonQuery();

            // Trả về Guid tạm để khớp cấu trúc thực thể C#
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(newIntId).CopyTo(bytes, 0);

            return new Entities.User
            {
                Id = new Guid(bytes),
                Username = create_params.Username,
                Password = create_params.Password
            };
        }
    }
}