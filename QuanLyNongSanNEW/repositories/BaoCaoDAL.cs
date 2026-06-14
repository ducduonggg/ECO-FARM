using Microsoft.Data.SqlClient;
using QLNongSan.Databases;
using QLNongSan.schemas;
using System;
using System.Data;

namespace QLNongSan.Repositories
{
    public class BaoCaoDAL
    {
        public SQLServerFactory factory;

        public DataTable GetAllBaoCao()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaBaoCao, NgayBaoCao, LoaiBaoCao, NoiDung FROM BaoCao ORDER BY MaBaoCao DESC";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                da.Fill(dt);
            return dt;
        }

        public bool ThemBaoCao(BaoCaoDTO bc)
        {
            if (bc == null || string.IsNullOrWhiteSpace(bc.NoiDung)) return false;
            string query = @"INSERT INTO BaoCao (NgayBaoCao, LoaiBaoCao, NoiDung)
                             VALUES (@NgayBaoCao, @LoaiBaoCao, @NoiDung)";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@NgayBaoCao", bc.NgayBaoCao);
                    cmd.Parameters.AddWithValue("@LoaiBaoCao", bc.LoaiBaoCao);
                    cmd.Parameters.AddWithValue("@NoiDung", bc.NoiDung);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }

        public bool XoaBaoCao(int maBaoCao)
        {
            string query = "DELETE FROM BaoCao WHERE MaBaoCao = @MaBaoCao";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@MaBaoCao", maBaoCao);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch { return false; }
            }
        }

        public BaoCaoDTO GetBaoCaoById(int maBaoCao)
        {
            string query = "SELECT * FROM BaoCao WHERE MaBaoCao = @MaBaoCao";
            using (SqlConnection conn = factory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaBaoCao", maBaoCao);
                conn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                        return new BaoCaoDTO
                        {
                            MaBaoCao = (int)r["MaBaoCao"],
                            NgayBaoCao = r["NgayBaoCao"].ToString(),
                            LoaiBaoCao = r["LoaiBaoCao"].ToString(),
                            NoiDung = r["NoiDung"].ToString()
                        };
                }
            }
            return null;
        }
    }
}