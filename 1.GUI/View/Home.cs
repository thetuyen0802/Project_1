using _1.GUI.View;
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

namespace _1.GUI
{
    public partial class Home : Form
    {
        private int _rolelogin;
        private User _user;
        public Home(User _uslog)
        {
            InitializeComponent();
            _rolelogin = _uslog.RoleId;
            _user = _uslog;

        }
        private void Home_Load(object sender, EventArgs e)
        {
            //Chú ý : Role login =1 là nhân viên login =2 là admin
            if (_rolelogin == 1)
            {
                this.Controls.Remove(btn_product);
                this.Controls.Remove(btn_nhanvien);
                btn_sales.Location = new Point(0, 0);
                btn_bill.Location = new Point(0, 50);
                btn_customer.Location = new Point(0, 100);
                btn_account.Location=new Point(0, 150);
                frmSale sales = new frmSale(_user);
                FillForm(sales);
            }
            if (_rolelogin == 2)
            {
                frmproduct f_Product = new frmproduct();
                FillForm(f_Product);
            }


        }
        void FillForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(form);
            form.Show();
        }
        //void ResizeControll()
        //{
        //    float ScaleX = (float)this.Width / this.MaximumSize.Width;
        //    float ScaleY = (float)this.Height / this.MaximumSize.Height;

        //    foreach (Control control in this.Controls)
        //    {
        //        if (control.Tag.ToString() == "NoResize") continue;
        //        int newX = (int)(control.Location.X / ScaleX);
        //        int newY = (int)(control.Location.Y / ScaleY);
        //        int newWidth = (int)(control.Width / ScaleX);
        //        int newHeight = (int)(control.Height / ScaleY);

        //        control.Location = new Point(newX, newY);
        //        control.Size = new System.Drawing.Size(newWidth, newHeight);
        //    }
        //}

        private void btn_product_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            frmproduct f_Product = new frmproduct();
            FillForm(f_Product);

        }

        //private void Home_Resize(object sender, EventArgs e)
        //{
        //    ResizeControll();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_sales_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            frmSale sales = new frmSale(_user);
            FillForm(sales);
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            if (_rolelogin == 1)
            {
                Account_Employess account_Employes = new Account_Employess(_user);
                FillForm(account_Employes);
            }
            else if (_rolelogin == 2)
            {
                Account_Manager account_Manager = new Account_Manager();
                FillForm(account_Manager);
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả từ hộp thoại
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {

            }

        }
        private void btn_customer_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            frmCustomer customer = new frmCustomer();
            FillForm(customer);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            frmEmployess frm= new frmEmployess();
            FillForm(frm);
        }
    }
}
