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
        private IProductServices _services;
        private IBrandServices _brandServices;

        public frmproduct()
        {
            InitializeComponent();
            _services = new ProductServices();
            _brandServices = new BrandServices();
            LoadData();
        }
        public void LoadData()
        {
            List<Product> products = _services.GetAll();
            dview_product.DataSource = products;
            cbx_brand.DataSource = _brandServices.GetAll();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.QuantityExists = int.Parse(txt_quantity.Text);
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
            Product product = new Product();
            product.ProductName = txt_name.Text;
            product.Cost = float.Parse(txt_cost.Text);
            product.QuantityExists = int.Parse(txt_quantity.Text);
            _services.Update(product);
            LoadData();
        }

        private void dview_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int proId = (int)dview_product.Rows[e.RowIndex].Cells[0].Value;
            _services.FindById(proId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
