using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLNongSan.UI
{
    partial class FormSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvSanPham = new DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            cboLoaiHang = new ComboBox();
            txtSoLuongTon = new TextBox();
            txtGiaBan = new TextBox();
            txtDVT = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeight = 29;
            dgvSanPham.Location = new Point(20, 260);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(950, 320);
            dgvSanPham.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(cboLoaiHang);
            groupBox1.Controls.Add(txtSoLuongTon);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtDVT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(832, 95);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 35);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(714, 95);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 35);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(832, 43);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 35);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(714, 42);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 35);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(149, 46);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(186, 27);
            txtMaSP.TabIndex = 4;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(149, 96);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(186, 27);
            txtTenSP.TabIndex = 5;
            // 
            // cboLoaiHang
            // 
            cboLoaiHang.Location = new Point(149, 147);
            cboLoaiHang.Name = "cboLoaiHang";
            cboLoaiHang.Size = new Size(186, 28);
            cboLoaiHang.TabIndex = 6;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(504, 150);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(186, 27);
            txtSoLuongTon.TabIndex = 7;
            txtSoLuongTon.TextChanged += txtSoLuongTon_TextChanged;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(504, 95);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(186, 27);
            txtGiaBan.TabIndex = 8;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(504, 46);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(186, 27);
            txtDVT.TabIndex = 9;
            txtDVT.TextChanged += txtDVT_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(26, 148);
            label2.Name = "label2";
            label2.Size = new Size(106, 26);
            label2.TabIndex = 10;
            label2.Text = "Loại Hàng:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(380, 49);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 11;
            label5.Text = "DVT:";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 99);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 12;
            label3.Text = "Tên Sản Phẩm:";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 50);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 13;
            label6.Text = "Mã Sản Phẩm:";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(379, 99);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 14;
            label4.Text = "Giá Bán:";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(379, 150);
            label7.Name = "label7";
            label7.Size = new Size(125, 23);
            label7.TabIndex = 15;
            label7.Text = "Số Lượng Tồn:";
            // 
            // FormSanPham
            // 
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 600);
            Controls.Add(groupBox1);
            Controls.Add(dgvSanPham);
            MinimumSize = new Size(1000, 640);
            Name = "FormSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Nông sản - Quản lý Sản phẩm";
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void SetupButtonStyle(System.Windows.Forms.Button btn, string text, System.Drawing.Color backColor, System.Drawing.Color foreColor, int x, int y)
        {
            btn.Text = text; btn.BackColor = backColor; btn.ForeColor = foreColor;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Size = new System.Drawing.Size(100, 40);
            btn.Location = new System.Drawing.Point(x, y);
            btn.FlatAppearance.BorderSize = 0;
        }
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private Button button1;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}