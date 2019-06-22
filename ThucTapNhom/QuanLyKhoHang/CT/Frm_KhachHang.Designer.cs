namespace QuanLyKhoHang.CT
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_lammoi = new DevComponents.DotNetBar.ButtonX();
            this.bt_luu = new DevComponents.DotNetBar.ButtonX();
            this.bt_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.tbx_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.dgvKhachHang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tbx_makh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_tenkh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_gioitinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_dienthoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_fax = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_lammoi.Location = new System.Drawing.Point(432, 12);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(85, 30);
            this.btn_lammoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_lammoi.TabIndex = 24;
            this.btn_lammoi.Text = "Refresh ";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.Image = ((System.Drawing.Image)(resources.GetObject("bt_luu.Image")));
            this.bt_luu.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bt_luu.Location = new System.Drawing.Point(327, 12);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 30);
            this.bt_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_luu.TabIndex = 23;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bt_xoa.Location = new System.Drawing.Point(222, 12);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 30);
            this.bt_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_xoa.TabIndex = 22;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_sua.Location = new System.Drawing.Point(117, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 30);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_them.Location = new System.Drawing.Point(12, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 30);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_timkiem
            // 
            // 
            // 
            // 
            this.tbx_timkiem.Border.Class = "TextBoxBorder";
            this.tbx_timkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_timkiem.Location = new System.Drawing.Point(542, 15);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.PreventEnterBeep = true;
            this.tbx_timkiem.Size = new System.Drawing.Size(195, 22);
            this.tbx_timkiem.TabIndex = 26;
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX6.Location = new System.Drawing.Point(743, 12);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(90, 30);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 25;
            this.buttonX6.Text = "Tìm Kiếm";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(240, 70);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(785, 354);
            this.dgvKhachHang.TabIndex = 27;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhacungcap_CellContentClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 87);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 23);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "Mã KH";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 127);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 23);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "Tên KH";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 167);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 23);
            this.labelX3.TabIndex = 30;
            this.labelX3.Text = "Địa Chỉ";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 207);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(55, 23);
            this.labelX4.TabIndex = 31;
            this.labelX4.Text = "Giới Tính";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 247);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 23);
            this.labelX5.TabIndex = 32;
            this.labelX5.Text = "Điện Thoại";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(12, 287);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(44, 23);
            this.labelX6.TabIndex = 33;
            this.labelX6.Text = "Email";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(12, 327);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 23);
            this.labelX7.TabIndex = 34;
            this.labelX7.Text = "Fax";
            // 
            // tbx_makh
            // 
            // 
            // 
            // 
            this.tbx_makh.Border.Class = "TextBoxBorder";
            this.tbx_makh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_makh.Location = new System.Drawing.Point(82, 90);
            this.tbx_makh.Name = "tbx_makh";
            this.tbx_makh.PreventEnterBeep = true;
            this.tbx_makh.Size = new System.Drawing.Size(130, 20);
            this.tbx_makh.TabIndex = 35;
            // 
            // tbx_tenkh
            // 
            // 
            // 
            // 
            this.tbx_tenkh.Border.Class = "TextBoxBorder";
            this.tbx_tenkh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_tenkh.Location = new System.Drawing.Point(82, 130);
            this.tbx_tenkh.Name = "tbx_tenkh";
            this.tbx_tenkh.PreventEnterBeep = true;
            this.tbx_tenkh.Size = new System.Drawing.Size(130, 20);
            this.tbx_tenkh.TabIndex = 36;
            // 
            // tbx_diachi
            // 
            // 
            // 
            // 
            this.tbx_diachi.Border.Class = "TextBoxBorder";
            this.tbx_diachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_diachi.Location = new System.Drawing.Point(82, 170);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.PreventEnterBeep = true;
            this.tbx_diachi.Size = new System.Drawing.Size(130, 20);
            this.tbx_diachi.TabIndex = 37;
            this.tbx_diachi.TextChanged += new System.EventHandler(this.textBoxX3_TextChanged);
            // 
            // tbx_gioitinh
            // 
            // 
            // 
            // 
            this.tbx_gioitinh.Border.Class = "TextBoxBorder";
            this.tbx_gioitinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_gioitinh.Location = new System.Drawing.Point(82, 210);
            this.tbx_gioitinh.Name = "tbx_gioitinh";
            this.tbx_gioitinh.PreventEnterBeep = true;
            this.tbx_gioitinh.Size = new System.Drawing.Size(130, 20);
            this.tbx_gioitinh.TabIndex = 38;
            // 
            // tbx_dienthoai
            // 
            // 
            // 
            // 
            this.tbx_dienthoai.Border.Class = "TextBoxBorder";
            this.tbx_dienthoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_dienthoai.Location = new System.Drawing.Point(82, 250);
            this.tbx_dienthoai.Name = "tbx_dienthoai";
            this.tbx_dienthoai.PreventEnterBeep = true;
            this.tbx_dienthoai.Size = new System.Drawing.Size(130, 20);
            this.tbx_dienthoai.TabIndex = 39;
            // 
            // tbx_email
            // 
            // 
            // 
            // 
            this.tbx_email.Border.Class = "TextBoxBorder";
            this.tbx_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_email.Location = new System.Drawing.Point(82, 290);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.PreventEnterBeep = true;
            this.tbx_email.Size = new System.Drawing.Size(130, 20);
            this.tbx_email.TabIndex = 40;
            // 
            // tbx_fax
            // 
            // 
            // 
            // 
            this.tbx_fax.Border.Class = "TextBoxBorder";
            this.tbx_fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_fax.Location = new System.Drawing.Point(82, 330);
            this.tbx_fax.Name = "tbx_fax";
            this.tbx_fax.PreventEnterBeep = true;
            this.tbx_fax.Size = new System.Drawing.Size(130, 20);
            this.tbx_fax.TabIndex = 41;
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbx_fax);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_dienthoai);
            this.Controls.Add(this.tbx_gioitinh);
            this.Controls.Add(this.tbx_diachi);
            this.Controls.Add(this.tbx_tenkh);
            this.Controls.Add(this.tbx_makh);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.tbx_timkiem);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.DoubleBuffered = true;
            this.Name = "Frm_KhachHang";
            this.Size = new System.Drawing.Size(1040, 440);
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_lammoi;
        private DevComponents.DotNetBar.ButtonX bt_luu;
        private DevComponents.DotNetBar.ButtonX bt_xoa;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_timkiem;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKhachHang;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_makh;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_tenkh;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_diachi;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_gioitinh;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_dienthoai;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_email;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_fax;
    }
}