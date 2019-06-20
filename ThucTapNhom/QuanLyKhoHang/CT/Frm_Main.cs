using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace QuanLyKhoHang.CT
{
    public partial class Frm_Main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Frm_Main()
        {
            InitializeComponent();
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
            Frm_NhanVien nv = new Frm_NhanVien();
            ThemTab("Quản Lý Nhân Viên", nv);
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            Frm_KhachHang kh = new Frm_KhachHang();
            ThemTab("Quản Lý Khách Hàng", kh);
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            Frm_NhaCungCap ncc = new Frm_NhaCungCap();
            ThemTab("Quản Lý Nhà Cung Cấp", ncc);
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            Frm_BoPhan bp = new Frm_BoPhan();
            ThemTab("Quản Lý Bộ Phận", bp);
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            Frm_KhoHang kh = new Frm_KhoHang();
            ThemTab("Quản Lý Kho Hàng", kh);
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau dmk = new Frm_DoiMatKhau();
            ThemTab("Đổi Mật Khẩu", dmk);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Frm_DoiQuyen dq = new Frm_DoiQuyen();
            ThemTab("Đổi Quyền", dq);
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan tk = new Frm_TaiKhoan();
            ThemTab("Thêm Tài Khoản", tk);
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDung nd = new ThongTinNguoiDung();
            ThemTab("Thông Tin Người Dùng", nd);
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Xuất", "Quản Lý Kho Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhap dn = new Frm_DangNhap();
                dn.ShowDialog();
            }
           
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {        
            Frm_SanPham sp = new Frm_SanPham();
            ThemTab("Quản Lý Sản Phẩm", sp);
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            Frm_DanhMucSP dm = new Frm_DanhMucSP();
            ThemTab("Danh Mục Sản Phẩm", dm);
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            Nhap nh = new Nhap();
            ThemTab("Quản Lý Nhập Hàng", nh);
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
    }
}
