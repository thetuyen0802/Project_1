﻿namespace _1.GUI.View
{
    partial class frmEmployess
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
            label3 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            txt_name = new TextBox();
            txt_email = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txt_userid = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 46);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(893, 449);
            dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 129);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(418, 331);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 7;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += this.btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(635, 331);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(523, 122);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(292, 27);
            txt_name.TabIndex = 10;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(523, 184);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(295, 27);
            txt_email.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 191);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 13;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 144);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "UserId";
            // 
            // txt_userid
            // 
            txt_userid.Location = new Point(161, 144);
            txt_userid.Name = "txt_userid";
            txt_userid.Size = new Size(144, 27);
            txt_userid.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 93);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(144, 27);
            textBox2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 93);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 17;
            label5.Text = "Nhân viên ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đã nghỉ việc ", "Đang làm việc" });
            comboBox1.Location = new Point(161, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 28);
            comboBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 191);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 19;
            label6.Text = "Trạng thái";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(211, 331);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 20;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += this.btn_add_Click;
            // 
            // frmEmployess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 833);
            Controls.Add(btn_add);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(txt_userid);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmployess";
            Text = "frmNhanvien";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_name;
        private TextBox txt_email;
        private Label label4;
        private Label label2;
        private TextBox txt_userid;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Button btn_add;
    }
}