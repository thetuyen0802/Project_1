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
        //private IBrandServices _brandServices;
        private int _clickid;

        public frmproduct()
        {
            InitializeComponent();
            _services = new ProductServices();
            _brandService = new BrandServices();
            //_brandServices = new BrandServices();
            LoadData();
        }
        public void LoadData()
        {
            List<Brand> brands = _brandService.GetAll();
            List<Product> products = _services.GetAll();
            dview_product.DataSource = products;
            cbx_brand.DataSource = brands;
            cbx_brand.DisplayMember = "BrandName";
            cbx_brand.ValueMember = "BrandId";


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            /////Chú ý trạng thái của sản phẩm :
            ////    Trạng thái = 0 => Ngừng kinh doanh
            ///     Trạng thái = 1 => Còn hàng
            ///     Tạng thái  = 2 => Hết hàng
            Product product = new Product();
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.QuantityExists = int.Parse(txt_quantity.Text);
            product.Status = 1;
            product.Status = comboBox1.SelectedIndex;
            product.BrandId = int.Parse(cbx_brand.SelectedValue.ToString());

            _services.Add(product);
            LoadData();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_cost.Text = string.Empty;
            txt_quantity.Text = string.Empty;
            txt_name.Text = string.Empty;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Product product = _services.FindById(_clickid);
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.QuantityExists = int.Parse(txt_quantity.Text);
            product.Status = comboBox1.SelectedIndex;
            _services.Update(product);
            LoadData();
        }

        private void dview_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _clickid = (int)dview_product.Rows[e.RowIndex].Cells[0].Value;
            Product product = _services.FindById(_clickid);
            txt_name.Text = product.ProductName;
            txt_quantity.Text = product.QuantityExists.ToString();
            txt_cost.Text = product.Cost.ToString();
            txt_id.Text = _clickid.ToString();
        }

        private void dview_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmproduct_Load(object sender, EventArgs e)
        {


        }
        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            Product product = _services.FindById(_clickid);
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.QuantityExists = int.Parse(txt_quantity.Text);
            product.Status = 0;
            _services.Update(product);
            LoadData();
        }
    }
}
