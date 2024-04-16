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
using Color = _3.DAL.Model.Color;
using Size = _3.DAL.Model.Size;

namespace _1.GUI.View
{
    public partial class frmProInfor : Form
    {
        private IBrandServices brandServices;
        private ICategogyServices categogyServices;
        private IMaterialServices materialServices;
        private IColorServices colorServices;
        private ISizeService sizeServices;
        private List<Brand> brands;
        private List<Material> materials;
        private List<Category> categories;
        private List<_3.DAL.Model.Color> colors;
        private List<_3.DAL.Model.Size> sizes;
        private int braId = 0;
        public frmProInfor()
        {
            InitializeComponent();
            brandServices = new BrandServices();
            categogyServices = new CategogyServices();
            materialServices = new MaterialServices();
            colorServices = new ColorServices();
            sizeServices = new SizeService();

            materials = new List<Material>();
            categories = new List<Category>();
            colors = new List<Color>();
            sizes = new List<Size>();
            brands = new List<Brand>();

            Load();
            LoadBrandData();
            LoadCategoryData();
            LoadMaterial();
            LoadColor();
            Loadsize();


        }



        public void Load()
        {
            brands = brandServices.GetAll();
            categories = categogyServices.GetCategories();
            materials = materialServices.GetAll();
            colors = colorServices.GetColors();
            sizes = sizeServices.GetSizes();

            dataGridView1.Columns.Add("BrandId", "BrandId");
            dataGridView1.Columns.Add("BrandName", "Thương hiệu");
            dataGridView1.Columns["BrandId"].Visible = false;

            dataGridView2.Columns.Add("CategoryName", "Loại sản phẩm");

            dataGridView3.Columns.Add("MaterialName", "Chất liệu");

            dataGridView4.Columns.Add("ColorName", "Màu sắc");

            dataGridView5.Columns.Add("SizeName", "Kích cỡ");

        }
        public void LoadBrandData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in brands)
            {
                dataGridView1.Rows.Add(item.BrandId, item.BrandName);
            }
        }
        public void LoadCategoryData()
        {
            dataGridView2.Rows.Clear();
            foreach (var item in categories)
            {
                dataGridView2.Rows.Add(item.CategoryName);
            }
        }
        public void LoadMaterial()
        {
            dataGridView3.Rows.Clear();
            foreach (var item in materials)
            {
                dataGridView3.Rows.Add(item.MaterialName);
            }
        }
        public void LoadColor()
        {
            dataGridView4.Rows.Clear();
            foreach (var item in colors)
            {
                dataGridView4.Rows.Add(item.ColorName);
            }
        }
        public void Loadsize()
        {
            dataGridView5.Rows.Clear();
            foreach (var item in sizes)
            {
                dataGridView5.Rows.Add(item.SizeName);
            }
        }
        private void btn_addbrand_Click(object sender, EventArgs e)
        {
            int ex = 0;
            brands = brandServices.GetAll();
            foreach (var item in brands)
            {
                if (txt_brandname.Text == item.BrandName)
                {
                    ex = 1;
                    break;
                }
                else
                {
                    ex = 0;
                }
            }
            if (txt_brandname.Text == "")
            {
                MessageBox.Show("Tên thương hiệu trống");
            }
            else
            {
                if (ex == 1)
                {
                    MessageBox.Show("Thương hiệu đã tồn tại");
                }
                else
                {
                    Brand brand = new Brand();
                    brand.BrandName = txt_brandname.Text;
                    MessageBox.Show(brandServices.Add(brand));
                }
            }

            dataGridView1.Rows.Clear();
            LoadBrandData();
        }

        private void btn_updatebrand_Click(object sender, EventArgs e)
        {
            if (braId == 0)
            {
                MessageBox.Show("Chưa chọn thương hiệu cần sửa");
            }
            else
            {
                Brand brand = brandServices.GetById(braId);
                brand.BrandName = txt_brandname.Text;
                MessageBox.Show(brandServices.Update(brand));

                dataGridView1.Rows.Clear();
                LoadBrandData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            braId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["BrandId"].Value.ToString());
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            if (txt_categoty.Text == "")
            {
                MessageBox.Show("Tên loại sản phẩm đang trống");
            }
            else
            {
                int ex = 0;
                categories = categogyServices.GetCategories();
                foreach (var item in categories)
                {
                    if (item.CategoryName == txt_categoty.Text)
                    {
                        ex = 1;
                        break;
                    }
                    else
                    {
                        ex = 0;
                    }
                }
                if (ex == 1)
                {
                    MessageBox.Show("Loại sản phẩm đã tồn tại");
                }
                else
                {
                    Category category = new Category();
                    category.CategoryName = txt_categoty.Text;
                    MessageBox.Show(categogyServices.Add(category));
                }

            }
            dataGridView2.Rows.Clear();
            LoadCategoryData();
        }

        private void btn_addmaterial_Click(object sender, EventArgs e)
        {
            if (txt_material.Text == "")
            {
                MessageBox.Show("Tên chất liệu đang trống");
            }
            else
            {
                int ex = 0;
                materials = materialServices.GetAll();
                foreach (var item in materials)
                {
                    if (item.MaterialName == txt_material.Text)
                    {
                        ex = 1;
                        break;
                    }
                    else
                    {
                        ex = 0;
                    }
                }
                if (ex == 1)
                {
                    MessageBox.Show("Chất liệu đã tồn tại");
                }
                else
                {
                    Material material = new Material();
                    material.MaterialName = txt_material.Text;
                    MessageBox.Show(materialServices.Add(material));
                }

            }
            dataGridView3.Rows.Clear();
            LoadMaterial();
        }

        private void btn_addcolor_Click(object sender, EventArgs e)
        {
            if (txt_color.Text == "")
            {
                MessageBox.Show("Tên màu đang trống");
            }
            else
            {
                int ex = 0;
                colors = colorServices.GetColors();
                foreach (var item in colors)
                {
                    if (item.ColorName == txt_color.Text)
                    {
                        ex = 1;
                        break;
                    }
                    else
                    {
                        ex = 0;
                    }
                }
                if (ex == 1)
                {
                    MessageBox.Show("Màu đã tồn tại");
                }
                else
                {
                    _3.DAL.Model.Color color = new Color();
                    color.ColorName = txt_color.Text;
                    MessageBox.Show(colorServices.Add(color));
                }

            }
            dataGridView4.Rows.Clear();
            LoadColor();
        }

        private void btn_addsize_Click(object sender, EventArgs e)
        {

            if (txt_size.Text == "")
            {
                MessageBox.Show("Tên cỡ đang trống");
            }
            else
            {
                int ex = 0;
                sizes = sizeServices.GetSizes();
                foreach (var item in sizes)
                {
                    if (item.SizeName == txt_size.Text)
                    {
                        ex = 1;
                        break;
                    }
                    else
                    {
                        ex = 0;
                    }
                }
                if (ex == 1)
                {
                    MessageBox.Show("Cỡ đã tồn tại");
                }
                else
                {
                    _3.DAL.Model.Size size = new Size();
                    size.SizeName = txt_size.Text;
                    MessageBox.Show(sizeServices.Add(size));
                }

            }
            dataGridView5.Rows.Clear();
            LoadColor();
        }
    }
}
