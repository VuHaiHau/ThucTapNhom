namespace TTN_QLTV
{
    partial class frmChiTietPhieuMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuMuon));
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.cbxsach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxmuon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvctpmt = new System.Windows.Forms.DataGridView();
            this.grbNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpmt)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbNhanVien.Controls.Add(this.cbxsach);
            this.grbNhanVien.Controls.Add(this.label3);
            this.grbNhanVien.Controls.Add(this.tbxmuon);
            this.grbNhanVien.Controls.Add(this.label12);
            this.grbNhanVien.Controls.Add(this.txtMaPhieu);
            this.grbNhanVien.Controls.Add(this.lbTenPhong);
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(66, 31);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Size = new System.Drawing.Size(535, 252);
            this.grbNhanVien.TabIndex = 33;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thêm Phiếu Mượn";
            // 
            // cbxsach
            // 
            this.cbxsach.FormattingEnabled = true;
            this.cbxsach.Location = new System.Drawing.Point(139, 125);
            this.cbxsach.Name = "cbxsach";
            this.cbxsach.Size = new System.Drawing.Size(375, 27);
            this.cbxsach.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Sách :";
            // 
            // tbxmuon
            // 
            this.tbxmuon.BackColor = System.Drawing.SystemColors.Window;
            this.tbxmuon.Location = new System.Drawing.Point(140, 212);
            this.tbxmuon.Name = "tbxmuon";
            this.tbxmuon.Size = new System.Drawing.Size(374, 26);
            this.tbxmuon.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 12;
            this.label12.Text = "Số Lượng Mượn:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(139, 48);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(375, 26);
            this.txtMaPhieu.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu :";
            // 
            // btThem
            // 
            this.btThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btThem.BackgroundImage")));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(623, 143);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 35);
            this.btThem.TabIndex = 34;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // dgvctpmt
            // 
            this.dgvctpmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctpmt.Location = new System.Drawing.Point(66, 289);
            this.dgvctpmt.Name = "dgvctpmt";
            this.dgvctpmt.Size = new System.Drawing.Size(640, 226);
            this.dgvctpmt.TabIndex = 35;
            this.dgvctpmt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(778, 527);
            this.Controls.Add(this.dgvctpmt);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.grbNhanVien);
            this.MaximizeBox = false;
            this.Name = "frmChiTietPhieuMuon";
            this.Text = "Thêm Phiếu Mượn";
            this.Load += new System.EventHandler(this.frmChiTietPhieuMuon_Load);
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.ComboBox cbxsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxmuon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvctpmt;
    }
}