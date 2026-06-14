using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormNhanVien : Form
    {
        private readonly QLNongSan.Application application;

        // Constructor mặc định cho Designer
        public FormNhanVien()
        {
            InitializeComponent();
        }

        // Constructor chính nhận Application từ form cha
        public FormNhanVien(QLNongSan.Application application)
        {
            this.application = application;
            InitializeComponent();
            DinhDangBieuMauLuoi();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            HienThiData();
        }

        // Định dạng lưới dữ liệu
        private void DinhDangBieuMauLuoi()
        {
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 228, 232);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvNhanVien.DefaultCellStyle.BackColor = Color.White;
            dgvNhanVien.DefaultCellStyle.ForeColor = Color.Black;
            dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvNhanVien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvNhanVien.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNhanVien.GridColor = Color.FromArgb(220, 220, 220);
        }

        // Tải và hiển thị danh sách nhân viên lên lưới
        private void HienThiData()
        {
            try
            {
                if (application == null) return;

                // BUG FIX: Không cần xóa cột thủ công vì Designer đã định nghĩa cột sẵn (AutoGenerateColumns=false)
                // Chỉ cần gán DataSource là đủ
                DataTable dt = application.employeeRepository.GetListNhanVien();
                dgvNhanVien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Gom dữ liệu từ các ô nhập liệu thành đối tượng DTO
        private NhanVienDTO LayDuLieuForm()
        {
            return new NhanVienDTO
            {
                MaNV = txtMaNV.Text.Trim(),
                TenNV = txtTenNV.Text.Trim(),
                ChucVu = txtChucVu.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };
        }

        // Xóa trắng form và cho phép nhập mã mới
        private void LamMoiForm()
        {
            txtMaNV.Clear();
            txtMaNV.ReadOnly = true;   // Luôn khóa — DB tự sinh, không cho nhập tay
            txtTenNV.Clear();
            txtSDT.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            txtTenNV.Focus();
        }

        // --- XỬ LÝ CÁC NÚT CHỨC NĂNG ---

        // 1. THÊM nhân viên mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // BỎ HOÀN TOÀN đoạn kiểm tra txtMaNV — DB tự sinh, không cần nhập
                if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNV.Focus();
                    return;
                }

                NhanVienDTO nv = LayDuLieuForm();
                string ketQua = application.employeeRepository.AddNhanVien(nv);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    LamMoiForm();
                }
                else
                {
                    MessageBox.Show("Không thể thêm nhân viên.\n" + ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. SỬA thông tin nhân viên đang chọn
        // BUG FIX: Thay thế toàn bộ btnSua_Click giả (bool isSuccess = true) bằng code thực gọi DAL
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTenNV.Text))
                {
                    MessageBox.Show("Tên nhân viên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenNV.Focus();
                    return;
                }

                NhanVienDTO nv = LayDuLieuForm();
                string ketQua = application.employeeRepository.UpdateNhanVien(nv);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    LamMoiForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.\n" + ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. XÓA nhân viên đang chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận xóa nhân viên [{txtMaNV.Text} - {txtTenNV.Text}]?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string ketQua = application.employeeRepository.DeleteNhanVien(txtMaNV.Text.Trim());
                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiData();
                    LamMoiForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.\n" + ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. LÀM MỚI form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        // Khi click vào dòng trên lưới: điền thông tin lên form để xem/sửa/xóa
        // BUG FIX: Dùng đúng tên cột Designer đã đặt (colMaNV, colHoTen...) thay vì kiểm tra động rườm rà
        // BUG FIX: Cột ChucVu trong DataTable thực tế tên là "ChucVu" (do alias AS ChucVu trong DAL)
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNhanVien.CurrentRow == null) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["colMaNV"].Value?.ToString();
            txtTenNV.Text = row.Cells["colHoTen"].Value?.ToString();
            txtSDT.Text = row.Cells["colSDT"].Value?.ToString();
            txtChucVu.Text = row.Cells["colChucVu"].Value?.ToString();
            txtDiaChi.Text = row.Cells["colDiaChi"].Value?.ToString();

            // Khóa mã NV lại khi đang sửa để tránh thay đổi khóa chính
            txtMaNV.ReadOnly = true;
        }
    }
}