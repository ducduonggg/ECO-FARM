// Parent directory hierarchy is QLNongSan/Database
namespace QLNongSan.Databases
{
    using Microsoft.Data.SqlClient;

    // Database factory - manages connection pooling and is responsible for creating connection in stateless repositories/DALs
    public class SQLServerFactory
    {
        private readonly string connectionString;

        // Constructor dùng Windows Authentication (Integrated Security)
        public SQLServerFactory(string serverName, string databaseName)
        {
            connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = serverName,
                InitialCatalog = databaseName,
                IntegratedSecurity = true,
                TrustServerCertificate = true,
                Encrypt = false
            }.ConnectionString;
        }

        // Constructor dùng SQL Authentication (giữ lại nếu cần dùng)
        public SQLServerFactory(string serverName, string databaseName, string userName, string password)
        {
            connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = serverName,
                InitialCatalog = databaseName,
                UserID = userName,
                Password = password,
                Encrypt = false,
                TrustServerCertificate = true
            }.ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}