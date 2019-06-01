namespace QuanLyKhoHang
{
    partial class FrmDanhMucSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucSP));
            this.tbx_makho = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.bt_chophepsua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.tbx_tendm = new System.Windows.Forms.TextBox();
            this.tbx_madm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_qldmsp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_quaylai = new System.Windows.Forms.Button();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.dgvDANHMUC = new System.Windows.Forms.DataGridView();
            this.group_dmsp = new System.Windows.Forms.GroupBox();
            this.group_qldmsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).BeginInit();
            this.group_dmsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_makho
            // 
            this.tbx_makho.FormattingEnabled = true;
            this.tbx_makho.Location = new System.Drawing.Point(485, 27);
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(349, 27);
            this.tbx_makho.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(485, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 62;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ghinhan.Location = new System.Drawing.Point(367, 127);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(112, 50);
            this.btn_ghinhan.TabIndex = 41;
            this.btn_ghinhan.Text = "Ghi Nhận";
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_xoa.Location = new System.Drawing.Point(249, 127);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(112, 50);
            this.bt_xoa.TabIndex = 7;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(485, 61);
            this.tbx_ghichu.Multiline = true;
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(349, 29);
            this.tbx_ghichu.TabIndex = 5;
            // 
            // bt_chophepsua
            // 
            this.bt_chophepsua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_chophepsua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chophepsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_chophepsua.Location = new System.Drawing.Point(131, 127);
            this.bt_chophepsua.Name = "bt_chophepsua";
            this.bt_chophepsua.Size = new System.Drawing.Size(112, 50);
            this.bt_chophepsua.TabIndex = 8;
            this.bt_chophepsua.Text = "Sửa";
            this.bt_chophepsua.UseVisualStyleBackColor = false;
            this.bt_chophepsua.Click += new System.EventHandler(this.bt_chophepsua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_them.Location = new System.Drawing.Point(13, 127);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(112, 50);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // tbx_tendm
            // 
            this.tbx_tendm.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_tendm.ForeColor = System.Drawing.Color.Black;
            this.tbx_tendm.Location = new System.Drawing.Point(131, 64);
            this.tbx_tendm.Name = "tbx_tendm";
            this.tbx_tendm.Size = new System.Drawing.Size(261, 26);
            this.tbx_tendm.TabIndex = 2;
            this.tbx_tendm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_tendm_TextChanged);
            // 
            // tbx_madm
            // 
            this.tbx_madm.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_madm.Enabled = false;
            this.tbx_madm.ForeColor = System.Drawing.Color.Black;
            this.tbx_madm.Location = new System.Drawing.Point(131, 28);
            this.tbx_madm.Name = "tbx_madm";
            this.tbx_madm.Size = new System.Drawing.Size(261, 26);
            this.tbx_madm.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Danh Mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Danh Mục";
            // 
            // group_qldmsp
            // 
            this.group_qldmsp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.group_qldmsp.Controls.Add(this.tbx_makho);
            this.group_qldmsp.Controls.Add(this.button2);
            this.group_qldmsp.Controls.Add(this.button1);
            this.group_qldmsp.Controls.Add(this.btn_ghinhan);
            this.group_qldmsp.Controls.Add(this.btn_Timkiem);
            this.group_qldmsp.Controls.Add(this.bt_xoa);
            this.group_qldmsp.Controls.Add(this.tbx_ghichu);
            this.group_qldmsp.Controls.Add(this.bt_chophepsua);
            this.group_qldmsp.Controls.Add(this.bt_them);
            this.group_qldmsp.Controls.Add(this.tbx_tendm);
            this.group_qldmsp.Controls.Add(this.tbx_madm);
            this.group_qldmsp.Controls.Add(this.label5);
            this.group_qldmsp.Controls.Add(this.label4);
            this.group_qldmsp.Controls.Add(this.label3);
            this.group_qldmsp.Controls.Add(this.label2);
            this.group_qldmsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_qldmsp.Location = new System.Drawing.Point(12, 55);
            this.group_qldmsp.Name = "group_qldmsp";
            this.group_qldmsp.Size = new System.Drawing.Size(840, 183);
            this.group_qldmsp.TabIndex = 36;
            this.group_qldmsp.TabStop = false;
            this.group_qldmsp.Text = "Quản Trị";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(721, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Location = new System.Drawing.Point(603, 127);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(112, 50);
            this.btn_Timkiem.TabIndex = 11;
            this.btn_Timkiem.Text = "Tìm Kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click_1);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("btn_quaylai.Image")));
            this.btn_quaylai.Location = new System.Drawing.Point(18, 6);
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(65, 40);
            this.btn_quaylai.TabIndex = 39;
            this.btn_quaylai.UseVisualStyleBackColor = true;
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_timkiem.Location = new System.Drawing.Point(146, 22);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(688, 26);
            this.tbx_timkiem.TabIndex = 10;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_tk_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(559, 25);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 19);
            this.lb_thongbao.TabIndex = 13;
            // 
            // dgvDANHMUC
            // 
            this.dgvDANHMUC.BackgroundColor = System.Drawing.Color.White;
            this.dgvDANHMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDANHMUC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDANHMUC.Location = new System.Drawing.Point(6, 69);
            this.dgvDANHMUC.Name = "dgvDANHMUC";
            this.dgvDANHMUC.ReadOnly = true;
            this.dgvDANHMUC.RowHeadersVisible = false;
            this.dgvDANHMUC.Size = new System.Drawing.Size(828, 255);
            this.dgvDANHMUC.TabIndex = 0;
            this.dgvDANHMUC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDANHMUC_CellContentClick);
            // 
            // group_dmsp
            // 
            this.group_dmsp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.group_dmsp.Controls.Add(this.dgvDANHMUC);
            this.group_dmsp.Controls.Add(this.lb_thongbao);
            this.group_dmsp.Controls.Add(this.tbx_timkiem);
            this.group_dmsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_dmsp.Location = new System.Drawing.Point(12, 244);
            this.group_dmsp.Name = "group_dmsp";
            this.group_dmsp.Size = new System.Drawing.Size(840, 336);
            this.group_dmsp.TabIndex = 37;
            this.group_dmsp.TabStop = false;
            this.group_dmsp.Text = "Danh Sách Danh Mục";
            // 
            // FrmDanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 581);
            this.Controls.Add(this.btn_quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group_dmsp);
            this.Controls.Add(this.group_qldmsp);
            this.Name = "FrmDanhMucSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucSP_FormClosed);
            this.Load += new System.EventHandler(this.DanhMucSP_Load);
            this.group_qldmsp.ResumeLayout(false);
            this.group_qldmsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).EndInit();
            this.group_dmsp.ResumeLayout(false);
            this.group_dmsp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dANHMUCBindingSource;
        private System.Windows.Forms.ComboBox tbx_makho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox tbx_ghichu;
        private System.Windows.Forms.Button bt_chophepsua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tbx_tendm;
        private System.Windows.Forms.TextBox tbx_madm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_qldmsp;
        private System.Windows.Forms.Button btn_quaylai;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.DataGridView dgvDANHMUC;
        private System.Windows.Forms.GroupBox group_dmsp;
    }
}