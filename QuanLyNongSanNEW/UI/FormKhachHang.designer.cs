namespace QLNongSan.UI
{
    partial class FormKhachHang
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
            lblMaKH = new Label();
            txtMaKH = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            grpDanhSach = new GroupBox();
            dgvKhachHang = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblMaKH);
            grpThongTin.Controls.Add(txtMaKH);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblSDT);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(lblDiaChi);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblGhiChu);
            grpThongTin.Controls.Add(txtGhiChu);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Dock = DockStyle.Top;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(0, 0);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(984, 200);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // lblMaKH
            // 
            lblMaKH.Font = new Font("Segoe UI", 10F);
            lblMaKH.Location = new Point(20, 40);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(134, 25);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã khách hàng:";
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Segoe UI", 10F);
            txtMaKH.Location = new Point(160, 38);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(200, 30);
            txtMaKH.TabIndex = 1;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(20, 85);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(120, 25);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(160, 82);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 30);
            txtHoTen.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 10F);
            lblSDT.Location = new Point(20, 130);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(120, 25);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F);
            txtSDT.Location = new Point(160, 127);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(200, 30);
            txtSDT.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.Location = new Point(380, 40);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(80, 25);
            lblDiaChi.TabIndex = 6;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(470, 37);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(230, 30);
            txtDiaChi.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(380, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(470, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 30);
            txtEmail.TabIndex = 9;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Segoe UI", 10F);
            lblGhiChu.Location = new Point(380, 130);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(80, 25);
            lblGhiChu.TabIndex = 10;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 10F);
            txtGhiChu.Location = new Point(470, 127);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(230, 30);
            txtGhiChu.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(13, 110, 253);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(743, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(858, 40);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(743, 90);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(858, 90);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvKhachHang);
            grpDanhSach.Dock = DockStyle.Fill;
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.Location = new Point(0, 200);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Padding = new Padding(10, 15, 10, 10);
            grpDanhSach.Size = new Size(984, 400);
            grpDanhSach.TabIndex = 1;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.BorderStyle = BorderStyle.Fixed3D;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKH, HoTen, SDT, DiaChi, Email, GhiChu });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Font = new Font("Segoe UI", 10F);
            dgvKhachHang.Location = new Point(10, 38);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 30;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(964, 352);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // MaKH
            // 
            MaKH.DataPropertyName = "MaKH";
            MaKH.HeaderText = "Mã KH";
            MaKH.MinimumWidth = 6;
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số điện thoại";
            SDT.MinimumWidth = 6;
            SDT.Name = "SDT";
            SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            GhiChu.ReadOnly = true;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 600);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThongTin);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 640);
            Name = "FormKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nông sản - Quản lý Khách hàng";
            Load += FormKhachHang_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
