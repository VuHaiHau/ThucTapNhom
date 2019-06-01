namespace TTN_QLTV
{
    partial class frmTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLoai));
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatl = new System.Windows.Forms.TextBox();
            this.txttentl = new System.Windows.Forms.TextBox();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btlammoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvtheloai = new System.Windows.Forms.DataGridView();
            this.thongke = new System.Windows.Forms.Button();
            this.cbxtheloai = new System.Windows.Forms.ComboBox();
            this.grbNhanVien.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thể Loại :";
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(136, 149);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(0, 19);
            this.lbTenPhong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thể Loại :";
            // 
            // txtmatl
            // 
            this.txtmatl.Location = new System.Drawing.Point(140, 82);
            this.txtmatl.Name = "txtmatl";
            this.txtmatl.Size = new System.Drawing.Size(230, 26);
            this.txtmatl.TabIndex = 0;
            // 
            // txttentl
            // 
            this.txttentl.Location = new System.Drawing.Point(142, 161);
            this.txttentl.Name = "txttentl";
            this.txttentl.Size = new System.Drawing.Size(231, 26);
            this.txttentl.TabIndex = 1;
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.Controls.Add(this.txttentl);
            this.grbNhanVien.Controls.Add(this.txtmatl);
            this.grbNhanVien.Controls.Add(this.label2);
            this.grbNhanVien.Controls.Add(this.lbTenPhong);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(25, 95);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(407, 249);
            this.grbNhanVien.TabIndex = 12;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông Tin Thể Loại";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btlammoi);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btXoa);
            this.grbChucNang.Controls.Add(this.btSua);
            this.grbChucNang.Controls.Add(this.btThem);
            this.grbChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(453, 95);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(186, 249);
            this.grbChucNang.TabIndex = 30;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btlammoi
            // 
            this.btlammoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlammoi.BackgroundImage")));
            this.btlammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btlammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlammoi.Location = new System.Drawing.Point(44, 196);
            this.btlammoi.Name = "btlammoi";
            this.btlammoi.Size = new System.Drawing.Size(84, 34);
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
            this.btnLuu.Location = new System.Drawing.Point(44, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 38);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Ghi Nhận";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btXoa.BackgroundImage")));
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(44, 110);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(84, 33);
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
            this.btSua.Location = new System.Drawing.Point(44, 68);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(84, 36);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(44, 23);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(84, 35);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvtheloai
            // 
            this.dgvtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtheloai.Location = new System.Drawing.Point(25, 362);
            this.dgvtheloai.Name = "dgvtheloai";
            this.dgvtheloai.Size = new System.Drawing.Size(614, 216);
            this.dgvtheloai.TabIndex = 33;
            this.dgvtheloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtheloai_CellClick);
            // 
            // thongke
            // 
            this.thongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.Location = new System.Drawing.Point(198, 25);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(234, 29);
            this.thongke.TabIndex = 34;
            this.thongke.Text = "Thống Kê Sách Theo Thể Loại";
            this.thongke.UseVisualStyleBackColor = true;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // cbxtheloai
            // 
            this.cbxtheloai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxtheloai.FormattingEnabled = true;
            this.cbxtheloai.Location = new System.Drawing.Point(453, 27);
            this.cbxtheloai.Name = "cbxtheloai";
            this.cbxtheloai.Size = new System.Drawing.Size(138, 27);
            this.cbxtheloai.TabIndex = 35;
            this.cbxtheloai.SelectedIndexChanged += new System.EventHandler(this.cbxtheloai_SelectedIndexChanged);
            // 
            // frmTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 584);
            this.Controls.Add(this.cbxtheloai);
            this.Controls.Add(this.thongke);
            this.Controls.Add(this.dgvtheloai);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbNhanVien);
            this.MaximizeBox = false;
            this.Name = "frmTheLoai";
            this.Text = "TheLoai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTheLoai_FormClosed);
            this.Load += new System.EventHandler(this.TheLoai_Load);
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtheloai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatl;
        private System.Windows.Forms.TextBox txttentl;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btlammoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvtheloai;
        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.ComboBox cbxtheloai;
    }
}