namespace TTN_QLTV
{
    partial class frmDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocGia));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.gbGT = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.dtgNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grbNhanVien.SuspendLayout();
            this.gbGT.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(501, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 26);
            this.txtTimKiem.TabIndex = 25;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btTimKiem.BackgroundImage")));
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(699, 6);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(89, 38);
            this.btTimKiem.TabIndex = 26;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Controls.Add(this.gbGT);
            this.grbNhanVien.Controls.Add(this.txtDiachi);
            this.grbNhanVien.Controls.Add(this.txtHoten);
            this.grbNhanVien.Controls.Add(this.dtgNgaySinh);
            this.grbNhanVien.Controls.Add(this.txtLop);
            this.grbNhanVien.Controls.Add(this.txtMaSV);
            this.grbNhanVien.Controls.Add(this.label7);
            this.grbNhanVien.Controls.Add(this.label5);
            this.grbNhanVien.Controls.Add(this.label6);
            this.grbNhanVien.Controls.Add(this.label4);
            this.grbNhanVien.Controls.Add(this.label2);
            this.grbNhanVien.Controls.Add(this.lbTenPhong);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(12, 93);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(555, 238);
            this.grbNhanVien.TabIndex = 27;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông Tin Độc Giả";
            // 
            // gbGT
            // 
            this.gbGT.Controls.Add(this.rbNu);
            this.gbGT.Controls.Add(this.rbNam);
            this.gbGT.Location = new System.Drawing.Point(139, 84);
            this.gbGT.Name = "gbGT";
            this.gbGT.Size = new System.Drawing.Size(179, 43);
            this.gbGT.TabIndex = 17;
            this.gbGT.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(78, 18);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(48, 23);
            this.rbNu.TabIndex = 0;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(6, 18);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 23);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(139, 165);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(323, 26);
            this.txtDiachi.TabIndex = 13;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(139, 57);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(323, 26);
            this.txtHoten.TabIndex = 12;
            // 
            // dtgNgaySinh
            // 
            this.dtgNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtgNgaySinh.Location = new System.Drawing.Point(139, 133);
            this.dtgNgaySinh.Name = "dtgNgaySinh";
            this.dtgNgaySinh.Size = new System.Drawing.Size(179, 26);
            this.dtgNgaySinh.TabIndex = 9;
            this.dtgNgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(139, 198);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(323, 26);
            this.txtLop.TabIndex = 6;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(139, 26);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(323, 26);
            this.txtMaSV.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lớp :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Độc Giả :";
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
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả :";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btlammoi);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btXoa);
            this.grbChucNang.Controls.Add(this.btSua);
            this.grbChucNang.Controls.Add(this.btThem);
            this.grbChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(589, 93);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(199, 238);
            this.grbChucNang.TabIndex = 28;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btlammoi
            // 
            this.btlammoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlammoi.BackgroundImage")));
            this.btlammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btlammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlammoi.Location = new System.Drawing.Point(55, 191);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(85, 39);
            this.btlammoi.TabIndex = 2;
            this.btlammoi.Text = "Làm Mới";
            this.btlammoi.UseVisualStyleBackColor = true;
            this.btlammoi.Click += new System.EventHandler(this.btlammoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(55, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 36);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(55, 106);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(85, 37);
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
            this.btSua.Location = new System.Drawing.Point(55, 65);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(85, 38);
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
            this.btThem.Location = new System.Drawing.Point(55, 25);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(85, 34);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(12, 337);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(776, 227);
            this.dgvDocGia.TabIndex = 29;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            this.dgvDocGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDocGia_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Xuất Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDocGia
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.MaximizeBox = false;
            this.Name = "frmDocGia";
            this.Text = "frmDocGia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDocGia_FormClosed);
            this.Load += new System.EventHandler(this.frmDocGia_Load);
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.gbGT.ResumeLayout(false);
            this.gbGT.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.DateTimePicker dtgNgaySinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.GroupBox gbGT;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Button button1;
    }
}