﻿namespace QuanLyKhoHang.CT
{
    partial class Frm_ChiTietPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTimCT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_xoa = new DevComponents.DotNetBar.ButtonX();
            this.bt_them = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cb_maphieu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txt_soluong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_dongia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_sanpham = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.dt_ChiTietPhieuNhap = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bt_luu = new DevComponents.DotNetBar.ButtonX();
            this.bt_thoat = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimCT
            // 
            // 
            // 
            // 
            this.txtTimCT.Border.Class = "TextBoxBorder";
            this.txtTimCT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimCT.Location = new System.Drawing.Point(170, 15);
            this.txtTimCT.Name = "txtTimCT";
            this.txtTimCT.PreventEnterBeep = true;
            this.txtTimCT.Size = new System.Drawing.Size(148, 20);
            this.txtTimCT.TabIndex = 30;
            // 
            // bt_xoa
            // 
            this.bt_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_xoa.Location = new System.Drawing.Point(87, 12);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_xoa.TabIndex = 29;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_them.Location = new System.Drawing.Point(6, 12);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_them.TabIndex = 28;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.bt_thoat);
            this.groupPanel2.Controls.Add(this.bt_luu);
            this.groupPanel2.Controls.Add(this.cb_maphieu);
            this.groupPanel2.Controls.Add(this.buttonX9);
            this.groupPanel2.Controls.Add(this.txtTimCT);
            this.groupPanel2.Controls.Add(this.bt_xoa);
            this.groupPanel2.Controls.Add(this.bt_them);
            this.groupPanel2.Controls.Add(this.labelX11);
            this.groupPanel2.Controls.Add(this.labelX10);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Controls.Add(this.txt_soluong);
            this.groupPanel2.Controls.Add(this.txt_dongia);
            this.groupPanel2.Controls.Add(this.cb_sanpham);
            this.groupPanel2.Controls.Add(this.labelX8);
            this.groupPanel2.Controls.Add(this.dt_ChiTietPhieuNhap);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(800, 450);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // cb_maphieu
            // 
            this.cb_maphieu.DisplayMember = "Text";
            this.cb_maphieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_maphieu.FormattingEnabled = true;
            this.cb_maphieu.ItemHeight = 14;
            this.cb_maphieu.Location = new System.Drawing.Point(56, 57);
            this.cb_maphieu.Name = "cb_maphieu";
            this.cb_maphieu.Size = new System.Drawing.Size(81, 20);
            this.cb_maphieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_maphieu.TabIndex = 32;
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX9.Location = new System.Drawing.Point(323, 12);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(75, 23);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.TabIndex = 31;
            this.buttonX9.Text = "Tìm Kiếm";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(3, 175);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(43, 23);
            this.labelX11.TabIndex = 27;
            this.labelX11.Text = "Đơn Giá";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(3, 135);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(50, 23);
            this.labelX10.TabIndex = 26;
            this.labelX10.Text = "Số Lượng";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(3, 95);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(43, 23);
            this.labelX9.TabIndex = 25;
            this.labelX9.Text = "Tên SP";
            // 
            // txt_soluong
            // 
            // 
            // 
            // 
            this.txt_soluong.Border.Class = "TextBoxBorder";
            this.txt_soluong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_soluong.Location = new System.Drawing.Point(56, 137);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PreventEnterBeep = true;
            this.txt_soluong.Size = new System.Drawing.Size(81, 20);
            this.txt_soluong.TabIndex = 24;
            // 
            // txt_dongia
            // 
            // 
            // 
            // 
            this.txt_dongia.Border.Class = "TextBoxBorder";
            this.txt_dongia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dongia.Location = new System.Drawing.Point(56, 177);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.PreventEnterBeep = true;
            this.txt_dongia.Size = new System.Drawing.Size(81, 20);
            this.txt_dongia.TabIndex = 23;
            // 
            // cb_sanpham
            // 
            this.cb_sanpham.DisplayMember = "Text";
            this.cb_sanpham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_sanpham.FormattingEnabled = true;
            this.cb_sanpham.ItemHeight = 14;
            this.cb_sanpham.Location = new System.Drawing.Point(56, 97);
            this.cb_sanpham.Name = "cb_sanpham";
            this.cb_sanpham.Size = new System.Drawing.Size(81, 20);
            this.cb_sanpham.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_sanpham.TabIndex = 22;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(3, 54);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(35, 23);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "Mã PN";
            // 
            // dt_ChiTietPhieuNhap
            // 
            this.dt_ChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_ChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dt_ChiTietPhieuNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dt_ChiTietPhieuNhap.Location = new System.Drawing.Point(6, 261);
            this.dt_ChiTietPhieuNhap.Name = "dt_ChiTietPhieuNhap";
            this.dt_ChiTietPhieuNhap.Size = new System.Drawing.Size(779, 165);
            this.dt_ChiTietPhieuNhap.TabIndex = 8;
            this.dt_ChiTietPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_ChiTietPhieuNhap_CellContentClick);
            // 
            // bt_luu
            // 
            this.bt_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_luu.Location = new System.Drawing.Point(360, 203);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_luu.TabIndex = 33;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_thoat.Location = new System.Drawing.Point(433, 97);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_thoat.TabIndex = 34;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Frm_ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupPanel2);
            this.DoubleBuffered = true;
            this.Name = "Frm_ChiTietPhieuNhap";
            this.Text = "Frm_ChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.Frm_ChiTietPhieuNhap_Load);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_ChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtTimCT;
        private DevComponents.DotNetBar.ButtonX bt_xoa;
        private DevComponents.DotNetBar.ButtonX bt_them;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_maphieu;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_soluong;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_dongia;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_sanpham;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dt_ChiTietPhieuNhap;
        private DevComponents.DotNetBar.ButtonX bt_luu;
        private DevComponents.DotNetBar.ButtonX bt_thoat;
    }
}