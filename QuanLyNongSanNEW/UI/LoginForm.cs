using QLNongSan.UI;

namespace QLNongSan.UI
{
    using Authentication.Errors;
    using QLNongSan.Authentication.Schemas;


    public partial class LoginForm : Form
    {
        private readonly Application application;

        public LoginForm(
            Application application
        )
        {
            this.application = application;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoggedInUser loggedInUser;
            try
            {
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();
                loggedInUser = application.authenticationService.Authenticate(username, password);
            }
            catch (AuthenticationError ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                return;
            }
            MessageBox.Show("Đăng nhập thành công!", "Eco Farm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            AdminForm fMenu = new AdminForm(application);
            fMenu.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            this.Hide();


            FormUserKhachHang fKhachHang = new FormUserKhachHang();


            fKhachHang.ShowDialog();


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void BtnKhachHang_Click(object sender, EventArgs e)
        {

            this.Hide();


            FormUserKhachHang fKhachHang = new FormUserKhachHang();


            fKhachHang.ShowDialog();


            this.Close();
        }

    }
}
