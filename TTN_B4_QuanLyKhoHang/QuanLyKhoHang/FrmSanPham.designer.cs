﻿namespace QuanLyKhoHang
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_huynhap = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_chophepsua = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.dtpicker_hsd = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_nsx = new System.Windows.Forms.DateTimePicker();
            this.txb_ghichu = new System.Windows.Forms.TextBox();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.txb_soluong = new System.Windows.Forms.NumericUpDown();
            this.txb_ncc = new System.Windows.Forms.ComboBox();
            this.txb_madm = new System.Windows.Forms.ComboBox();
            this.lb_tiente = new System.Windows.Forms.Label();
            this.label_thongbaoSP = new System.Windows.Forms.Label();
            this.txb_giasp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txb_phanloai = new System.Windows.Forms.TextBox();
            this.txb_serial = new System.Windows.Forms.TextBox();
            this.tbx_tensp = new System.Windows.Forms.TextBox();
            this.tbx_masp = new System.Windows.Forms.TextBox();
            this.pictureBox_sanpham = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txb_timkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_SANPHAM = new System.Windows.Forms.DataGridView();
            this.groupBox_DSSP = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txb_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SANPHAM)).BeginInit();
            this.groupBox_DSSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(380, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 28);
            this.label11.TabIndex = 74;
            this.label11.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_huynhap);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_lammoi);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_chophepsua);
            this.groupBox1.Controls.Add(this.btn_themmoi);
            this.groupBox1.Location = new System.Drawing.Point(726, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 185);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // btn_huynhap
            // 
            this.btn_huynhap.BackColor = System.Drawing.Color.White;
            this.btn_huynhap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huynhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_huynhap.Location = new System.Drawing.Point(140, 102);
            this.btn_huynhap.Name = "btn_huynhap";
            this.btn_huynhap.Size = new System.Drawing.Size(100, 50);
            this.btn_huynhap.TabIndex = 63;
            this.btn_huynhap.Text = "Hủy";
            this.btn_huynhap.UseVisualStyleBackColor = false;
            this.btn_huynhap.Click += new System.EventHandler(this.btn_huynhap_Click_1);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.Color.White;
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ghinhan.Location = new System.Drawing.Point(13, 102);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(100, 50);
            this.btn_ghinhan.TabIndex = 40;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.Color.White;
            this.btn_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_lammoi.Location = new System.Drawing.Point(268, 102);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(100, 50);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_xoa.Location = new System.Drawing.Point(268, 23);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 50);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_chophepsua
            // 
            this.btn_chophepsua.BackColor = System.Drawing.Color.White;
            this.btn_chophepsua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chophepsua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_chophepsua.Location = new System.Drawing.Point(140, 23);
            this.btn_chophepsua.Name = "btn_chophepsua";
            this.btn_chophepsua.Size = new System.Drawing.Size(100, 50);
            this.btn_chophepsua.TabIndex = 1;
            this.btn_chophepsua.Text = "Sửa";
            this.btn_chophepsua.UseVisualStyleBackColor = false;
            this.btn_chophepsua.Click += new System.EventHandler(this.btn_chophepsua_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.BackColor = System.Drawing.Color.White;
            this.btn_themmoi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themmoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_themmoi.Location = new System.Drawing.Point(13, 23);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(100, 50);
            this.btn_themmoi.TabIndex = 0;
            this.btn_themmoi.Text = "Thêm ";
            this.btn_themmoi.UseVisualStyleBackColor = false;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // dtpicker_hsd
            // 
            this.dtpicker_hsd.CustomFormat = "MM/dd/yyyy";
            this.dtpicker_hsd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_hsd.Location = new System.Drawing.Point(347, 112);
            this.dtpicker_hsd.Name = "dtpicker_hsd";
            this.dtpicker_hsd.Size = new System.Drawing.Size(159, 25);
            this.dtpicker_hsd.TabIndex = 64;
            // 
            // dtpicker_nsx
            // 
            this.dtpicker_nsx.CustomFormat = "MM/dd/yyyy";
            this.dtpicker_nsx.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_nsx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_nsx.Location = new System.Drawing.Point(347, 78);
            this.dtpicker_nsx.Name = "dtpicker_nsx";
            this.dtpicker_nsx.Size = new System.Drawing.Size(159, 25);
            this.dtpicker_nsx.TabIndex = 63;
            // 
            // txb_ghichu
            // 
            this.txb_ghichu.Location = new System.Drawing.Point(583, 112);
            this.txb_ghichu.Multiline = true;
            this.txb_ghichu.Name = "txb_ghichu";
            this.txb_ghichu.Size = new System.Drawing.Size(135, 54);
            this.txb_ghichu.TabIndex = 62;
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("bt_quaylai.Image")));
            this.bt_quaylai.Location = new System.Drawing.Point(16, 5);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(65, 35);
            this.bt_quaylai.TabIndex = 75;
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // txb_soluong
            // 
            this.txb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soluong.Location = new System.Drawing.Point(347, 146);
            this.txb_soluong.Name = "txb_soluong";
            this.txb_soluong.Size = new System.Drawing.Size(61, 21);
            this.txb_soluong.TabIndex = 72;
            this.txb_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_ncc
            // 
            this.txb_ncc.FormattingEnabled = true;
            this.txb_ncc.Location = new System.Drawing.Point(102, 112);
            this.txb_ncc.Name = "txb_ncc";
            this.txb_ncc.Size = new System.Drawing.Size(157, 21);
            this.txb_ncc.TabIndex = 71;
            // 
            // txb_madm
            // 
            this.txb_madm.FormattingEnabled = true;
            this.txb_madm.Location = new System.Drawing.Point(102, 146);
            this.txb_madm.Name = "txb_madm";
            this.txb_madm.Size = new System.Drawing.Size(157, 21);
            this.txb_madm.TabIndex = 70;
            // 
            // lb_tiente
            // 
            this.lb_tiente.AutoSize = true;
            this.lb_tiente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tiente.Location = new System.Drawing.Point(679, 93);
            this.lb_tiente.Name = "lb_tiente";
            this.lb_tiente.Size = new System.Drawing.Size(41, 19);
            this.lb_tiente.TabIndex = 69;
            this.lb_tiente.Text = "VND";
            // 
            // label_thongbaoSP
            // 
            this.label_thongbaoSP.AutoSize = true;
            this.label_thongbaoSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thongbaoSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_thongbaoSP.Location = new System.Drawing.Point(288, 183);
            this.label_thongbaoSP.Name = "label_thongbaoSP";
            this.label_thongbaoSP.Size = new System.Drawing.Size(0, 12);
            this.label_thongbaoSP.TabIndex = 49;
            // 
            // txb_giasp
            // 
            this.txb_giasp.Location = new System.Drawing.Point(583, 70);
            this.txb_giasp.Name = "txb_giasp";
            this.txb_giasp.Size = new System.Drawing.Size(135, 20);
            this.txb_giasp.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "Giá";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1128, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 39);
            this.button8.TabIndex = 66;
            this.button8.Text = "Tải ảnh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // txb_phanloai
            // 
            this.txb_phanloai.Location = new System.Drawing.Point(583, 44);
            this.txb_phanloai.Name = "txb_phanloai";
            this.txb_phanloai.Size = new System.Drawing.Size(135, 20);
            this.txb_phanloai.TabIndex = 61;
            // 
            // txb_serial
            // 
            this.txb_serial.Location = new System.Drawing.Point(347, 44);
            this.txb_serial.Name = "txb_serial";
            this.txb_serial.Size = new System.Drawing.Size(159, 20);
            this.txb_serial.TabIndex = 60;
            // 
            // tbx_tensp
            // 
            this.tbx_tensp.Location = new System.Drawing.Point(102, 78);
            this.tbx_tensp.Multiline = true;
            this.tbx_tensp.Name = "tbx_tensp";
            this.tbx_tensp.Size = new System.Drawing.Size(157, 25);
            this.tbx_tensp.TabIndex = 59;
            this.tbx_tensp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_tensp_TextChanged);
            // 
            // tbx_masp
            // 
            this.tbx_masp.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_masp.Location = new System.Drawing.Point(102, 44);
            this.tbx_masp.Multiline = true;
            this.tbx_masp.Name = "tbx_masp";
            this.tbx_masp.Size = new System.Drawing.Size(157, 25);
            this.tbx_masp.TabIndex = 58;
            // 
            // pictureBox_sanpham
            // 
            this.pictureBox_sanpham.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox_sanpham.Location = new System.Drawing.Point(1110, 10);
            this.pictureBox_sanpham.Name = "pictureBox_sanpham";
            this.pictureBox_sanpham.Size = new System.Drawing.Size(117, 141);
            this.pictureBox_sanpham.TabIndex = 57;
            this.pictureBox_sanpham.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(512, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 19);
            this.label12.TabIndex = 56;
            this.label12.Text = "Ghi Chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Phân Loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 54;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Hạn SD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ngày SX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Serial";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.White;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(1102, 19);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 50);
            this.btn_timkiem.TabIndex = 2;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click_1);
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txb_timkiem.Location = new System.Drawing.Point(172, 31);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.Size = new System.Drawing.Size(916, 26);
            this.txb_timkiem.TabIndex = 1;
            this.txb_timkiem.Enter += new System.EventHandler(this.txt_tk_Enter);
            this.txb_timkiem.Leave += new System.EventHandler(this.txt_tk_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = " Nhà CC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã SP";
            // 
            // dgv_SANPHAM
            // 
            this.dgv_SANPHAM.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_SANPHAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SANPHAM.Location = new System.Drawing.Point(7, 75);
            this.dgv_SANPHAM.Name = "dgv_SANPHAM";
            this.dgv_SANPHAM.RowHeadersVisible = false;
            this.dgv_SANPHAM.Size = new System.Drawing.Size(1195, 249);
            this.dgv_SANPHAM.TabIndex = 0;
            this.dgv_SANPHAM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SANPHAM_CellContentClick);
            // 
            // groupBox_DSSP
            // 
            this.groupBox_DSSP.Controls.Add(this.btn_timkiem);
            this.groupBox_DSSP.Controls.Add(this.txb_timkiem);
            this.groupBox_DSSP.Controls.Add(this.dgv_SANPHAM);
            this.groupBox_DSSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DSSP.Location = new System.Drawing.Point(16, 199);
            this.groupBox_DSSP.Name = "groupBox_DSSP";
            this.groupBox_DSSP.Size = new System.Drawing.Size(1211, 330);
            this.groupBox_DSSP.TabIndex = 45;
            this.groupBox_DSSP.TabStop = false;
            this.groupBox_DSSP.Text = "Danh Sách  Sản Phẩm";
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 535);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpicker_hsd);
            this.Controls.Add(this.dtpicker_nsx);
            this.Controls.Add(this.txb_ghichu);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.txb_soluong);
            this.Controls.Add(this.txb_ncc);
            this.Controls.Add(this.txb_madm);
            this.Controls.Add(this.lb_tiente);
            this.Controls.Add(this.label_thongbaoSP);
            this.Controls.Add(this.txb_giasp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txb_phanloai);
            this.Controls.Add(this.txb_serial);
            this.Controls.Add(this.tbx_tensp);
            this.Controls.Add(this.tbx_masp);
            this.Controls.Add(this.pictureBox_sanpham);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_DSSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SANPHAM_FormClosed);
            this.Load += new System.EventHandler(this.SANPHAM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txb_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SANPHAM)).EndInit();
            this.groupBox_DSSP.ResumeLayout(false);
            this.groupBox_DSSP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_huynhap;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_chophepsua;
        private System.Windows.Forms.Button btn_themmoi;
        private System.Windows.Forms.DateTimePicker dtpicker_hsd;
        private System.Windows.Forms.DateTimePicker dtpicker_nsx;
        private System.Windows.Forms.TextBox txb_ghichu;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.NumericUpDown txb_soluong;
        private System.Windows.Forms.ComboBox txb_ncc;
        private System.Windows.Forms.ComboBox txb_madm;
        private System.Windows.Forms.Label lb_tiente;
        private System.Windows.Forms.Label label_thongbaoSP;
        private System.Windows.Forms.TextBox txb_giasp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txb_phanloai;
        private System.Windows.Forms.TextBox txb_serial;
        private System.Windows.Forms.TextBox tbx_tensp;
        private System.Windows.Forms.TextBox tbx_masp;
        private System.Windows.Forms.PictureBox pictureBox_sanpham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txb_timkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_SANPHAM;
        private System.Windows.Forms.GroupBox groupBox_DSSP;
    }
}