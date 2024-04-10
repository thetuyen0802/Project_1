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
    public partial class frmEmployess : Form
    {
        private IUserServices _userServices;
        private IEmployessServices _employessServices;
        private int _id;
        public frmEmployess()
        {
            _employessServices= new EmployessServices();
            _userServices = new UserServices();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.Columns.Add("EmployessId", "Id");
            dataGridView1.Columns.Add("UserId","UserId");
            dataGridView1.Columns.Add("Name", "Tên ");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Status", "Trạng thái");

            List<Employess> employesses = _employessServices.GetAll();
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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
                int ex = 0;
            if (_employessServices.GetAll().Where(c => c.Email == txt_email.Text)==null)
            {
                ex = 0;
            }
            else
            {
                ex = 1;
            }
            if (ex==0)
            {
                User user = new User();
                user.RoleId = 1;
                user.UserName = txt_email.Text;
                user.Password = txt_email.Text;
                user.Status = 1; // 1 laf ddang hoatj ddong , 0 laf ngung hoatj ddong
                MessageBox.Show(_userServices.AddUser(user));

                Employess employess = new Employess();
                employess.UserId = user.UserId;
                employess.Name = txt_name.Text;
                employess.Email = txt_email.Text;
                employess.Status = 1; // 1 laf ddang lafm viec 0 laf nghi viec
                MessageBox.Show(_employessServices.Add(employess));
                LoadData();
            }
            if (ex==1)
            {
                MessageBox.Show("Email đã tồn tại");
            }
        }

        private void frmEmployess_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            LoadData();
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            txt_employessId.Text = _id.ToString();
            txt_email.Text=_employessServices.GetById(_id).Email;
            txt_userid.Text = _employessServices.GetById(_id).UserId.ToString();
            txt_name.Text=_employessServices.GetById(_id).Name;
            comboBox1.SelectedIndex=_employessServices.GetById(_id).Status;
        }
    }
}
