namespace QLNongSan.UI
{
    partial class FormNhapHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            lblMaPN = new Label();
            txtMaPN = new TextBox();
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblNhaCungCap = new Label();
            cboNhaCungCap = new ComboBox();
            lblNgayNhap = new Label();
            dtpNgayNhap = new DateTimePicker();
            lblSanPham = new Label();
            cboSanPham = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblGiaNhap = new Label();
            txtGiaNhap = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnLamMoi = new Button();
            grpDanhSach = new GroupBox();
            lblTongTien = new Label();
            lblTongTienText = new Label();
            dgvChiTiet = new DataGridView();
            lblHanSuDung = new Label();
            dtpHanSuDung = new DateTimePicker();
            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(dtpHanSuDung);
            grpThongTin.Controls.Add(lblHanSuDung);
            grpThongTin.Controls.Add(lblMaPN);
            grpThongTin.Controls.Add(txtMaPN);
            grpThongTin.Controls.Add(lblNhanVien);
            grpThongTin.Controls.Add(cboNhanVien);
            grpThongTin.Controls.Add(lblNhaCungCap);
            grpThongTin.Controls.Add(cboNhaCungCap);
            grpThongTin.Controls.Add(lblNgayNhap);
            grpThongTin.Controls.Add(dtpNgayNhap);
            grpThongTin.Controls.Add(lblSanPham);
            grpThongTin.Controls.Add(cboSanPham);
            grpThongTin.Controls.Add(lblSoLuong);
            grpThongTin.Controls.Add(txtSoLuong);
            grpThongTin.Controls.Add(lblGiaNhap);
            grpThongTin.Controls.Add(txtGiaNhap);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnLuu);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Dock = DockStyle.Top;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(0, 0);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(984, 195);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "THÔNG TIN PHIẾU NHẬP HÀNG";
            // 
            // lblMaPN
            // 
            lblMaPN.Font = new Font("Segoe UI", 10F);
            lblMaPN.Location = new Point(20, 35);
            lblMaPN.Name = "lblMaPN";
            lblMaPN.Size = new Size(110, 25);
            lblMaPN.TabIndex = 0;
            lblMaPN.Text = "Mã phiếu:";
            // 
            // txtMaPN
            // 
            txtMaPN.Font = new Font("Segoe UI", 10F);
            txtMaPN.Location = new Point(150, 32);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(200, 30);
            txtMaPN.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Font = new Font("Segoe UI", 10F);
            lblNhanVien.Location = new Point(20, 72);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(110, 25);
            lblNhanVien.TabIndex = 2;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Font = new Font("Segoe UI", 10F);
            cboNhanVien.Location = new Point(150, 69);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(200, 31);
            cboNhanVien.TabIndex = 3;
            // 
            // lblNhaCungCap
            // 
            lblNhaCungCap.Font = new Font("Segoe UI", 10F);
            lblNhaCungCap.Location = new Point(20, 109);
            lblNhaCungCap.Name = "lblNhaCungCap";
            lblNhaCungCap.Size = new Size(124, 25);
            lblNhaCungCap.TabIndex = 4;
            lblNhaCungCap.Text = "Nhà cung cấp:";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhaCungCap.Font = new Font("Segoe UI", 10F);
            cboNhaCungCap.Location = new Point(150, 106);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(200, 31);
            cboNhaCungCap.TabIndex = 5;
            // 
            // lblNgayNhap
            // 
            lblNgayNhap.Font = new Font("Segoe UI", 10F);
            lblNgayNhap.Location = new Point(20, 146);
            lblNgayNhap.Name = "lblNgayNhap";
            lblNgayNhap.Size = new Size(110, 25);
            lblNgayNhap.TabIndex = 6;
            lblNgayNhap.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Font = new Font("Segoe UI", 10F);
            dtpNgayNhap.Format = DateTimePickerFormat.Short;
            dtpNgayNhap.Location = new Point(150, 146);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(200, 30);
            dtpNgayNhap.TabIndex = 7;
            // 
            // lblSanPham
            // 
            lblSanPham.Font = new Font("Segoe UI", 10F);
            lblSanPham.Location = new Point(370, 35);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(97, 25);
            lblSanPham.TabIndex = 8;
            lblSanPham.Text = "Sản phẩm:";
            // 
            // cboSanPham
            // 
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Font = new Font("Segoe UI", 10F);
            cboSanPham.Location = new Point(482, 32);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(220, 31);
            cboSanPham.TabIndex = 9;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Font = new Font("Segoe UI", 10F);
            lblSoLuong.Location = new Point(370, 72);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(90, 25);
            lblSoLuong.TabIndex = 10;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 10F);
            txtSoLuong.Location = new Point(482, 69);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(220, 30);
            txtSoLuong.TabIndex = 11;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.Font = new Font("Segoe UI", 10F);
            lblGiaNhap.Location = new Point(370, 109);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(90, 25);
            lblGiaNhap.TabIndex = 12;
            lblGiaNhap.Text = "Giá nhập:";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Font = new Font("Segoe UI", 10F);
            txtGiaNhap.Location = new Point(482, 106);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(220, 30);
            txtGiaNhap.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(13, 110, 253);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(735, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm SP";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(850, 32);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa SP";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(25, 135, 84);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(735, 77);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 35);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu Phiếu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(850, 77);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(lblTongTien);
            grpDanhSach.Controls.Add(lblTongTienText);
            grpDanhSach.Controls.Add(dgvChiTiet);
            grpDanhSach.Dock = DockStyle.Fill;
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(0, 195);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(10, 15, 10, 45);
            grpDanhSach.Size = new Size(984, 405);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "DANH SÁCH CHI TIẾT SẢN PHẨM NHẬP VÀO";
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTien.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(220, 53, 69);
            lblTongTien.Location = new Point(755, 370);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(215, 30);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongTienText
            // 
            lblTongTienText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTongTienText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTongTienText.Location = new Point(630, 370);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(120, 30);
            lblTongTienText.TabIndex = 1;
            lblTongTienText.Text = "TỔNG TIỀN:";
            lblTongTienText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.Fixed3D;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Font = new Font("Segoe UI", 10F);
            dgvChiTiet.Location = new Point(10, 38);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(964, 322);
            dgvChiTiet.TabIndex = 0;
            // 
            // lblHanSuDung
            // 
            lblHanSuDung.Font = new Font("Segoe UI", 10F);
            lblHanSuDung.Location = new Point(370, 146);
            lblHanSuDung.Name = "lblHanSuDung";
            lblHanSuDung.Size = new Size(118, 25);
            lblHanSuDung.TabIndex = 18;
            lblHanSuDung.Text = "Hạn sử dụng:";
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Font = new Font("Segoe UI", 10F);
            dtpHanSuDung.Format = DateTimePickerFormat.Short;
            dtpHanSuDung.Location = new Point(482, 146);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(220, 30);
            dtpHanSuDung.TabIndex = 19;
            // 
            // FormNhapHang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 600);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThongTin);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 640);
            Name = "FormNhapHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nhập hàng";
            Load += FormNhapHang_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTien;
        private DateTimePicker dtpHanSuDung;
        private Label lblHanSuDung;
    }
}