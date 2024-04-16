using _2.BUS.IServices;
using _2.BUS.Services;
using _3.DAL.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace _1.GUI
{
    public partial class frmproduct : Form
    {
        private IBrandServices _brandService;
        private IProductServices _services;
        private IProductDetailServices _detailService;
        private IBrandServices _brandServices;
        private ICategogyServices _categogyService;
        private IMaterialServices _materialService;
        private IColorServices _colorService;
        private ISizeService _sizeService;

        private int _clickid;
        private int idspdt;
        private List<Product> _products;
        private List<ProductDetail> _productDetails;

        public frmproduct()
        {
            InitializeComponent();
            _services = new ProductServices();
            _brandService = new BrandServices();
            _brandServices = new BrandServices();
            _detailService = new ProductDetailServices();
            _products = new List<Product>();
            _productDetails = new List<ProductDetail>();
            _colorService = new ColorServices();
            _materialService = new MaterialServices();
            _sizeService = new SizeService();
            _categogyService = new CategogyServices();
            _materialService = new MaterialServices();
            LoadData();
            UpdateView();
            _clickid = 0;

        }
        public void LoadData()
        {
            List<Brand> brands = _brandService.GetAll();
            _products = _services.GetAll().Where(c => c.Status == 1).ToList();
            dview_product.Columns.Add("Id", "ID");

            dview_product.Columns.Add("ProductName", "Tên sản phẩm");
            dview_product.Columns.Add("Brand", "Thương hiệu");
            dview_product.Columns.Add("Cost", "Giá nhập");


            view_prodetail.Columns.Add("Name", "Tên sản phẩm");
            view_prodetail.Columns.Add("Brand", "Thương hiệu");
            view_prodetail.Columns.Add("Category", "Loại sản phẩm");
            view_prodetail.Columns.Add("Material", "Chất liệu");
            view_prodetail.Columns.Add("Color", "Màu sắc");
            view_prodetail.Columns.Add("Size", "Kích cỡ");
            view_prodetail.Columns.Add("Price", "Giá bán");
            view_prodetail.Columns.Add("Quantity", "Số lượng tồn");
            view_prodetail.Columns.Add("Idspdt", "Idspdt");


            cbx_brand.DataSource = brands;
            cbx_brand.DisplayMember = "BrandName";
            cbx_brand.ValueMember = "BrandId";


            List<_3.DAL.Model.Color> colors = _colorService.GetColors();
            List<Material> materials = _materialService.GetAll();
            List<_3.DAL.Model.Size> sizes = _sizeService.GetSizes();
            List<Category> categories = _categogyService.GetCategories();

            cbx_Category.DataSource = categories;

            cbx_Category.DisplayMember = "CategoryName";
            cbx_Category.ValueMember = "CategoryId";

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
        public void UpdateView()
        {
            dview_product.Rows.Clear();
            foreach (var item in _products)
            {

                dview_product.Rows.Add(
                    item.ProductId,
                    item.ProductName,
                    _brandService.GetById(item.BrandId).BrandName,
                    item.Cost
                    );
            }
        }
        public void LoadDataProdetail()
        {
            _productDetails = _detailService.GetAll().Where(c => c.ProductId == _clickid).ToList();
            foreach (var item in _productDetails)
            {
                view_prodetail.Rows.Add
                    (
                    _services.FindById(item.ProductId).ProductName,
                    _brandServices.GetById(_services.FindById(item.ProductId).BrandId).BrandName,
                    _categogyService.GetByID(item.CategoryId).CategoryName,
                    _materialService.Get(item.MaterialId).MaterialName,
                    _colorService.GetByID(item.ColorId).ColorName,
                    _sizeService.GetById(item.SizeId).SizeName,
                    item.Price,
                    item.QuantityExists
                    );
            }

        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            /////Chú ý trạng thái của sản phẩm :
            ////    Trạng thái = 0 => Ngừng kinh doanh
            ///     Trạng thái = 1 => Đang kinh doah
            ///     

            Product product = new Product();
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.BrandId = (int)cbx_brand.SelectedValue;
            product.Status = 1;
            int exs = 1;
            foreach (var item in _services.GetAll())
            {
                if (product.ProductName == item.ProductName || product.BrandId == item.BrandId)
                {
                    exs = 0;
                    break;
                }
                else
                {
                    exs = 1;
                }

            }

            if (exs == 0)
            {
                MessageBox.Show("Sản phẩm đã tồn tại");
            }
            else
            {
                _services.Add(product);
                UpdateView();
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_id.Text = string.Empty;
            txt_cost.Text = string.Empty;
            txt_name.Text = string.Empty;
            cbx_brand.SelectedIndex = -1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Product product = _services.FindById(_clickid);
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.BrandId = (int)cbx_brand.SelectedValue;

            _services.Update(product);
            UpdateView();
        }

        private void dview_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex != -1)
            {
                // Chặn việc chọn dòng tiêu đề
                dview_product.ClearSelection();
            }
            else
            {

                _clickid = (int)dview_product.Rows[e.RowIndex].Cells["Id"].Value;
                Product product = _services.FindById(_clickid);
                txt_name.Text = product.ProductName;

                txt_cost.Text = product.Cost.ToString();
                txt_id.Text = _clickid.ToString();
                cbx_brand.SelectedValue = product.BrandId;
                
                view_prodetail.Rows.Clear();
                LoadDataProdetail();
            }
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {


        }
        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            Product product = _services.FindById(_clickid);
            product.Status = 0;
            _services.Update(product);
            UpdateView();
        }

        private void btn_add_pro_detail_Click(object sender, EventArgs e)
        {
            if (_clickid == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm ");
            }
            else
            {
                int gianhap= int .Parse(txt_cost.Text);
                int giaban= int.Parse(txt_price.Text);

                if (giaban<gianhap)
                {
                    DialogResult result = MessageBox.Show("Sản phẩm có giá bán thấp hơn giá nhập", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   
                    if (result == DialogResult.Yes)
                    {
                        ProductDetail productDetail = new ProductDetail();
                        productDetail.ProductId = _clickid;
                        productDetail.CategoryId = int.Parse(cbx_Category.SelectedValue.ToString());
                        productDetail.MaterialId = int.Parse(cbx_material.SelectedValue.ToString());
                        productDetail.Price = int.Parse(txt_price.Text);
                        productDetail.ColorId = int.Parse(cbx_color.SelectedValue.ToString());
                        productDetail.SizeId = int.Parse(cbx_size.SelectedValue.ToString());


                        MessageBox.Show(_detailService.Add(productDetail));

                    }
                    else
                    {

                    }
                }
                view_prodetail.Rows.Clear();
                LoadDataProdetail();

            }

        }

        private void view_prodetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                view_prodetail.ClearSelection();
            }
            else
            {
                idspdt = 0;
                idspdt = int.Parse(view_prodetail.Rows[e.RowIndex].Cells[""].Value.ToString());
                ProductDetail prd = _detailService.FindById(idspdt);

                cbx_Category.SelectedValue = prd.CategoryId;
                cbx_material.SelectedValue = prd.MaterialId;
                cbx_size.SelectedValue = prd.SizeId;
                cbx_color.SelectedValue = prd.ColorId;

            }
        }

        private void btn_update_pro_detail_Click(object sender, EventArgs e)
        {
            if (_clickid == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm ");
            }
            else
            {
                if (idspdt == 0)
                {
                    MessageBox.Show("Chưa chọn sản phẩm chi tiết");

                }
                else
                {
                    ProductDetail productDetail = _detailService.FindById(idspdt);
                    productDetail.CategoryId = int.Parse(cbx_Category.SelectedValue.ToString());
                    productDetail.MaterialId = int.Parse(cbx_material.SelectedValue.ToString());
                    productDetail.ColorId = int.Parse(cbx_color.SelectedValue.ToString());
                    productDetail.SizeId = int.Parse(cbx_size.SelectedValue.ToString());

                    MessageBox.Show(_detailService.Update(productDetail));
                }
                view_prodetail.Rows.Clear();
                LoadDataProdetail();
            }

            
        }
    }
}
