namespace _1.GUI.View
{
    partial class frmProInfor
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            btn_updatebrand = new Button();
            btn_addbrand = new Button();
            txt_brandname = new TextBox();
            panel2 = new Panel();
            btn_addcategory = new Button();
            txt_categoty = new TextBox();
            panel3 = new Panel();
            btn_addmaterial = new Button();
            txt_material = new TextBox();
            panel4 = new Panel();
            btn_addcolor = new Button();
            txt_color = new TextBox();
            panel5 = new Panel();
            btn_addsize = new Button();
            txt_size = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            dataGridView5 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên thương hiệu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Màu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 22);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên chất liệu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 22);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên loại sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 18);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Tên cỡ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(232, 9);
            label6.Name = "label6";
            label6.Size = new Size(347, 46);
            label6.TabIndex = 5;
            label6.Text = "Thông tin sản phẩm ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btn_updatebrand);
            panel1.Controls.Add(btn_addbrand);
            panel1.Controls.Add(txt_brandname);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 6;
            // 
            // btn_updatebrand
            // 
            btn_updatebrand.Location = new Point(126, 93);
            btn_updatebrand.Name = "btn_updatebrand";
            btn_updatebrand.Size = new Size(94, 29);
            btn_updatebrand.TabIndex = 3;
            btn_updatebrand.Text = "Sửa";
            btn_updatebrand.UseVisualStyleBackColor = true;
            btn_updatebrand.Click += btn_updatebrand_Click;
            // 
            // btn_addbrand
            // 
            btn_addbrand.Location = new Point(23, 93);
            btn_addbrand.Name = "btn_addbrand";
            btn_addbrand.Size = new Size(94, 29);
            btn_addbrand.TabIndex = 2;
            btn_addbrand.Text = "Thêm";
            btn_addbrand.UseVisualStyleBackColor = true;
            btn_addbrand.Click += btn_addbrand_Click;
            // 
            // txt_brandname
            // 
            txt_brandname.Location = new Point(21, 51);
            txt_brandname.Name = "txt_brandname";
            txt_brandname.Size = new Size(189, 27);
            txt_brandname.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btn_addcategory);
            panel2.Controls.Add(txt_categoty);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(31, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 7;
            // 
            // btn_addcategory
            // 
            btn_addcategory.Location = new Point(26, 93);
            btn_addcategory.Name = "btn_addcategory";
            btn_addcategory.Size = new Size(94, 29);
            btn_addcategory.TabIndex = 5;
            btn_addcategory.Text = "Thêm";
            btn_addcategory.UseVisualStyleBackColor = true;
            btn_addcategory.Click += btn_addcategory_Click;
            // 
            // txt_categoty
            // 
            txt_categoty.Location = new Point(26, 51);
            txt_categoty.Name = "txt_categoty";
            txt_categoty.Size = new Size(190, 27);
            txt_categoty.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btn_addmaterial);
            panel3.Controls.Add(txt_material);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(31, 386);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 8;
            // 
            // btn_addmaterial
            // 
            btn_addmaterial.Location = new Point(24, 93);
            btn_addmaterial.Name = "btn_addmaterial";
            btn_addmaterial.Size = new Size(94, 29);
            btn_addmaterial.TabIndex = 4;
            btn_addmaterial.Text = "Thêm";
            btn_addmaterial.UseVisualStyleBackColor = true;
            btn_addmaterial.Click += btn_addmaterial_Click;
            // 
            // txt_material
            // 
            txt_material.Location = new Point(24, 54);
            txt_material.Name = "txt_material";
            txt_material.Size = new Size(196, 27);
            txt_material.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(btn_addcolor);
            panel4.Controls.Add(txt_color);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(31, 533);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 9;
            // 
            // btn_addcolor
            // 
            btn_addcolor.Location = new Point(23, 93);
            btn_addcolor.Name = "btn_addcolor";
            btn_addcolor.Size = new Size(94, 29);
            btn_addcolor.TabIndex = 3;
            btn_addcolor.Text = "Thêm";
            btn_addcolor.UseVisualStyleBackColor = true;
            btn_addcolor.Click += btn_addcolor_Click;
            // 
            // txt_color
            // 
            txt_color.Location = new Point(23, 46);
            txt_color.Name = "txt_color";
            txt_color.Size = new Size(187, 27);
            txt_color.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(btn_addsize);
            panel5.Controls.Add(txt_size);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(31, 681);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 10;
            // 
            // btn_addsize
            // 
            btn_addsize.Location = new Point(22, 93);
            btn_addsize.Name = "btn_addsize";
            btn_addsize.Size = new Size(94, 29);
            btn_addsize.TabIndex = 6;
            btn_addsize.Text = "Thêm";
            btn_addsize.UseVisualStyleBackColor = true;
            btn_addsize.Click += btn_addsize_Click;
            // 
            // txt_size
            // 
            txt_size.Location = new Point(22, 47);
            txt_size.Name = "txt_size";
            txt_size.Size = new Size(194, 27);
            txt_size.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(334, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(374, 122);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(334, 242);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(374, 122);
            dataGridView2.TabIndex = 12;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(334, 386);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(374, 125);
            dataGridView3.TabIndex = 13;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(334, 537);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(374, 123);
            dataGridView4.TabIndex = 14;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(334, 686);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 29;
            dataGridView5.Size = new Size(374, 125);
            dataGridView5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 75);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 16;
            label7.Text = "Danh sách thương hiệu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 222);
            label8.Name = "label8";
            label8.Size = new Size(174, 20);
            label8.TabIndex = 17;
            label8.Text = "Danh sách loại sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 366);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 18;
            label9.Text = "Danh sách chất liệu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(334, 514);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 19;
            label10.Text = "Danh sách màu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(335, 663);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 20;
            label11.Text = "Danh sách cỡ";
            // 
            // frmProInfor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 830);
            ControlBox = false;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dataGridView5);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProInfor";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button btn_addbrand;
        private TextBox txt_brandname;
        private Button btn_addcategory;
        private TextBox txt_categoty;
        private TextBox txt_material;
        private TextBox txt_color;
        private TextBox txt_size;
        private Button btn_addmaterial;
        private Button btn_addcolor;
        private Button btn_addsize;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btn_updatebrand;
    }
}