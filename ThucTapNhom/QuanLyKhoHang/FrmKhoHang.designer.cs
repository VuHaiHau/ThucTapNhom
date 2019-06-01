namespace QuanLyKhoHang
{
    partial class FrmKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoHang));
            this.tbx_tongdmsp = new System.Windows.Forms.NumericUpDown();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_chophepsua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.groupBox_ketquatimkiem = new System.Windows.Forms.GroupBox();
            this.dgvKHOHANG = new System.Windows.Forms.DataGridView();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.tbx_makho = new System.Windows.Forms.TextBox();
            this.tbx_tenkho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_quaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tongdmsp)).BeginInit();
            this.groupBox_ketquatimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHOHANG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_tongdmsp
            // 
            this.tbx_tongdmsp.Location = new System.Drawing.Point(575, 31);
            this.tbx_tongdmsp.Name = "tbx_tongdmsp";
            this.tbx_tongdmsp.Size = new System.Drawing.Size(80, 26);
            this.tbx_tongdmsp.TabIndex = 64;
            this.tbx_tongdmsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ghinhan.Location = new System.Drawing.Point(420, 81);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(110, 50);
            this.btn_ghinhan.TabIndex = 43;
            this.btn_ghinhan.Text = "Ghi Nhận";
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click_1);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_lammoi.Location = new System.Drawing.Point(550, 81);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(110, 50);
            this.btn_lammoi.TabIndex = 11;
            this.btn_lammoi.Text = "Hủy";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click_1);
            // 
            // btn_chophepsua
            // 
            this.btn_chophepsua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_chophepsua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chophepsua.Location = new System.Drawing.Point(160, 81);
            this.btn_chophepsua.Name = "btn_chophepsua";
            this.btn_chophepsua.Size = new System.Drawing.Size(110, 50);
            this.btn_chophepsua.TabIndex = 10;
            this.btn_chophepsua.Text = "Sửa";
            this.btn_chophepsua.UseVisualStyleBackColor = false;
            this.btn_chophepsua.Click += new System.EventHandler(this.btn_chophepsua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_xoa.Location = new System.Drawing.Point(290, 81);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(110, 50);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_1);
            // 
            // groupBox_ketquatimkiem
            // 
            this.groupBox_ketquatimkiem.Controls.Add(this.dgvKHOHANG);
            this.groupBox_ketquatimkiem.Controls.Add(this.tbx_timkiem);
            this.groupBox_ketquatimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ketquatimkiem.Location = new System.Drawing.Point(15, 199);
            this.groupBox_ketquatimkiem.Name = "groupBox_ketquatimkiem";
            this.groupBox_ketquatimkiem.Size = new System.Drawing.Size(967, 303);
            this.groupBox_ketquatimkiem.TabIndex = 10;
            this.groupBox_ketquatimkiem.TabStop = false;
            this.groupBox_ketquatimkiem.Text = "Danh Sách Kho Hàng";
            // 
            // dgvKHOHANG
            // 
            this.dgvKHOHANG.BackgroundColor = System.Drawing.Color.White;
            this.dgvKHOHANG.CausesValidation = false;
            this.dgvKHOHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKHOHANG.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvKHOHANG.Location = new System.Drawing.Point(5, 61);
            this.dgvKHOHANG.Name = "dgvKHOHANG";
            this.dgvKHOHANG.ReadOnly = true;
            this.dgvKHOHANG.RowHeadersVisible = false;
            this.dgvKHOHANG.Size = new System.Drawing.Size(956, 229);
            this.dgvKHOHANG.TabIndex = 0;
            this.dgvKHOHANG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHOHANG_CellClick);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_timkiem.Location = new System.Drawing.Point(149, 25);
            this.tbx_timkiem.Multiline = true;
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(812, 24);
            this.tbx_timkiem.TabIndex = 1;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_tk_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(810, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(680, 81);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(110, 50);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click_2);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_them.Location = new System.Drawing.Point(30, 81);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(110, 50);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(747, 31);
            this.tbx_ghichu.Multiline = true;
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(206, 30);
            this.tbx_ghichu.TabIndex = 7;
            // 
            // tbx_makho
            // 
            this.tbx_makho.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_makho.Enabled = false;
            this.tbx_makho.ForeColor = System.Drawing.Color.Black;
            this.tbx_makho.Location = new System.Drawing.Point(74, 31);
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(117, 26);
            this.tbx_makho.TabIndex = 4;
            // 
            // tbx_tenkho
            // 
            this.tbx_tenkho.Location = new System.Drawing.Point(284, 31);
            this.tbx_tenkho.Name = "tbx_tenkho";
            this.tbx_tenkho.Size = new System.Drawing.Size(194, 26);
            this.tbx_tenkho.TabIndex = 5;
            this.tbx_tenkho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_tenkho_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng  SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_tongdmsp);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.btn_chophepsua);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.tbx_ghichu);
            this.groupBox1.Controls.Add(this.tbx_tenkho);
            this.groupBox1.Controls.Add(this.tbx_makho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Trị Kho Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "KHO HÀNG";
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("bt_quaylai.Image")));
            this.bt_quaylai.Location = new System.Drawing.Point(15, 5);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(70, 40);
            this.bt_quaylai.TabIndex = 22;
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click_1);
            // 
            // FrmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(994, 501);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.groupBox_ketquatimkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KhoHang_FormClosed);
            this.Load += new System.EventHandler(this.KhoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbx_tongdmsp)).EndInit();
            this.groupBox_ketquatimkiem.ResumeLayout(false);
            this.groupBox_ketquatimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHOHANG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown tbx_tongdmsp;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_chophepsua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.GroupBox groupBox_ketquatimkiem;
        private System.Windows.Forms.DataGridView dgvKHOHANG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tbx_ghichu;
        private System.Windows.Forms.TextBox tbx_makho;
        private System.Windows.Forms.TextBox tbx_tenkho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_quaylai;
    }
}