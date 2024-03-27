using _1.GUI.View;
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
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)

        {
            Product product = new Product();

            FillForm(product);
           

        }
        void FillForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(form);
            form.Show();
        }
        void ResizeControll()
        {
            float ScaleX = (float)this.Width / this.MaximumSize.Width;
            float ScaleY = (float)this.Height / this.MaximumSize.Height;

            foreach (Control control in this.Controls)
            {
                if (control.Tag.ToString() == "NoResize") continue;
                int newX = (int)(control.Location.X / ScaleX);
                int newY = (int)(control.Location.Y / ScaleY);
                int newWidth = (int)(control.Width / ScaleX);
                int newHeight = (int)(control.Height / ScaleY);

                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
            }
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Product product = new Product();
            FillForm(product);
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            ResizeControll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_sales_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            Sales sales=new Sales();
            FillForm(sales);
        }
    }
}
