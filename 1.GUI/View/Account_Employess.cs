using _2.BUS.IServices;
using _2.BUS.Services;
using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.GUI.View
{
    public partial class Account_Employess : Form
    {
        private IUserServices _userServices;
        private User _Userif;
        public Account_Employess(User user)
        {
            InitializeComponent();
            _Userif = user;
            _userServices = new UserServices();
        }

        private void Account_Employess_Load(object sender, EventArgs e)
        {

            txt_password.Text = _Userif.Password;
            txt_username.Text = _Userif.UserName;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            User newUser = _userServices.GetById(_Userif.UserId);
            newUser.UserName = txt_username.Text;
            newUser.Password = txt_password.Text;
            MessageBox.Show(_userServices.Update(newUser));

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
