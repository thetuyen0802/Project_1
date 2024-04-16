using _2.BUS.IServices;
using _2.BUS.Services;

using _3.DAL.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = _3.DAL.Model.User;

namespace _1.GUI.View
{
    public partial class Account_Manager : Form
    {
        private IUserServices _services;
        private int id;
        private List<User> _users;  


        public Account_Manager()
        {
            InitializeComponent();
            _services = new UserServices();
            Load();
            LoadData();

        }
        void LoadData()
        {

            _users = _services.GetUsers().ToList();
            foreach (var item in _users)
            {
                dataView.Rows.Add(
                    item.UserId,
                    item.UserName,
                    item.Password,
                    item.RoleId==1 ? "Nhân viên" : "Quản lý",
                    item.Status == 1 ? ("Đang làm việc") : ("Đã nghỉ việc")
                    ); 
            }


        }
        public void Load()
        {
            dataView.Columns.Add("UserId", "UserId");
            dataView.Columns.Add("UserName", "Tên tài khoản");
            dataView.Columns.Add("Password", "Mật khẩu ");
            dataView.Columns.Add("RoleId", "Chức vụ");
            dataView.Columns.Add("Status", "Trạng thái");


            dataView.Columns["UserId"].Visible= false;
            
        }
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    User userView = new User();
          
        //    userView.UserName = txt_username.Text;
        //    userView.Password = txt_password.Text;
        //    if (cbx_chucvu.SelectedIndex == 0)
        //    {
        //        userView.RoleId = 1;
        //    }
        //    else
        //    {
        //        userView.RoleId = 2;
        //    }
        //    if (rbt_status_0.Checked)
        //    {
        //        userView.Status = 0;
        //    }
        //    else if (rbt_status_1.Checked)
        //    {
        //        userView.Status = 1;
        //    }
        //    MessageBox.Show(_services.AddUser(userView));
        //    LoadData();
        //}

        private void btn_update_Click(object sender, EventArgs e)
        {
            var user = _services.GetById(id);
       
            user.UserName = txt_username.Text;
            user.Password = txt_password.Text;
            if (cbx_chucvu.SelectedIndex == 0)
            {
                user.RoleId = 1;
            }
            else
            {
                user.RoleId = 2;
            }
            if (rbt_status_0.Checked)
            {
                user.Status = 0;//0 là da nghi
            }
            else if (rbt_status_1.Checked)
            {
                user.Status = 1;//1 là đang làm việc
            }
            MessageBox.Show(_services.Update(user));
            dataView.Rows.Clear();
            LoadData();
        }

      

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataView.Rows[e.RowIndex].Cells[0].Value;
            User user = _services.GetById(id);
         
            txt_username.Text = user.UserName;
            txt_password.Text = user.Password;
            if (user.RoleId == 1)
            {
                cbx_chucvu.SelectedIndex = 0;
            }
            else
            {
                cbx_chucvu.SelectedIndex = 1;
            }
            if (user.Status == 0)
            {
                rbt_status_0.Checked = true;
            }
            else
            {
                rbt_status_1.Checked = true;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
          
            txt_password.Text = string.Empty;
            txt_username.Text = string.Empty;
            cbx_chucvu.Text = string.Empty;
            rbt_status_0.Checked = false;
            rbt_status_1.Checked = false;
        }

        
    }
}
