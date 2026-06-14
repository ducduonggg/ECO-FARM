using System;
using System.Data;
using System.Windows.Forms;
using QLNongSan.Repositories;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormKhachHang : Form
    {
        private readonly Application application;

        public FormKhachHang(Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            HienThiData();
        }

        private void HienThiData()
        {
            try
            {
                dgvKhachHang.DataSource = application.customerRepository.GetListKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private KhachHangDTO LayDuLieuForm()
        {
            return new KhachHangDTO
            {
                MaKH = txtMaKH.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                GhiChu = txtGhiChu.Text.Trim()
            };
        }

        private void LamMoiForm()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
            txtMaKH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string kq = application.customerRepository.AddKhachHang(LayDuLieuForm());
            if (kq == "SUCCESS")
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData(); LamMoiForm();
            }
            else MessageBox.Show(kq, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string kq = application.customerRepository.UpdateKhachHang(LayDuLieuForm());
            if (kq == "SUCCESS")
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData(); LamMoiForm();
            }
            else MessageBox.Show(kq, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text)) { MessageBox.Show("Chọn khách hàng cần xóa!"); return; }
            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string kq = application.customerRepository.DeleteKhachHang(txtMaKH.Text.Trim());
                if (kq == "SUCCESS") { MessageBox.Show("Xóa thành công!"); HienThiData(); LamMoiForm(); }
                else MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e) => LamMoiForm();

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            txtSDT.Text = row.Cells["SDT"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void grpThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}