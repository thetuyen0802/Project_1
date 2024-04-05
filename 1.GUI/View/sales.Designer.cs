namespace _1.GUI.View
{
    partial class Sales
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
            label2 = new Label();
            panel1 = new Panel();
            btn_search = new Button();
            txt_search = new TextBox();
            btn_producdetail = new Button();
            button3 = new Button();
            label3 = new Label();
            dview_product = new DataGridView();
            btn_savebill = new Button();
            btn_paymentbill = new Button();
            btn_deletefrbill = new Button();
            ((System.ComponentModel.ISupportInitialize)dview_bill).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dview_product).BeginInit();
            SuspendLayout();
            // 
            // dview_bill
            // 
            dview_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_bill.Location = new Point(3, 104);
            dview_bill.Name = "dview_bill";
            dview_bill.RowHeadersWidth = 51;
            dview_bill.RowTemplate.Height = 29;
            dview_bill.Size = new Size(894, 284);
            dview_bill.TabIndex = 0;
            dview_bill.CellContentClick += dview_bill_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 1;
            label1.Text = "Bán Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 2;
            label2.Text = "Hóa đơn chờ";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(btn_producdetail);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dview_product);
            panel1.Location = new Point(3, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(894, 390);
            panel1.TabIndex = 4;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(37, 19);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 9;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(152, 19);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(733, 27);
            txt_search.TabIndex = 8;
            // 
            // btn_producdetail
            // 
            btn_producdetail.Location = new Point(696, 351);
            btn_producdetail.Name = "btn_producdetail";
            btn_producdetail.Size = new Size(160, 29);
            btn_producdetail.TabIndex = 7;
            btn_producdetail.Text = "Xem chi tiết";
            btn_producdetail.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(696, 292);
            button3.Name = "button3";
            button3.Size = new Size(160, 29);
            button3.TabIndex = 6;
            button3.Text = "Thêm vào hóa đơn";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 79);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 5;
            label3.Text = "Danh sách sản phẩm";
            // 
            // dview_product
            // 
            dview_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_product.Location = new Point(3, 102);
            dview_product.Name = "dview_product";
            dview_product.RowHeadersWidth = 51;
            dview_product.RowTemplate.Height = 29;
            dview_product.Size = new Size(687, 285);
            dview_product.TabIndex = 0;
            dview_product.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_savebill
            // 
            btn_savebill.Location = new Point(356, 420);
            btn_savebill.Name = "btn_savebill";
            btn_savebill.Size = new Size(147, 29);
            btn_savebill.TabIndex = 5;
            btn_savebill.Text = "Lưu hóa đơn";
            btn_savebill.UseVisualStyleBackColor = true;
            // 
            // btn_paymentbill
            // 
            btn_paymentbill.Location = new Point(598, 420);
            btn_paymentbill.Name = "btn_paymentbill";
            btn_paymentbill.Size = new Size(147, 29);
            btn_paymentbill.TabIndex = 6;
            btn_paymentbill.Text = "Thanh toán";
            btn_paymentbill.UseVisualStyleBackColor = true;
            // 
            // btn_deletefrbill
            // 
            btn_deletefrbill.Location = new Point(124, 420);
            btn_deletefrbill.Name = "btn_deletefrbill";
            btn_deletefrbill.Size = new Size(147, 29);
            btn_deletefrbill.TabIndex = 7;
            btn_deletefrbill.Text = "Xóa khỏi hóa đơn";
            btn_deletefrbill.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 880);
            ControlBox = false;
            Controls.Add(btn_deletefrbill);
            Controls.Add(btn_paymentbill);
            Controls.Add(btn_savebill);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dview_bill);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "a";
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
        private Label label2;
        private Panel panel1;
        private Label label3;
        private DataGridView dview_product;
        private Button btn_producdetail;
        private Button button3;
        private Button btn_savebill;
        private Button btn_paymentbill;
        private Button btn_deletefrbill;
        private Button btn_search;
        private TextBox txt_search;
    }
}