namespace QuanLyKhoHang
{
    partial class FrmNhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhaCC));
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.dgv_nhacungcap = new System.Windows.Forms.DataGridView();
            this.tbx_Ghichu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_Diachi = new System.Windows.Forms.TextBox();
            this.tbx_MaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbx_TenNCC = new System.Windows.Forms.TextBox();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhacungcap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_timkiem.Location = new System.Drawing.Point(157, 25);
            this.tbx_timkiem.Multiline = true;
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(640, 28);
            this.tbx_timkiem.TabIndex = 16;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_tk_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // dgv_nhacungcap
            // 
            this.dgv_nhacungcap.AllowUserToAddRows = false;
            this.dgv_nhacungcap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhacungcap.Location = new System.Drawing.Point(16, 70);
            this.dgv_nhacungcap.Name = "dgv_nhacungcap";
            this.dgv_nhacungcap.Size = new System.Drawing.Size(781, 226);
            this.dgv_nhacungcap.TabIndex = 11;
            this.dgv_nhacungcap.TabStop = false;
            this.dgv_nhacungcap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhacungcap_CellClick);
            // 
            // tbx_Ghichu
            // 
            this.tbx_Ghichu.Location = new System.Drawing.Point(467, 76);
            this.tbx_Ghichu.Multiline = true;
            this.tbx_Ghichu.Name = "tbx_Ghichu";
            this.tbx_Ghichu.Size = new System.Drawing.Size(321, 28);
            this.tbx_Ghichu.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbx_timkiem);
            this.groupBox2.Controls.Add(this.dgv_nhacungcap);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 302);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhà CC";
            // 
            // tbx_Diachi
            // 
            this.tbx_Diachi.Location = new System.Drawing.Point(467, 35);
            this.tbx_Diachi.Multiline = true;
            this.tbx_Diachi.Name = "tbx_Diachi";
            this.tbx_Diachi.Size = new System.Drawing.Size(321, 26);
            this.tbx_Diachi.TabIndex = 3;
            // 
            // tbx_MaNCC
            // 
            this.tbx_MaNCC.Location = new System.Drawing.Point(85, 35);
            this.tbx_MaNCC.Name = "tbx_MaNCC";
            this.tbx_MaNCC.Size = new System.Drawing.Size(255, 26);
            this.tbx_MaNCC.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NCC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btlammoi);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.tbx_Ghichu);
            this.groupBox1.Controls.Add(this.tbx_Diachi);
            this.groupBox1.Controls.Add(this.tbx_TenNCC);
            this.groupBox1.Controls.Add(this.tbx_MaNCC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 200);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QT Nhà Cung Cấp";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(541, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 148;
            this.button1.Text = "Tìm Kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(276, 131);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 50);
            this.btn_xoa.TabIndex = 147;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // btlammoi
            // 
            this.btlammoi.BackColor = System.Drawing.SystemColors.Control;
            this.btlammoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlammoi.ForeColor = System.Drawing.Color.Black;
            this.btlammoi.Image = ((System.Drawing.Image)(resources.GetObject("btlammoi.Image")));
            this.btlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlammoi.Location = new System.Drawing.Point(678, 131);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(110, 50);
            this.btlammoi.TabIndex = 145;
            this.btlammoi.Text = "Refresh";
            this.btlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlammoi.UseVisualStyleBackColor = false;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ghinhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ForeColor = System.Drawing.Color.Black;
            this.btn_ghinhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ghinhan.Image")));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ghinhan.Location = new System.Drawing.Point(411, 131);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(100, 50);
            this.btn_ghinhan.TabIndex = 144;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(141, 131);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 50);
            this.btn_sua.TabIndex = 143;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(16, 131);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 50);
            this.btn_them.TabIndex = 142;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(649, -254);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 50);
            this.btnTimKiem.TabIndex = 146;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // tbx_TenNCC
            // 
            this.tbx_TenNCC.Location = new System.Drawing.Point(85, 78);
            this.tbx_TenNCC.Name = "tbx_TenNCC";
            this.tbx_TenNCC.Size = new System.Drawing.Size(255, 26);
            this.tbx_TenNCC.TabIndex = 2;
            this.tbx_TenNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_TenNCC_TextChanged);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("bt_quaylai.Image")));
            this.bt_quaylai.Location = new System.Drawing.Point(9, 6);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(65, 40);
            this.bt_quaylai.TabIndex = 20;
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "NHÀ CUNG CẤP SẢN PHẨM";
            // 
            // FrmNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhaCC_FormClosed);
            this.Load += new System.EventHandler(this.NhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhacungcap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.DataGridView dgv_nhacungcap;
        private System.Windows.Forms.TextBox tbx_Ghichu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_Diachi;
        private System.Windows.Forms.TextBox tbx_MaNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_TenNCC;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button button1;
    }
}