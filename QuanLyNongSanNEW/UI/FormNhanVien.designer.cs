namespace QLNongSan.UI
{
    partial class FormNhanVien
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
            panelInput = new Panel();
            lblTitleInput = new Label();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            lblHoTen = new Label();
            txtTenNV = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblChucVu = new Label();
            txtChucVu = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            panelGridTitle = new Panel();
            lblTitleGrid = new Label();
            dgvNhanVien = new DataGridView();
            colMaNV = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colChucVu = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            panelInput.SuspendLayout();
            panelGridTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.FromArgb(240, 240, 240);
            panelInput.Controls.Add(lblTitleInput);
            panelInput.Controls.Add(lblMaNV);
            panelInput.Controls.Add(txtMaNV);
            panelInput.Controls.Add(lblHoTen);
            panelInput.Controls.Add(txtTenNV);
            panelInput.Controls.Add(lblSDT);
            panelInput.Controls.Add(txtSDT);
            panelInput.Controls.Add(lblDiaChi);
            panelInput.Controls.Add(txtDiaChi);
            panelInput.Controls.Add(lblChucVu);
            panelInput.Controls.Add(txtChucVu);
            panelInput.Controls.Add(btnThem);
            panelInput.Controls.Add(btnSua);
            panelInput.Controls.Add(btnXoa);
            panelInput.Controls.Add(btnLamMoi);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 0);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1100, 190);
            panelInput.TabIndex = 2;
            // 
            // lblTitleInput
            // 
            lblTitleInput.AutoSize = true;
            lblTitleInput.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleInput.ForeColor = Color.Black;
            lblTitleInput.Location = new Point(15, 15);
            lblTitleInput.Name = "lblTitleInput";
            lblTitleInput.Size = new Size(230, 25);
            lblTitleInput.TabIndex = 0;
            lblTitleInput.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Font = new Font("Segoe UI", 10F);
            lblMaNV.Location = new Point(20, 58);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(118, 23);
            lblMaNV.TabIndex = 1;
            lblMaNV.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10F);
            txtMaNV.Location = new Point(145, 55);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(220, 30);
            txtMaNV.TabIndex = 2;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.Location = new Point(20, 100);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(88, 23);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 10F);
            txtTenNV.Location = new Point(145, 97);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(220, 30);
            txtTenNV.TabIndex = 4;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 10F);
            lblSDT.Location = new Point(20, 142);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 23);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F);
            txtSDT.Location = new Point(145, 139);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(220, 30);
            txtSDT.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.Location = new Point(400, 58);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(66, 23);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(490, 55);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(220, 30);
            txtDiaChi.TabIndex = 8;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Segoe UI", 10F);
            lblChucVu.Location = new Point(400, 100);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(76, 23);
            lblChucVu.TabIndex = 9;
            lblChucVu.Text = "Chức vụ:";
            // 
            // txtChucVu
            // 
            txtChucVu.Font = new Font("Segoe UI", 10F);
            txtChucVu.Location = new Point(490, 97);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(220, 30);
            txtChucVu.TabIndex = 10;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 120, 215);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(750, 53);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 34);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 185, 0);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(865, 53);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 34);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 54, 72);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(750, 95);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 34);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(865, 95);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 34);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panelGridTitle
            // 
            panelGridTitle.BackColor = Color.FromArgb(240, 240, 240);
            panelGridTitle.Controls.Add(lblTitleGrid);
            panelGridTitle.Dock = DockStyle.Top;
            panelGridTitle.Location = new Point(0, 190);
            panelGridTitle.Name = "panelGridTitle";
            panelGridTitle.Size = new Size(1100, 45);
            panelGridTitle.TabIndex = 1;
            // 
            // lblTitleGrid
            // 
            lblTitleGrid.AutoSize = true;
            lblTitleGrid.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitleGrid.ForeColor = Color.Black;
            lblTitleGrid.Location = new Point(15, 12);
            lblTitleGrid.Name = "lblTitleGrid";
            lblTitleGrid.Size = new Size(237, 25);
            lblTitleGrid.TabIndex = 0;
            lblTitleGrid.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaNV, colHoTen, colSDT, colChucVu, colDiaChi });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 235);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 40;
            dgvNhanVien.RowTemplate.Height = 28;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1100, 365);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNV";
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDT";
            colSDT.HeaderText = "Số Điện Thoại";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            // 
            // colChucVu
            // 
            colChucVu.DataPropertyName = "ChucVu";
            colChucVu.HeaderText = "Chức Vụ";
            colChucVu.MinimumWidth = 6;
            colChucVu.Name = "colChucVu";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // FormNhanVien
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvNhanVien);
            Controls.Add(panelGridTitle);
            Controls.Add(panelInput);
            Name = "FormNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += FormNhanVien_Load;
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelGridTitle.ResumeLayout(false);
            panelGridTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblTitleInput;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panelGridTitle;
        private System.Windows.Forms.Label lblTitleGrid;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}