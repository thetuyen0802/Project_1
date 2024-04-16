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
    public partial class frmCustomer : Form
    {
        private CustomerServices CustomerServices;
        private int id;

        public frmCustomer()
        {
            InitializeComponent();
            CustomerServices = new CustomerServices();
            Load();
        }
        public void Load()
        {
            dataGridView1.DataSource = CustomerServices.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txt_name.Text;
            customer.PhoneNumber = txt_sdt.Text;
            MessageBox.Show(CustomerServices.Add(customer));
            Load();
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Load();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerServices.GetByID(id);
            customer.Name = txt_name.Text;
            customer.PhoneNumber = txt_sdt.Text;
            MessageBox.Show(CustomerServices.Update(customer));
            Load();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (id==null)
            {
            }
            else
            {
                txt_name.Text = CustomerServices.GetByID(id).Name;
                txt_sdt.Text = CustomerServices.GetByID(id).PhoneNumber;
            }
        }
    }
}
