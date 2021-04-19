namespace BTLHSK
{
    partial class DangNhap
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
            this.taiKhoan = new System.Windows.Forms.TextBox();
            this.matKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taiKhoan
            // 
            this.taiKhoan.Location = new System.Drawing.Point(35, 61);
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.Size = new System.Drawing.Size(229, 22);
            this.taiKhoan.TabIndex = 0;
            this.taiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginBtn_KeyPress);
            // 
            // matKhau
            // 
            this.matKhau.Location = new System.Drawing.Point(35, 131);
            this.matKhau.MaxLength = 30;
            this.matKhau.Name = "matKhau";
            this.matKhau.PasswordChar = '*';
            this.matKhau.Size = new System.Drawing.Size(229, 22);
            this.matKhau.TabIndex = 1;
            this.matKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginBtn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.Location = new System.Drawing.Point(141, 281);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(109, 45);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matKhau);
            this.groupBox1.Controls.Add(this.taiKhoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form đăng nhập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taiKhoan;
        private System.Windows.Forms.TextBox matKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}