namespace QuanLyKhoHang
{
    partial class FrmNhanVIen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVIen));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_nv = new System.Windows.Forms.ComboBox();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.lbx_nv = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.lbx_trangthai = new System.Windows.Forms.Label();
            this.cbx_trangthai = new System.Windows.Forms.CheckBox();
            this.tbx_MaBP = new System.Windows.Forms.ComboBox();
            this.tbx_chucvu = new System.Windows.Forms.TextBox();
            this.pn_radio = new System.Windows.Forms.Panel();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.btn_file = new System.Windows.Forms.Button();
            this.pc_nhanvien = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.tbx_DienThoai = new System.Windows.Forms.TextBox();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_NS = new System.Windows.Forms.DateTimePicker();
            this.tbx_luong = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_TenNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_MaNV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.pn_radio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_nhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_nv);
            this.groupBox2.Controls.Add(this.tbx_timkiem);
            this.groupBox2.Controls.Add(this.lbx_nv);
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 296);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // cbx_nv
            // 
            this.cbx_nv.FormattingEnabled = true;
            this.cbx_nv.Items.AddRange(new object[] {
            "Đang Làm",
            "Đã Nghỉ",
            "Tất Cả"});
            this.cbx_nv.Location = new System.Drawing.Point(844, 263);
            this.cbx_nv.Name = "cbx_nv";
            this.cbx_nv.Size = new System.Drawing.Size(154, 27);
            this.cbx_nv.TabIndex = 19;
            this.cbx_nv.SelectedIndexChanged += new System.EventHandler(this.cbx_nv_SelectedIndexChanged_1);
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbx_timkiem.Location = new System.Drawing.Point(156, 25);
            this.tbx_timkiem.Multiline = true;
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(842, 24);
            this.tbx_timkiem.TabIndex = 24;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_Timkiem_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_Timkiem_Leave);
            // 
            // lbx_nv
            // 
            this.lbx_nv.AutoSize = true;
            this.lbx_nv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_nv.Location = new System.Drawing.Point(705, 266);
            this.lbx_nv.Name = "lbx_nv";
            this.lbx_nv.Size = new System.Drawing.Size(137, 22);
            this.lbx_nv.TabIndex = 1;
            this.lbx_nv.Text = "Xem Nhân Viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 55);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(992, 202);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.TabStop = false;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            // 
            // lbx_trangthai
            // 
            this.lbx_trangthai.AutoSize = true;
            this.lbx_trangthai.Location = new System.Drawing.Point(589, 102);
            this.lbx_trangthai.Name = "lbx_trangthai";
            this.lbx_trangthai.Size = new System.Drawing.Size(73, 19);
            this.lbx_trangthai.TabIndex = 30;
            this.lbx_trangthai.Text = "Trạng Thái";
            // 
            // cbx_trangthai
            // 
            this.cbx_trangthai.AutoSize = true;
            this.cbx_trangthai.Location = new System.Drawing.Point(675, 101);
            this.cbx_trangthai.Name = "cbx_trangthai";
            this.cbx_trangthai.Size = new System.Drawing.Size(109, 23);
            this.cbx_trangthai.TabIndex = 29;
            this.cbx_trangthai.Text = "Đang Đi Làm";
            this.cbx_trangthai.UseVisualStyleBackColor = true;
            this.cbx_trangthai.CheckedChanged += new System.EventHandler(this.cbx_trangthai_CheckedChanged);
            // 
            // tbx_MaBP
            // 
            this.tbx_MaBP.FormattingEnabled = true;
            this.tbx_MaBP.Location = new System.Drawing.Point(668, 62);
            this.tbx_MaBP.Name = "tbx_MaBP";
            this.tbx_MaBP.Size = new System.Drawing.Size(206, 27);
            this.tbx_MaBP.TabIndex = 11;
            // 
            // tbx_chucvu
            // 
            this.tbx_chucvu.Location = new System.Drawing.Point(365, 30);
            this.tbx_chucvu.Name = "tbx_chucvu";
            this.tbx_chucvu.Size = new System.Drawing.Size(206, 26);
            this.tbx_chucvu.TabIndex = 8;
            // 
            // pn_radio
            // 
            this.pn_radio.Controls.Add(this.rbtn_Nu);
            this.pn_radio.Controls.Add(this.rbtn_Nam);
            this.pn_radio.Location = new System.Drawing.Point(84, 123);
            this.pn_radio.Name = "pn_radio";
            this.pn_radio.Size = new System.Drawing.Size(193, 31);
            this.pn_radio.TabIndex = 5;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(72, 2);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(48, 23);
            this.rbtn_Nu.TabIndex = 6;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Location = new System.Drawing.Point(3, 2);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(57, 23);
            this.rbtn_Nam.TabIndex = 5;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_file.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_file.ForeColor = System.Drawing.Color.Black;
            this.btn_file.Location = new System.Drawing.Point(914, 181);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(59, 28);
            this.btn_file.TabIndex = 12;
            this.btn_file.Text = "File";
            this.btn_file.UseVisualStyleBackColor = false;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click_1);
            // 
            // pc_nhanvien
            // 
            this.pc_nhanvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pc_nhanvien.Location = new System.Drawing.Point(880, 25);
            this.pc_nhanvien.Name = "pc_nhanvien";
            this.pc_nhanvien.Size = new System.Drawing.Size(118, 132);
            this.pc_nhanvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_nhanvien.TabIndex = 28;
            this.pc_nhanvien.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bộ Phận";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Lương";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Location = new System.Drawing.Point(365, 61);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(206, 26);
            this.tbx_DiaChi.TabIndex = 9;
            // 
            // tbx_DienThoai
            // 
            this.tbx_DienThoai.Location = new System.Drawing.Point(668, 25);
            this.tbx_DienThoai.Name = "tbx_DienThoai";
            this.tbx_DienThoai.Size = new System.Drawing.Size(206, 26);
            this.tbx_DienThoai.TabIndex = 7;
            this.tbx_DienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_DienThoai_TextChanged);
            this.tbx_DienThoai.Leave += new System.EventHandler(this.tbx_DienThoai_TextChanged);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Image = ((System.Drawing.Image)(resources.GetObject("bt_quaylai.Image")));
            this.bt_quaylai.Location = new System.Drawing.Point(12, 1);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(65, 40);
            this.bt_quaylai.TabIndex = 26;
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dateTimePicker_NS
            // 
            this.dateTimePicker_NS.CustomFormat = "";
            this.dateTimePicker_NS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NS.Location = new System.Drawing.Point(84, 91);
            this.dateTimePicker_NS.Name = "dateTimePicker_NS";
            this.dateTimePicker_NS.Size = new System.Drawing.Size(193, 26);
            this.dateTimePicker_NS.TabIndex = 4;
            // 
            // tbx_luong
            // 
            this.tbx_luong.Location = new System.Drawing.Point(365, 94);
            this.tbx_luong.Name = "tbx_luong";
            this.tbx_luong.Size = new System.Drawing.Size(206, 26);
            this.tbx_luong.TabIndex = 10;
            this.tbx_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Luong);
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(365, 127);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(206, 26);
            this.tbx_Email.TabIndex = 3;
            this.tbx_Email.Leave += new System.EventHandler(this.txb_Email);
            // 
            // tbx_TenNV
            // 
            this.tbx_TenNV.Location = new System.Drawing.Point(84, 60);
            this.tbx_TenNV.Name = "tbx_TenNV";
            this.tbx_TenNV.Size = new System.Drawing.Size(193, 26);
            this.tbx_TenNV.TabIndex = 2;
            this.tbx_TenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_TenNV_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Chức Vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên NV\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã NV";
            // 
            // tbx_MaNV
            // 
            this.tbx_MaNV.Location = new System.Drawing.Point(84, 30);
            this.tbx_MaNV.Name = "tbx_MaNV";
            this.tbx_MaNV.Size = new System.Drawing.Size(193, 26);
            this.tbx_MaNV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.bt_xoa);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btlammoi);
            this.groupBox1.Controls.Add(this.btn_ghinhan);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.lbx_trangthai);
            this.groupBox1.Controls.Add(this.cbx_trangthai);
            this.groupBox1.Controls.Add(this.tbx_MaBP);
            this.groupBox1.Controls.Add(this.tbx_chucvu);
            this.groupBox1.Controls.Add(this.pn_radio);
            this.groupBox1.Controls.Add(this.btn_file);
            this.groupBox1.Controls.Add(this.pc_nhanvien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbx_DiaChi);
            this.groupBox1.Controls.Add(this.tbx_DienThoai);
            this.groupBox1.Controls.Add(this.dateTimePicker_NS);
            this.groupBox1.Controls.Add(this.tbx_luong);
            this.groupBox1.Controls.Add(this.tbx_Email);
            this.groupBox1.Controls.Add(this.tbx_TenNV);
            this.groupBox1.Controls.Add(this.tbx_MaNV);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 238);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QL Nhân Viên";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(645, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 50);
            this.button7.TabIndex = 169;
            this.button7.Text = "In Phiếu";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.SystemColors.Control;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Black;
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(270, 182);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(110, 50);
            this.bt_xoa.TabIndex = 136;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click_2);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(770, 182);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 50);
            this.btnTimKiem.TabIndex = 135;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btlammoi
            // 
            this.btlammoi.BackColor = System.Drawing.SystemColors.Control;
            this.btlammoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlammoi.ForeColor = System.Drawing.Color.Black;
            this.btlammoi.Image = ((System.Drawing.Image)(resources.GetObject("btlammoi.Image")));
            this.btlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlammoi.Location = new System.Drawing.Point(520, 182);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(110, 50);
            this.btlammoi.TabIndex = 133;
            this.btlammoi.Text = "Refresh";
            this.btlammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btlammoi.UseVisualStyleBackColor = false;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click_1);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ghinhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ForeColor = System.Drawing.Color.Black;
            this.btn_ghinhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ghinhan.Image")));
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ghinhan.Location = new System.Drawing.Point(395, 182);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(110, 50);
            this.btn_ghinhan.TabIndex = 132;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(145, 182);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 50);
            this.btn_sua.TabIndex = 131;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(20, 182);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 50);
            this.btn_them.TabIndex = 126;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // FrmNhanVIen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_quaylai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhanVIen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhanVIen_FormClosed);
            this.Load += new System.EventHandler(this.NhanVIen_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.pn_radio.ResumeLayout(false);
            this.pn_radio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_nhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_nv;
        private System.Windows.Forms.Label lbx_nv;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label lbx_trangthai;
        private System.Windows.Forms.CheckBox cbx_trangthai;
        private System.Windows.Forms.ComboBox tbx_MaBP;
        private System.Windows.Forms.TextBox tbx_chucvu;
        private System.Windows.Forms.Panel pn_radio;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.PictureBox pc_nhanvien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.TextBox tbx_DienThoai;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NS;
        private System.Windows.Forms.TextBox tbx_luong;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_TenNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_MaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button button7;
    }
}