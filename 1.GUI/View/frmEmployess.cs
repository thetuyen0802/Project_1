﻿using _2.BUS.IServices;
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
    public partial class frmEmployess : Form
    {
        private IUserServices _userServices;
        private IEmployessServices _employessServices;
        private int _id;
        private List<Employess> employesses;
        public frmEmployess()
        {
            _employessServices= new EmployessServices();
            _userServices = new UserServices();
            List<Employess> employesses= new List<Employess>();
            InitializeComponent();
            UpdateData();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.Columns.Add("EmployessId", "Id");
            dataGridView1.Columns.Add("UserId","UserId");
            dataGridView1.Columns.Add("Name", "Tên ");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Status", "Trạng thái");

            dataGridView1.Columns["EmployessId"].Visible = false;
            dataGridView1.Columns["UserId"].Visible = false;

            foreach (var item in employesses)
            {
                dataGridView1.Rows.Add
                    (
                        item.EmployessId,
                        item.UserId,
                        item.Name,
                        item.Email,
                        item.Status==1?"Đang làm việc":"Nghỉ việc"
                    );
            }

        }
        public void UpdateData()
        {
            employesses = _employessServices.GetAll();
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             int ex = 0;
            foreach (var item in employesses)
            {
                
                if (item.Email==txt_email.Text)
                {
                    ex = 1;
                    break;
                }
                else
                {
                    ex = 0;
                }
            }
            if (ex==0)
            {
                User user = new User();
                user.RoleId = 1;
                user.UserName = txt_email.Text;
                user.Password = txt_email.Text;
                user.Status = 1; // 1 laf ddang hoatj ddong , 0 laf ngung hoatj ddong
                _userServices.AddUser(user);

                Employess employess = new Employess();
                employess.UserId = user.UserId;
                employess.Name = txt_name.Text;
                employess.Email = txt_email.Text;
                employess.Status = 1; // 1 laf ddang lafm viec 0 laf nghi viec
                MessageBox.Show(_employessServices.Add(employess));
                dataGridView1.Rows.Clear();
                ClearForm();
                UpdateData();
                
            }
            if (ex==1)
            {
                MessageBox.Show("Email đã tồn tại");
                dataGridView1.Rows.Clear();
               
                UpdateData();
            }
            
        }

       
        public void ClearForm()
        {
            txt_email.Text= string.Empty;
            
            txt_name.Text= string.Empty;
            txt_email.Text= string.Empty;
            comboBox1 .SelectedIndex = 1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (_id==null)
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }
            else
            {
                Employess employess = _employessServices.GetById(_id);
                employess.Email= txt_email.Text;
                employess.Name= txt_name.Text;
                employess.Status = comboBox1.SelectedIndex;
                _employessServices.Update(employess);
            }
            dataGridView1.Rows.Clear();
            ClearForm();
            UpdateData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                dataGridView1.ClearSelection();
            }
            else
            {
                _id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (_id == null)
                {
                    ClearForm();
                }
                else
                {
                    txt_email.Text = _employessServices.GetById(_id).Email;
                    txt_name.Text = _employessServices.GetById(_id).Name;
                    comboBox1.SelectedIndex = _employessServices.GetById(_id).Status;
                }
            }
            

        }
    }
}
