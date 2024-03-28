namespace _1.GUI.View
{
    partial class Account_Manager
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            panel1 = new Panel();
            txt_search = new TextBox();
            btn_search = new Button();
            button2 = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbt_status_1 = new RadioButton();
            rbt_status_0 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(894, 211);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(394, 27);
            textBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(107, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(132, 28);
            comboBox2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(530, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 156);
            panel1.TabIndex = 6;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(40, 201);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(694, 27);
            txt_search.TabIndex = 7;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(767, 201);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 8;
            btn_search.Text = "Tìm Kiếm";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(38, 20);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "Thêm ";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(38, 86);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 1;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(237, 27);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(237, 86);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Clear Form";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 9;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 144);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 148);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 13;
            label5.Text = "Trạng thái :";
            // 
            // rbt_status_1
            // 
            rbt_status_1.AutoSize = true;
            rbt_status_1.Location = new Point(369, 146);
            rbt_status_1.Name = "rbt_status_1";
            rbt_status_1.Size = new Size(102, 24);
            rbt_status_1.TabIndex = 14;
            rbt_status_1.TabStop = true;
            rbt_status_1.Text = "Hoạt động";
            rbt_status_1.UseVisualStyleBackColor = true;
            // 
            // rbt_status_0
            // 
            rbt_status_0.AutoSize = true;
            rbt_status_0.Location = new Point(369, 176);
            rbt_status_0.Name = "rbt_status_0";
            rbt_status_0.Size = new Size(146, 24);
            rbt_status_0.TabIndex = 15;
            rbt_status_0.TabStop = true;
            rbt_status_0.Text = "Không hoạt động";
            rbt_status_0.UseVisualStyleBackColor = true;
            // 
            // Account_Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 450);
            ControlBox = false;
            Controls.Add(rbt_status_0);
            Controls.Add(rbt_status_1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account_Manager";
            Text = "Account_Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private Panel panel1;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_update;
        private Button button2;
        private TextBox txt_search;
        private Button btn_search;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton rbt_status_1;
        private RadioButton rbt_status_0;
    }
}