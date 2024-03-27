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
            btn_register = new Button();
            label3 = new Label();
            btn_fogot_pass = new Button();
            SuspendLayout();
            // 
            // txt_password
            // 
            txt_password.Location = new Point(258, 215);
            txt_password.Name = "txt_password";
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
            btn_login.Location = new Point(258, 275);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(381, 275);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(106, 29);
            btn_register.TabIndex = 5;
            btn_register.Text = "Đăng ký";
            btn_register.UseVisualStyleBackColor = true;
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
            // btn_fogot_pass
            // 
            btn_fogot_pass.Location = new Point(517, 275);
            btn_fogot_pass.Name = "btn_fogot_pass";
            btn_fogot_pass.Size = new Size(118, 29);
            btn_fogot_pass.TabIndex = 7;
            btn_fogot_pass.Text = "Quên mật khẩu";
            btn_fogot_pass.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_fogot_pass);
            Controls.Add(label3);
            Controls.Add(btn_register);
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
        private Button btn_register;
        private Label label3;
        private Button btn_fogot_pass;
    }
}
