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
        private IBill_ProductDetailsServices billdetailServices;
        private IProductDetailServices productDetailServices;
        private IProductServices productServices;
        private ICustomerServices customerServices;
        private IEmployessServices employessServices;
        private ICategogyServices categogyServices;
        private IMaterialServices materialServices;
        private IBrandServices brandServices;
        private IColorServices colorServices;
        private ISizeService sizeServices;

        private List<Bill> bills;
        private List<Bill_ProductDetail> billsDetail;
        private List<ProductDetail> productDetail;
        private List<Product> products;
        private int _billId;
        public frmBill()
        {
            InitializeComponent();
            billServices = new BillServices();
            billdetailServices = new Bill_ProductDetailsServices();
            productDetailServices = new ProductDetailServices();
            productServices = new ProductServices();
            customerServices = new CustomerServices();
            customerServices = new CustomerServices();
            employessServices = new EmployessServices();
            categogyServices = new CategogyServices();
            materialServices = new MaterialServices();
            brandServices = new BrandServices();
            colorServices = new ColorServices();
            sizeServices = new SizeService();

            bills = new List<Bill>();
            products = new List<Product>();
            productDetail = new List<ProductDetail>();
            billsDetail = new List<Bill_ProductDetail>();
            //cbx_status.SelectedIndex = 1;
            Loadbill();
            LoadBillDetail();
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
            view_billdetail.Columns.Add("Brand", "Thương hiệu");
            view_billdetail.Columns.Add("Category", "Loại sản phẩm");
            view_billdetail.Columns.Add("Material", "Chất liệu");
            view_billdetail.Columns.Add("Color", "Màu");
            view_billdetail.Columns.Add("Size", "Cỡ");
            view_billdetail.Columns.Add("Price", "Đơn giá");
            view_billdetail.Columns.Add("Quantity", "Số lượng");
            view_billdetail.Columns.Add("Total", "Thành tiền");


        }
        public void LoadBillData()
        {
            foreach (var item in bills)
            {
                view_bill.Rows.Add(
                    item.BillId,
                    employessServices.GetById((int)item.EmployessId).Name,
                    customerServices.GetByID((int)item.CustomerId).Name,
                    item.CreateDate,
                    item.PaymenDate
                    );
            }
        }
        public void LoadBillDetailData()
        {
            products = productServices.GetAll();
            productDetail = productDetailServices.GetAll();

            var data = from prd in products
                       join prddt in productDetail on prd.ProductId equals prddt.ProductId
                       join billdt in billsDetail on prddt.ProDetailId equals billdt.ProDetailId
                       select new
                       {
                           Name = prd.ProductName,
                           Brand = brandServices.GetById(prd.ProductId).BrandName,
                           Categoey = categogyServices.GetByID(prddt.CategoryId).CategoryName,
                           Material = materialServices.Get(prddt.MaterialId).MaterialName,
                           Color = colorServices.GetByID(prddt.ColorId).ColorName,
                           Size = sizeServices.GetById(prddt.SizeId).SizeName,
                           Price = prddt.Price,
                           Quantity = billdt.Quantity,
                       };
            foreach (var item in data)
            {
                view_billdetail.Rows.Add(
                    item.Name,
                    item.Brand,
                    item.Categoey,
                    item.Material,
                    item.Color,
                    item.Size,
                    item.Price,
                    item.Quantity,
                    (float)(item.Price * item.Quantity)
                    );
            }
            float tt = 0;
            for (int i = 0; i < view_billdetail.Rows.Count; i++)
            {
                tt += float.Parse(view_billdetail.Rows[i].Cells["Total"].Value.ToString());
            }

            txt_total.Text = tt.ToString();
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
            _billId = (int)view_bill.Rows[e.RowIndex].Cells["BillId"].Value;
            billsDetail = billdetailServices.GetAll().Where(c => c.BillId == _billId).ToList();
            view_billdetail.Rows.Clear();
            LoadBillDetailData();
        }

        private void cbx_status_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng");
                cbx_status.SelectedIndex = -1;
            }
            else
            {
                int cus = 0;
                cus = customerServices.GetAll().FirstOrDefault(c => c.PhoneNumber == txt_phone.Text).CustomerId;
                if (cus == null)
                {
                    MessageBox.Show("Số điện thoại nhập sai hoặc khách hàng chưa đang ký");
                    cbx_status.SelectedIndex = -1;

                }
                else
                {
                    int status = cbx_status.SelectedIndex;
                    bills = billServices.GetAll().Where(c => c.Status == status).ToList();
                    view_bill.Rows.Clear();
                    LoadBillData();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
