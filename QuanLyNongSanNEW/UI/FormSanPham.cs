using QLNongSan.Repositories;
using QLNongSan.schemas;
using System;
using System.Data; // BẮT BUỘC để nhận diện DataRowView
using System.Windows.Forms;
using System.Drawing;
namespace QLNongSan.UI
{
    public partial class FormSanPham : Form
    {
        private readonly Application application;
        public FormSanPham(Application application)
        {
            this.application = application;
            InitializeComponent();
            // Giữ nguyên logic liên kết sự kiện
            this.Load += FormSanPham_Load;
            this.btnThem.Click += btnThem_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.btnLamMoi.Click += btnLamMoi_Click;
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            LoadLoaiHang();
        }

        private void LoadLoaiHang()
        {
            try
            {
                var dt = application.productRepository.GetDanhSachLoaiHang();
                cboLoaiHang.DataSource = dt;
                cboLoaiHang.DisplayMember = "TenLoai";
                cboLoaiHang.ValueMember = "MaLoai";
                cboLoaiHang.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải loại hàng: " + ex.Message, "Lỗi");
            }
        }

        private void HienThiDanhSachSanPham()
        {
            try
            {
                dgvSanPham.DataSource = application.productRepository.GetListSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sản phẩm: " + ex.Message, "Lỗi");
            }
        }

        // Click vào dòng trên bảng → tự điền vào form
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSanPham.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells["Mã SP"].Value?.ToString();
            txtTenSP.Text = row.Cells["Tên sản phẩm"].Value?.ToString();
            txtDVT.Text = row.Cells["ĐVT"].Value?.ToString();
            txtGiaBan.Text = row.Cells["Giá bán"].Value?.ToString();
            txtSoLuongTon.Text = row.Cells["Tồn kho"].Value?.ToString();

            // Chọn đúng loại hàng trong ComboBox
            string tenLoai = row.Cells["Loại hàng"].Value?.ToString();
            foreach (DataRowView item in cboLoaiHang.Items)
            {
                if (item["TenLoai"].ToString() == tenLoai)
                {
                    cboLoaiHang.SelectedItem = item;
                    break;
                }
            }
        }

        // Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên sản phẩm!", "Thông báo");
                    return;
                }

                SanPhamDTO sp = new SanPhamDTO
                {
                    TenSP = txtTenSP.Text.Trim(),
                    DVT = txtDVT.Text.Trim(),
                    MaLoai = cboLoaiHang.SelectedValue?.ToString() ?? "",
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim()),
                    GiaBan = decimal.Parse(txtGiaBan.Text.Trim())
                };

                string ketQua = application.productRepository.AddSanPham(sp);
                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachSanPham();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho 'Số lượng tồn' và 'Giá bán'!", "Sai định dạng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Hệ thống");
            }
        }

        // Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm từ bảng!", "Thông báo");
                    return;
                }

                SanPhamDTO sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    DVT = txtDVT.Text.Trim(),
                    MaLoai = cboLoaiHang.SelectedValue?.ToString() ?? "",
                    SoLuongTon = int.Parse(txtSoLuongTon.Text.Trim()),
                    GiaBan = decimal.Parse(txtGiaBan.Text.Trim())
                };

                string ketQua = application.productRepository.UpdateSanPham(sp);
                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachSanPham();
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message);
            }
        }

        // Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtMaSP.Text.Trim();
                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm từ bảng!", "Thông báo");
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string ketQua = application.productRepository.DeleteSanPham(maSP);
                    if (ketQua == "SUCCESS")
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
                        HienThiDanhSachSanPham();
                        btnLamMoi.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
            }
        }

        // Nút LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtMaSP.BackColor = Color.FromArgb(60, 60, 60);
            txtTenSP.Clear();
            txtDVT.Clear();
            txtSoLuongTon.Clear();
            txtGiaBan.Clear();
            cboLoaiHang.SelectedIndex = -1;
            txtTenSP.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongTon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}