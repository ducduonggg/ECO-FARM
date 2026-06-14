using System;
using System.Data;
using System.Windows.Forms;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormLoaiHang : Form
    {
        private readonly Application application;
        private string _maLoaiDangSua = null; // null = chế độ Thêm, có giá trị = chế độ Sửa

        public FormLoaiHang(Application application)
        {
            this.application = application;
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;

            // Click vào dòng trong grid → điền lên form
            dgvLoaiHang.SelectionChanged += dgvLoaiHang_SelectionChanged;
        }

        // ═══════════════════════════════════════════
        // LOAD FORM
        // ═══════════════════════════════════════════
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HienThiData();
            CapNhatTrangThai(cheDoThem: true);
        }

        // ═══════════════════════════════════════════
        // HIỂN THỊ DỮ LIỆU
        // ═══════════════════════════════════════════
        private void HienThiData()
        {
            dgvLoaiHang.DataSource = application.categoryRepository.GetListLoaiHang();
        }

        // ═══════════════════════════════════════════
        // CHỌN DÒNG TRONG GRID → ĐIỀN LÊN FORM
        // ═══════════════════════════════════════════
        private void dgvLoaiHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiHang.CurrentRow == null) return;

            DataGridViewRow row = dgvLoaiHang.CurrentRow;
            txtMaLoai.Text = row.Cells["MaLoai"].Value?.ToString() ?? "";
            txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString() ?? "";
            _maLoaiDangSua = txtMaLoai.Text;

            CapNhatTrangThai(cheDoThem: false);
        }

        // ═══════════════════════════════════════════
        // NÚT: THÊM
        // ═══════════════════════════════════════════
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên loại hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            LoaiHangDTO dto = new LoaiHangDTO
            {
                TenLoai = txtTenLoai.Text.Trim()
            };

            string ketQua = application.categoryRepository.AddLoaiHang(dto);
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Thêm loại hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════
        // NÚT: SỬA
        // ═══════════════════════════════════════════
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_maLoaiDangSua))
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên loại hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            LoaiHangDTO dto = new LoaiHangDTO
            {
                MaLoai = _maLoaiDangSua,
                TenLoai = txtTenLoai.Text.Trim()
            };

            string ketQua = application.categoryRepository.UpdateLoaiHang(dto);
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Cập nhật loại hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════
        // NÚT: XÓA
        // ═══════════════════════════════════════════
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_maLoaiDangSua))
            {
                MessageBox.Show("Vui lòng chọn loại hàng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLoai = txtTenLoai.Text;
            if (MessageBox.Show($"Bạn có chắc muốn xóa loại hàng \"{tenLoai}\"?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            string ketQua = application.categoryRepository.DeleteLoaiHang(_maLoaiDangSua);
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Xóa loại hàng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════
        // NÚT: LÀM MỚI
        // ═══════════════════════════════════════════
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // ═══════════════════════════════════════════
        // HELPER: Reset form về chế độ Thêm mới
        // ═══════════════════════════════════════════
        private void LamMoi()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            _maLoaiDangSua = null;
            dgvLoaiHang.ClearSelection();
            CapNhatTrangThai(cheDoThem: true);
            txtTenLoai.Focus();
        }

        // ═══════════════════════════════════════════
        // HELPER: Cập nhật trạng thái nút theo chế độ
        // ═══════════════════════════════════════════
        private void CapNhatTrangThai(bool cheDoThem)
        {
            btnThem.Enabled = cheDoThem;
            btnSua.Enabled = !cheDoThem;
            btnXoa.Enabled = !cheDoThem;
            txtMaLoai.ReadOnly = true; // MaLoai luôn do DB tự sinh (IDENTITY)
        }

        // ═══════════════════════════════════════════
        // SỰ KIỆN GIỮ LẠI TỪ DESIGNER (không dùng)
        // ═══════════════════════════════════════════
        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}