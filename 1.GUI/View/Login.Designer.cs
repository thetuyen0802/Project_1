namespace _1.GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_password = new TextBox();
            txt_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            label3 = new Label();
            rbt_showpass = new RadioButton();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(258, 215);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(377, 27);
            txt_password.TabIndex = 0;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(258, 119);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(377, 27);
            txt_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 122);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 218);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(349, 297);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(138, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(349, 29);
            label3.Name = "label3";
            label3.Size = new Size(138, 35);
            label3.TabIndex = 6;
            label3.Text = "Đăng nhập";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // rbt_showpass
            // 
            rbt_showpass.AutoCheck = false;
            rbt_showpass.AutoSize = true;
            rbt_showpass.Location = new Point(258, 257);
            rbt_showpass.Name = "rbt_showpass";
            rbt_showpass.Size = new Size(129, 24);
            rbt_showpass.TabIndex = 8;
            rbt_showpass.TabStop = true;
            rbt_showpass.Text = "Xem mật khẩu ";
            rbt_showpass.UseVisualStyleBackColor = true;
            rbt_showpass.CheckedChanged += rbt_showpass_CheckedChanged;
            rbt_showpass.Click += rbt_showpass_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbt_showpass);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Controls.Add(txt_password);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_password;
        private TextBox txt_username;
        private Label label1;
        private Label label2;
        private Button btn_login;
        private Label label3;
        private RadioButton rbt_showpass;
    }
}
