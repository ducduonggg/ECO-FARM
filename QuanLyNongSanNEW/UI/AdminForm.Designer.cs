namespace QLNongSan
{
    partial class AdminForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            pnlContent = new Panel();
            panel1 = new Panel();
            btnKhachHang = new Button();
            btnThongTinLo = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(16, 84);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(270, 60);
            button1.TabIndex = 0;
            button1.Text = "📦       Sản phẩm";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(16, 152);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(270, 60);
            button2.TabIndex = 7;
            button2.Text = "🗂️       Loại hàng";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(16, 220);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(270, 60);
            button3.TabIndex = 8;
            button3.Text = "📥       Nhập hàng";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(16, 288);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(270, 60);
            button4.TabIndex = 9;
            button4.Text = "\U0001f6d2       Bán hàng";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(16, 356);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(270, 60);
            button5.TabIndex = 10;
            button5.Text = "👤       Nhân viên";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(16, 424);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(270, 60);
            button6.TabIndex = 11;
            button6.Text = "📊       Báo cáo";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(311, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1613, 1055);
            pnlContent.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThongTinLo);
            panel1.Controls.Add(btnKhachHang);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 1055);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Location = new Point(13, 492);
            btnKhachHang.Margin = new Padding(4);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(270, 60);
            btnKhachHang.TabIndex = 11;
            btnKhachHang.Text = "👤       Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += button7_Click;
            // 
            // btnThongTinLo
            // 
            btnThongTinLo.Location = new Point(16, 560);
            btnThongTinLo.Margin = new Padding(4);
            btnThongTinLo.Name = "btnThongTinLo";
            btnThongTinLo.Size = new Size(270, 60);
            btnThongTinLo.TabIndex = 12;
            btnThongTinLo.Text = "📝       Thông in lô";
            btnThongTinLo.TextAlign = ContentAlignment.MiddleLeft;
            btnThongTinLo.UseVisualStyleBackColor = true;
            btnThongTinLo.Click += btnThongTinLo_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pnlContent);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AdminForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel pnlContent;
        private Panel panel1;
        private Button btnKhachHang;
        private Button btnThongTinLo;
    }
}