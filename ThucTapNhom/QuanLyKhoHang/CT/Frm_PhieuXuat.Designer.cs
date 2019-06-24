namespace QuanLyKhoHang.CT
{
    partial class Frm_PhieuXuat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PhieuXuat));
            this.dtgrPN = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYXUAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XEMCT = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.cb_NCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.cb_khohang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbx_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.txt_ghichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dt_ngaynhap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cb_NhanVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_maphieu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhap)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrPN
            // 
            this.dtgrPN.AllowUserToAddRows = false;
            this.dtgrPN.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPX,
            this.TENKHO,
            this.TENNV,
            this.NGAYXUAT,
            this.TONGTIEN,
            this.GHICHU,
            this.TENKH,
            this.XEMCT});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrPN.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrPN.EnableHeadersVisualStyles = false;
            this.dtgrPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dtgrPN.Location = new System.Drawing.Point(213, 54);
            this.dtgrPN.Name = "dtgrPN";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrPN.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrPN.Size = new System.Drawing.Size(796, 320);
            this.dtgrPN.TabIndex = 25;
            this.dtgrPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrPN_CellClick);
            // 
            // MAPX
            // 
            this.MAPX.DataPropertyName = "MAPX";
            this.MAPX.HeaderText = "Mã Phiếu Xuất";
            this.MAPX.Name = "MAPX";
            // 
            // TENKHO
            // 
            this.TENKHO.DataPropertyName = "TENKHO";
            this.TENKHO.HeaderText = "Kho Hàng";
            this.TENKHO.Name = "TENKHO";
            // 
            // TENNV
            // 
            this.TENNV.DataPropertyName = "TENNV";
            this.TENNV.HeaderText = "Tên Nhân Viên";
            this.TENNV.Name = "TENNV";
            // 
            // NGAYXUAT
            // 
            this.NGAYXUAT.DataPropertyName = "NGAYXUAT";
            this.NGAYXUAT.HeaderText = "Ngày Xuất";
            this.NGAYXUAT.Name = "NGAYXUAT";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi Chú";
            this.GHICHU.Name = "GHICHU";
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên Khách Hàng";
            this.TENKH.Name = "TENKH";
            // 
            // XEMCT
            // 
            this.XEMCT.HeaderText = "Thao Tác";
            this.XEMCT.Name = "XEMCT";
            this.XEMCT.Text = "Xem Chi Tiết";
            this.XEMCT.UseColumnTextForButtonValue = true;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnLuu.Location = new System.Drawing.Point(309, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 30);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // cb_NCC
            // 
            this.cb_NCC.DisplayMember = "Text";
            this.cb_NCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.ItemHeight = 17;
            this.cb_NCC.Location = new System.Drawing.Point(89, 314);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(112, 23);
            this.cb_NCC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_NCC.TabIndex = 23;
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.Location = new System.Drawing.Point(873, 12);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(135, 30);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 22;
            this.buttonX6.Text = "In Phiếu Xuất";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // cb_khohang
            // 
            this.cb_khohang.DisplayMember = "Text";
            this.cb_khohang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_khohang.FormattingEnabled = true;
            this.cb_khohang.ItemHeight = 17;
            this.cb_khohang.Location = new System.Drawing.Point(89, 114);
            this.cb_khohang.Name = "cb_khohang";
            this.cb_khohang.Size = new System.Drawing.Size(112, 23);
            this.cb_khohang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_khohang.TabIndex = 21;
            // 
            // tbx_timkiem
            // 
            // 
            // 
            // 
            this.tbx_timkiem.Border.Class = "TextBoxBorder";
            this.tbx_timkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_timkiem.Location = new System.Drawing.Point(507, 16);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.PreventEnterBeep = true;
            this.tbx_timkiem.Size = new System.Drawing.Size(236, 22);
            this.tbx_timkiem.TabIndex = 20;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_timkiem_leave);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Image = ((System.Drawing.Image)(resources.GetObject("buttonX5.Image")));
            this.buttonX5.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonX5.Location = new System.Drawing.Point(749, 12);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(95, 30);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 19;
            this.buttonX5.Text = "Tìm Kiếm";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click_1);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.buttonX4.Location = new System.Drawing.Point(409, 12);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(75, 30);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 18;
            this.buttonX4.Text = "Refresh";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btXoa.Location = new System.Drawing.Point(209, 12);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 30);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btSua.Location = new System.Drawing.Point(109, 12);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 30);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btThem.Location = new System.Drawing.Point(9, 12);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 30);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // txt_ghichu
            // 
            // 
            // 
            // 
            this.txt_ghichu.Border.Class = "TextBoxBorder";
            this.txt_ghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ghichu.Location = new System.Drawing.Point(89, 274);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.PreventEnterBeep = true;
            this.txt_ghichu.Size = new System.Drawing.Size(112, 22);
            this.txt_ghichu.TabIndex = 13;
            // 
            // dt_ngaynhap
            // 
            // 
            // 
            // 
            this.dt_ngaynhap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dt_ngaynhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaynhap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dt_ngaynhap.ButtonDropDown.Visible = true;
            this.dt_ngaynhap.IsPopupCalendarOpen = false;
            this.dt_ngaynhap.Location = new System.Drawing.Point(89, 194);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dt_ngaynhap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaynhap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dt_ngaynhap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dt_ngaynhap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaynhap.MonthCalendar.DisplayMonth = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            this.dt_ngaynhap.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dt_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dt_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dt_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dt_ngaynhap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dt_ngaynhap.MonthCalendar.TodayButtonVisible = true;
            this.dt_ngaynhap.Name = "dt_ngaynhap";
            this.dt_ngaynhap.Size = new System.Drawing.Size(112, 22);
            this.dt_ngaynhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dt_ngaynhap.TabIndex = 12;
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.DisplayMember = "Text";
            this.cb_NhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.ItemHeight = 17;
            this.cb_NhanVien.Location = new System.Drawing.Point(89, 154);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(112, 23);
            this.cb_NhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_NhanVien.TabIndex = 11;
            // 
            // txtTongTien
            // 
            // 
            // 
            // 
            this.txtTongTien.Border.Class = "TextBoxBorder";
            this.txtTongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTongTien.Location = new System.Drawing.Point(89, 234);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PreventEnterBeep = true;
            this.txtTongTien.Size = new System.Drawing.Size(112, 22);
            this.txtTongTien.TabIndex = 10;
            // 
            // txt_maphieu
            // 
            // 
            // 
            // 
            this.txt_maphieu.Border.Class = "TextBoxBorder";
            this.txt_maphieu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_maphieu.Location = new System.Drawing.Point(89, 74);
            this.txt_maphieu.Name = "txt_maphieu";
            this.txt_maphieu.PreventEnterBeep = true;
            this.txt_maphieu.Size = new System.Drawing.Size(112, 22);
            this.txt_maphieu.TabIndex = 8;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(9, 313);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Khách Hàng";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(9, 273);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Ghi Chú";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 233);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Tổng Tiền";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 193);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Ngày Xuất";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 154);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "NV Xuất";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 113);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Kho Hàng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 73);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã PX";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dtgrPN);
            this.groupPanel1.Controls.Add(this.btnLuu);
            this.groupPanel1.Controls.Add(this.cb_NCC);
            this.groupPanel1.Controls.Add(this.buttonX6);
            this.groupPanel1.Controls.Add(this.cb_khohang);
            this.groupPanel1.Controls.Add(this.tbx_timkiem);
            this.groupPanel1.Controls.Add(this.buttonX5);
            this.groupPanel1.Controls.Add(this.buttonX4);
            this.groupPanel1.Controls.Add(this.btXoa);
            this.groupPanel1.Controls.Add(this.btSua);
            this.groupPanel1.Controls.Add(this.btThem);
            this.groupPanel1.Controls.Add(this.txt_ghichu);
            this.groupPanel1.Controls.Add(this.dt_ngaynhap);
            this.groupPanel1.Controls.Add(this.cb_NhanVien);
            this.groupPanel1.Controls.Add(this.txtTongTien);
            this.groupPanel1.Controls.Add(this.txt_maphieu);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(1, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1023, 398);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Phiếu Xuất Hàng";
            // 
            // Frm_PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "Frm_PhieuXuat";
            this.Size = new System.Drawing.Size(1024, 402);
            this.Load += new System.EventHandler(this.Frm_PhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ngaynhap)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dtgrPN;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_NCC;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_khohang;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_timkiem;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ghichu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dt_ngaynhap;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_NhanVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongTien;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_maphieu;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYXUAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn XEMCT;
    }
}