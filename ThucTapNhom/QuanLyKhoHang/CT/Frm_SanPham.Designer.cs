namespace QuanLyKhoHang.CT
{
    partial class Frm_SanPham
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
            this.btn_themmoi = new DevComponents.DotNetBar.ButtonX();
            this.btn_chophepsua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.bt_luu = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox_sanpham = new System.Windows.Forms.PictureBox();
            this.button8 = new DevComponents.DotNetBar.ButtonX();
            this.txb_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.tbx_masp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_tensp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txb_serial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txb_phanloai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txb_ncc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txb_soluong = new System.Windows.Forms.NumericUpDown();
            this.dtpicker_nsx = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpicker_hsd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txb_ghichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgv_SANPHAM = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txb_giasp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txb_madm = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker_nsx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker_hsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SANPHAM)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themmoi.Location = new System.Drawing.Point(12, 12);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(75, 23);
            this.btn_themmoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_themmoi.TabIndex = 0;
            this.btn_themmoi.Text = "Thêm";
            this.btn_themmoi.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_chophepsua
            // 
            this.btn_chophepsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chophepsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chophepsua.Location = new System.Drawing.Point(119, 12);
            this.btn_chophepsua.Name = "btn_chophepsua";
            this.btn_chophepsua.Size = new System.Drawing.Size(75, 23);
            this.btn_chophepsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chophepsua.TabIndex = 1;
            this.btn_chophepsua.Text = "Sửa";
            this.btn_chophepsua.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Location = new System.Drawing.Point(237, 12);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(472, 12);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 3;
            this.buttonX4.Text = "Refresh ";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_luu.Location = new System.Drawing.Point(351, 12);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_luu.TabIndex = 4;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Location = new System.Drawing.Point(788, 12);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(75, 23);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 5;
            this.buttonX6.Text = "Tìm Kiếm";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // pictureBox_sanpham
            // 
            this.pictureBox_sanpham.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox_sanpham.Location = new System.Drawing.Point(903, 12);
            this.pictureBox_sanpham.Name = "pictureBox_sanpham";
            this.pictureBox_sanpham.Size = new System.Drawing.Size(117, 141);
            this.pictureBox_sanpham.TabIndex = 58;
            this.pictureBox_sanpham.TabStop = false;
            // 
            // button8
            // 
            this.button8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button8.Location = new System.Drawing.Point(927, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button8.TabIndex = 59;
            this.button8.Text = "Tải Ảnh";
            this.button8.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // txb_timkiem
            // 
            // 
            // 
            // 
            this.txb_timkiem.Border.Class = "TextBoxBorder";
            this.txb_timkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txb_timkiem.Location = new System.Drawing.Point(587, 14);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.PreventEnterBeep = true;
            this.txb_timkiem.Size = new System.Drawing.Size(195, 20);
            this.txb_timkiem.TabIndex = 60;
            this.txb_timkiem.Enter += new System.EventHandler(this.txt_tk_enter);
            this.txb_timkiem.Leave += new System.EventHandler(this.txt_timkiem_leave);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(21, 66);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 61;
            this.labelX1.Text = "Mã Sản Phẩm";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(21, 103);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 62;
            this.labelX2.Text = "Tên Sản Phẩm";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(21, 137);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 63;
            this.labelX3.Text = "Nhà Cung Cấp";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(21, 173);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 64;
            this.labelX4.Text = "Danh Mục";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(328, 66);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 23);
            this.labelX5.TabIndex = 65;
            this.labelX5.Text = "Serial ";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(328, 175);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(62, 23);
            this.labelX6.TabIndex = 66;
            this.labelX6.Text = "Số Lượng";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(328, 104);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(58, 23);
            this.labelX7.TabIndex = 67;
            this.labelX7.Text = "Ngày SX";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(328, 141);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(58, 23);
            this.labelX8.TabIndex = 68;
            this.labelX8.Text = "HSD";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(610, 69);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 69;
            this.labelX9.Text = "Phân Loại";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(610, 102);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(60, 23);
            this.labelX10.TabIndex = 70;
            this.labelX10.Text = "Giá";
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(610, 141);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(60, 23);
            this.labelX11.TabIndex = 71;
            this.labelX11.Text = "Ghi Chú";
            // 
            // tbx_masp
            // 
            // 
            // 
            // 
            this.tbx_masp.Border.Class = "TextBoxBorder";
            this.tbx_masp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_masp.Location = new System.Drawing.Point(111, 69);
            this.tbx_masp.Name = "tbx_masp";
            this.tbx_masp.PreventEnterBeep = true;
            this.tbx_masp.Size = new System.Drawing.Size(181, 20);
            this.tbx_masp.TabIndex = 72;
            // 
            // tbx_tensp
            // 
            // 
            // 
            // 
            this.tbx_tensp.Border.Class = "TextBoxBorder";
            this.tbx_tensp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_tensp.Location = new System.Drawing.Point(111, 105);
            this.tbx_tensp.Name = "tbx_tensp";
            this.tbx_tensp.PreventEnterBeep = true;
            this.tbx_tensp.Size = new System.Drawing.Size(181, 20);
            this.tbx_tensp.TabIndex = 73;
            // 
            // txb_serial
            // 
            // 
            // 
            // 
            this.txb_serial.Border.Class = "TextBoxBorder";
            this.txb_serial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txb_serial.Location = new System.Drawing.Point(396, 69);
            this.txb_serial.Name = "txb_serial";
            this.txb_serial.PreventEnterBeep = true;
            this.txb_serial.Size = new System.Drawing.Size(170, 20);
            this.txb_serial.TabIndex = 74;
            // 
            // txb_phanloai
            // 
            // 
            // 
            // 
            this.txb_phanloai.Border.Class = "TextBoxBorder";
            this.txb_phanloai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txb_phanloai.Location = new System.Drawing.Point(676, 69);
            this.txb_phanloai.Name = "txb_phanloai";
            this.txb_phanloai.PreventEnterBeep = true;
            this.txb_phanloai.Size = new System.Drawing.Size(187, 20);
            this.txb_phanloai.TabIndex = 75;
            // 
            // txb_ncc
            // 
            this.txb_ncc.DisplayMember = "Text";
            this.txb_ncc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_ncc.FormattingEnabled = true;
            this.txb_ncc.ItemHeight = 14;
            this.txb_ncc.Location = new System.Drawing.Point(111, 143);
            this.txb_ncc.Name = "txb_ncc";
            this.txb_ncc.Size = new System.Drawing.Size(181, 20);
            this.txb_ncc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txb_ncc.TabIndex = 77;
            // 
            // txb_soluong
            // 
            this.txb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soluong.Location = new System.Drawing.Point(396, 176);
            this.txb_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txb_soluong.Name = "txb_soluong";
            this.txb_soluong.Size = new System.Drawing.Size(170, 20);
            this.txb_soluong.TabIndex = 79;
            this.txb_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpicker_nsx
            // 
            // 
            // 
            // 
            this.dtpicker_nsx.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpicker_nsx.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_nsx.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpicker_nsx.ButtonDropDown.Visible = true;
            this.dtpicker_nsx.IsPopupCalendarOpen = false;
            this.dtpicker_nsx.Location = new System.Drawing.Point(396, 105);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpicker_nsx.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_nsx.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpicker_nsx.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpicker_nsx.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_nsx.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dtpicker_nsx.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpicker_nsx.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpicker_nsx.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpicker_nsx.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpicker_nsx.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_nsx.MonthCalendar.TodayButtonVisible = true;
            this.dtpicker_nsx.Name = "dtpicker_nsx";
            this.dtpicker_nsx.Size = new System.Drawing.Size(170, 20);
            this.dtpicker_nsx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpicker_nsx.TabIndex = 80;
            // 
            // dtpicker_hsd
            // 
            // 
            // 
            // 
            this.dtpicker_hsd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpicker_hsd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_hsd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpicker_hsd.ButtonDropDown.Visible = true;
            this.dtpicker_hsd.IsPopupCalendarOpen = false;
            this.dtpicker_hsd.Location = new System.Drawing.Point(396, 143);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpicker_hsd.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_hsd.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpicker_hsd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpicker_hsd.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_hsd.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dtpicker_hsd.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpicker_hsd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpicker_hsd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpicker_hsd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpicker_hsd.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpicker_hsd.MonthCalendar.TodayButtonVisible = true;
            this.dtpicker_hsd.Name = "dtpicker_hsd";
            this.dtpicker_hsd.Size = new System.Drawing.Size(170, 20);
            this.dtpicker_hsd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpicker_hsd.TabIndex = 81;
            // 
            // txb_ghichu
            // 
            // 
            // 
            // 
            this.txb_ghichu.Border.Class = "TextBoxBorder";
            this.txb_ghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txb_ghichu.Location = new System.Drawing.Point(676, 143);
            this.txb_ghichu.Name = "txb_ghichu";
            this.txb_ghichu.PreventEnterBeep = true;
            this.txb_ghichu.Size = new System.Drawing.Size(187, 20);
            this.txb_ghichu.TabIndex = 82;
            // 
            // dgv_SANPHAM
            // 
            this.dgv_SANPHAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SANPHAM.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SANPHAM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_SANPHAM.Location = new System.Drawing.Point(12, 223);
            this.dgv_SANPHAM.Name = "dgv_SANPHAM";
            this.dgv_SANPHAM.Size = new System.Drawing.Size(1008, 186);
            this.dgv_SANPHAM.TabIndex = 83;
            this.dgv_SANPHAM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sp);
            // 
            // txb_giasp
            // 
            // 
            // 
            // 
            this.txb_giasp.Border.Class = "TextBoxBorder";
            this.txb_giasp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txb_giasp.Location = new System.Drawing.Point(676, 105);
            this.txb_giasp.Name = "txb_giasp";
            this.txb_giasp.PreventEnterBeep = true;
            this.txb_giasp.Size = new System.Drawing.Size(187, 20);
            this.txb_giasp.TabIndex = 84;
            // 
            // txb_madm
            // 
            this.txb_madm.DisplayMember = "Text";
            this.txb_madm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_madm.FormattingEnabled = true;
            this.txb_madm.ItemHeight = 14;
            this.txb_madm.Location = new System.Drawing.Point(111, 176);
            this.txb_madm.Name = "txb_madm";
            this.txb_madm.Size = new System.Drawing.Size(181, 20);
            this.txb_madm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txb_madm.TabIndex = 85;
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txb_madm);
            this.Controls.Add(this.txb_giasp);
            this.Controls.Add(this.dgv_SANPHAM);
            this.Controls.Add(this.txb_ghichu);
            this.Controls.Add(this.dtpicker_hsd);
            this.Controls.Add(this.dtpicker_nsx);
            this.Controls.Add(this.txb_soluong);
            this.Controls.Add(this.txb_ncc);
            this.Controls.Add(this.txb_phanloai);
            this.Controls.Add(this.txb_serial);
            this.Controls.Add(this.tbx_tensp);
            this.Controls.Add(this.tbx_masp);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txb_timkiem);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox_sanpham);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_chophepsua);
            this.Controls.Add(this.btn_themmoi);
            this.DoubleBuffered = true;
            this.Name = "Frm_SanPham";
            this.Size = new System.Drawing.Size(1036, 433);
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker_nsx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpicker_hsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SANPHAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_themmoi;
        private DevComponents.DotNetBar.ButtonX btn_chophepsua;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX bt_luu;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private System.Windows.Forms.PictureBox pictureBox_sanpham;
        private DevComponents.DotNetBar.ButtonX button8;
        private DevComponents.DotNetBar.Controls.TextBoxX txb_timkiem;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_masp;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_tensp;
        private DevComponents.DotNetBar.Controls.TextBoxX txb_serial;
        private DevComponents.DotNetBar.Controls.TextBoxX txb_phanloai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txb_ncc;
        private System.Windows.Forms.NumericUpDown txb_soluong;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpicker_nsx;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpicker_hsd;
        private DevComponents.DotNetBar.Controls.TextBoxX txb_ghichu;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_SANPHAM;
        private DevComponents.DotNetBar.Controls.TextBoxX txb_giasp;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txb_madm;
    }
}