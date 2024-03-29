namespace _1.GUI
{
    partial class F_product
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
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dview_product).BeginInit();
            SuspendLayout();
            // 
            // txt_id
            // 
            txt_id.Location = new Point(146, 167);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(247, 27);
            txt_id.TabIndex = 0;
            // 
            // dview_product
            // 
            dview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_product.Location = new Point(416, 12);
            dview_product.Name = "dview_product";
            dview_product.RowHeadersWidth = 51;
            dview_product.RowTemplate.Height = 29;
            dview_product.Size = new Size(472, 426);
            dview_product.TabIndex = 1;
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(146, 272);
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
            txt_cost.Location = new Point(146, 317);
            txt_cost.Name = "txt_cost";
            txt_cost.Size = new Size(247, 27);
            txt_cost.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(3, 389);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(84, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Thêm ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(103, 389);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(88, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(214, 389);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(83, 29);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
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
            // btn_clear
            // 
            btn_clear.Location = new Point(316, 389);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 13;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click_1;
            // 
            // F_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 450);
            ControlBox = false;
            Controls.Add(btn_clear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_cost);
            Controls.Add(txt_name);
            Controls.Add(txt_quantity);
            Controls.Add(dview_product);
            Controls.Add(txt_id);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_product";
            Text = "Producct";
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
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
       
    }
}