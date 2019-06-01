namespace TTN_QLTV
{
    partial class frmDoiMatKhau
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_tdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_dmk = new System.Windows.Forms.Button();
            this.tbx_nlmatkhaumoi = new System.Windows.Forms.TextBox();
            this.tbx_matkhaumoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_matkhaucu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đổi Mật Khẩu";
            // 
            // tbx_tdn
            // 
            this.tbx_tdn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tdn.Location = new System.Drawing.Point(202, 64);
            this.tbx_tdn.Name = "tbx_tdn";
            this.tbx_tdn.Size = new System.Drawing.Size(196, 26);
            this.tbx_tdn.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên Đăng Nhập :";
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(256, 232);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(142, 30);
            this.btn_huy.TabIndex = 19;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_dmk
            // 
            this.btn_dmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dmk.Location = new System.Drawing.Point(113, 232);
            this.btn_dmk.Name = "btn_dmk";
            this.btn_dmk.Size = new System.Drawing.Size(93, 30);
            this.btn_dmk.TabIndex = 18;
            this.btn_dmk.Text = "Đổi";
            this.btn_dmk.UseVisualStyleBackColor = true;
            this.btn_dmk.Click += new System.EventHandler(this.btn_dmk_Click);
            // 
            // tbx_nlmatkhaumoi
            // 
            this.tbx_nlmatkhaumoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nlmatkhaumoi.Location = new System.Drawing.Point(202, 190);
            this.tbx_nlmatkhaumoi.Name = "tbx_nlmatkhaumoi";
            this.tbx_nlmatkhaumoi.Size = new System.Drawing.Size(197, 26);
            this.tbx_nlmatkhaumoi.TabIndex = 17;
            this.tbx_nlmatkhaumoi.UseSystemPasswordChar = true;
            // 
            // tbx_matkhaumoi
            // 
            this.tbx_matkhaumoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_matkhaumoi.Location = new System.Drawing.Point(202, 147);
            this.tbx_matkhaumoi.Name = "tbx_matkhaumoi";
            this.tbx_matkhaumoi.Size = new System.Drawing.Size(196, 26);
            this.tbx_matkhaumoi.TabIndex = 15;
            this.tbx_matkhaumoi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập Lại Mật Khẩu Mới :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật Khẩu Mới :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mật Khẩu Hiện Tại :";
            // 
            // tbx_matkhaucu
            // 
            this.tbx_matkhaucu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_matkhaucu.Location = new System.Drawing.Point(202, 106);
            this.tbx_matkhaucu.Name = "tbx_matkhaucu";
            this.tbx_matkhaucu.Size = new System.Drawing.Size(196, 26);
            this.tbx_matkhaucu.TabIndex = 21;
            this.tbx_matkhaucu.UseSystemPasswordChar = true;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.tbx_matkhaucu);
            this.Controls.Add(this.tbx_tdn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dmk);
            this.Controls.Add(this.tbx_nlmatkhaumoi);
            this.Controls.Add(this.tbx_matkhaumoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoiMatKhau_FormClosed);
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_tdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_dmk;
        private System.Windows.Forms.TextBox tbx_nlmatkhaumoi;
        private System.Windows.Forms.TextBox tbx_matkhaumoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_matkhaucu;
    }
}