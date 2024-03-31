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
            dataView = new DataGridView();
            txt_username = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            cbx_chucvu = new ComboBox();
            panel1 = new Panel();
            btn_clear = new Button();
            btn_update = new Button();
            btn_add = new Button();
            txt_search = new TextBox();
            btn_search = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbt_status_1 = new RadioButton();
            rbt_status_0 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(4, 234);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 29;
            dataView.Size = new Size(894, 211);
            dataView.TabIndex = 0;
            dataView.CellClick += dataView_CellClick;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(107, 12);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(394, 27);
            txt_username.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(107, 56);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(394, 27);
            txt_email.TabIndex = 2;
            txt_email.TextChanged += textBox2_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(107, 100);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(394, 27);
            txt_password.TabIndex = 3;
            // 
            // cbx_chucvu
            // 
            cbx_chucvu.FormattingEnabled = true;
            cbx_chucvu.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            cbx_chucvu.Location = new Point(107, 140);
            cbx_chucvu.Name = "cbx_chucvu";
            cbx_chucvu.Size = new Size(132, 28);
            cbx_chucvu.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_add);
            panel1.Location = new Point(530, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 156);
            panel1.TabIndex = 6;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(237, 86);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 3;
            btn_clear.Text = "Clear Form";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(38, 86);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 1;
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(38, 20);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button2_Click;
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
            btn_search.Click += btn_search_Click;
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
            Controls.Add(cbx_chucvu);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_username);
            Controls.Add(dataView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account_Manager";
            Text = "Account_Manager";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataView;
        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_password;
        private ComboBox cbx_chucvu;
        private Panel panel1;
        private Button btn_clear;
        private Button btn_update;
        private Button btn_add;
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