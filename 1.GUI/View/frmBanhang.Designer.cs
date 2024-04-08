namespace _1.GUI.View
{
    partial class frmBanhang
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
            dview_product = new DataGridView();
            btn_save = new Button();
            btn_bora = new Button();
            btn_thanhtoan = new Button();
            btn_delete = new Button();
            label3 = new Label();
            btn_thaydoi = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_phone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dview_bill).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dview_product).BeginInit();
            SuspendLayout();
            // 
            // dview_bill
            // 
            dview_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_bill.Location = new Point(3, 101);
            dview_bill.Name = "dview_bill";
            dview_bill.RowHeadersWidth = 51;
            dview_bill.RowTemplate.Height = 29;
            dview_bill.Size = new Size(894, 242);
            dview_bill.TabIndex = 0;
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
            panel1.Controls.Add(dview_product);
            panel1.Location = new Point(3, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 412);
            panel1.TabIndex = 2;
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
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(740, 320);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(151, 27);
            txt_soluong.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(741, 297);
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
            // 
            // cbx_category
            // 
            cbx_category.FormattingEnabled = true;
            cbx_category.Location = new Point(740, 57);
            cbx_category.Name = "cbx_category";
            cbx_category.Size = new Size(151, 28);
            cbx_category.TabIndex = 5;
            // 
            // cbx_size
            // 
            cbx_size.FormattingEnabled = true;
            cbx_size.Location = new Point(740, 194);
            cbx_size.Name = "cbx_size";
            cbx_size.Size = new Size(151, 28);
            cbx_size.TabIndex = 4;
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
            btn_add.Location = new Point(9, 358);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 1;
            btn_add.Text = "Thêm vào ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // dview_product
            // 
            dview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_product.Location = new Point(3, 23);
            dview_product.Name = "dview_product";
            dview_product.RowHeadersWidth = 51;
            dview_product.RowTemplate.Height = 29;
            dview_product.Size = new Size(727, 306);
            dview_product.TabIndex = 0;
            dview_product.CellClick += dview_product_CellClick;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(574, 349);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(120, 29);
            btn_save.TabIndex = 3;
            btn_save.Text = "Lưu hóa đơn";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_bora
            // 
            btn_bora.Location = new Point(223, 349);
            btn_bora.Name = "btn_bora";
            btn_bora.Size = new Size(120, 29);
            btn_bora.TabIndex = 4;
            btn_bora.Text = "Bỏ ra";
            btn_bora.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(747, 349);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(120, 29);
            btn_thanhtoan.TabIndex = 5;
            btn_thanhtoan.Text = "Thanh toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(45, 349);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 29);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
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
            // btn_thaydoi
            // 
            btn_thaydoi.Location = new Point(397, 349);
            btn_thaydoi.Name = "btn_thaydoi";
            btn_thaydoi.Size = new Size(120, 29);
            btn_thaydoi.TabIndex = 8;
            btn_thaydoi.Text = "Thay đổi";
            btn_thaydoi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 9;
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
            txt_phone.Text = "Sđt khách hàng";
            // 
            // frmBanhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 833);
            ControlBox = false;
            Controls.Add(txt_phone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(btn_thaydoi);
            Controls.Add(label3);
            Controls.Add(btn_delete);
            Controls.Add(btn_thanhtoan);
            Controls.Add(btn_bora);
            Controls.Add(panel1);
            Controls.Add(btn_save);
            Controls.Add(label1);
            Controls.Add(dview_bill);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmBanhang";
            Text = "frmBanhang";
            Load += frmBanhang_Load;
            ((System.ComponentModel.ISupportInitialize)dview_bill).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dview_product).EndInit();
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
        private DataGridView dview_product;
        private Label label2;
        private Button btn_thanhtoan;
        private Button btn_delete;
        private Label label3;
        private Button btn_thaydoi;
        private TextBox textBox1;
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
    }
}