using _2.BUS.Services;
using _3.DAL.Model;

namespace _1.GUI
{
    public partial class Login : Form
    {
        private UserServices _userServices;
        private User _uslog;
        public Login()
        {
            InitializeComponent();
            _uslog = new User();
            _userServices=new UserServices();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text=="")
            {
                MessageBox.Show("Tên tài khoản trống");
            }
            else if (txt_password.Text=="")
            {
                MessageBox.Show("Mật khẩu trống");
            }
            else
            {
                int us = 1;

                foreach (var item in _userServices.GetUsers())
                {
                    if (item.UserName == txt_username.Text)
                    {
                        us = 1;
                        _uslog = item;
                        break;
                    }
                    else us = 0;

                }

                if (us == 0)
                {
                    MessageBox.Show("Tên tài khoản không đúng hoặc không tồn tại");
                }
                else if (us == 1)
                {
                 
                    if (_uslog.Password == txt_password.Text)
                    {

                        Home home = new Home(_uslog);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu");
                    }
                }
            }

        }

        private void rbt_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_showpass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void rbt_showpass_Click(object sender, EventArgs e)
        {
            rbt_showpass.Checked=!rbt_showpass.Checked;

        }
    }
}
