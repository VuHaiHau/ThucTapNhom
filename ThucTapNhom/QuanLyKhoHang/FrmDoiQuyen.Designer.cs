﻿namespace QuanLyKhoHang
{
    partial class FrmDoiQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiQuyen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_tdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_dq = new System.Windows.Forms.Button();
            this.tbx_quyencu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.tbx_quyenmoi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 111);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chú ý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "nếu đổi quyền cho tài khoản khác!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "- Tên Đăng Nhập không thể bỏ trống";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "đổi quyền cho chính bản thân!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "- Tên Đăng Nhập có thể bỏ trống nếu ";
            // 
            // tbx_tdn
            // 
            this.tbx_tdn.Location = new System.Drawing.Point(150, 65);
            this.tbx_tdn.Name = "tbx_tdn";
            this.tbx_tdn.Size = new System.Drawing.Size(196, 20);
            this.tbx_tdn.TabIndex = 25;
            this.tbx_tdn.TextChanged += new System.EventHandler(this.tbx_tdn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tên Đăng Nhập";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(244, 192);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(93, 30);
            this.btn_huy.TabIndex = 29;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // btn_dq
            // 
            this.btn_dq.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dq.Location = new System.Drawing.Point(130, 192);
            this.btn_dq.Name = "btn_dq";
            this.btn_dq.Size = new System.Drawing.Size(93, 30);
            this.btn_dq.TabIndex = 28;
            this.btn_dq.Text = "Đổi";
            this.btn_dq.UseVisualStyleBackColor = false;
            this.btn_dq.Click += new System.EventHandler(this.btn_dq_Click_1);
            // 
            // tbx_quyencu
            // 
            this.tbx_quyencu.Location = new System.Drawing.Point(150, 107);
            this.tbx_quyencu.Name = "tbx_quyencu";
            this.tbx_quyencu.Size = new System.Drawing.Size(196, 20);
            this.tbx_quyencu.TabIndex = 27;
            this.tbx_quyencu.TextChanged += new System.EventHandler(this.tbx_quyencu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quyền mới";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quyền hiện Tại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "NÂNG CẤP QUYỀN NHÂN VIÊN";
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(4, 12);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(52, 34);
            this.btn_quaylai.TabIndex = 33;
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // tbx_quyenmoi
            // 
            this.tbx_quyenmoi.Location = new System.Drawing.Point(150, 148);
            this.tbx_quyenmoi.Name = "tbx_quyenmoi";
            this.tbx_quyenmoi.Size = new System.Drawing.Size(196, 20);
            this.tbx_quyenmoi.TabIndex = 32;
            this.tbx_quyenmoi.TextChanged += new System.EventHandler(this.tbx_quyenmoi_TextChanged);
            // 
            // FrmDoiQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 358);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbx_tdn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dq);
            this.Controls.Add(this.tbx_quyencu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.tbx_quyenmoi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoiQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.Load += new System.EventHandler(this.DoiQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_tdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_dq;
        private System.Windows.Forms.TextBox tbx_quyencu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.TextBox tbx_quyenmoi;
    }
}