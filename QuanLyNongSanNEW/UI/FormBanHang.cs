using QLNongSan.Repositories;
using QLNongSan.schemas;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLNongSan.UI
{
    public partial class FormBanHang : Form
    {
        private readonly Application application;

        // DataTable tạm lưu chi tiết phiếu bán hiện tại
        private DataTable dtChiTiet = new DataTable();

        public FormBanHang(Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        // ═══════════════════════════════════════════
        // LOAD FORM
        // ═══════════════════════════════════════════
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            KhoiTaoChiTiet();
            LoadComboBoxes();
            TaoMaPBMoi();
        }

        // Khởi tạo cột cho DataTable tạm
        private void KhoiTaoChiTiet()
        {
            dtChiTiet.Columns.Add("MaSP");
            dtChiTiet.Columns.Add("TenSP");
            dtChiTiet.Columns.Add("DVT");
            dtChiTiet.Columns.Add("GiaBan", typeof(decimal));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("ChietKhau", typeof(decimal));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));

            // Bind sang DataGridView với tên cột khớp designer
            dgvChiTiet.AutoGenerateColumns = false;
            colMaSP.DataPropertyName = "MaSP";
            colTenSP.DataPropertyName = "TenSP";
            colDVT.DataPropertyName = "DVT";
            colGiaBan.DataPropertyName = "GiaBan";
            colSoLuong.DataPropertyName = "SoLuong";
            colChietKhau.DataPropertyName = "ChietKhau";
            colThanhTien.DataPropertyName = "ThanhTien";

            dgvChiTiet.DataSource = dtChiTiet;
        }

        // Đổ dữ liệu vào các ComboBox từ DB
        // LƯU Ý: phải set DisplayMember/ValueMember TRƯỚC DataSource
        private void LoadComboBoxes()
        {
            try
            {
                // Khách hàng
                DataTable dtKH = application.salesRepository.GetDanhSachKhachHang();
                cboKhachHang.DisplayMember = "TenKH";
                cboKhachHang.ValueMember = "MaKH";
                cboKhachHang.DataSource = dtKH;

                // Nhân viên — tự detect tên cột hiển thị để tránh hiện MaNV
                DataTable dtNV = application.salesRepository.GetDanhSachNhanVien();
                // DAL: SELECT MaNV, HoTen AS TenNV => cột trả về là "MaNV" và "TenNV"
                string displayCol = "TenNV";
                string valueCol = "MaNV";
                cboNhanVien.DisplayMember = displayCol;
                cboNhanVien.ValueMember = valueCol;
                cboNhanVien.DataSource = dtNV;

                // Phương thức thanh toán
                if (cboPTTT.Items.Count == 0)
                    cboPTTT.Items.AddRange(new string[] { "Tiền mặt", "Chuyển khoản", "Thẻ tín dụng" });
                cboPTTT.SelectedIndex = 0;

                // Sản phẩm
                DataTable dtSP = application.salesRepository.GetDanhSachSanPham();
                cboSanPham.DisplayMember = "TenSP";
                cboSanPham.ValueMember = "MaSP";
                cboSanPham.DataSource = dtSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tự sinh mã phiếu bán theo ngày giờ
        private void TaoMaPBMoi()
        {
            txtMaPB.Text = "PB" + DateTime.Now.ToString("yyyyMMddHHmm");
        }

        // ═══════════════════════════════════════════
        // SỰ KIỆN COMBOBOX SẢN PHẨM
        // ═══════════════════════════════════════════
        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null) return;

            string tenSP = cboSanPham.Text;
            DataRow row = application.salesRepository.GetSanPhamByTen(tenSP);
            if (row != null)
            {
                txtGiaBan.Text = row["GiaBan"].ToString();
                cboDVT.Text = row["DVT"].ToString();
            }
        }

        // ═══════════════════════════════════════════
        // TÍNH TOÁN
        // ═══════════════════════════════════════════
        private decimal TinhThanhTien()
        {
            decimal giaBan = decimal.TryParse(txtGiaBan.Text, out decimal g) ? g : 0;
            int soLuong = int.TryParse(txtSoLuong.Text, out int sl) ? sl : 0;
            decimal chietKhau = decimal.TryParse(txtChietKhau.Text, out decimal ck) ? ck : 0;
            return giaBan * soLuong * (1 - chietKhau / 100m);
        }

        private void CapNhatTong()
        {
            decimal tong = 0;
            foreach (DataRow row in dtChiTiet.Rows)
                tong += Convert.ToDecimal(row["ThanhTien"]);
            txtTong.Text = tong.ToString("N0") + " VNĐ";
        }

        // ═══════════════════════════════════════════
        // NÚT: THÊM SẢN PHẨM (btnThem)
        // ═══════════════════════════════════════════
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal thanhTien = TinhThanhTien();
            DataTable dtSP = (DataTable)cboSanPham.DataSource;
            DataRow spRow = dtSP.Rows[cboSanPham.SelectedIndex];

            dtChiTiet.Rows.Add(
                spRow["MaSP"].ToString(),
                cboSanPham.Text,
                cboDVT.Text,
                decimal.TryParse(txtGiaBan.Text, out decimal g) ? g : 0,
                soLuong,
                decimal.TryParse(txtChietKhau.Text, out decimal ck) ? ck : 0,
                thanhTien
            );

            CapNhatTong();
            LamMoiChiTiet();
        }

        // ═══════════════════════════════════════════
        // NÚT: XÓA DÒNG (btnXoa)
        // ═══════════════════════════════════════════
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtChiTiet.Rows.RemoveAt(dgvChiTiet.CurrentRow.Index);
            CapNhatTong();
        }

        // ═══════════════════════════════════════════
        // NÚT: SỬA DÒNG (btnSua) — điền lại lên form
        // ═══════════════════════════════════════════
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idx = dgvChiTiet.CurrentRow.Index;
            DataRow row = dtChiTiet.Rows[idx];

            cboSanPham.Text = row["TenSP"].ToString();
            cboDVT.Text = row["DVT"].ToString();
            txtGiaBan.Text = row["GiaBan"].ToString();
            txtSoLuong.Text = row["SoLuong"].ToString();
            txtChietKhau.Text = row["ChietKhau"].ToString();

            dtChiTiet.Rows.RemoveAt(idx);
            CapNhatTong();
        }

        // ═══════════════════════════════════════════
        // NÚT: LÀM MỚI CHI TIẾT (btnLamMoi)
        // ═══════════════════════════════════════════
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiChiTiet();
        }

        private void LamMoiChiTiet()
        {
            if (cboSanPham.Items.Count > 0) cboSanPham.SelectedIndex = 0;
            cboDVT.Text = string.Empty;
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtChietKhau.Text = "0";
        }

        // ═══════════════════════════════════════════
        // NÚT: THANH TOÁN & IN HÓA ĐƠN (btnThanhToan)
        // ═══════════════════════════════════════════
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string ketQua = LuuPhieu();
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Thanh toán thành công!\nĐang in hóa đơn...", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HuyPhieu();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════
        // NÚT: LƯU PHIẾU BÁN (btnLuuPhieu)
        // ═══════════════════════════════════════════
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            string ketQua = LuuPhieu();
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Lưu phiếu bán thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                HuyPhieu();
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ═══════════════════════════════════════════
        // NÚT: HỦY PHIẾU (btnHuyPhieu)
        // ═══════════════════════════════════════════
        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy phiếu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HuyPhieu();
            }
        }

        // ═══════════════════════════════════════════
        // LƯU PHIẾU VÀO DB (HoaDon + ChiTietHoaDon)
        // ═══════════════════════════════════════════
        private string LuuPhieu()
        {
            // Validation phía form trước khi gọi DAL
            if (cboNhanVien.SelectedValue == null || string.IsNullOrEmpty(cboNhanVien.SelectedValue.ToString()))
                return "Vui lòng chọn nhân viên bán!";

            if (dtChiTiet.Rows.Count == 0)
                return "Chưa có sản phẩm nào trong phiếu!";

            string maNV = cboNhanVien.SelectedValue.ToString();
            string maKH = cboKhachHang.SelectedValue?.ToString() ?? string.Empty;

            PhieuBanDTO phieu = new PhieuBanDTO
            {
                MaPB = txtMaPB.Text.Trim(),
                MaKH = maKH,          // DAL dùng MaKH
                MaNV = maNV,          // DAL dùng MaNV
                NgayBan = dtpNgayBan.Value.ToString("yyyy-MM-dd"),
                PhuongThucTT = cboPTTT.Text,
                TongThanhToan = decimal.TryParse(
                    txtTong.Text.Replace(" VNĐ", "").Replace(",", ""),
                    out decimal t) ? t : 0
            };

            return application.salesRepository.LuuPhieuBan(phieu, dtChiTiet);
        }

        // ═══════════════════════════════════════════
        // RESET TOÀN BỘ FORM
        // ═══════════════════════════════════════════
        private void HuyPhieu()
        {
            dtChiTiet.Rows.Clear();
            txtTong.Text = "0 VNĐ";
            TaoMaPBMoi();

            if (cboKhachHang.Items.Count > 0) cboKhachHang.SelectedIndex = 0;
            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
            cboPTTT.SelectedIndex = 0;
            dtpNgayBan.Value = DateTime.Now;

            LamMoiChiTiet();
        }
    }
}