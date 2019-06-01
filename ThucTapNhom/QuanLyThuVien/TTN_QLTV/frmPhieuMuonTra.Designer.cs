namespace TTN_QLTV
{
    partial class frmPhieuMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuMuonTra));
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.cbxsach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxmuon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxdocgia = new System.Windows.Forms.ComboBox();
            this.dtgNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtgNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cbxnhanvien = new System.Windows.Forms.ComboBox();
            this.txttra = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLammoi = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvPhieuMuonTra = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btninpm = new System.Windows.Forms.Button();
            this.grbNhanVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTimKiem.BackgroundImage")));
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(704, 14);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(87, 34);
            this.btTimKiem.TabIndex = 31;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(506, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 26);
            this.txtTimKiem.TabIndex = 30;
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Controls.Add(this.cbxsach);
            this.grbNhanVien.Controls.Add(this.label3);
            this.grbNhanVien.Controls.Add(this.tbxmuon);
            this.grbNhanVien.Controls.Add(this.label12);
            this.grbNhanVien.Controls.Add(this.cbxdocgia);
            this.grbNhanVien.Controls.Add(this.dtgNgayTra);
            this.grbNhanVien.Controls.Add(this.dtgNgayMuon);
            this.grbNhanVien.Controls.Add(this.cbxnhanvien);
            this.grbNhanVien.Controls.Add(this.txttra);
            this.grbNhanVien.Controls.Add(this.txtMaPhieu);
            this.grbNhanVien.Controls.Add(this.label7);
            this.grbNhanVien.Controls.Add(this.label5);
            this.grbNhanVien.Controls.Add(this.label6);
            this.grbNhanVien.Controls.Add(this.label4);
            this.grbNhanVien.Controls.Add(this.label2);
            this.grbNhanVien.Controls.Add(this.lbTenPhong);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(12, 76);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(589, 306);
            this.grbNhanVien.TabIndex = 32;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông Tin Phiếu Mượn";
            // 
            // cbxsach
            // 
            this.cbxsach.FormattingEnabled = true;
            this.cbxsach.Location = new System.Drawing.Point(137, 132);
            this.cbxsach.Name = "cbxsach";
            this.cbxsach.Size = new System.Drawing.Size(401, 27);
            this.cbxsach.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Sách :";
            // 
            // tbxmuon
            // 
            this.tbxmuon.Location = new System.Drawing.Point(137, 229);
            this.tbxmuon.Name = "tbxmuon";
            this.tbxmuon.Size = new System.Drawing.Size(401, 26);
            this.tbxmuon.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Số Lượng Mượn:";
            // 
            // cbxdocgia
            // 
            this.cbxdocgia.FormattingEnabled = true;
            this.cbxdocgia.Location = new System.Drawing.Point(137, 98);
            this.cbxdocgia.Name = "cbxdocgia";
            this.cbxdocgia.Size = new System.Drawing.Size(401, 27);
            this.cbxdocgia.TabIndex = 11;
            // 
            // dtgNgayTra
            // 
            this.dtgNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtgNgayTra.Location = new System.Drawing.Point(137, 197);
            this.dtgNgayTra.Name = "dtgNgayTra";
            this.dtgNgayTra.Size = new System.Drawing.Size(170, 26);
            this.dtgNgayTra.TabIndex = 10;
            this.dtgNgayTra.Value = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            // 
            // dtgNgayMuon
            // 
            this.dtgNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtgNgayMuon.Location = new System.Drawing.Point(137, 165);
            this.dtgNgayMuon.Name = "dtgNgayMuon";
            this.dtgNgayMuon.Size = new System.Drawing.Size(170, 26);
            this.dtgNgayMuon.TabIndex = 9;
            this.dtgNgayMuon.Value = new System.DateTime(2018, 5, 23, 0, 0, 0, 0);
            // 
            // cbxnhanvien
            // 
            this.cbxnhanvien.FormattingEnabled = true;
            this.cbxnhanvien.Location = new System.Drawing.Point(139, 61);
            this.cbxnhanvien.Name = "cbxnhanvien";
            this.cbxnhanvien.Size = new System.Drawing.Size(401, 27);
            this.cbxnhanvien.TabIndex = 8;
            // 
            // txttra
            // 
            this.txttra.Location = new System.Drawing.Point(139, 261);
            this.txttra.Name = "txttra";
            this.txttra.Size = new System.Drawing.Size(401, 26);
            this.txttra.TabIndex = 6;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(139, 26);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(401, 26);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Lượng Trả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Trả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Mượn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Độc Giả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người Viết :";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(136, 149);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(0, 19);
            this.lbTenPhong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLammoi);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(624, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 306);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btLammoi
            // 
            this.btLammoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLammoi.BackgroundImage")));
            this.btLammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLammoi.Location = new System.Drawing.Point(57, 249);
            this.btLammoi.Name = "btLammoi";
            this.btLammoi.Size = new System.Drawing.Size(83, 34);
            this.btLammoi.TabIndex = 2;
            this.btLammoi.Text = "Làm Mới";
            this.btLammoi.UseVisualStyleBackColor = true;
            this.btLammoi.Click += new System.EventHandler(this.btLammoi_Click);
            // 
            // btLuu
            // 
            this.btLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLuu.BackgroundImage")));
            this.btLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(57, 197);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(83, 32);
            this.btLuu.TabIndex = 1;
            this.btLuu.Text = "Ghi Nhận";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(57, 142);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(83, 33);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSua.BackgroundImage")));
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(57, 89);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(83, 36);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(57, 25);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 35);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvPhieuMuonTra
            // 
            this.dgvPhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuonTra.Location = new System.Drawing.Point(12, 400);
            this.dgvPhieuMuonTra.Name = "dgvPhieuMuonTra";
            this.dgvPhieuMuonTra.ReadOnly = true;
            this.dgvPhieuMuonTra.Size = new System.Drawing.Size(815, 208);
            this.dgvPhieuMuonTra.TabIndex = 33;
            this.dgvPhieuMuonTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuonTra_CellClick);
            this.dgvPhieuMuonTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuonTra_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 34;
            this.button1.Text = "In Phiếu Trả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btninpm
            // 
            this.btninpm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninpm.BackgroundImage")));
            this.btninpm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btninpm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninpm.Location = new System.Drawing.Point(12, 10);
            this.btninpm.Name = "btninpm";
            this.btninpm.Size = new System.Drawing.Size(157, 32);
            this.btninpm.TabIndex = 3;
            this.btninpm.Text = "In Phiếu Mượn";
            this.btninpm.UseVisualStyleBackColor = true;
            this.btninpm.Click += new System.EventHandler(this.btninpm_Click);
            // 
            // frmPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 611);
            this.Controls.Add(this.btninpm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPhieuMuonTra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.MaximizeBox = false;
            this.Name = "frmPhieuMuonTra";
            this.Text = "Phiếu Mượn Trả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuMuonTra_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhieuMuonTra_FormClosed);
            this.Load += new System.EventHandler(this.frmPhieuMuonTra1_Load);
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.ComboBox cbxsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxmuon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxdocgia;
        private System.Windows.Forms.DateTimePicker dtgNgayTra;
        private System.Windows.Forms.DateTimePicker dtgNgayMuon;
        private System.Windows.Forms.ComboBox cbxnhanvien;
        private System.Windows.Forms.TextBox txttra;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLammoi;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvPhieuMuonTra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btninpm;
    }
}