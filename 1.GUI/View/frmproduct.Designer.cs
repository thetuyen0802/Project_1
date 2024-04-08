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
            txt_id = new TextBox();
            dview_product = new DataGridView();
            txt_quantity = new TextBox();
            txt_name = new TextBox();
            txt_cost = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_update = new Button();
            btn_add = new Button();
            btn_clear = new Button();
            btn_delete = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            cbx_brand = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dview_product).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(146, 167);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(247, 27);
            txt_id.TabIndex = 0;
            // 
            // dview_product
            // 
            dview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_product.Location = new Point(1, 454);
            dview_product.Name = "dview_product";
            dview_product.RowHeadersWidth = 51;
            dview_product.RowTemplate.Height = 29;
            dview_product.Size = new Size(898, 377);
            dview_product.TabIndex = 1;
            dview_product.CellClick += dview_product_CellClick;
            dview_product.CellContentClick += dview_product_CellContentClick;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(146, 280);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(247, 27);
            txt_quantity.TabIndex = 2;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(146, 216);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(247, 27);
            txt_name.TabIndex = 3;
            // 
            // txt_cost
            // 
            txt_cost.Location = new Point(540, 219);
            txt_cost.Name = "txt_cost";
            txt_cost.Size = new Size(247, 27);
            txt_cost.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 174);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 226);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 287);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 226);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 11;
            label4.Text = "Giá";
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
            btn_update.Location = new Point(305, 382);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(88, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(146, 382);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(88, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(587, 382);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(88, 29);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click_1;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(433, 382);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ngừng kinh doanh", "Còn hàng", "Hết hàng" });
            comboBox1.Location = new Point(540, 279);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 28);
            comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 287);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 16;
            label6.Text = "Tình trạng";
            // 
            // cbx_brand
            // 
            cbx_brand.FormattingEnabled = true;
            cbx_brand.Location = new Point(540, 166);
            cbx_brand.Name = "cbx_brand";
            cbx_brand.Size = new Size(217, 28);
            cbx_brand.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(442, 170);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 18;
            label7.Text = "Thương hiệu";
            // 
            // frmproduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 833);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(cbx_brand);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(btn_delete);
            Controls.Add(btn_clear);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_cost);
            Controls.Add(txt_name);
            Controls.Add(txt_quantity);
            Controls.Add(dview_product);
            Controls.Add(txt_id);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmproduct";
            Text = " b";
            Load += frmproduct_Load;
            ((System.ComponentModel.ISupportInitialize)dview_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_id;
        private DataGridView dview_product;
        private TextBox txt_quantity;
        private TextBox txt_name;
        private TextBox txt_cost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_update;
        private Button btn_add;
        private Button btn_clear;
        private Button btn_delete;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox cbx_brand;
        private Label label7;
    }
}