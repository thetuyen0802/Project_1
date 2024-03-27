namespace _1.GUI
{
    partial class Product
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
            textBox1 = new TextBox();
            DTview_product = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTview_product).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 0;
            // 
            // DTview_product
            // 
            DTview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTview_product.Location = new Point(416, 12);
            DTview_product.Name = "DTview_product";
            DTview_product.RowHeadersWidth = 51;
            DTview_product.RowTemplate.Height = 29;
            DTview_product.Size = new Size(472, 426);
            DTview_product.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 272);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(247, 27);
            textBox4.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(22, 389);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm ";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(163, 389);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(299, 389);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 167);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 223);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 279);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 324);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 11;
            label4.Text = "Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(114, 28);
            label5.Name = "label5";
            label5.Size = new Size(194, 50);
            label5.TabIndex = 12;
            label5.Text = "Sản Phẩm";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 450);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(DTview_product);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            Text = "Producct";
            ((System.ComponentModel.ISupportInitialize)DTview_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView DTview_product;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}