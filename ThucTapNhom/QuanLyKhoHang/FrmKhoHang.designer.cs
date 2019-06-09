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
            this.groupBox_ketquatimkiem = new System.Windows.Forms.GroupBox();
            this.dgvKHOHANG = new System.Windows.Forms.DataGridView();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.tbx_makho = new System.Windows.Forms.TextBox();
            this.tbx_tenkho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_chophepsua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
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
            this.tbx_tongdmsp.Location = new System.Drawing.Point(552, 31);
            this.tbx_tongdmsp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbx_tongdmsp.Name = "tbx_tongdmsp";
            this.tbx_tongdmsp.Size = new System.Drawing.Size(80, 26);
            this.tbx_tongdmsp.TabIndex = 64;
            this.tbx_tongdmsp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_ketquatimkiem
            // 
            this.groupBox_ketquatimkiem.Controls.Add(this.dgvKHOHANG);
            this.groupBox_ketquatimkiem.Controls.Add(this.tbx_timkiem);
            this.groupBox_ketquatimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(737, 31);
            this.tbx_ghichu.Multiline = true;
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(198, 30);
            this.tbx_ghichu.TabIndex = 7;
            // 
            // tbx_makho
            // 
            this.tbx_makho.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_makho.Enabled = false;
            this.tbx_makho.ForeColor = System.Drawing.Color.Black;
            this.tbx_makho.Location = new System.Drawing.Point(81, 31);
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(95, 26);
            this.tbx_makho.TabIndex = 4;
            // 
            // tbx_tenkho
            // 
            this.tbx_tenkho.Location = new System.Drawing.Point(266, 31);
            this.tbx_tenkho.Name = "tbx_tenkho";
            this.tbx_tenkho.Size = new System.Drawing.Size(181, 26);
            this.tbx_tenkho.TabIndex = 5;
            this.tbx_tenkho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_tenkho_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng  SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.bt_them);
            this.groupBox1.Controls.Add(this.btlammoi);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_chophepsua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.tbx_tongdmsp);
            this.groupBox1.Controls.Add(this.tbx_ghichu);
            this.groupBox1.Controls.Add(this.tbx_tenkho);
            this.groupBox1.Controls.Add(this.tbx_makho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Trị Kho Hàng";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(820, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 154;
            this.button2.Text = "Tìm Kiếm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.Control;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Black;
            this.bt_them.Image = ((System.Drawing.Image)(resources.GetObject("bt_them.Image")));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(340, 81);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(110, 50);
            this.bt_them.TabIndex = 153;
            this.bt_them.Text = "Xóa";
            this.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btlammoi
            // 
            this.btlammoi.BackColor = System.Drawing.SystemColors.Control;
            this.btlammoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlammoi.ForeColor = System.Drawing.Color.Black;
            this.btlammoi.Image = ((System.Drawing.Image)(resources.GetObject("btlammoi.Image")));
            this.btlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlammoi.Location = new System.Drawing.Point(660, 81);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(110, 50);
            this.btlammoi.TabIndex = 152;
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
            this.btn_ghinhan.Location = new System.Drawing.Point(500, 81);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(110, 50);
            this.btn_ghinhan.TabIndex = 151;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_chophepsua
            // 
            this.btn_chophepsua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_chophepsua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chophepsua.ForeColor = System.Drawing.Color.Black;
            this.btn_chophepsua.Image = ((System.Drawing.Image)(resources.GetObject("btn_chophepsua.Image")));
            this.btn_chophepsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chophepsua.Location = new System.Drawing.Point(180, 81);
            this.btn_chophepsua.Name = "btn_chophepsua";
            this.btn_chophepsua.Size = new System.Drawing.Size(110, 50);
            this.btn_chophepsua.TabIndex = 150;
            this.btn_chophepsua.Text = "Sửa";
            this.btn_chophepsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chophepsua.UseVisualStyleBackColor = false;
            this.btn_chophepsua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(20, 81);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 50);
            this.btn_them.TabIndex = 149;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
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
        private System.Windows.Forms.GroupBox groupBox_ketquatimkiem;
        private System.Windows.Forms.DataGridView dgvKHOHANG;
        private System.Windows.Forms.TextBox tbx_timkiem;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button btn_chophepsua;
        private System.Windows.Forms.Button btn_them;
    }
}