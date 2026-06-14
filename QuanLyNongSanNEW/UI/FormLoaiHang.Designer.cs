namespace QLNongSan.UI
{
    partial class FormLoaiHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            txtMaLoai = new TextBox();
            label2 = new Label();
            txtTenLoai = new TextBox();
            dgvLoaiHang = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtMaLoai);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtTenLoai);
            groupBox2.Location = new Point(20, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(860, 150);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN LOẠI HÀNG";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(754, 84);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(635, 84);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(754, 31);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(635, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 63);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Loại Hàng:";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(139, 60);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(166, 27);
            txtMaLoai.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(321, 63);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên Loại Hàng:";
            label2.Click += label2_Click;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(452, 60);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(166, 27);
            txtTenLoai.TabIndex = 3;
            // 
            // dgvLoaiHang
            // 
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiHang.ColumnHeadersHeight = 29;
            dgvLoaiHang.Location = new Point(-2, 204);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.RowHeadersWidth = 51;
            dgvLoaiHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiHang.Size = new Size(992, 335);
            dgvLoaiHang.TabIndex = 1;
            dgvLoaiHang.CellContentClick += dgvLoaiHang_CellContentClick;
            // 
            // FormLoaiHang
            // 
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 600);
            Controls.Add(groupBox2);
            Controls.Add(dgvLoaiHang);
            MinimumSize = new Size(1000, 640);
            Name = "FormLoaiHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Loại hàng";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBox2;
        private Label label1, label2;
        private TextBox txtMaLoai, txtTenLoai;
        private DataGridView dgvLoaiHang;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}