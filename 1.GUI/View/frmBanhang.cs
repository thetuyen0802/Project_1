using _2.BUS.IServices;
using _2.BUS.Services;
using _3.DAL.Context;
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
    public partial class frmBanhang : Form
    {
        private DBContext _dbContext;
        private IUserServices _userServices;
        private IEmployessServices _employessServices;
        private ICustomerServices _customerServices;
        private IColorServices _colorServices;
        private IMaterialServices _materialServices;
        private ISizeService _sizeServices;
        private ICategogyServices _categogyServices;
        private IProductDetailServices _productDetailServices;
        private IProductServices _productServices;
        private IBillServices _billServices;
        private IBill_ProductDetailsServices _bill_ProductDetailsServices;
        private Product product;
        private int idsp;
        private ProductDetail detail;
        private int? billid;
        private Bill bill;
        private User Userlog;
     
        public frmBanhang(User user)
        {
            InitializeComponent();
            _userServices = new UserServices();
            _employessServices = new EmployessServices();
            _productServices = new ProductServices();
            _productDetailServices = new ProductDetailServices();
            _colorServices = new ColorServices();
            _materialServices = new MaterialServices();
            _sizeServices= new SizeService();
            _categogyServices = new CategogyServices();
            _billServices = new BillServices();
            _bill_ProductDetailsServices = new Bill_ProductDetailsServices();
            _dbContext = new DBContext();
             bill = new Bill();
            Userlog = user;
        }
        public void LoadSpCT()
        {
            dview_product.DataSource = _productServices.GetAll();
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

        private void frmBanhang_Load(object sender, EventArgs e)
        {
            LoadSpCT();
        }

        private void dview_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idsp = (int)dview_product.Rows[e.RowIndex].Cells[0].Value;
            product = _productServices.FindById(idsp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // check xem có hóa đơn nào đang tồn tại không nếu không thì tạo mới một bill gán billId = bill.billid để nếu thêm sản phẩm thì thêm tiếp vào bill đang tồn tại
            //Check xem đang tạo bill cho khác hàng nào nếu chưa thông báo chưa chọn khách hàng: có khách hàng thì mới được tạo và thêm bill
            if (txt_name.Text== null)
            {
                MessageBox.Show("Chưa có khách hàng");
            }
            else if (billid== null)
            {
                //Tạo thêm bill
                int employessid = _employessServices.GetAll().FirstOrDefault(c=>c.UserId==Userlog.UserId).EmployessId;
                bill.CustomerId= _customerServices.GetAll().FirstOrDefault(c=>c.PhoneNumber==txt_phone.Text).CustomerId;
                bill.EmployessId = employessid;
                bill.CreateDate = DateTime.Now;
                bill.PaymenDate = null;
                billid=bill.BillId;
                _billServices.Add(bill);

                //Lấy sản phẩm được chọn
                Product product = _productServices.FindById(idsp);
                //Lấy Chi tiết sản phẩm 
                // Kiểm tra xem chi tiết sản phẩm đã tồn tại trong db chưa
                var allProductDetails = _productDetailServices.GetAll();

                // Kiểm tra từng sản phẩm chi tiết trong danh sách
                foreach (var existingDetail in allProductDetails)
                {
                    // So sánh các thuộc tính của sản phẩm chi tiết hiện tại với sản phẩm chi tiết trong danh sách
                    if (existingDetail.ProductId == idsp &&
                        existingDetail.CategoryId == int.Parse(cbx_category.SelectedValue.ToString()) &&
                        existingDetail.MaterialId == int.Parse(cbx_material.SelectedValue.ToString()) &&
                        existingDetail.SizeId == int.Parse(cbx_size.SelectedValue.ToString()) &&
                        existingDetail.ColorId == int.Parse(cbx_color.SelectedValue.ToString()))
                    {
                        // Nếu tìm thấy sản phẩm chi tiết có các thuộc tính giống nhau, sử dụng sản phẩm chi tiết đó
                        detail = existingDetail;
                        break;
                    }
                }
                //
               if (detail == null)
                {
                    detail = new ProductDetail();
                    detail.ProductId = idsp;
                    detail.CategoryId = int.Parse(cbx_category.SelectedValue.ToString());
                    detail.MaterialId = int.Parse(cbx_material.SelectedValue.ToString());
                    detail.SizeId = int.Parse(cbx_size.SelectedValue.ToString());
                    detail.ColorId = int.Parse(cbx_color.SelectedValue.ToString());
                    _productDetailServices.Add(detail);
                }

                //Thêm chi tiết hóa đơn
                Bill_ProductDetail bill_ProductDetail1 = new Bill_ProductDetail();
                bill_ProductDetail1.BillId = bill.BillId;
                bill_ProductDetail1.ProDetailId = detail.ProDetailId;
                bill_ProductDetail1.Price = _productServices.FindById(idsp).Price;
                bill_ProductDetail1.Quantity = int.Parse(txt_soluong.Text);
                _bill_ProductDetailsServices.Add(bill_ProductDetail1);
                

                var bill_detail = from bill_ProductDetail in _dbContext.Bill_ProductDetails
                                  join productDetail in _dbContext.ProductDetails on bill_ProductDetail.ProDetailId equals productDetail.ProDetailId
                                  select new
                                  {
                                      BillId = bill_ProductDetail.BillId,
                                      ProductId = productDetail.ProductId,
                                      CategoryId = productDetail.CategoryId,
                                      MaterialId = productDetail.MaterialId,
                                      ColorId = productDetail.ColorId,
                                      SizeId = productDetail.SizeId,
                                      Price = bill_ProductDetail.Price,
                                      Quantity = bill_ProductDetail.Quantity
                                  };

                dview_bill.DataSource = bill_detail.Where(c => c.BillId == bill.BillId);
            }
          

  
        }
    }
}
