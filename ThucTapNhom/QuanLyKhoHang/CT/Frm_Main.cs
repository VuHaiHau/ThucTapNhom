using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;
namespace QuanLyKhoHang.CT
{
    public partial class Frm_Main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static string Quyenhan = "";
        public Frm_Main()
        {
            InitializeComponent();
            userNamemenu.Text = Quyenhan;
        }

        private void ThemTab(string strtabname, UserControl UCContent)
        {
            foreach (TabItem tabPage in tabControl1.Tabs)
                if (tabPage.Text == strtabname)
                {
                    tabControl1.SelectedTab = tabPage;
                    return;
                }
            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strtabname;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 1;
            newTabPanel.TabItem = newTabPage;
            Random ran = new Random();
            newTabPage.Name = strtabname + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strtabname;
            UCContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(UCContent);
            tabControl1.Controls.Add(newTabPanel);
            tabControl1.Tabs.Add(newTabPage);
            tabControl1.SelectedTab = newTabPage;


        }

        private void buttonItem19_Click_1(object sender, EventArgs e)
        {
            Frm_NhanVienDaXong nv = new Frm_NhanVienDaXong();
            ThemTab("Quản Lý Nhân Viên", nv);
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            Frm_KhachHangDaXong kh = new Frm_KhachHangDaXong();
            ThemTab("Quản Lý Khách Hàng", kh);
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCapDaXong ncc = new Frm_NhaCungCapDaXong();
            ThemTab("Quản Lý Nhà Cung Cấp", ncc);
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            Frm_BoPhanDaXong bp = new Frm_BoPhanDaXong();
            ThemTab("Quản Lý Bộ Phận", bp);
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            Frm_KhoHangDaXong kh = new Frm_KhoHangDaXong();
            ThemTab("Quản Lý Kho Hàng", kh);
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhauDaXong dmk = new Frm_DoiMatKhauDaXong();
            ThemTab("Đổi Mật Khẩu", dmk);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Frm_DoiQuyenDaXong dq = new Frm_DoiQuyenDaXong();
            ThemTab("Đổi Quyền", dq);
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoanDaXong tk = new Frm_TaiKhoanDaXong();
            ThemTab("Thêm Tài Khoản", tk);
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungDaXong nd = new ThongTinNguoiDungDaXong();
            ThemTab("Thông Tin Người Dùng", nd);
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Xuất", "Quản Lý Kho Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhapDaXong dn = new Frm_DangNhapDaXong();
                dn.ShowDialog();
            }
           
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {        
            Frm_SanPhamDaXong sp = new Frm_SanPhamDaXong();
            ThemTab("Quản Lý Sản Phẩm", sp);
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            Frm_DanhMucSPDaXong dm = new Frm_DanhMucSPDaXong();
            ThemTab("Danh Mục Sản Phẩm", dm);
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            Frm_PhieuNhapDaXong ph = new Frm_PhieuNhapDaXong();
            ThemTab("Quản Lý Nhập Hàng", ph);
        }

     
        private void buttonItem31_Click(object sender, EventArgs e)
        {
            ThongTinPhanMem pm = new ThongTinPhanMem();
            ThemTab("Thông Tin Phần Mềm", pm);
        }

        private void buttonItem33_Click(object sender, EventArgs e)
        {
            Frm_LienHe lh = new Frm_LienHe();
            ThemTab("Liên Hệ", lh);
        }

        private void buttonItem35_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Ứng Dụng", "Quản Lý Kho Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       

        private void DongTap(object sender, TabStripActionEventArgs e)
        {
            TabItem chontab = tabControl1.SelectedTab;
            tabControl1.Tabs.Remove(chontab);
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            ThongKeSLTonKho tk = new ThongKeSLTonKho();
            ThemTab("Thống Kê Số Kượng Tồn", tk);
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel5_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            Frm_PhieuXuat px = new Frm_PhieuXuat();
            ThemTab("Quản Lý Xuất Hàng", px);
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            Frm_BaoCao bc = new Frm_BaoCao();
            ThemTab("Báo Cáo Nhập-Xuất Hàng", bc);
        }
    }

    internal class userNamemenu
    {
        public static string Text { get; internal set; }
    }
}
