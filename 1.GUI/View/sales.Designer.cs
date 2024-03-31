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
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dview_bill).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dview_bill
            // 
            dview_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_bill.Location = new Point(12, 104);
            dview_bill.Name = "dview_bill";
            dview_bill.RowHeadersWidth = 51;
            dview_bill.RowTemplate.Height = 29;
            dview_bill.Size = new Size(876, 284);
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
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Hóa đơn";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 324);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(628, 285);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 13);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 5;
            label3.Text = "Danh sách sản phẩm";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 876);
            ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dview_bill;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private DataGridView dataGridView1;
    }
}