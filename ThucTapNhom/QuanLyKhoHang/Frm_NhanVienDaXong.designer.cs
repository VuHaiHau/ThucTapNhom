namespace QuanLyKhoHang
{
    partial class Frm_NhanVienDaXong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhanVienDaXong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_nv = new System.Windows.Forms.ComboBox();
            this.lbx_nv = new System.Windows.Forms.Label();
            this.cbx_trangthai = new System.Windows.Forms.CheckBox();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.tbx_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.btn_lammoi = new DevComponents.DotNetBar.ButtonX();
            this.btn_ghinhan = new DevComponents.DotNetBar.ButtonX();
            this.bt_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbx_MaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbx_TenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePicker_NS = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.pn_radio = new System.Windows.Forms.Panel();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbx_chucvu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.tbx_DiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_luong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.tbx_Email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.tbx_DienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.tbx_MaBP = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.pc_nhanvien = new System.Windows.Forms.PictureBox();
            this.btn_file = new DevComponents.DotNetBar.ButtonX();
            this.lbx_trangthai = new DevComponents.DotNetBar.LabelX();
            this.dgvNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker_NS)).BeginInit();
            this.pn_radio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_nv
            // 
            this.cbx_nv.FormattingEnabled = true;
            this.cbx_nv.Items.AddRange(new object[] {
            "Đang Làm",
            "Đã Nghỉ",
            "Tất Cả"});
            this.cbx_nv.Location = new System.Drawing.Point(861, 404);
            this.cbx_nv.Name = "cbx_nv";
            this.cbx_nv.Size = new System.Drawing.Size(154, 21);
            this.cbx_nv.TabIndex = 19;
            this.cbx_nv.SelectedIndexChanged += new System.EventHandler(this.cbx_nv_SelectedIndexChanged_1);
            // 
            // lbx_nv
            // 
            this.lbx_nv.AutoSize = true;
            this.lbx_nv.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_nv.Location = new System.Drawing.Point(703, 404);
            this.lbx_nv.Name = "lbx_nv";
            this.lbx_nv.Size = new System.Drawing.Size(137, 22);
            this.lbx_nv.TabIndex = 1;
            this.lbx_nv.Text = "Xem Nhân Viên";
            // 
            // cbx_trangthai
            // 
            this.cbx_trangthai.AutoSize = true;
            this.cbx_trangthai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_trangthai.Location = new System.Drawing.Point(667, 135);
            this.cbx_trangthai.Name = "cbx_trangthai";
            this.cbx_trangthai.Size = new System.Drawing.Size(88, 17);
            this.cbx_trangthai.TabIndex = 29;
            this.cbx_trangthai.Text = "Đang Đi Làm";
            this.cbx_trangthai.UseVisualStyleBackColor = true;
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
            this.btn_them.TabIndex = 31;
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
            this.tbx_timkiem.Location = new System.Drawing.Point(518, 14);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.PreventEnterBeep = true;
            this.tbx_timkiem.Size = new System.Drawing.Size(195, 22);
            this.tbx_timkiem.TabIndex = 39;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_timkiem);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txttimkiem_leave);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX6.Location = new System.Drawing.Point(719, 12);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(90, 30);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 38;
            this.buttonX6.Text = "Tìm Kiếm";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.Image")));
            this.btn_lammoi.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_lammoi.Location = new System.Drawing.Point(412, 12);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(85, 30);
            this.btn_lammoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_lammoi.TabIndex = 37;
            this.btn_lammoi.Text = "Refresh ";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ghinhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_ghinhan.Image")));
            this.btn_ghinhan.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_ghinhan.Location = new System.Drawing.Point(312, 12);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(75, 30);
            this.btn_ghinhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ghinhan.TabIndex = 36;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bt_xoa.Location = new System.Drawing.Point(212, 12);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 30);
            this.bt_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_xoa.TabIndex = 35;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btn_sua.Location = new System.Drawing.Point(112, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 30);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(27, 58);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(48, 23);
            this.labelX1.TabIndex = 40;
            this.labelX1.Text = "Mã NV";
            // 
            // tbx_MaNV
            // 
            // 
            // 
            // 
            this.tbx_MaNV.Border.Class = "TextBoxBorder";
            this.tbx_MaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_MaNV.Location = new System.Drawing.Point(96, 60);
            this.tbx_MaNV.Name = "tbx_MaNV";
            this.tbx_MaNV.PreventEnterBeep = true;
            this.tbx_MaNV.Size = new System.Drawing.Size(157, 20);
            this.tbx_MaNV.TabIndex = 48;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(27, 92);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(48, 23);
            this.labelX2.TabIndex = 49;
            this.labelX2.Text = "Tên NV";
            // 
            // tbx_TenNV
            // 
            // 
            // 
            // 
            this.tbx_TenNV.Border.Class = "TextBoxBorder";
            this.tbx_TenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_TenNV.Location = new System.Drawing.Point(96, 95);
            this.tbx_TenNV.Name = "tbx_TenNV";
            this.tbx_TenNV.PreventEnterBeep = true;
            this.tbx_TenNV.Size = new System.Drawing.Size(157, 20);
            this.tbx_TenNV.TabIndex = 50;
            this.tbx_TenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tennv);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(27, 128);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(63, 23);
            this.labelX3.TabIndex = 51;
            this.labelX3.Text = "Ngày Sinh";
            // 
            // dateTimePicker_NS
            // 
            // 
            // 
            // 
            this.dateTimePicker_NS.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimePicker_NS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePicker_NS.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimePicker_NS.ButtonDropDown.Visible = true;
            this.dateTimePicker_NS.IsPopupCalendarOpen = false;
            this.dateTimePicker_NS.Location = new System.Drawing.Point(96, 130);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dateTimePicker_NS.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePicker_NS.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dateTimePicker_NS.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimePicker_NS.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePicker_NS.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker_NS.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dateTimePicker_NS.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimePicker_NS.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimePicker_NS.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimePicker_NS.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dateTimePicker_NS.MonthCalendar.TodayButtonVisible = true;
            this.dateTimePicker_NS.Name = "dateTimePicker_NS";
            this.dateTimePicker_NS.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker_NS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimePicker_NS.TabIndex = 57;
            // 
            // pn_radio
            // 
            this.pn_radio.Controls.Add(this.rbtn_Nu);
            this.pn_radio.Controls.Add(this.rbtn_Nam);
            this.pn_radio.Location = new System.Drawing.Point(96, 165);
            this.pn_radio.Name = "pn_radio";
            this.pn_radio.Size = new System.Drawing.Size(157, 31);
            this.pn_radio.TabIndex = 58;
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Location = new System.Drawing.Point(72, 2);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(39, 17);
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
            this.rbtn_Nam.Size = new System.Drawing.Size(47, 17);
            this.rbtn_Nam.TabIndex = 5;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(27, 168);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(60, 23);
            this.labelX4.TabIndex = 59;
            this.labelX4.Text = "Giới Tính";
            // 
            // tbx_chucvu
            // 
            // 
            // 
            // 
            this.tbx_chucvu.Border.Class = "TextBoxBorder";
            this.tbx_chucvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_chucvu.Location = new System.Drawing.Point(373, 58);
            this.tbx_chucvu.Name = "tbx_chucvu";
            this.tbx_chucvu.PreventEnterBeep = true;
            this.tbx_chucvu.Size = new System.Drawing.Size(175, 20);
            this.tbx_chucvu.TabIndex = 60;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(297, 56);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(60, 23);
            this.labelX5.TabIndex = 61;
            this.labelX5.Text = "Chức Vụ";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(297, 92);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(60, 23);
            this.labelX6.TabIndex = 62;
            this.labelX6.Text = "Địa Chỉ";
            // 
            // tbx_DiaChi
            // 
            // 
            // 
            // 
            this.tbx_DiaChi.Border.Class = "TextBoxBorder";
            this.tbx_DiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_DiaChi.Location = new System.Drawing.Point(373, 95);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.PreventEnterBeep = true;
            this.tbx_DiaChi.Size = new System.Drawing.Size(175, 20);
            this.tbx_DiaChi.TabIndex = 63;
            // 
            // tbx_luong
            // 
            // 
            // 
            // 
            this.tbx_luong.Border.Class = "TextBoxBorder";
            this.tbx_luong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_luong.Location = new System.Drawing.Point(373, 131);
            this.tbx_luong.Name = "tbx_luong";
            this.tbx_luong.PreventEnterBeep = true;
            this.tbx_luong.Size = new System.Drawing.Size(175, 20);
            this.tbx_luong.TabIndex = 64;
            this.tbx_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Luong);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(297, 130);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(46, 23);
            this.labelX7.TabIndex = 65;
            this.labelX7.Text = "Lương";
            // 
            // tbx_Email
            // 
            // 
            // 
            // 
            this.tbx_Email.Border.Class = "TextBoxBorder";
            this.tbx_Email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_Email.Location = new System.Drawing.Point(373, 168);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.PreventEnterBeep = true;
            this.tbx_Email.Size = new System.Drawing.Size(175, 20);
            this.tbx_Email.TabIndex = 66;
            this.tbx_Email.Leave += new System.EventHandler(this.txt_email);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(297, 167);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(46, 23);
            this.labelX8.TabIndex = 67;
            this.labelX8.Text = "Email";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(595, 59);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 68;
            this.labelX9.Text = "Điện Thoại";
            // 
            // tbx_DienThoai
            // 
            // 
            // 
            // 
            this.tbx_DienThoai.Border.Class = "TextBoxBorder";
            this.tbx_DienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_DienThoai.Location = new System.Drawing.Point(667, 61);
            this.tbx_DienThoai.Name = "tbx_DienThoai";
            this.tbx_DienThoai.PreventEnterBeep = true;
            this.tbx_DienThoai.Size = new System.Drawing.Size(127, 20);
            this.tbx_DienThoai.TabIndex = 69;
            this.tbx_DienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dt);
            this.tbx_DienThoai.Leave += new System.EventHandler(this.txt_dt_leave);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(595, 94);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 70;
            this.labelX10.Text = "Bộ Phận";
            // 
            // tbx_MaBP
            // 
            this.tbx_MaBP.DisplayMember = "Text";
            this.tbx_MaBP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbx_MaBP.FormattingEnabled = true;
            this.tbx_MaBP.ItemHeight = 14;
            this.tbx_MaBP.Location = new System.Drawing.Point(667, 95);
            this.tbx_MaBP.Name = "tbx_MaBP";
            this.tbx_MaBP.Size = new System.Drawing.Size(127, 20);
            this.tbx_MaBP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbx_MaBP.TabIndex = 71;
            // 
            // pc_nhanvien
            // 
            this.pc_nhanvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pc_nhanvien.Location = new System.Drawing.Point(872, 9);
            this.pc_nhanvien.Name = "pc_nhanvien";
            this.pc_nhanvien.Size = new System.Drawing.Size(118, 132);
            this.pc_nhanvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_nhanvien.TabIndex = 72;
            this.pc_nhanvien.TabStop = false;
            // 
            // btn_file
            // 
            this.btn_file.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_file.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_file.Location = new System.Drawing.Point(898, 161);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 25);
            this.btn_file.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_file.TabIndex = 73;
            this.btn_file.Text = "Tải Ảnh";
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // lbx_trangthai
            // 
            // 
            // 
            // 
            this.lbx_trangthai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbx_trangthai.Location = new System.Drawing.Point(595, 131);
            this.lbx_trangthai.Name = "lbx_trangthai";
            this.lbx_trangthai.Size = new System.Drawing.Size(66, 23);
            this.lbx_trangthai.TabIndex = 74;
            this.lbx_trangthai.Text = "Trạng Thái";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 211);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1003, 176);
            this.dgvNhanVien.TabIndex = 75;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lbx_trangthai);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.pc_nhanvien);
            this.Controls.Add(this.tbx_MaBP);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.tbx_DienThoai);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.tbx_Email);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.tbx_luong);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbx_chucvu);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.pn_radio);
            this.Controls.Add(this.dateTimePicker_NS);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbx_TenNV);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbx_MaNV);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbx_timkiem);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_ghinhan);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cbx_nv);
            this.Controls.Add(this.lbx_nv);
            this.Controls.Add(this.cbx_trangthai);
            this.DoubleBuffered = true;
            this.Name = "Frm_NhanVien";
            this.Size = new System.Drawing.Size(1041, 440);
            this.Load += new System.EventHandler(this.NhanVIen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePicker_NS)).EndInit();
            this.pn_radio.ResumeLayout(false);
            this.pn_radio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_nv;
        private System.Windows.Forms.Label lbx_nv;
        private System.Windows.Forms.CheckBox cbx_trangthai;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_timkiem;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX btn_lammoi;
        private DevComponents.DotNetBar.ButtonX btn_ghinhan;
        private DevComponents.DotNetBar.ButtonX bt_xoa;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_MaNV;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_TenNV;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimePicker_NS;
        private System.Windows.Forms.Panel pn_radio;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_chucvu;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_DiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_luong;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_Email;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_DienThoai;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tbx_MaBP;
        private System.Windows.Forms.PictureBox pc_nhanvien;
        private DevComponents.DotNetBar.ButtonX btn_file;
        private DevComponents.DotNetBar.LabelX lbx_trangthai;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNhanVien;
    }
}