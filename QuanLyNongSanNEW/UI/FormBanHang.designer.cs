namespace QLNongSan.UI
{
    partial class FormBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlContent = new Panel();
            lblTieuDe = new Label();
            grpThongTin = new GroupBox();
            lblMaPB = new Label();
            txtMaPB = new TextBox();
            lblKhachHang = new Label();
            cboKhachHang = new ComboBox();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblNgayBan = new Label();
            dtpNgayBan = new DateTimePicker();
            lblPTTT = new Label();
            cboPTTT = new ComboBox();
            grpChiTiet = new GroupBox();
            lblSanPham = new Label();
            cboSanPham = new ComboBox();
            lblDVT = new Label();
            cboDVT = new ComboBox();
            lblGiaBan = new Label();
            txtGiaBan = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblChietKhau = new Label();
            txtChietKhau = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            grpDanhSach = new GroupBox();
            dgvChiTiet = new DataGridView();
            colMaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colDVT = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colChietKhau = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            lblTongLabel = new Label();
            txtTong = new TextBox();
            btnThanhToan = new Button();
            btnLuuPhieu = new Button();
            btnHuyPhieu = new Button();
            pnlContent.SuspendLayout();
            grpThongTin.SuspendLayout();
            grpChiTiet.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.Control;
            pnlContent.Controls.Add(lblTieuDe);
            pnlContent.Controls.Add(grpThongTin);
            pnlContent.Controls.Add(grpChiTiet);
            pnlContent.Controls.Add(grpDanhSach);
            pnlContent.Controls.Add(lblTongLabel);
            pnlContent.Controls.Add(txtTong);
            pnlContent.Controls.Add(btnThanhToan);
            pnlContent.Controls.Add(btnLuuPhieu);
            pnlContent.Controls.Add(btnHuyPhieu);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1280, 840);
            pnlContent.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.BackColor = Color.Transparent;
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Black;
            lblTieuDe.Location = new Point(420, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(441, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "🌿 LẬP PHIẾU BÁN HÀNG";
            // 
            // grpThongTin
            // 
            grpThongTin.BackColor = Color.Transparent;
            grpThongTin.Controls.Add(lblMaPB);
            grpThongTin.Controls.Add(txtMaPB);
            grpThongTin.Controls.Add(lblKhachHang);
            grpThongTin.Controls.Add(cboKhachHang);
            grpThongTin.Controls.Add(lblNhanVien);
            grpThongTin.Controls.Add(cboNhanVien);
            grpThongTin.Controls.Add(lblNgayBan);
            grpThongTin.Controls.Add(dtpNgayBan);
            grpThongTin.Controls.Add(lblPTTT);
            grpThongTin.Controls.Add(cboPTTT);
            grpThongTin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            grpThongTin.ForeColor = Color.Black;
            grpThongTin.Location = new Point(20, 70);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1240, 165);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "📋 Thông tin phiếu bán";
            // 
            // lblMaPB
            // 
            lblMaPB.AutoSize = true;
            lblMaPB.Font = new Font("Segoe UI", 11F);
            lblMaPB.ForeColor = Color.Black;
            lblMaPB.Location = new Point(12, 44);
            lblMaPB.Name = "lblMaPB";
            lblMaPB.Size = new Size(133, 25);
            lblMaPB.TabIndex = 0;
            lblMaPB.Text = "Mã phiếu bán:";
            // 
            // txtMaPB
            // 
            txtMaPB.BackColor = SystemColors.Window;
            txtMaPB.Font = new Font("Segoe UI", 11F);
            txtMaPB.Location = new Point(12, 72);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.Size = new Size(200, 32);
            txtMaPB.TabIndex = 0;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 11F);
            lblKhachHang.ForeColor = Color.Black;
            lblKhachHang.Location = new Point(230, 44);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(116, 25);
            lblKhachHang.TabIndex = 1;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Segoe UI", 11F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(230, 72);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(280, 33);
            cboKhachHang.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 11F);
            lblNhanVien.ForeColor = Color.Black;
            lblNhanVien.Location = new Point(530, 44);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(139, 25);
            lblNhanVien.TabIndex = 2;
            lblNhanVien.Text = "Nhân viên bán:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 11F);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(530, 72);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(260, 33);
            cboNhanVien.TabIndex = 2;
            // 
            // lblNgayBan
            // 
            lblNgayBan.AutoSize = true;
            lblNgayBan.Font = new Font("Segoe UI", 11F);
            lblNgayBan.ForeColor = Color.Black;
            lblNgayBan.Location = new Point(808, 44);
            lblNgayBan.Name = "lblNgayBan";
            lblNgayBan.Size = new Size(97, 25);
            lblNgayBan.TabIndex = 3;
            lblNgayBan.Text = "Ngày bán:";
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Font = new Font("Segoe UI", 11F);
            dtpNgayBan.Format = DateTimePickerFormat.Short;
            dtpNgayBan.Location = new Point(808, 72);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(180, 32);
            dtpNgayBan.TabIndex = 3;
            // 
            // lblPTTT
            // 
            lblPTTT.AutoSize = true;
            lblPTTT.Font = new Font("Segoe UI", 11F);
            lblPTTT.ForeColor = Color.Black;
            lblPTTT.Location = new Point(1005, 44);
            lblPTTT.Name = "lblPTTT";
            lblPTTT.Size = new Size(149, 25);
            lblPTTT.TabIndex = 4;
            lblPTTT.Text = "Phương thức TT:";
            // 
            // cboPTTT
            // 
            cboPTTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPTTT.Font = new Font("Segoe UI", 11F);
            cboPTTT.FormattingEnabled = true;
            cboPTTT.Location = new Point(1005, 72);
            cboPTTT.Name = "cboPTTT";
            cboPTTT.Size = new Size(220, 33);
            cboPTTT.TabIndex = 4;
            // 
            // grpChiTiet
            // 
            grpChiTiet.BackColor = Color.Transparent;
            grpChiTiet.Controls.Add(lblSanPham);
            grpChiTiet.Controls.Add(cboSanPham);
            grpChiTiet.Controls.Add(lblDVT);
            grpChiTiet.Controls.Add(cboDVT);
            grpChiTiet.Controls.Add(lblGiaBan);
            grpChiTiet.Controls.Add(txtGiaBan);
            grpChiTiet.Controls.Add(lblSoLuong);
            grpChiTiet.Controls.Add(txtSoLuong);
            grpChiTiet.Controls.Add(lblChietKhau);
            grpChiTiet.Controls.Add(txtChietKhau);
            grpChiTiet.Controls.Add(btnThem);
            grpChiTiet.Controls.Add(btnXoa);
            grpChiTiet.Controls.Add(btnSua);
            grpChiTiet.Controls.Add(btnLamMoi);
            grpChiTiet.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            grpChiTiet.ForeColor = Color.Black;
            grpChiTiet.Location = new Point(20, 248);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Size = new Size(1240, 165);
            grpChiTiet.TabIndex = 2;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "🌾 Chi tiết sản phẩm";
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Font = new Font("Segoe UI", 11F);
            lblSanPham.ForeColor = Color.Black;
            lblSanPham.Location = new Point(12, 38);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(100, 25);
            lblSanPham.TabIndex = 0;
            lblSanPham.Text = "Sản phẩm:";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Font = new Font("Segoe UI", 11F);
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(12, 66);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(280, 33);
            cboSanPham.TabIndex = 5;
            cboSanPham.SelectedIndexChanged += cboSanPham_SelectedIndexChanged;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Font = new Font("Segoe UI", 11F);
            lblDVT.ForeColor = Color.Black;
            lblDVT.Location = new Point(308, 38);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(108, 25);
            lblDVT.TabIndex = 6;
            lblDVT.Text = "Đơn vị tính:";
            // 
            // cboDVT
            // 
            cboDVT.Font = new Font("Segoe UI", 11F);
            cboDVT.FormattingEnabled = true;
            cboDVT.Location = new Point(308, 66);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(140, 33);
            cboDVT.TabIndex = 6;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Font = new Font("Segoe UI", 11F);
            lblGiaBan.ForeColor = Color.Black;
            lblGiaBan.Location = new Point(464, 38);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(137, 25);
            lblGiaBan.TabIndex = 7;
            lblGiaBan.Text = "Giá bán (VNĐ):";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = SystemColors.Window;
            txtGiaBan.Font = new Font("Segoe UI", 11F);
            txtGiaBan.Location = new Point(464, 66);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.ReadOnly = true;
            txtGiaBan.Size = new Size(170, 32);
            txtGiaBan.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 11F);
            lblSoLuong.ForeColor = Color.Black;
            lblSoLuong.Location = new Point(650, 38);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(91, 25);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 11F);
            txtSoLuong.Location = new Point(650, 66);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(130, 32);
            txtSoLuong.TabIndex = 8;
            // 
            // lblChietKhau
            // 
            lblChietKhau.AutoSize = true;
            lblChietKhau.Font = new Font("Segoe UI", 11F);
            lblChietKhau.ForeColor = Color.Black;
            lblChietKhau.Location = new Point(796, 38);
            lblChietKhau.Name = "lblChietKhau";
            lblChietKhau.Size = new Size(139, 25);
            lblChietKhau.TabIndex = 9;
            lblChietKhau.Text = "Chiết khấu (%):";
            // 
            // txtChietKhau
            // 
            txtChietKhau.Font = new Font("Segoe UI", 11F);
            txtChietKhau.Location = new Point(796, 66);
            txtChietKhau.Name = "txtChietKhau";
            txtChietKhau.Size = new Size(130, 32);
            txtChietKhau.TabIndex = 9;
            txtChietKhau.Text = "0";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(29, 158, 117);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(960, 52);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 44);
            btnThem.TabIndex = 10;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 60, 60);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(1080, 52);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 44);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "🗑 Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(55, 138, 221);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(960, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 44);
            btnSua.TabIndex = 12;
            btnSua.Text = "✏ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(130, 130, 130);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1080, 105);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 44);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "🔄 Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.BackColor = Color.Transparent;
            grpDanhSach.Controls.Add(dgvChiTiet);
            grpDanhSach.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.Black;
            grpDanhSach.Location = new Point(20, 428);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1240, 280);
            grpDanhSach.TabIndex = 3;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "📦 Danh sách chi tiết phiếu bán";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { colMaSP, colTenSP, colDVT, colGiaBan, colSoLuong, colChietKhau, colThanhTien });
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.GridColor = Color.FromArgb(220, 240, 230);
            dgvChiTiet.Location = new Point(3, 32);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(1234, 245);
            dgvChiTiet.TabIndex = 0;
            // 
            // colMaSP
            // 
            colMaSP.FillWeight = 60F;
            colMaSP.HeaderText = "Mã SP";
            colMaSP.MinimumWidth = 6;
            colMaSP.Name = "colMaSP";
            colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            colTenSP.FillWeight = 180F;
            colTenSP.HeaderText = "Tên sản phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            colTenSP.ReadOnly = true;
            // 
            // colDVT
            // 
            colDVT.FillWeight = 60F;
            colDVT.HeaderText = "ĐVT";
            colDVT.MinimumWidth = 6;
            colDVT.Name = "colDVT";
            colDVT.ReadOnly = true;
            // 
            // colGiaBan
            // 
            colGiaBan.HeaderText = "Giá bán";
            colGiaBan.MinimumWidth = 6;
            colGiaBan.Name = "colGiaBan";
            colGiaBan.ReadOnly = true;
            // 
            // colSoLuong
            // 
            colSoLuong.FillWeight = 80F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            // 
            // colChietKhau
            // 
            colChietKhau.FillWeight = 90F;
            colChietKhau.HeaderText = "Chiết khấu (%)";
            colChietKhau.MinimumWidth = 6;
            colChietKhau.Name = "colChietKhau";
            colChietKhau.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.FillWeight = 120F;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblTongLabel
            // 
            lblTongLabel.BackColor = Color.Transparent;
            lblTongLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTongLabel.ForeColor = Color.Black;
            lblTongLabel.Location = new Point(540, 722);
            lblTongLabel.Name = "lblTongLabel";
            lblTongLabel.Size = new Size(300, 40);
            lblTongLabel.TabIndex = 4;
            lblTongLabel.Text = "TỔNG THANH TOÁN:";
            lblTongLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTong
            // 
            txtTong.BackColor = SystemColors.Window;
            txtTong.BorderStyle = BorderStyle.None;
            txtTong.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtTong.ForeColor = Color.Black;
            txtTong.Location = new Point(854, 718);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(340, 40);
            txtTong.TabIndex = 14;
            txtTong.Text = "0 VNĐ";
            txtTong.TextAlign = HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(0, 168, 168);
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(20, 770);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(380, 50);
            btnThanhToan.TabIndex = 15;
            btnThanhToan.Text = "\U0001f6d2 THANH TOÁN & IN HÓA ĐƠN";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnLuuPhieu
            // 
            btnLuuPhieu.BackColor = Color.FromArgb(29, 158, 117);
            btnLuuPhieu.FlatAppearance.BorderSize = 0;
            btnLuuPhieu.FlatStyle = FlatStyle.Flat;
            btnLuuPhieu.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLuuPhieu.ForeColor = Color.White;
            btnLuuPhieu.Location = new Point(430, 770);
            btnLuuPhieu.Name = "btnLuuPhieu";
            btnLuuPhieu.Size = new Size(300, 50);
            btnLuuPhieu.TabIndex = 16;
            btnLuuPhieu.Text = "💾 LƯU PHIẾU BÁN";
            btnLuuPhieu.UseVisualStyleBackColor = false;
            btnLuuPhieu.Click += btnLuuPhieu_Click;
            // 
            // btnHuyPhieu
            // 
            btnHuyPhieu.BackColor = Color.FromArgb(200, 50, 50);
            btnHuyPhieu.FlatAppearance.BorderSize = 0;
            btnHuyPhieu.FlatStyle = FlatStyle.Flat;
            btnHuyPhieu.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnHuyPhieu.ForeColor = Color.White;
            btnHuyPhieu.Location = new Point(750, 770);
            btnHuyPhieu.Name = "btnHuyPhieu";
            btnHuyPhieu.Size = new Size(240, 50);
            btnHuyPhieu.TabIndex = 17;
            btnHuyPhieu.Text = "🗑 HỦY PHIẾU";
            btnHuyPhieu.UseVisualStyleBackColor = false;
            btnHuyPhieu.Click += btnHuyPhieu_Click;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 840);
            Controls.Add(pnlContent);
            MinimumSize = new Size(1280, 840);
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng - QL Nông Sản";
            Load += FormBanHang_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpChiTiet.ResumeLayout(false);
            grpChiTiet.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        // ─── Controls ───
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTieuDe;

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblPTTT;
        private System.Windows.Forms.ComboBox cboPTTT;

        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblChietKhau;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChietKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;

        private System.Windows.Forms.Label lblTongLabel;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnHuyPhieu;
    }
}