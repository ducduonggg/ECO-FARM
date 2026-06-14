using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QRCoder;

namespace QLNongSan.UI
{
    public partial class FormUserKhachHang : Form
    {
        public FormUserKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string thongTinKhachHang = "Mã SP:#AB72 - Nhà Sản xuất: Bùi Đức Dương - Tình trạng:Ổn định - Ngày sản xuất:6/1/2022";


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(thongTinKhachHang, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);


                Bitmap qrCodeImage = qrCode.GetGraphic(20);


                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Image Files(*.png)|*.png";
                    sfd.FileName = "MaQR_LoSP_001";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        qrCodeImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Xuất mã QR thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tạo QR: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}