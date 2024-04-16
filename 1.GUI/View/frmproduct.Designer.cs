namespace _1.GUI
{
    partial class frmproduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txt_id = new TextBox();
            dview_product = new DataGridView();
            txt_name = new TextBox();
            txt_cost = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_update = new Button();
            btn_add = new Button();
            btn_clear = new Button();
            btn_delete = new Button();
            cbx_brand = new ComboBox();
            label7 = new Label();
            brandServicesBindingSource = new BindingSource(components);
            txt_price = new TextBox();
            label3 = new Label();
            txt_quantity = new TextBox();
            label6 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbx_Category = new ComboBox();
            cbx_color = new ComboBox();
            cbx_material = new ComboBox();
            cbx_size = new ComboBox();
            view_prodetail = new DataGridView();
            btn_add_pro_detail = new Button();
            btn_update_pro_detail = new Button();
            ((System.ComponentModel.ISupportInitialize)dview_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandServicesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)view_prodetail).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(123, 84);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(247, 27);
            txt_id.TabIndex = 0;
            // 
            // dview_product
            // 
            dview_product.AllowUserToAddRows = false;
            dview_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_product.Location = new Point(379, 84);
            dview_product.Name = "dview_product";
            dview_product.RowHeadersWidth = 51;
            dview_product.RowTemplate.Height = 29;
            dview_product.Size = new Size(509, 180);
            dview_product.TabIndex = 1;
            dview_product.CellClick += dview_product_CellClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(123, 124);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(247, 27);
            txt_name.TabIndex = 3;
            // 
            // txt_cost
            // 
            txt_cost.Location = new Point(123, 167);
            txt_cost.Name = "txt_cost";
            txt_cost.Size = new Size(247, 27);
            txt_cost.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 11;
            label4.Text = "Giá nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(333, 31);
            label5.Name = "label5";
            label5.Size = new Size(194, 50);
            label5.TabIndex = 12;
            label5.Text = "Sản Phẩm";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(465, 296);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(88, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(107, 296);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(129, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm sản phẩm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(596, 296);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(88, 29);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click_1;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(272, 296);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(148, 29);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Xóa sản phẩm ";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // cbx_brand
            // 
            cbx_brand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_brand.FormattingEnabled = true;
            cbx_brand.Location = new Point(123, 208);
            cbx_brand.Name = "cbx_brand";
            cbx_brand.Size = new Size(215, 28);
            cbx_brand.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 216);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 18;
            label7.Text = "Thương hiệu";
            // 
            // brandServicesBindingSource
            // 
            brandServicesBindingSource.DataSource = typeof(_2.BUS.Services.BrandServices);
            // 
            // txt_price
            // 
            txt_price.Location = new Point(506, 418);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(151, 27);
            txt_price.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 425);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 20;
            label3.Text = "Giá bán";
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(506, 452);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(137, 27);
            txt_quantity.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 459);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 22;
            label6.Text = "Số lượng tồn";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 464);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 23;
            label8.Text = "Màu sắc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 425);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 24;
            label9.Text = "Chất liệu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 388);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 25;
            label10.Text = "Loại sản phẩm ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(407, 388);
            label11.Name = "label11";
            label11.Size = new Size(27, 20);
            label11.TabIndex = 26;
            label11.Text = "Cỡ";
            // 
            // cbx_Category
            // 
            cbx_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Category.FormattingEnabled = true;
            cbx_Category.Location = new Point(148, 380);
            cbx_Category.Name = "cbx_Category";
            cbx_Category.Size = new Size(215, 28);
            cbx_Category.TabIndex = 27;
            // 
            // cbx_color
            // 
            cbx_color.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_color.FormattingEnabled = true;
            cbx_color.Location = new Point(148, 456);
            cbx_color.Name = "cbx_color";
            cbx_color.Size = new Size(215, 28);
            cbx_color.TabIndex = 28;
            // 
            // cbx_material
            // 
            cbx_material.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_material.FormattingEnabled = true;
            cbx_material.Location = new Point(148, 417);
            cbx_material.Name = "cbx_material";
            cbx_material.Size = new Size(215, 28);
            cbx_material.TabIndex = 29;
            // 
            // cbx_size
            // 
            cbx_size.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_size.FormattingEnabled = true;
            cbx_size.Location = new Point(506, 380);
            cbx_size.Name = "cbx_size";
            cbx_size.Size = new Size(151, 28);
            cbx_size.TabIndex = 30;
            // 
            // view_prodetail
            // 
            view_prodetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view_prodetail.Location = new Point(1, 509);
            view_prodetail.Name = "view_prodetail";
            view_prodetail.RowHeadersWidth = 51;
            view_prodetail.RowTemplate.Height = 29;
            view_prodetail.Size = new Size(894, 219);
            view_prodetail.TabIndex = 31;
            view_prodetail.CellClick += view_prodetail_CellClick;
            // 
            // btn_add_pro_detail
            // 
            btn_add_pro_detail.Location = new Point(67, 768);
            btn_add_pro_detail.Name = "btn_add_pro_detail";
            btn_add_pro_detail.Size = new Size(198, 29);
            btn_add_pro_detail.TabIndex = 32;
            btn_add_pro_detail.Text = "Thêm chi tiết sản phẩm";
            btn_add_pro_detail.UseVisualStyleBackColor = true;
            btn_add_pro_detail.Click += btn_add_pro_detail_Click;
            // 
            // btn_update_pro_detail
            // 
            btn_update_pro_detail.Location = new Point(311, 768);
            btn_update_pro_detail.Name = "btn_update_pro_detail";
            btn_update_pro_detail.Size = new Size(94, 29);
            btn_update_pro_detail.TabIndex = 33;
            btn_update_pro_detail.Text = "Cập nhật";
            btn_update_pro_detail.UseVisualStyleBackColor = true;
            btn_update_pro_detail.Click += btn_update_pro_detail_Click;
            // 
            // frmproduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 833);
            ControlBox = false;
            Controls.Add(btn_update_pro_detail);
            Controls.Add(btn_add_pro_detail);
            Controls.Add(view_prodetail);
            Controls.Add(cbx_size);
            Controls.Add(cbx_material);
            Controls.Add(cbx_color);
            Controls.Add(cbx_Category);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txt_quantity);
            Controls.Add(label3);
            Controls.Add(txt_price);
            Controls.Add(label7);
            Controls.Add(cbx_brand);
            Controls.Add(btn_delete);
            Controls.Add(btn_clear);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_cost);
            Controls.Add(txt_name);
            Controls.Add(dview_product);
            Controls.Add(txt_id);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmproduct";
            Text = " b";
            Load += frmproduct_Load;
            ((System.ComponentModel.ISupportInitialize)dview_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandServicesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)view_prodetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private DataGridView dview_product;
        private TextBox txt_name;
        private TextBox txt_cost;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button btn_update;
        private Button btn_add;
        private Button btn_clear;
        private Button btn_delete;
        private ComboBox cbx_brand;
        private Label label7;
        private BindingSource brandServicesBindingSource;
        private TextBox txt_price;
        private Label label3;
        private TextBox txt_quantity;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cbx_Category;
        private ComboBox cbx_color;
        private ComboBox cbx_material;
        private ComboBox cbx_size;
        private DataGridView view_prodetail;
        private Button btn_add_pro_detail;
        private Button btn_update_pro_detail;
    }
}