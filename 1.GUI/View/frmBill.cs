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
    public partial class frmBill : Form
    {
        private IBillServices billServices;
        private ICustomerServices customerServices;
        private IEmployessServices employessServices;
        private List<Bill> bills;
        public frmBill()
        {
            InitializeComponent();
            billServices = new BillServices();
            customerServices = new CustomerServices();
            employessServices = new EmployessServices();
            List<Bill> bills = new List<Bill>();
            cbx_status.SelectedIndex = 1;
            Loadbill();
        }
        public void Loadbill()
        {
            view_bill.Columns.Add("BillId", "Id");
            view_bill.Columns.Add("EmployessId", "Nhân viên");
            view_bill.Columns.Add("CustomerId", "Khách hàng");
            view_bill.Columns.Add("CreateDate", "Ngày lập");
            view_bill.Columns.Add("PayDate", "Ngày thanh toán");

            view_bill.Columns["BillId"].Visible = false;
        }
        public void LoadBillDetail()
        {
            view_billdetail.Columns.Add("Name", "Tên sản phẩm");
            view_billdetail.Columns.Add("Category", "Loại sản phẩm");
            view_billdetail.Columns.Add("Color", "Màu");

            view_billdetail.Columns.Add("Size", "Cỡ");
            view_billdetail.Columns.Add("Name", "Tên sản phẩm");

            view_billdetail.Columns.Add("Name", "Tên sản phẩm");
            view_billdetail.Columns.Add("Name", "Tên sản phẩm");
            view_billdetail.Columns.Add("Name", "Tên sản phẩm");

        }    
        public void LoadBillData()
        {
            foreach (var item in bills)
            {
                view_bill.Rows.Add(
                    item.BillId,
                    employessServices.GetById((int)item.EmployessId),
                    customerServices.GetByID((int)item.CustomerId),
                    item.CreateDate,
                    item.PaymenDate
                    );
            }
        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_status.SelectedIndex == 0)
            {
                bills = billServices.GetAll().Where(c => c.Status == 0).ToList();
            }
            else
            {
                bills = billServices.GetAll().Where(c => c.Status == 1).ToList();
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại khách hàng");
                }
                else
                {
                    int cus = 0;
                    cus = customerServices.GetAll().FirstOrDefault(c => c.PhoneNumber == txt_phone.Text).CustomerId;
                    if (cus == null)
                    {
                        MessageBox.Show("Số điện thoại nhập sai hoặc khách hàng chưa đang ký");
                    }
                    else
                    {

                        txt_customer_name.Text = customerServices.GetByID(cus).Name;
                        bills = billServices.GetAll().Where(c => c.CustomerId == cus).ToList();
                        LoadBillData();
                    }
                }
            }
        }

        private void view_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
