namespace TTN_QLTV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbx_title = new System.Windows.Forms.Label();
            this.pc_User = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.userNamemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_nhanv = new System.Windows.Forms.Button();
            this.btn_khachhang = new System.Windows.Forms.Button();
            this.btn_xuatnhap = new System.Windows.Forms.Button();
            this.btn_sanpham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pc_User)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_title
            // 
            this.lbx_title.AutoSize = true;
            this.lbx_title.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_title.ForeColor = System.Drawing.Color.Red;
            this.lbx_title.Location = new System.Drawing.Point(142, 51);
            this.lbx_title.Name = "lbx_title";
            this.lbx_title.Size = new System.Drawing.Size(490, 36);
            this.lbx_title.TabIndex = 1;
            this.lbx_title.Text = "Phần Mềm Quản Lý Thư Viện MTA";
            // 
            // pc_User
            // 
            this.pc_User.Image = ((System.Drawing.Image)(resources.GetObject("pc_User.Image")));
            this.pc_User.Location = new System.Drawing.Point(754, 124);
            this.pc_User.Name = "pc_User";
            this.pc_User.Size = new System.Drawing.Size(34, 38);
            this.pc_User.TabIndex = 2;
            this.pc_User.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuUser);
            this.panel1.Location = new System.Drawing.Point(616, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 38);
            this.panel1.TabIndex = 11;
            // 
            // menuUser
            // 
            this.menuUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNamemenu,
            this.cToolStripMenuItem});
            this.menuUser.Location = new System.Drawing.Point(0, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(132, 24);
            this.menuUser.TabIndex = 1;
            this.menuUser.Text = "menuStrip1";
            // 
            // userNamemenu
            // 
            this.userNamemenu.Name = "userNamemenu";
            this.userNamemenu.Size = new System.Drawing.Size(58, 20);
            this.userNamemenu.Text = "ADMIN";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.cToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cToolStripMenuItem.Image")));
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // btn_nhanv
            // 
            this.btn_nhanv.BackColor = System.Drawing.Color.Green;
            this.btn_nhanv.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanv.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanv.Image")));
            this.btn_nhanv.Location = new System.Drawing.Point(40, 235);
            this.btn_nhanv.Name = "btn_nhanv";
            this.btn_nhanv.Size = new System.Drawing.Size(134, 88);
            this.btn_nhanv.TabIndex = 12;
            this.btn_nhanv.Text = "Nhân Viên";
            this.btn_nhanv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nhanv.UseVisualStyleBackColor = false;
            this.btn_nhanv.Click += new System.EventHandler(this.btn_nhanv_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_khachhang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.Image")));
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_khachhang.Location = new System.Drawing.Point(230, 235);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(134, 88);
            this.btn_khachhang.TabIndex = 13;
            this.btn_khachhang.Text = "Độc Giả";
            this.btn_khachhang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_khachhang.UseVisualStyleBackColor = false;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_xuatnhap
            // 
            this.btn_xuatnhap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_xuatnhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatnhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_xuatnhap.Image")));
            this.btn_xuatnhap.Location = new System.Drawing.Point(614, 200);
            this.btn_xuatnhap.Name = "btn_xuatnhap";
            this.btn_xuatnhap.Size = new System.Drawing.Size(134, 182);
            this.btn_xuatnhap.TabIndex = 14;
            this.btn_xuatnhap.Text = "Phiếu Mượn-Trả";
            this.btn_xuatnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_xuatnhap.UseVisualStyleBackColor = false;
            this.btn_xuatnhap.Click += new System.EventHandler(this.btn_xuatnhap_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_sanpham.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sanpham.Image = ((System.Drawing.Image)(resources.GetObject("btn_sanpham.Image")));
            this.btn_sanpham.Location = new System.Drawing.Point(421, 235);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(132, 88);
            this.btn_sanpham.TabIndex = 15;
            this.btn_sanpham.Text = "Sách";
            this.btn_sanpham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sanpham.UseVisualStyleBackColor = false;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sanpham);
            this.Controls.Add(this.btn_xuatnhap);
            this.Controls.Add(this.btn_khachhang);
            this.Controls.Add(this.btn_nhanv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pc_User);
            this.Controls.Add(this.lbx_title);
            this.Name = "frmMain";
            this.Text = "Chương Trình Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pc_User)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbx_title;
        private System.Windows.Forms.PictureBox pc_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.Button btn_nhanv;
        private System.Windows.Forms.Button btn_khachhang;
        private System.Windows.Forms.Button btn_xuatnhap;
        private System.Windows.Forms.Button btn_sanpham;
        private System.Windows.Forms.ToolStripMenuItem userNamemenu;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}