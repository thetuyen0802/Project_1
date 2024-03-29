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
            dview_listproduct = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dview_listproduct).BeginInit();
            SuspendLayout();
            // 
            // dview_listproduct
            // 
            dview_listproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dview_listproduct.Location = new Point(12, 123);
            dview_listproduct.Name = "dview_listproduct";
            dview_listproduct.RowHeadersWidth = 51;
            dview_listproduct.RowTemplate.Height = 29;
            dview_listproduct.Size = new Size(676, 315);
            dview_listproduct.TabIndex = 0;
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
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Danh sách sản phẩm";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(900, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dview_listproduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sales";
            Text = "a";
            ((System.ComponentModel.ISupportInitialize)dview_listproduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dview_listproduct;
        private Label label1;
        private Label label2;
    }
}