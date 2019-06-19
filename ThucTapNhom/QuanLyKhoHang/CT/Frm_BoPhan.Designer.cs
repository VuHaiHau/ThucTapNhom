namespace QuanLyKhoHang.CT
{
    partial class Frm_BoPhan
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
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_ghinhan = new DevComponents.DotNetBar.ButtonX();
            this.btn_lammoi = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.tbx_timkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgv_BoPhan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbx_MaBP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_TenBP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbx_NQL = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbx_MaKho = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbx_Dienthoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(12, 23);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(117, 23);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(223, 23);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ghinhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ghinhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.Location = new System.Drawing.Point(327, 23);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(75, 23);
            this.btn_ghinhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ghinhan.TabIndex = 3;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_lammoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(327, 72);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_lammoi.TabIndex = 4;
            this.btn_lammoi.Text = "Refresh ";
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Location = new System.Drawing.Point(224, 71);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(75, 23);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 5;
            this.buttonX6.Text = "Tìm Kiếm";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // tbx_timkiem
            // 
            // 
            // 
            // 
            this.tbx_timkiem.Border.Class = "TextBoxBorder";
            this.tbx_timkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_timkiem.Location = new System.Drawing.Point(12, 72);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.PreventEnterBeep = true;
            this.tbx_timkiem.Size = new System.Drawing.Size(195, 22);
            this.tbx_timkiem.TabIndex = 6;
            this.tbx_timkiem.TextChanged += new System.EventHandler(this.tbx_timkiem_TextChanged);
            this.tbx_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.tbx_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // dgv_BoPhan
            // 
            this.dgv_BoPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BoPhan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BoPhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_BoPhan.Location = new System.Drawing.Point(445, 23);
            this.dgv_BoPhan.Name = "dgv_BoPhan";
            this.dgv_BoPhan.Size = new System.Drawing.Size(568, 367);
            this.dgv_BoPhan.TabIndex = 7;
            this.dgv_BoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BoPhan_CellClick);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 130);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(38, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã BP";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 168);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(38, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên BP";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(177, 169);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(29, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "NQL";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(180, 129);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(29, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Kho";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 209);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(38, 23);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Số ĐT";
            // 
            // tbx_MaBP
            // 
            // 
            // 
            // 
            this.tbx_MaBP.Border.Class = "TextBoxBorder";
            this.tbx_MaBP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_MaBP.Location = new System.Drawing.Point(56, 131);
            this.tbx_MaBP.Name = "tbx_MaBP";
            this.tbx_MaBP.PreventEnterBeep = true;
            this.tbx_MaBP.Size = new System.Drawing.Size(100, 20);
            this.tbx_MaBP.TabIndex = 5;
            // 
            // tbx_TenBP
            // 
            // 
            // 
            // 
            this.tbx_TenBP.Border.Class = "TextBoxBorder";
            this.tbx_TenBP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_TenBP.Location = new System.Drawing.Point(56, 169);
            this.tbx_TenBP.Name = "tbx_TenBP";
            this.tbx_TenBP.PreventEnterBeep = true;
            this.tbx_TenBP.Size = new System.Drawing.Size(100, 20);
            this.tbx_TenBP.TabIndex = 6;
            this.tbx_TenBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenBP);
            // 
            // tbx_NQL
            // 
            this.tbx_NQL.DisplayMember = "Text";
            this.tbx_NQL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbx_NQL.FormattingEnabled = true;
            this.tbx_NQL.ItemHeight = 14;
            this.tbx_NQL.Location = new System.Drawing.Point(212, 168);
            this.tbx_NQL.Name = "tbx_NQL";
            this.tbx_NQL.Size = new System.Drawing.Size(190, 20);
            this.tbx_NQL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbx_NQL.TabIndex = 8;
            // 
            // tbx_MaKho
            // 
            this.tbx_MaKho.DisplayMember = "Text";
            this.tbx_MaKho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tbx_MaKho.FormattingEnabled = true;
            this.tbx_MaKho.ItemHeight = 14;
            this.tbx_MaKho.Location = new System.Drawing.Point(212, 130);
            this.tbx_MaKho.Name = "tbx_MaKho";
            this.tbx_MaKho.Size = new System.Drawing.Size(190, 20);
            this.tbx_MaKho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbx_MaKho.TabIndex = 9;
            // 
            // tbx_Dienthoai
            // 
            // 
            // 
            // 
            this.tbx_Dienthoai.Border.Class = "TextBoxBorder";
            this.tbx_Dienthoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbx_Dienthoai.Location = new System.Drawing.Point(56, 209);
            this.tbx_Dienthoai.Name = "tbx_Dienthoai";
            this.tbx_Dienthoai.PreventEnterBeep = true;
            this.tbx_Dienthoai.Size = new System.Drawing.Size(100, 20);
            this.tbx_Dienthoai.TabIndex = 10;
            this.tbx_Dienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoDT);
            this.tbx_Dienthoai.Leave += new System.EventHandler(this.txt_SoDT);
            // 
            // Frm_BoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbx_Dienthoai);
            this.Controls.Add(this.tbx_MaKho);
            this.Controls.Add(this.tbx_NQL);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.tbx_TenBP);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbx_MaBP);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dgv_BoPhan);
            this.Controls.Add(this.tbx_timkiem);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_ghinhan);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.DoubleBuffered = true;
            this.Name = "Frm_BoPhan";
            this.Size = new System.Drawing.Size(1025, 402);
            this.Load += new System.EventHandler(this.Frm_BoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BoPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_ghinhan;
        private DevComponents.DotNetBar.ButtonX btn_lammoi;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_timkiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_BoPhan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_MaBP;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_TenBP;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tbx_NQL;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tbx_MaKho;
        private DevComponents.DotNetBar.Controls.TextBoxX tbx_Dienthoai;
    }
}