namespace _1.GUI.View
{
    partial class frmCustomer
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
            dataGridView1 = new DataGridView();
            txt_name = new TextBox();
            txt_sdt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_them = new Button();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(341, 50);
            label1.Name = "label1";
            label1.Size = new Size(205, 46);
            label1.TabIndex = 0;
            label1.Text = "Khách hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(876, 509);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(148, 116);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(290, 27);
            txt_name.TabIndex = 2;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(148, 167);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(290, 27);
            txt_sdt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 123);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 174);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 6;
            label3.Text = "Sđt";
            // 
            // btn_them
            // 
            btn_them.Location = new Point(148, 216);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(344, 216);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 8;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(882, 765);
            ControlBox = false;
            Controls.Add(btn_update);
            Controls.Add(btn_them);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_sdt);
            Controls.Add(txt_name);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomer";
            Text = "frmCustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txt_name;
        private TextBox txt_sdt;
        private Label label2;
        private Label label3;
        private Button btn_them;
        private Button btn_update;
    }
}