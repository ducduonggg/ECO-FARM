using System;
using System.Data;
using System.Windows.Forms;
using QLNongSan.Repositories;
using QLNongSan.Models;

namespace QLNongSan
{
    public partial class FormThongTinLo : Form
    {
        private readonly ThongTinLoDAL dal;
        private bool isAdding = false;

        public FormThongTinLo()
        {
            InitializeComponent();

            var sqlServerFactory = new Databases.SQLServerFactory(
                serverName: ".",
                databaseName: "QuanLyNongSan"
            );

            dal = new ThongTinLoDAL
            {
                factory = sqlServerFactory
            };

            LoadComboBoxes();
            LoadData();
        }

        public FormThongTinLo(Application application)
        {
            InitializeComponent();

            dal = application.batchRepository;

            LoadComboBoxes();
            LoadData();
        }

        // ─── LOAD DỮ LIỆU ────────────────────────────────────────────────

        private void LoadData()
        {
            try
            {
                DataTable dt = dal.GetAll();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Khách hàng
                DataTable dtKH = dal.GetKhachHangCombo();
                cmbMaKH.DataSource = dtKH;
                cmbMaKH.DisplayMember = "HoTen";
                cmbMaKH.ValueMember = "MaKH";
                cmbMaKH.SelectedIndex = -1;

                // Sản phẩm
                DataTable dtSP = dal.GetSanPhamCombo();
                cmbMaSP.DataSource = dtSP;
                cmbMaSP.DisplayMember = "TenSP";
                cmbMaSP.ValueMember = "MaSP";
                cmbMaSP.SelectedIndex = -1;

                // Phiếu nhập
                DataTable dtPN = dal.GetPhieuNhapCombo();
                cmbMaPN.DataSource = dtPN;
                cmbMaPN.DisplayMember = "MaPN";
                cmbMaPN.ValueMember = "MaPN";
                cmbMaPN.SelectedIndex = -1;

                // Trạng thái
                cmbTrangThai.Items.Clear();
                cmbTrangThai.Items.AddRange(new object[] { "Còn hàng", "Hết hàng", "Đang xử lý" });
                cmbTrangThai.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu combo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── XÓA TRẮNG FORM ─────────────────────────────────────────────

        private void XoaTrang()
        {
            txbMaLo.Clear();
            txbMaLo.Enabled = true;
            nudSoLuong.Value = 0;
            txbDonVi.Clear();
            cmbMaKH.SelectedIndex = -1;
            cmbMaSP.SelectedIndex = -1;
            cmbMaPN.SelectedIndex = -1;
            txbTenLo.Clear();
            dtpNgayNhap.Value = DateTime.Now;
            txbGhiChu.Clear();
            dtpNgayMua.Value = DateTime.Now;
            txbLienHe.Clear();
            cmbTrangThai.SelectedIndex = -1;
        }

        // ─── VALIDATE ───────────────────────────────────────────────────

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txbMaLo.Text))
            {
                MessageBox.Show("Mã lô không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbMaLo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbTenLo.Text))
            {
                MessageBox.Show("Tên lô không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbTenLo.Focus();
                return false;
            }

            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoLuong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbDonVi.Text))
            {
                MessageBox.Show("Đơn vị không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbDonVi.Focus();
                return false;
            }

            if (cmbTrangThai.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmbTrangThai.Text))
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTrangThai.Focus();
                return false;
            }

            return true;
        }

        // ─── LẤY DỮ LIỆU TỪ FORM → DTO ─────────────────────────────────

        private ThongTinLo GetDataFromForm()
        {
            return new ThongTinLo
            {
                MaLo = txbMaLo.Text.Trim(),
                TenLo = txbTenLo.Text.Trim(),
                SoLuong = nudSoLuong.Value,
                DonVi = txbDonVi.Text.Trim(),
                MaKH = cmbMaKH.SelectedValue is int valKH ? valKH : (int?)null,
                MaSP = cmbMaSP.SelectedValue is int valSP ? valSP : (int?)null,
                MaPN = cmbMaPN.SelectedValue is int valPN ? valPN : (int?)null,
                NgayNhap = dtpNgayNhap.Value,
                NgayMua = dtpNgayMua.Value,
                GhiChu = txbGhiChu.Text.Trim(),
                LienHe = txbLienHe.Text.Trim(),
                TrangThai = cmbTrangThai.Text.Trim()
            };
        }

        // ─── GÁN DỮ LIỆU TỪ DÒNG GRID → FORM ────────────────────────────

        private void BindRowToForm(DataGridViewRow row)
        {
            txbMaLo.Text = row.Cells["MaLo"].Value?.ToString() ?? "";
            txbTenLo.Text = row.Cells["TenLo"].Value?.ToString() ?? "";
            nudSoLuong.Value = row.Cells["SoLuong"].Value != null && row.Cells["SoLuong"].Value != DBNull.Value
                ? Convert.ToDecimal(row.Cells["SoLuong"].Value)
                : 0;
            txbDonVi.Text = row.Cells["DonVi"].Value?.ToString() ?? "";

            cmbMaKH.SelectedValue = row.Cells["MaKH"].Value != DBNull.Value ? row.Cells["MaKH"].Value : null;
            cmbMaSP.SelectedValue = row.Cells["MaSP"].Value != DBNull.Value ? row.Cells["MaSP"].Value : null;
            cmbMaPN.SelectedValue = row.Cells["MaPN"].Value != DBNull.Value ? row.Cells["MaPN"].Value : null;

            dtpNgayNhap.Value = row.Cells["NgayNhap"].Value != DBNull.Value
                ? Convert.ToDateTime(row.Cells["NgayNhap"].Value)
                : DateTime.Now;

            dtpNgayMua.Value = row.Cells["NgayMua"].Value != DBNull.Value
                ? Convert.ToDateTime(row.Cells["NgayMua"].Value)
                : DateTime.Now;

            txbGhiChu.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";
            txbLienHe.Text = row.Cells["LienHe"].Value?.ToString() ?? "";

            string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "";
            int idx = cmbTrangThai.Items.IndexOf(trangThai);
            cmbTrangThai.SelectedIndex = idx >= 0 ? idx : -1;
            if (idx < 0) cmbTrangThai.Text = trangThai;

            isAdding = false;
            txbMaLo.Enabled = false; // Không cho sửa mã lô khi đang sửa/xem
        }

        // ─── SỰ KIỆN NÚT ────────────────────────────────────────────────

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            XoaTrang();
            txbMaLo.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isAdding = false;
            XoaTrang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaLo.Text))
            {
                MessageBox.Show("Vui lòng chọn một lô từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isAdding = false;
            txbTenLo.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMaLo.Text))
            {
                MessageBox.Show("Vui lòng chọn một lô để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa lô có mã '{txbMaLo.Text}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                dal.Delete(txbMaLo.Text.Trim());
                MessageBox.Show("Xóa thành công!", "Thông báo");
                XoaTrang();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                ThongTinLo lo = GetDataFromForm();

                if (isAdding)
                {
                    dal.Insert(lo);
                }
                else
                {
                    dal.Update(lo);
                }

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
                isAdding = false;
                XoaTrang();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── SỰ KIỆN KHÁC ───────────────────────────────────────────────

        private void txbMaLo_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                BindRowToForm(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}