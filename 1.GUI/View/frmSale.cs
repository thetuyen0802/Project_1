using _2.BUS.IServices;
using _2.BUS.Services;
using _3.DAL.Context;
using _3.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace _1.GUI.View
{
    public partial class frmSale : Form
    {
        private IUserServices _userServices;
        private IEmployessServices _employessServices;
        private ICustomerServices _customerServices;
        private IBrandServices _brandServices;
        private IColorServices _colorServices;
        private IMaterialServices _materialServices;
        private ISizeService _sizeServices;
        private ICategogyServices _categogyServices;
        private IProductDetailServices _productDetailServices;
        private IProductServices _productServices;
        private IBillServices _billServices;
        private IBill_ProductDetailsServices _bill_ProductDetailsServices;


        private int idsp;
        private int idspdt;
        private int billid;
        private Bill bill;
        private List<ProductDetail> detail;
        private List<Product> product;
        private List<Bill_ProductDetail> bill_ProductDetail;
        private User Userlog;
       

        private int _indexRowClick;

        public frmSale(User user)
        {
            InitializeComponent();
            _userServices = new UserServices();
            _employessServices = new EmployessServices();
            _productServices = new ProductServices();
            _productDetailServices = new ProductDetailServices();
            _brandServices = new BrandServices();
            _colorServices = new ColorServices();
            _customerServices = new CustomerServices();
            _materialServices = new MaterialServices();
            _sizeServices = new SizeService();
            _categogyServices = new CategogyServices();
            _billServices = new BillServices();
            _bill_ProductDetailsServices = new Bill_ProductDetailsServices();
            Userlog = user;
            cbx_category.SelectedIndex = -1;
            cbx_color.SelectedIndex = -1;
            cbx_size.SelectedIndex = -1;
            cbx_material.SelectedIndex = -1;
            billid = -1;
            product = new List<Product>();
            detail = new List<ProductDetail>();
            bill_ProductDetail = new List<Bill_ProductDetail>();
            LoadProduct();
            Loadbill();
        }
        public void Loadbill()
        {

            dview_bill.Columns.Add("Name", "Tên sản phẩm");
            dview_bill.Columns.Add("Brand", "Thương hiệu");
            dview_bill.Columns.Add("CategoryId", "Loại sản phẩm");
            dview_bill.Columns.Add("MaterialId", "Chất liệu");
            dview_bill.Columns.Add("SizeId", "Cỡ");
            dview_bill.Columns.Add("ColorId", "Màu");
            dview_bill.Columns.Add("Quantity", "Số lượng");
            dview_bill.Columns.Add("Price", "Đơn giá");
            dview_bill.Columns.Add("Total", "Thành tiền");
            dview_bill.Columns.Add("Idsp", "IDSp");
            dview_bill.Columns.Add("Idspdt", "IDSPDT");
            dview_bill.Columns.Add("Billid", "BillId");

            dview_bill.Columns["Idsp"].Visible = false;
            dview_bill.Columns["Idspdt"].Visible = false;
            dview_bill.Columns["Billid"].Visible = false;

           
        }
        public void Loadbilldata()
        {
            var data = from prodetail in detail
                       join pro in product on prodetail.ProductId equals pro.ProductId
                       join bill_prodetail in bill_ProductDetail on prodetail.ProDetailId equals bill_prodetail.ProDetailId
                       select new
                       {
                           BillId = bill_prodetail.BillId,
                           ProductId = prodetail.ProductId,
                           ProDetailId = prodetail.ProDetailId,
                           ProName = pro.ProductName,
                           BrandId = pro.BrandId,
                           CategoryId = prodetail.CategoryId,
                           MaterialId = prodetail.MaterialId,
                           SizeId = prodetail.SizeId,
                           ColorId = prodetail.ColorId,
                           Quantity = bill_prodetail.Quantity,
                           price = bill_prodetail.Price,
                       };

            foreach (var item in data.Distinct())
            {
                dview_bill.Rows.Add(
                    item.ProName,
                    _brandServices.GetById(item.BrandId).BrandName,
                    _categogyServices.GetByID(item.CategoryId).CategoryName,
                    _materialServices.Get(item.MaterialId).MaterialName,
                    _sizeServices.GetById(item.SizeId).SizeName,
                    _colorServices.GetByID(item.ColorId).ColorName,
                    item.Quantity,
                    item.price,
                    (float)item.Quantity * item.price
                    );
            }
            float tt = 0;
            for (int i = 0; i < dview_bill.RowCount; i++)
            {
                if (dview_bill.Rows[i].Cells["Total"].Value != null)
                {
                    tt += float.Parse(dview_bill.Rows[i].Cells["Total"].Value.ToString());
                }
            }
            txt_tongtien.Text = tt.ToString()+" đ";
        }
        public void LoadProduct()
        {
            product = _productServices.GetAll().Where(c=>c.Status== 1).ToList();
            dview_product.DataSource = product;

        }
        public void LoadProductDetail()
        {
            detail = _productDetailServices.GetAll().Where(c => c.ProductId == idsp).ToList();
            dview_productdetail.DataSource = detail;

        }
        private void frmBanhang_Load(object sender, EventArgs e)
        {
            List<_3.DAL.Model.Color> colors = _colorServices.GetColors();
            List<Material> materials = _materialServices.GetAll();
            List<_3.DAL.Model.Size> sizes = _sizeServices.GetSizes();
            List<Category> categories = _categogyServices.GetCategories();

            cbx_category.DataSource = categories;

            cbx_category.DisplayMember = "CategoryName";
            cbx_category.ValueMember = "CategoryId";

            cbx_color.DataSource = colors;

            cbx_color.DisplayMember = "ColorName";
            cbx_color.ValueMember = "ColorId";

            cbx_size.DataSource = sizes;

            cbx_size.DisplayMember = "SizeName";
            cbx_size.ValueMember = "SizeId";

            cbx_material.DataSource = materials;

            cbx_material.DisplayMember = "MaterialName";
            cbx_material.ValueMember = "MaterialId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_phone.Text=="")
            {
                MessageBox.Show("Nhập số điện thoại khách hàng");
            }else
            if (detail == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm");
            }
            else
            if (txt_soluong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng");
            }
            else if(int.Parse(txt_soluong.Text)>(int)_productDetailServices.FindById(idspdt).QuantityExists)
            {
                MessageBox.Show("Số lượng tồn không đủ");
            }
            else
            {

                if (billid == -1) ///BILL CHƯA TỒN TẠI
                {

                    bill = new Bill();
                    
                    bill.EmployessId = _employessServices.GetAll().FirstOrDefault(c => c.UserId == Userlog.UserId).EmployessId;
                    bill.CustomerId = _customerServices.GetAll().FirstOrDefault(c => c.PhoneNumber == txt_phone.Text).CustomerId;
                    bill.CreateDate = DateTime.Now;
                    bill.Status = 0;//set chưa thanh toán 
                    bill.PaymenDate = null;
                    _billServices.Add(bill);
                    billid = bill.BillId;///lấy ra billID 

                    Product prd = _productServices.FindById(idsp);
                    product.Add(prd);//Thêm sản phẩm được chọn vào list sản phẩm (producct)
                    ProductDetail prddt = _productDetailServices.FindById(idspdt);
                    detail.Add(prddt);//Thêm chi tiết sản phẩm được chọn vào list sản phẩm (detail)
                    //Cappj nhật số lượng
                    int qantityex=_productDetailServices.FindById(idspdt).QuantityExists-int.Parse(txt_soluong.Text);
                    if (qantityex<=0)
                    {
                        ProductDetail productDetail = _productDetailServices.FindById(idspdt);
                        productDetail.status = 0;
                        _productDetailServices.Update(productDetail);
                    }
                    else
                    {
                        ProductDetail productDetail = _productDetailServices.FindById(idspdt);
                        productDetail.QuantityExists = qantityex;
                        _productDetailServices.Update(productDetail);
                    }
                   


                    float price = _productDetailServices.FindById(idspdt).Price;
                    Bill_ProductDetail bill_ProductDetail1 = new Bill_ProductDetail();
                    bill_ProductDetail1.Price = price;
                    bill_ProductDetail1.BillId = billid;
                    bill_ProductDetail1.ProDetailId = idspdt;
                    bill_ProductDetail1.Quantity = int.Parse(txt_soluong.Text);

                    
                    bill_ProductDetail.Add(bill_ProductDetail1);
                 
                }
                else
                {
                    Bill bill = _billServices.FindById(billid);
                    bill.EmployessId = _employessServices.GetAll().FirstOrDefault(c => c.UserId == Userlog.UserId).EmployessId;
                    bill.CustomerId = _customerServices.GetAll().FirstOrDefault(c => c.PhoneNumber == txt_phone.Text).CustomerId;
                    bill.CreateDate = DateTime.Now;
                    bill.Status = 0;//set chưa thanh toán 
                    bill.PaymenDate = null;


                    Product prd = _productServices.FindById(idsp);
                    product.Add(prd);//Thêm sản phẩm được chọn vào list sản phẩm (producct)
                    ProductDetail prddt = _productDetailServices.FindById(idspdt);
                    detail.Add(prddt);//Thêm chi tiết sản phẩm được chọn vào list sản phẩm (detail)
                    //cập nhật số lượng
                    int qantityex = _productDetailServices.FindById(idspdt).QuantityExists - (int)txt_soluong.TabIndex;
                    if (qantityex == 0)
                    {
                        ProductDetail productDetail = _productDetailServices.FindById(idspdt);
                        productDetail.status = 0;//hết hagf
                        _productDetailServices.Update(productDetail);
                    }
                    else
                    {
                        ProductDetail productDetail = _productDetailServices.FindById(idspdt);
                        productDetail.QuantityExists = qantityex;
                        _productDetailServices.Update(productDetail);
                    }
                    billid = bill.BillId;///lấy ra billID 

                    float price = _productDetailServices.FindById(idspdt).Price;
                    Bill_ProductDetail bill_ProductDetail1 = new Bill_ProductDetail();
                    bill_ProductDetail1.Price = price;
                    bill_ProductDetail1.BillId = billid;
                    bill_ProductDetail1.ProDetailId = idspdt;
                    bill_ProductDetail1.Quantity = int.Parse(txt_soluong.Text);

                    bill_ProductDetail.Add(bill_ProductDetail1);

                  
                }
               

            }
            dview_bill.Rows.Clear();
            Loadbilldata();

        }

        private void cbx_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int categoryId = int.Parse(cbx_category.SelectedValue.ToString());

            if (detail.Where(c => c.CategoryId == categoryId).ToList().Count == 0)
            {
                MessageBox.Show("Sản phẩm hết hàng hoặc không tồn tại");
                cbx_category.SelectedIndex = -1;

            }
            else
            {
                detail = detail.Where(c => c.CategoryId == categoryId).ToList();
                LoadProductDetail();
            }
        }
        private void cbx_color_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int colorid = int.Parse(cbx_color.SelectedValue.ToString());
            if (detail.Where(c => c.ColorId == colorid).ToList().Count == 0)
            {
                MessageBox.Show("Sản phẩm hết hàng hoặc không tồn tại");
                cbx_color.SelectedIndex = -1;
            }
            else
            {
                detail = detail.Where(c => c.ColorId == colorid).ToList();
                LoadProductDetail();
            }
        }
        private void cbx_size_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int sizeid = int.Parse(cbx_size.SelectedValue.ToString());
            if (detail.Where(c => c.SizeId == sizeid).ToList().Count == 0)
            {
                MessageBox.Show("Sản phẩm hết hàng hoặc không tồn tại");
                cbx_size.SelectedIndex = -1;
            }
            else
            {
                detail = detail.Where(c => c.SizeId == sizeid).ToList();
                LoadProductDetail();
            }
        }
        private void cbx_material_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int materialid = int.Parse(cbx_material.SelectedValue.ToString());
            if (detail.Where(c => c.MaterialId == materialid).ToList().Count == 0)
            {
                MessageBox.Show("Sản phẩm hết hàng hoặc không tồn tại");
                cbx_material.SelectedIndex = -1;
            }
            else
            {
                detail = detail.Where(c => c.MaterialId == materialid).ToList();
                LoadProductDetail();
            }
        }
        private void btn_clearfillter_Click(object sender, EventArgs e)
        {
            txt_findbyname.Text = string.Empty;
            cbx_category.SelectedIndex = -1;
            cbx_color.SelectedIndex = -1;
            cbx_size.SelectedIndex = -1;
            cbx_material.SelectedIndex = -1;
            detail = _productDetailServices.GetAll();
            LoadProduct();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dview_bill.RowCount == 0)
            {
                MessageBox.Show("Hóa đơn đang chưa có sản phẩm nào");
            }
            else
            {
                _billServices.Update(bill);
                MessageBox.Show("Lưu thành công");
                billid = -1;
                idsp = -1;
                idspdt = -1;
                product.Clear();
                detail.Clear();
            }

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (dview_bill.RowCount == 0)
            {
                MessageBox.Show("Hóa đơn đang chưa có sản phẩm nào");
            }
            else
            {
                bill.PaymenDate = DateTime.Now;
                bill.Status = 1;
                _billServices.Update(bill);
                MessageBox.Show("Thanh toán thành công");
                billid = -1;
                idsp = -1;
                idspdt = -1;
                product.Clear();
                detail.Clear();
            }
        }

        private void btn_findbyname_Click(object sender, EventArgs e)
        {
            if (_productServices.GetAll().Where(c => c.ProductName == txt_findbyname.Text).ToList() != null)
            {
                dview_product.DataSource = _productServices.GetAll().Where(c => c.ProductName == txt_findbyname.Text).ToList();
            }
            else
            {
                MessageBox.Show("Không có sản phẩm");
            }
        }

        private void dview_product_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            idsp = (int)dview_product.Rows[e.RowIndex].Cells[0].Value;
            LoadProductDetail();
        }

        private void dview_productdetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idspdt = (int)dview_productdetail.Rows[e.RowIndex].Cells[0].Value;
            cbx_category.SelectedValue = _productDetailServices.FindById(idspdt).CategoryId;
            cbx_color.SelectedValue = _productDetailServices.FindById(idspdt).ColorId;
            cbx_material.SelectedValue = _productDetailServices.FindById(idspdt).MaterialId;
            cbx_size.SelectedValue = _productDetailServices.FindById(idspdt).SizeId;

        }

        private void btn_bora_Click(object sender, EventArgs e)
        {
            if (dview_bill.RowCount==0)
            {
                billid = -1;
                MessageBox.Show("Không có sản phẩm nào trong hóa đơn");
            }
            else
            {
                product.Remove(_productServices.FindById(idsp));
                detail.Remove(_productDetailServices.FindById(idspdt));
            }
            dview_bill.Rows.Clear();
            Loadbilldata();
        }

        private void dview_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dview_bill.Rows.Count &&
         dview_bill.Rows[e.RowIndex].Cells["Idsp"].Value != null &&
         dview_bill.Rows[e.RowIndex].Cells["Idspdt"].Value != null)
            {
                idsp = int.Parse(dview_bill.Rows[e.RowIndex].Cells["Idsp"].Value.ToString());
                idspdt = int.Parse(dview_bill.Rows[e.RowIndex].Cells["Idspdt"].Value.ToString());
            }
        }
    }
}
