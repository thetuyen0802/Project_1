namespace _1.GUI
{
    partial class Home
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
            panelContainer = new Panel();
            btn_product = new Button();
            btn_sales = new Button();
            btn_bill = new Button();
            btn_statistics = new Button();
            btn_account = new Button();
            btn_event = new Button();
            btn_exit = new Button();
            btn_logout = new Button();
            btn_customer = new Button();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Right;
            panelContainer.Location = new Point(155, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(900, 450);
            panelContainer.TabIndex = 2;
            // 
            // btn_product
            // 
            btn_product.Location = new Point(-3, 0);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(157, 53);
            btn_product.TabIndex = 3;
            btn_product.Text = "Sản Phẩm";
            btn_product.UseVisualStyleBackColor = true;
            btn_product.Click += btn_product_Click;
            // 
            // btn_sales
            // 
            btn_sales.Location = new Point(-3, 50);
            btn_sales.Name = "btn_sales";
            btn_sales.Size = new Size(157, 53);
            btn_sales.TabIndex = 4;
            btn_sales.Text = "Bán Hàng";
            btn_sales.UseVisualStyleBackColor = true;
            btn_sales.Click += btn_sales_Click;
            // 
            // btn_bill
            // 
            btn_bill.Location = new Point(-3, 100);
            btn_bill.Name = "btn_bill";
            btn_bill.Size = new Size(157, 53);
            btn_bill.TabIndex = 5;
            btn_bill.Text = "Hóa Đơn";
            btn_bill.UseVisualStyleBackColor = true;
            // 
            // btn_statistics
            // 
            btn_statistics.Location = new Point(-3, 199);
            btn_statistics.Name = "btn_statistics";
            btn_statistics.Size = new Size(157, 53);
            btn_statistics.TabIndex = 7;
            btn_statistics.Text = "Thống Kê";
            btn_statistics.UseVisualStyleBackColor = true;
            // 
            // btn_account
            // 
            btn_account.Location = new Point(-3, 327);
            btn_account.Name = "btn_account";
            btn_account.Size = new Size(157, 53);
            btn_account.TabIndex = 8;
            btn_account.Text = "Tài khoản";
            btn_account.UseVisualStyleBackColor = true;
            btn_account.Click += btn_account_Click;
            // 
            // btn_event
            // 
            btn_event.Location = new Point(-3, 249);
            btn_event.Name = "btn_event";
            btn_event.Size = new Size(157, 53);
            btn_event.TabIndex = 9;
            btn_event.Text = "Sự Kiện";
            btn_event.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Red;
            btn_exit.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.ForeColor = SystemColors.ControlLightLight;
            btn_exit.Location = new Point(-3, 421);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(157, 29);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Đóng";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += button1_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Red;
            btn_logout.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logout.ForeColor = SystemColors.ControlLightLight;
            btn_logout.Location = new Point(-3, 386);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(157, 29);
            btn_logout.TabIndex = 10;
            btn_logout.Text = "Đăng xuất";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // btn_customer
            // 
            btn_customer.Location = new Point(-3, 151);
            btn_customer.Name = "btn_customer";
            btn_customer.Size = new Size(157, 53);
            btn_customer.TabIndex = 11;
            btn_customer.Text = "Khách Hàng";
            btn_customer.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 450);
            ControlBox = false;
            Controls.Add(btn_customer);
            Controls.Add(btn_logout);
            Controls.Add(btn_event);
            Controls.Add(btn_account);
            Controls.Add(btn_statistics);
            Controls.Add(btn_exit);
            Controls.Add(btn_bill);
            Controls.Add(btn_sales);
            Controls.Add(btn_product);
            Controls.Add(panelContainer);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContainer;
        private Button btn_product;
        private Button btn_sales;
        private Button btn_bill;
        private Button btn_statistics;
        private Button btn_account;
        private Button btn_event;
        private Button btn_exit;
        private Button btn_logout;
        private Button btn_customer;
    }
}