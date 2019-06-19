namespace QuanLyKhoHang.CT
{
    partial class Frm_NhaCungCap
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
            this.tbx_Diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbx_TenNCC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_MaNCC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgv_nhacungcap = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tbx_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_lammoi = new DevComponents.DotNetBar.ButtonX();
            this.btn_ghinhan = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.tbx_Ghichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Diachi
            // 
            // 
            // 
            // 
            this.tbx_Diachi.Border.Class = "TextBoxBorder";
            this.tbx_Diachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_Diachi.Location = new System.Drawing.Point(293, 124);
            this.tbx_Diachi.Name = "tbx_Diachi";
            this.tbx_Diachi.PreventEnterBeep = true;
            this.tbx_Diachi.Size = new System.Drawing.Size(184, 20);
            this.tbx_Diachi.TabIndex = 28;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(236, 122);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(49, 23);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "Địa Chỉ";
            // 
            // tbx_TenNCC
            // 
            // 
            // 
            // 
            this.tbx_TenNCC.Border.Class = "TextBoxBorder";
            this.tbx_TenNCC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_TenNCC.Location = new System.Drawing.Point(76, 165);
            this.tbx_TenNCC.Name = "tbx_TenNCC";
            this.tbx_TenNCC.PreventEnterBeep = true;
            this.tbx_TenNCC.Size = new System.Drawing.Size(133, 20);
            this.tbx_TenNCC.TabIndex = 23;
            // 
            // tbx_MaNCC
            // 
            // 
            // 
            // 
            this.tbx_MaNCC.Border.Class = "TextBoxBorder";
            this.tbx_MaNCC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_MaNCC.Location = new System.Drawing.Point(76, 124);
            this.tbx_MaNCC.Name = "tbx_MaNCC";
            this.tbx_MaNCC.PreventEnterBeep = true;
            this.tbx_MaNCC.Size = new System.Drawing.Size(133, 20);
            this.tbx_MaNCC.TabIndex = 21;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 163);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Tên NCC";
            // 
            // dgv_nhacungcap
            // 
            this.dgv_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhacungcap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nhacungcap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_nhacungcap.Location = new System.Drawing.Point(495, 17);
            this.dgv_nhacungcap.Name = "dgv_nhacungcap";
            this.dgv_nhacungcap.Size = new System.Drawing.Size(525, 388);
            this.dgv_nhacungcap.TabIndex = 25;
            this.dgv_nhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Nhacungcap);
            // 
            // tbx_timkiem
            // 
            // 
            // 
            // 
            this.tbx_timkiem.Border.Class = "TextBoxBorder";
            this.tbx_timkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_timkiem.Location = new System.Drawing.Point(14, 66);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.PreventEnterBeep = true;
            this.tbx_timkiem.Size = new System.Drawing.Size(195, 22);
            this.tbx_timkiem.TabIndex = 24;
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_timkiem_enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_timkiem_leave);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Location = new System.Drawing.Point(215, 65);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(75, 23);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 22;
            this.buttonX6.Text = "Tìm Kiếm";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(14, 124);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Mã NCC";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(402, 17);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_lammoi.TabIndex = 19;
            this.btn_lammoi.Text = "Refresh ";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ghinhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.Location = new System.Drawing.Point(305, 17);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(75, 23);
            this.btn_ghinhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ghinhan.TabIndex = 18;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(208, 17);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(111, 17);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(14, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_Ghichu
            // 
            // 
            // 
            // 
            this.tbx_Ghichu.Border.Class = "TextBoxBorder";
            this.tbx_Ghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_Ghichu.Location = new System.Drawing.Point(293, 163);
            this.tbx_Ghichu.Name = "tbx_Ghichu";
            this.tbx_Ghichu.PreventEnterBeep = true;
            this.tbx_Ghichu.Size = new System.Drawing.Size(184, 20);
            this.tbx_Ghichu.TabIndex = 29;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(235, 161);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(49, 23);
            this.labelX3.TabIndex = 30;
            this.labelX3.Text = "Ghi Chú";
            // 
            // Frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbx_Ghichu);
            this.Controls.Add(this.tbx_Diachi);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbx_TenNCC);
            this.Controls.Add(this.tbx_MaNCC);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgv_nhacungcap);
            this.Controls.Add(this.tbx_timkiem);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_ghinhan);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.DoubleBuffered = true;
            this.Name = "Frm_NhaCungCap";
            this.Size = new System.Drawing.Size(1041, 420);
            this.Load += new System.EventHandler(this.Frm_NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhacungcap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbx_Diachi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_TenNCC;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_MaNCC;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_nhacungcap;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_timkiem;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_lammoi;
        private DevComponents.DotNetBar.ButtonX btn_ghinhan;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_Ghichu;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}