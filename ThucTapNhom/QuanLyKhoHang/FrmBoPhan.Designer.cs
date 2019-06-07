namespace QuanLyKhoHang
{
    partial class FrmBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoPhan));
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_BoPhan = new System.Windows.Forms.DataGridView();
            this.tbx_MaKho = new System.Windows.Forms.ComboBox();
            this.tbx_NQL = new System.Windows.Forms.ComboBox();
            this.tbx_TenBP = new System.Windows.Forms.TextBox();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.tbx_Dienthoai = new System.Windows.Forms.TextBox();
            this.tbx_MaBP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoPhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_timkiem.Location = new System.Drawing.Point(104, 35);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(743, 26);
            this.tbx_timkiem.TabIndex = 11;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_tk_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_BoPhan);
            this.groupBox2.Controls.Add(this.tbx_timkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 267);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bộ Phận";
            // 
            // dgv_BoPhan
            // 
            this.dgv_BoPhan.AllowUserToAddRows = false;
            this.dgv_BoPhan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_BoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BoPhan.Location = new System.Drawing.Point(6, 82);
            this.dgv_BoPhan.Name = "dgv_BoPhan";
            this.dgv_BoPhan.RowHeadersVisible = false;
            this.dgv_BoPhan.Size = new System.Drawing.Size(841, 178);
            this.dgv_BoPhan.TabIndex = 12;
            this.dgv_BoPhan.TabStop = false;
            this.dgv_BoPhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BoPhan_CellContentClick);
            // 
            // tbx_MaKho
            // 
            this.tbx_MaKho.FormattingEnabled = true;
            this.tbx_MaKho.Location = new System.Drawing.Point(297, 66);
            this.tbx_MaKho.Name = "tbx_MaKho";
            this.tbx_MaKho.Size = new System.Drawing.Size(266, 27);
            this.tbx_MaKho.TabIndex = 4;
            // 
            // tbx_NQL
            // 
            this.tbx_NQL.FormattingEnabled = true;
            this.tbx_NQL.Location = new System.Drawing.Point(297, 25);
            this.tbx_NQL.Name = "tbx_NQL";
            this.tbx_NQL.Size = new System.Drawing.Size(266, 27);
            this.tbx_NQL.TabIndex = 3;
            // 
            // tbx_TenBP
            // 
            this.tbx_TenBP.Location = new System.Drawing.Point(89, 66);
            this.tbx_TenBP.Name = "tbx_TenBP";
            this.tbx_TenBP.Size = new System.Drawing.Size(145, 26);
            this.tbx_TenBP.TabIndex = 2;
            this.tbx_TenBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_TenBP_TextChanged);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(12, 2);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(65, 40);
            this.btn_quaylai.TabIndex = 16;
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click_1);
            // 
            // tbx_Dienthoai
            // 
            this.tbx_Dienthoai.Location = new System.Drawing.Point(678, 26);
            this.tbx_Dienthoai.Name = "tbx_Dienthoai";
            this.tbx_Dienthoai.Size = new System.Drawing.Size(169, 26);
            this.tbx_Dienthoai.TabIndex = 5;
            this.tbx_Dienthoai.TextChanged += new System.EventHandler(this.tbx_Dienthoai_TextChanged);
            this.tbx_Dienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_Dienthoai_TextChanged);
            this.tbx_Dienthoai.Leave += new System.EventHandler(this.txb_dthoai);
            // 
            // tbx_MaBP
            // 
            this.tbx_MaBP.Location = new System.Drawing.Point(91, 25);
            this.tbx_MaBP.Name = "tbx_MaBP";
            this.tbx_MaBP.Size = new System.Drawing.Size(143, 26);
            this.tbx_MaBP.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bộ Phận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btlammoi);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.tbx_MaKho);
            this.groupBox1.Controls.Add(this.tbx_NQL);
            this.groupBox1.Controls.Add(this.tbx_TenBP);
            this.groupBox1.Controls.Add(this.tbx_Dienthoai);
            this.groupBox1.Controls.Add(this.tbx_MaBP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 180);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Trị";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(586, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 151;
            this.button1.Text = "Tìm Kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btlammoi
            // 
            this.btlammoi.BackColor = System.Drawing.SystemColors.Control;
            this.btlammoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlammoi.ForeColor = System.Drawing.Color.Black;
            this.btlammoi.Image = ((System.Drawing.Image)(resources.GetObject("btlammoi.Image")));
            this.btlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlammoi.Location = new System.Drawing.Point(720, 124);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(110, 50);
            this.btlammoi.TabIndex = 150;
            this.btlammoi.Text = "Refresh";
            this.btlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlammoi.UseVisualStyleBackColor = false;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(301, 124);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 50);
            this.btn_xoa.TabIndex = 149;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ghinhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ForeColor = System.Drawing.Color.Black;
            this.btn_ghinhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ghinhan.Image")));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ghinhan.Location = new System.Drawing.Point(446, 124);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(100, 50);
            this.btn_ghinhan.TabIndex = 148;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(166, 124);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 50);
            this.btn_sua.TabIndex = 144;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(26, 124);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 50);
            this.btn_them.TabIndex = 143;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "NQL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "BỘ PHẬN";
            // 
            // FrmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoPhan_FormClosed);
            this.Load += new System.EventHandler(this.BoPhan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoPhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_BoPhan;
        private System.Windows.Forms.ComboBox tbx_MaKho;
        private System.Windows.Forms.ComboBox tbx_NQL;
        private System.Windows.Forms.TextBox tbx_TenBP;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.TextBox tbx_Dienthoai;
        private System.Windows.Forms.TextBox tbx_MaBP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btlammoi;
    }
}