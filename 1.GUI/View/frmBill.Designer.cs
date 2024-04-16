namespace _1.GUI.View
{
    partial class frmBill
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
            label1 = new Label();
            view_billdetail = new DataGridView();
            view_bill = new DataGridView();
            title_view_bill = new Label();
            label3 = new Label();
            cbx_status = new ComboBox();
            label4 = new Label();
            txt_phone = new TextBox();
            txt_customer_name = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_employess_name = new TextBox();
            btn_pay = new Button();
            txt_total = new TextBox();
            ((System.ComponentModel.ISupportInitialize)view_billdetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)view_bill).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 33);
            label1.Name = "label1";
            label1.Size = new Size(161, 46);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn";
            // 
            // view_billdetail
            // 
            view_billdetail.AllowUserToAddRows = false;
            view_billdetail.AllowUserToDeleteRows = false;
            view_billdetail.AllowUserToOrderColumns = true;
            view_billdetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view_billdetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view_billdetail.Location = new Point(2, 401);
            view_billdetail.Name = "view_billdetail";
            view_billdetail.RowHeadersWidth = 51;
            view_billdetail.RowTemplate.Height = 29;
            view_billdetail.Size = new Size(894, 322);
            view_billdetail.TabIndex = 1;
            // 
            // view_bill
            // 
            view_bill.AllowUserToAddRows = false;
            view_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            view_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view_bill.Location = new Point(2, 98);
            view_bill.Name = "view_bill";
            view_bill.RowHeadersWidth = 51;
            view_bill.RowTemplate.Height = 29;
            view_bill.Size = new Size(659, 228);
            view_bill.TabIndex = 2;
            view_bill.CellClick += view_bill_CellClick;
            // 
            // title_view_bill
            // 
            title_view_bill.AutoSize = true;
            title_view_bill.Location = new Point(2, 75);
            title_view_bill.Name = "title_view_bill";
            title_view_bill.Size = new Size(163, 20);
            title_view_bill.TabIndex = 4;
            title_view_bill.Text = "Hóa đơn đã thanh toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 378);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Hóa đơn chi tiết";
            // 
            // cbx_status
            // 
            cbx_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_status.FormattingEnabled = true;
            cbx_status.Items.AddRange(new object[] { "Chưa thanh toán ", "Đã thanh toán" });
            cbx_status.Location = new Point(667, 298);
            cbx_status.Name = "cbx_status";
            cbx_status.Size = new Size(216, 28);
            cbx_status.TabIndex = 6;
            cbx_status.SelectionChangeCommitted += cbx_status_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(667, 275);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(667, 235);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(221, 27);
            txt_phone.TabIndex = 8;
            txt_phone.KeyPress += txt_sdt_KeyPress;
            // 
            // txt_customer_name
            // 
            txt_customer_name.Enabled = false;
            txt_customer_name.Location = new Point(667, 174);
            txt_customer_name.Name = "txt_customer_name";
            txt_customer_name.ReadOnly = true;
            txt_customer_name.Size = new Size(221, 27);
            txt_customer_name.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(667, 212);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 10;
            label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(667, 151);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 11;
            label6.Text = "Tên khách hàng";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(667, 89);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 12;
            label7.Text = "Tên nhân viên";
            // 
            // txt_employess_name
            // 
            txt_employess_name.Enabled = false;
            txt_employess_name.Location = new Point(667, 112);
            txt_employess_name.Name = "txt_employess_name";
            txt_employess_name.ReadOnly = true;
            txt_employess_name.Size = new Size(221, 27);
            txt_employess_name.TabIndex = 13;
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(731, 739);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(157, 29);
            btn_pay.TabIndex = 14;
            btn_pay.Text = "Thanh toán";
            btn_pay.UseVisualStyleBackColor = true;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(456, 741);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(269, 27);
            txt_total.TabIndex = 15;
            // 
            // frmBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 833);
            ControlBox = false;
            Controls.Add(txt_total);
            Controls.Add(btn_pay);
            Controls.Add(txt_employess_name);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_customer_name);
            Controls.Add(txt_phone);
            Controls.Add(label4);
            Controls.Add(cbx_status);
            Controls.Add(label3);
            Controls.Add(title_view_bill);
            Controls.Add(view_bill);
            Controls.Add(view_billdetail);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBill";
            Text = "frmBill";
            ((System.ComponentModel.ISupportInitialize)view_billdetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)view_bill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView view_billdetail;
        private DataGridView view_bill;
        private Label title_view_bill;
        private Label label3;
        private ComboBox cbx_status;
        private Label label4;
        private TextBox txt_phone;
        private TextBox txt_customer_name;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_employess_name;
        private Button btn_pay;
        private TextBox txt_total;
    }
}