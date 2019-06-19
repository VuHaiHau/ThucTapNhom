namespace QuanLyKhoHang.CT
{
    partial class Frm_DanhMucSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbx_makho = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbx_tendm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbx_madm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvDANHMUC = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tbx_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_lammoi = new DevComponents.DotNetBar.ButtonX();
            this.bt_ghinhan = new DevComponents.DotNetBar.ButtonX();
            this.bt_xoa = new DevComponents.DotNetBar.ButtonX();
            this.bt_chophepsua = new DevComponents.DotNetBar.ButtonX();
            this.bt_them = new DevComponents.DotNetBar.ButtonX();
            this.tbx_ghichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_makho
            // 
            this.tbx_makho.DisplayMember = "Text";
            this.tbx_makho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbx_makho.FormattingEnabled = true;
            this.tbx_makho.ItemHeight = 14;
            this.tbx_makho.Location = new System.Drawing.Point(307, 125);
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(182, 20);
            this.tbx_makho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbx_makho.TabIndex = 26;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(351, 125);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(38, 23);
            this.labelX5.TabIndex = 20;
            // 
            // tbx_tendm
            // 
            // 
            // 
            // 
            this.tbx_tendm.Border.Class = "TextBoxBorder";
            this.tbx_tendm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_tendm.Location = new System.Drawing.Point(95, 161);
            this.tbx_tendm.Name = "tbx_tendm";
            this.tbx_tendm.PreventEnterBeep = true;
            this.tbx_tendm.Size = new System.Drawing.Size(130, 20);
            this.tbx_tendm.TabIndex = 23;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(257, 160);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(44, 23);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Ghi Chú";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(257, 123);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 23);
            this.labelX3.TabIndex = 15;
            this.labelX3.Text = "Tên Kho";
            // 
            // tbx_madm
            // 
            // 
            // 
            // 
            this.tbx_madm.Border.Class = "TextBoxBorder";
            this.tbx_madm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_madm.Location = new System.Drawing.Point(95, 125);
            this.tbx_madm.Name = "tbx_madm";
            this.tbx_madm.PreventEnterBeep = true;
            this.tbx_madm.Size = new System.Drawing.Size(130, 20);
            this.tbx_madm.TabIndex = 21;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(14, 162);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Tên Danh Mục";
            // 
            // dgvDANHMUC
            // 
            this.dgvDANHMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDANHMUC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDANHMUC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDANHMUC.Location = new System.Drawing.Point(14, 217);
            this.dgvDANHMUC.Name = "dgvDANHMUC";
            this.dgvDANHMUC.Size = new System.Drawing.Size(475, 256);
            this.dgvDANHMUC.TabIndex = 25;
            this.dgvDANHMUC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_DANHMUC);
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
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Mã Danh Mục";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(414, 17);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_lammoi.TabIndex = 19;
            this.btn_lammoi.Text = "Refresh ";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // bt_ghinhan
            // 
            this.bt_ghinhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_ghinhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_ghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ghinhan.Location = new System.Drawing.Point(314, 17);
            this.bt_ghinhan.Name = "bt_ghinhan";
            this.bt_ghinhan.Size = new System.Drawing.Size(75, 23);
            this.bt_ghinhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_ghinhan.TabIndex = 18;
            this.bt_ghinhan.Text = "Lưu";
            this.bt_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(214, 17);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_xoa.TabIndex = 16;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // bt_chophepsua
            // 
            this.bt_chophepsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_chophepsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_chophepsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chophepsua.Location = new System.Drawing.Point(114, 17);
            this.bt_chophepsua.Name = "bt_chophepsua";
            this.bt_chophepsua.Size = new System.Drawing.Size(75, 23);
            this.bt_chophepsua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_chophepsua.TabIndex = 13;
            this.bt_chophepsua.Text = "Sửa";
            this.bt_chophepsua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(14, 17);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_them.TabIndex = 11;
            this.bt_them.Text = "Thêm";
            this.bt_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_ghichu
            // 
            // 
            // 
            // 
            this.tbx_ghichu.Border.Class = "TextBoxBorder";
            this.tbx_ghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_ghichu.Location = new System.Drawing.Point(307, 163);
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.PreventEnterBeep = true;
            this.tbx_ghichu.Size = new System.Drawing.Size(182, 20);
            this.tbx_ghichu.TabIndex = 27;
            // 
            // Frm_DanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 491);
            this.Controls.Add(this.tbx_ghichu);
            this.Controls.Add(this.tbx_makho);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbx_tendm);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbx_madm);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgvDANHMUC);
            this.Controls.Add(this.tbx_timkiem);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.bt_ghinhan);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_chophepsua);
            this.Controls.Add(this.bt_them);
            this.DoubleBuffered = true;
            this.Name = "Frm_DanhMucSP";
            this.Text = "Frm_DanhMucSP";
            this.Load += new System.EventHandler(this.Frm_DanhMucSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx tbx_makho;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_tendm;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_madm;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDANHMUC;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_timkiem;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_lammoi;
        private DevComponents.DotNetBar.ButtonX bt_ghinhan;
        private DevComponents.DotNetBar.ButtonX bt_xoa;
        private DevComponents.DotNetBar.ButtonX bt_chophepsua;
        private DevComponents.DotNetBar.ButtonX bt_them;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_ghichu;
    }
}