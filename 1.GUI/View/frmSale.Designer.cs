namespace _1.GUI.View
{
    partial class frmSale
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
            dview_bill = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            btn_findbyname = new Button();
            txt_findbyname = new TextBox();
            label10 = new Label();
            dview_product = new DataGridView();
            btn_clearfillter = new Button();
            label = new Label();
            cbx_color = new ComboBox();
            txt_soluong = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbx_material = new ComboBox();
            cbx_category = new ComboBox();
            cbx_size = new ComboBox();
            label2 = new Label();
            btn_add = new Button();
            dview_productdetail = new DataGridView();
            btn_save = new Button();
            btn_bora = new Button();
            btn_thanhtoan = new Button();
            label3 = new Label();
            txt_name = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_phone = new TextBox();
            txt_tongtien = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dview_bill).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dview_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dview_productdetail).BeginInit();
            SuspendLayout();
            // 
            // dview_bill
            // 
            dview_bill.AllowUserToAddRows = false;
            dview_bill.AllowUserToDeleteRows = false;
            dview_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dview_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_bill.Location = new Point(6, 99);
            dview_bill.Name = "dview_bill";
            dview_bill.RowHeadersWidth = 51;
            dview_bill.RowTemplate.Height = 29;
            dview_bill.Size = new Size(891, 242);
            dview_bill.TabIndex = 0;
            dview_bill.CellClick += dview_bill_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 1;
            label1.Text = "Bán Hàng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btn_findbyname);
            panel1.Controls.Add(txt_findbyname);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dview_product);
            panel1.Controls.Add(btn_clearfillter);
            panel1.Controls.Add(label);
            panel1.Controls.Add(cbx_color);
            panel1.Controls.Add(txt_soluong);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbx_material);
            panel1.Controls.Add(cbx_category);
            panel1.Controls.Add(cbx_size);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(dview_productdetail);
            panel1.Location = new Point(3, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 426);
            panel1.TabIndex = 2;
            // 
            // btn_findbyname
            // 
            btn_findbyname.Location = new Point(455, 60);
            btn_findbyname.Name = "btn_findbyname";
            btn_findbyname.Size = new Size(94, 29);
            btn_findbyname.TabIndex = 19;
            btn_findbyname.Text = "Tìm kiếm";
            btn_findbyname.UseVisualStyleBackColor = true;
            btn_findbyname.Click += btn_findbyname_Click;
            // 
            // txt_findbyname
            // 
            txt_findbyname.Location = new Point(455, 27);
            txt_findbyname.Name = "txt_findbyname";
            txt_findbyname.Size = new Size(275, 27);
            txt_findbyname.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 202);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 17;
            label10.Text = "Chi tiết sản phẩm";
            // 
            // dview_product
            // 
            dview_product.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_product.Location = new Point(3, 23);
            dview_product.Name = "dview_product";
            dview_product.RowHeadersWidth = 51;
            dview_product.RowTemplate.Height = 29;
            dview_product.Size = new Size(432, 168);
            dview_product.TabIndex = 16;
            dview_product.CellClick += dview_product_CellClick_1;
            // 
            // btn_clearfillter
            // 
            btn_clearfillter.Location = new Point(103, 383);
            btn_clearfillter.Name = "btn_clearfillter";
            btn_clearfillter.Size = new Size(94, 29);
            btn_clearfillter.TabIndex = 15;
            btn_clearfillter.Text = "Clear";
            btn_clearfillter.UseVisualStyleBackColor = true;
            btn_clearfillter.Click += btn_clearfillter_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(740, 243);
            label.Name = "label";
            label.Size = new Size(38, 20);
            label.TabIndex = 14;
            label.Text = "Màu";
            // 
            // cbx_color
            // 
            cbx_color.FormattingEnabled = true;
            cbx_color.Location = new Point(741, 266);
            cbx_color.Name = "cbx_color";
            cbx_color.Size = new Size(151, 28);
            cbx_color.TabIndex = 13;
            cbx_color.SelectionChangeCommitted += cbx_color_SelectionChangeCommitted;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(740, 330);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(151, 27);
            txt_soluong.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(741, 307);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 11;
            label9.Text = "Số lượng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(741, 171);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 10;
            label8.Text = "Size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(740, 102);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 9;
            label7.Text = "Chất liệu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(740, 34);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 8;
            label6.Text = "Loại";
            // 
            // cbx_material
            // 
            cbx_material.FormattingEnabled = true;
            cbx_material.Location = new Point(740, 125);
            cbx_material.Name = "cbx_material";
            cbx_material.Size = new Size(151, 28);
            cbx_material.TabIndex = 6;
            cbx_material.SelectionChangeCommitted += cbx_material_SelectionChangeCommitted;
            // 
            // cbx_category
            // 
            cbx_category.FormattingEnabled = true;
            cbx_category.Location = new Point(740, 57);
            cbx_category.Name = "cbx_category";
            cbx_category.Size = new Size(151, 28);
            cbx_category.TabIndex = 5;
            cbx_category.SelectionChangeCommitted += cbx_category_SelectionChangeCommitted;
            // 
            // cbx_size
            // 
            cbx_size.FormattingEnabled = true;
            cbx_size.Location = new Point(740, 194);
            cbx_size.Name = "cbx_size";
            cbx_size.Size = new Size(151, 28);
            cbx_size.TabIndex = 4;
            cbx_size.SelectionChangeCommitted += cbx_size_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 3;
            label2.Text = "Danh sách sản phẩm ";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(3, 383);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Thêm vào ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // dview_productdetail
            // 
            dview_productdetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_productdetail.Location = new Point(3, 224);
            dview_productdetail.Name = "dview_productdetail";
            dview_productdetail.RowHeadersWidth = 51;
            dview_productdetail.RowTemplate.Height = 29;
            dview_productdetail.Size = new Size(727, 153);
            dview_productdetail.TabIndex = 0;
            dview_productdetail.CellClick += dview_productdetail_CellClick;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(174, 349);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(120, 29);
            btn_save.TabIndex = 3;
            btn_save.Text = "Lưu hóa đơn";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_bora
            // 
            btn_bora.Location = new Point(3, 349);
            btn_bora.Name = "btn_bora";
            btn_bora.Size = new Size(120, 29);
            btn_bora.TabIndex = 4;
            btn_bora.Text = "Bỏ ra";
            btn_bora.UseVisualStyleBackColor = true;
            btn_bora.Click += btn_bora_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(768, 349);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(120, 29);
            btn_thanhtoan.TabIndex = 5;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 78);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "Hóa đơn chờ";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(334, 71);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(183, 27);
            txt_name.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 76);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 76);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 11;
            label5.Text = "Số điện thoại";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(700, 68);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(167, 27);
            txt_phone.TabIndex = 12;
            txt_phone.KeyPress += txt_phone_KeyPress;
            // 
            // txt_tongtien
            // 
            txt_tongtien.Location = new Point(521, 351);
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(241, 27);
            txt_tongtien.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(436, 354);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 14;
            label11.Text = "Tổng Tiền ";
            // 
            // frmSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 833);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(txt_tongtien);
            Controls.Add(txt_phone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(btn_thanhtoan);
            Controls.Add(btn_bora);
            Controls.Add(panel1);
            Controls.Add(btn_save);
            Controls.Add(label1);
            Controls.Add(dview_bill);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmSale";
            Text = "frmBanhang";
            Load += frmBanhang_Load;
            ((System.ComponentModel.ISupportInitialize)dview_bill).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dview_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)dview_productdetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dview_bill;
        private Label label1;
        private Panel panel1;
        private Button btn_bora;
        private Button btn_save;
        private Button btn_add;
        private DataGridView dview_productdetail;
        private Label label2;
        private Button btn_thanhtoan;
        private Label label3;
        private TextBox txt_name;
        private Label label4;
        private Label label5;
        private TextBox txt_phone;
        private TextBox txt_soluong;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbx_material;
        private ComboBox cbx_category;
        private ComboBox cbx_size;
        private Label label;
        private ComboBox cbx_color;
        private Button btn_clearfillter;
        private Label label10;
        private DataGridView dview_product;
        private Button btn_findbyname;
        private TextBox txt_findbyname;
        private TextBox txt_tongtien;
        private Label label11;
    }
}