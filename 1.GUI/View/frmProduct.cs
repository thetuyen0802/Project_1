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
        private IBrandServices _brandServices;
        private int _clickid;
        private List<Product> _products;

        public frmproduct()
        {
            InitializeComponent();
            _services = new ProductServices();
            _brandService = new BrandServices();
            _brandServices = new BrandServices();
            _products = new List<Product>();
            LoadData();
            UpdateView();
        }
        public void LoadData()
        {
            List<Brand> brands = _brandService.GetAll();
            _products = _services.GetAll().Where(c=>c.Status==1).ToList();
            dview_product.Columns.Add("Id", "ID");
            
            dview_product.Columns.Add("ProductName", "Tên sản phẩm");
            dview_product.Columns.Add("Brand", "Thương hiệu");
            dview_product.Columns.Add("Cost", "Giá nhập");

            cbx_brand.DataSource = brands;
            cbx_brand.DisplayMember = "BrandName";
            cbx_brand.ValueMember = "BrandId";


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
            int exs=1;
            foreach (var item in _services.GetAll())
            {
                if (product.ProductName==item.ProductName || product.BrandId==item.BrandId)
                {
                    exs = 0;
                    break;
                }
                else
                {
                    exs = 1;
                }
                
            }

            if (exs==0)
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
            product.BrandId=(int)cbx_brand.SelectedValue;

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
                _clickid = (int)dview_product.Rows[e.RowIndex].Cells[0].Value;

                Product product = _services.FindById(_clickid);
                txt_name.Text = product.ProductName;

                txt_cost.Text = product.Cost.ToString();
                txt_id.Text = _clickid.ToString();
                cbx_brand.SelectedValue = product.BrandId;
            }
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
            product.Status = 0;
            _services.Update(product);
            UpdateView();
        }
    }
}
