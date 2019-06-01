namespace QuanLyKhoHang
{
    partial class FrmDoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoimatkhau));
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.tbx_tdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_dmk = new System.Windows.Forms.Button();
            this.tbx_nlmatkhaumoi = new System.Windows.Forms.TextBox();
            this.tbx_matkhaumoi = new System.Windows.Forms.TextBox();
            this.tbx_matkhaucu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(-1, 5);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(65, 35);
            this.btn_quaylai.TabIndex = 26;
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // tbx_tdn
            // 
            this.tbx_tdn.Location = new System.Drawing.Point(171, 67);
            this.tbx_tdn.Name = "tbx_tdn";
            this.tbx_tdn.Size = new System.Drawing.Size(144, 20);
            this.tbx_tdn.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên Đăng Nhập";
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(192, 235);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(93, 30);
            this.btn_huy.TabIndex = 24;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // btn_dmk
            // 
            this.btn_dmk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dmk.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dmk.Location = new System.Drawing.Point(84, 235);
            this.btn_dmk.Name = "btn_dmk";
            this.btn_dmk.Size = new System.Drawing.Size(93, 30);
            this.btn_dmk.TabIndex = 23;
            this.btn_dmk.Text = "Đổi";
            this.btn_dmk.UseVisualStyleBackColor = false;
            this.btn_dmk.Click += new System.EventHandler(this.btn_dmk_Click_1);
            // 
            // tbx_nlmatkhaumoi
            // 
            this.tbx_nlmatkhaumoi.Location = new System.Drawing.Point(171, 193);
            this.tbx_nlmatkhaumoi.Name = "tbx_nlmatkhaumoi";
            this.tbx_nlmatkhaumoi.Size = new System.Drawing.Size(144, 20);
            this.tbx_nlmatkhaumoi.TabIndex = 22;
            this.tbx_nlmatkhaumoi.UseSystemPasswordChar = true;
            // 
            // tbx_matkhaumoi
            // 
            this.tbx_matkhaumoi.Location = new System.Drawing.Point(171, 150);
            this.tbx_matkhaumoi.Name = "tbx_matkhaumoi";
            this.tbx_matkhaumoi.Size = new System.Drawing.Size(144, 20);
            this.tbx_matkhaumoi.TabIndex = 20;
            this.tbx_matkhaumoi.UseSystemPasswordChar = true;
            // 
            // tbx_matkhaucu
            // 
            this.tbx_matkhaucu.Location = new System.Drawing.Point(171, 109);
            this.tbx_matkhaucu.Name = "tbx_matkhaucu";
            this.tbx_matkhaucu.Size = new System.Drawing.Size(144, 20);
            this.tbx_matkhaucu.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nhập lại MK mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mật khẩu hiện Tại";
            // 
            // FrmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(351, 276);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.tbx_tdn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dmk);
            this.Controls.Add(this.tbx_nlmatkhaumoi);
            this.Controls.Add(this.tbx_matkhaumoi);
            this.Controls.Add(this.tbx_matkhaucu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.Doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.TextBox tbx_tdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_dmk;
        private System.Windows.Forms.TextBox tbx_nlmatkhaumoi;
        private System.Windows.Forms.TextBox tbx_matkhaumoi;
        private System.Windows.Forms.TextBox tbx_matkhaucu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}