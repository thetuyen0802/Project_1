namespace _1.GUI.View
{
    partial class Account_Employess
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
            txt_username = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_update = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(254, 61);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(329, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(254, 149);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(329, 27);
            txt_email.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(254, 245);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(329, 27);
            txt_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomRight;
            label1.Location = new Point(140, 68);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 156);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 252);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(254, 369);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 6;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // Account_Employess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 880);
            ControlBox = false;
            Controls.Add(btn_update);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account_Employess";
            Text = "Account_Employess";
            Load += Account_Employess_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_email;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_update;
    }
}