using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using QLNongSan.schemas;

namespace QLNongSan.UI
{
    public partial class FormBaoCao : Form
    {
        private readonly Application _application;

        // BUG FIX: Lưu application vào field để dùng được ở các hàm khác
        public FormBaoCao(Application application)
        {
            _application = application;
            InitializeComponent();
            // BUG FIX: Đăng ký Load event ở đây vì Designer không có Load handler
            this.Load += FormBaoCao_Load;
        }

        // =====================================================================
        // KHỞI TẠO - LOAD DỮ LIỆU
        // =====================================================================

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            CauHinhGrid();
            TaiDuLieuLen();
        }

        // Cấu hình cột DataGridView khớp với DataTable từ DAL
        private void CauHinhGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            // Xóa cột cũ trong Designer rồi tạo lại cho khớp tên DAL
            dataGridView1.Columns.Clear();

            var colMa = new DataGridViewTextBoxColumn();
            colMa.DataPropertyName = "MaBaoCao";
            colMa.HeaderText = "Mã BC";
            colMa.Name = "colMaBaoCao";
            colMa.Width = 60;

            var colNgay = new DataGridViewTextBoxColumn();
            colNgay.DataPropertyName = "NgayBaoCao";
            colNgay.HeaderText = "Ngày Báo Cáo";
            colNgay.Name = "colNgayBaoCao";

            var colLoai = new DataGridViewTextBoxColumn();
            colLoai.DataPropertyName = "LoaiBaoCao";
            colLoai.HeaderText = "Loại Báo Cáo";
            colLoai.Name = "colLoaiBaoCao";

            // Cột nội dung ẩn — dùng để hiển thị vào txtNoiDung khi click
            var colNoi = new DataGridViewTextBoxColumn();
            colNoi.DataPropertyName = "NoiDung";
            colNoi.HeaderText = "Nội Dung";
            colNoi.Name = "colNoiDung";
            colNoi.Visible = false;

            dataGridView1.Columns.AddRange(colMa, colNgay, colLoai, colNoi);
        }

        // Tải lại toàn bộ danh sách báo cáo từ DAL lên Grid
        private void TaiDuLieuLen()
        {
            try
            {
                DataTable dt = _application.reportRepository.GetAllBaoCao();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // NÚT LƯU BÁO CÁO
        // =====================================================================

        // BUG FIX: Thay vì add thẳng vào Grid (mất khi đóng form), giờ lưu qua DAL
        private void button1_Click(object sender, EventArgs e)
        {
            if (LoaiBC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(NoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung báo cáo!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NoiDung.Focus();
                return;
            }

            BaoCaoDTO bc = new BaoCaoDTO
            {
                NgayBaoCao = NgayBC.Value.ToShortDateString(),
                LoaiBaoCao = LoaiBC.Text,
                NoiDung    = NoiDung.Text.Trim()
            };

            bool ok = _application.reportRepository.ThemBaoCao(bc);
            if (ok)
            {
                MessageBox.Show("Lưu báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NoiDung.Clear();
                TaiDuLieuLen();  // Cập nhật lại Grid
            }
            else
            {
                MessageBox.Show("Lưu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // NÚT XÓA BÁO CÁO
        // =====================================================================

        // BUG FIX: Xóa đúng theo MaBaoCao qua DAL thay vì xóa thẳng dòng trên Grid
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trong bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa báo cáo này?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            // Lấy MaBaoCao từ dòng đang chọn
            int maBaoCao = Convert.ToInt32(dataGridView1.CurrentRow.Cells["colMaBaoCao"].Value);

            bool ok = _application.reportRepository.XoaBaoCao(maBaoCao);
            if (ok)
            {
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoiDung.Clear();
                TaiDuLieuLen();  // Cập nhật lại Grid
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Không tìm thấy báo cáo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // NÚT XUẤT PDF
        // =====================================================================

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng chọn một báo cáo từ danh sách để xem nội dung trước khi xuất PDF!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter   = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = "BaoCaoNongSan_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(
                    iTextSharp.text.PageSize.A4, 40f, 40f, 50f, 50f);
                PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.Create));
                pdfDoc.Open();

                // Font hỗ trợ tiếng Việt
                string fontPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont bf           = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font titleFont   = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font subFont     = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font contentFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

                // Tiêu đề
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("BÁO CÁO NÔNG SẢN\n", titleFont);
                title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                pdfDoc.Add(title);

                // Ngày xuất
                iTextSharp.text.Paragraph sub = new iTextSharp.text.Paragraph(
                    "Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "\n\n", subFont);
                sub.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                pdfDoc.Add(sub);

                // Nội dung
                iTextSharp.text.Paragraph content = new iTextSharp.text.Paragraph(txtNoiDung.Text, contentFont);
                content.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                pdfDoc.Add(content);

                pdfDoc.Close();
                MessageBox.Show("Xuất file PDF thành công!\n" + sfd.FileName,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        // CLICK DÒNG TRÊN GRID → HIỂN THỊ NỘI DUNG SANG txtNoiDung
        // =====================================================================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Điền lại thông tin báo cáo lên form để xem / chuẩn bị xóa
            if (row.Cells["colNoiDung"].Value != null)
                txtNoiDung.Text = row.Cells["colNoiDung"].Value.ToString();

            if (row.Cells["colNgayBaoCao"].Value != null)
                NgayBC.Value = DateTime.TryParse(
                    row.Cells["colNgayBaoCao"].Value.ToString(), out DateTime d) ? d : DateTime.Now;

            if (row.Cells["colLoaiBaoCao"].Value != null)
                LoaiBC.Text = row.Cells["colLoaiBaoCao"].Value.ToString();
        }

        // =====================================================================
        // CÁC SỰ KIỆN TRỐNG GIỮ LẠI ĐỂ KHÔNG LỖI DESIGNER
        // =====================================================================
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void LoaiBC_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void groupBox1_Enter_2(object sender, EventArgs e) { }
    }
}