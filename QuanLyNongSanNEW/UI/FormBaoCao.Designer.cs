namespace QLNongSan.UI
{
    partial class FormBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnXuatPDF = new Button();
            btnXoaBC = new Button();
            btnLuuBC = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            NoiDung = new TextBox();
            LoaiBC = new ComboBox();
            NgayBC = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Ngay = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            colNoiDung = new DataGridViewTextBoxColumn();
            txtNoiDung = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuatPDF);
            groupBox1.Controls.Add(btnXoaBC);
            groupBox1.Controls.Add(btnLuuBC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(NoiDung);
            groupBox1.Controls.Add(LoaiBC);
            groupBox1.Controls.Add(NgayBC);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(100, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(498, 833);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BÁO CÁO";
            groupBox1.Enter += groupBox1_Enter_2;
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.BackColor = SystemColors.ActiveCaption;
            btnXuatPDF.Location = new Point(59, 748);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(94, 29);
            btnXuatPDF.TabIndex = 8;
            btnXuatPDF.Text = "Xuất PDF";
            btnXuatPDF.UseVisualStyleBackColor = false;
            btnXuatPDF.Click += button3_Click;
            // 
            // btnXoaBC
            // 
            btnXoaBC.BackColor = Color.FromArgb(255, 192, 192);
            btnXoaBC.Location = new Point(59, 697);
            btnXoaBC.Name = "btnXoaBC";
            btnXoaBC.Size = new Size(94, 29);
            btnXoaBC.TabIndex = 7;
            btnXoaBC.Text = "Xóa";
            btnXoaBC.UseVisualStyleBackColor = false;
            btnXoaBC.Click += button2_Click;
            // 
            // btnLuuBC
            // 
            btnLuuBC.BackColor = Color.FromArgb(192, 255, 192);
            btnLuuBC.Location = new Point(59, 642);
            btnLuuBC.Name = "btnLuuBC";
            btnLuuBC.Size = new Size(94, 29);
            btnLuuBC.TabIndex = 6;
            btnLuuBC.Text = "Lưu";
            btnLuuBC.UseVisualStyleBackColor = false;
            btnLuuBC.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 348);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "Nội dung";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 225);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 4;
            label2.Text = "Loại báo cáo";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 116);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "Ngày báo cáo";
            label1.Click += label1_Click;
            // 
            // NoiDung
            // 
            NoiDung.Location = new Point(193, 345);
            NoiDung.Multiline = true;
            NoiDung.Name = "NoiDung";
            NoiDung.Size = new Size(277, 432);
            NoiDung.TabIndex = 2;
            // 
            // LoaiBC
            // 
            LoaiBC.FormattingEnabled = true;
            LoaiBC.Items.AddRange(new object[] { "Doanh thu", "Tình trạng kho", "Phản hồi khách hàng" });
            LoaiBC.Location = new Point(193, 225);
            LoaiBC.Name = "LoaiBC";
            LoaiBC.Size = new Size(250, 28);
            LoaiBC.TabIndex = 1;
            LoaiBC.SelectedIndexChanged += LoaiBC_SelectedIndexChanged;
            // 
            // NgayBC
            // 
            NgayBC.Location = new Point(193, 111);
            NgayBC.Name = "NgayBC";
            NgayBC.Size = new Size(250, 27);
            NgayBC.TabIndex = 0;
            NgayBC.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ngay, Loai, colNoiDung });
            dataGridView1.Location = new Point(604, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(545, 833);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ngay
            // 
            Ngay.HeaderText = "Ngày Báo Cáo";
            Ngay.MinimumWidth = 6;
            Ngay.Name = "Ngay";
            Ngay.ReadOnly = true;
            // 
            // Loai
            // 
            Loai.HeaderText = "Loại báo cáo";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.ReadOnly = true;
            // 
            // colNoiDung
            // 
            colNoiDung.HeaderText = "Column1";
            colNoiDung.MinimumWidth = 6;
            colNoiDung.Name = "colNoiDung";
            colNoiDung.Visible = false;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Dock = DockStyle.Right;
            txtNoiDung.Location = new Point(1147, 100);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(655, 833);
            txtNoiDung.TabIndex = 2;
            txtNoiDung.Text = "";
            // 
            // FormBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtNoiDung);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "FormBaoCao";
            Padding = new Padding(100);
            Text = "FormBaoCao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker NgayBC;
        private ComboBox LoaiBC;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox NoiDung;
        private DataGridView dataGridView1;
        private Button btnXoaBC;
        private Button btnLuuBC;
        private Button btnXuatPDF;
        private RichTextBox txtNoiDung;
        private DataGridViewTextBoxColumn Ngay;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn colNoiDung;
    }
}