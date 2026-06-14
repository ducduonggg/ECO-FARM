using System;
using System.Drawing;
using System.Windows.Forms;
using QLNongSan.UI;

namespace QLNongSan
{
    public partial class AdminForm : Form
    {
        private readonly QLNongSan.Application application;
        // 1. Biến lưu trữ Form đang hiển thị hiện tại
        private Form? currentChildForm;

        public AdminForm(QLNongSan.Application application)
        {
            this.application = application;
            InitializeComponent();
        }

        // 2. Hàm dùng chung để mở Form con vào Panel và đổi màu nút
        private void OpenChildForm(Form childForm, object btnSender)
        {
            // 1. Đóng Form cũ nếu đang mở
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            // 2. Thiết lập thuộc tính
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // 3. Hiển thị vào Panel
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            // QUAN TRỌNG: Đẩy Form con ra sau để không đè lên Menu nếu Panel bị tràn
            childForm.SendToBack();
            childForm.Show();

            // 4. Đổi màu nút
            HighlightButton(btnSender);
        }

        // Hàm mở Form con không làm đổi màu nút (nếu cần dùng độc lập)
        private void OpenChildForm(Form childForm)
        {
            // 1. Nếu đã có một Form con khác đang mở trước đó, đóng nó lại để giải phóng bộ nhớ
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // 2. Gán Form mới truyền vào làm Form con hiện tại
            currentChildForm = childForm;

            // 3. Cấu hình để Form con biến thành một thành phần điều khiển (Control) thông thường
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // Ẩn thanh tiêu đề (phóng to, thu nhỏ, tắt) của Form con
            childForm.Dock = DockStyle.Fill;                  // Kéo giãn lấp đầy bảng Panel chứa nó

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            // 5. Đưa Form con lên lớp trên cùng và hiển thị nó lên màn hình
            childForm.BringToFront();
            childForm.Show();
        }

        // 3. Hàm đổi màu nút khi được bấm
        private void HighlightButton(object btnSender)
        {
            if (btnSender is Button btnActive && btnActive.Parent != null)
            {
                // Thay vì tìm trong groupBox1, ta tìm trực tiếp trong Panel chứa nút
                foreach (Control ctrl in btnActive.Parent.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }
                }

                // Tô màu cho nút vừa bấm
                btnActive.BackColor = Color.FromArgb(235, 245, 235);
                btnActive.ForeColor = Color.ForestGreen;
            }
        }

        // 4. Các sự kiện Click chuyển đổi Form con
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham(application), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormLoaiHang(application), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang(application), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(application), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien(application), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang(application), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBaoCao(application), sender);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnThongTinLo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongTinLo(application), sender);
        }
    }

}