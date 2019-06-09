using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyKhoHang
{
    public partial class MainMenu : Form
    {
        public static string Quyenhan = "";
        public MainMenu()
        {
            InitializeComponent();
            userNamemenu.Text = Quyenhan;
        }

        private void btn_nhanv_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                FrmNhanVIen nhanvien = new FrmNhanVIen();
                nhanvien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhapHeThong DN = new FrmDangNhapHeThong();
            DN.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Phải là ADMIN thì mới đổi được mật khẩu cho tài khoản khác!");
            FrmDoimatkhau dmk = new FrmDoimatkhau();
            dmk.ShowDialog();
        }
        

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguoiDung ND = new FrmNguoiDung();
            ND.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            FrmNhanVIen.QUYENHD = Quyenhan.Trim();
            FrmBoPhan.QUYENHD = Quyenhan.Trim();
            FrmThemTaiKhoan.QUYENHD = Quyenhan.Trim();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBaoCao BC = new FrmBaoCao();
            BC.ShowDialog();
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDanhMucSP DMSP = new FrmDanhMucSP();
            DMSP.ShowDialog();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                FrmBoPhan bophan = new FrmBoPhan();
                bophan.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }

            
        }

        private void btn_nhacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhaCC nhacc = new FrmNhaCC();
            nhacc.ShowDialog();
        }
        
        private void btn_khohang_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                FrmKhoHang kho = new FrmKhoHang();
                kho.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }
           
        }

        private void btn_xuatnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhapHang nhapxuat = new FrmNhapHang();
            nhapxuat.ShowDialog();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKhachHang khachhang = new FrmKhachHang();
            khachhang.ShowDialog();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void đổiQuyềnHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                FrmDoiQuyen quyen = new FrmDoiQuyen();
                quyen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }     
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSanPham sanpham = new FrmSanPham();
            sanpham.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhanVIen nv = new FrmNhanVIen();
            nv.ShowDialog();
        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBoPhan bp = new FrmBoPhan();
            bp.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhaCC cc = new FrmNhaCC();
            cc.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKhachHang kh = new FrmKhachHang();
            kh.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKhoHang k = new FrmKhoHang();
            k.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSanPham sp = new FrmSanPham();
            sp.ShowDialog();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDanhMucSP dm = new FrmDanhMucSP();
            dm.ShowDialog();
        }

        

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmXuatHang bc = new FrmXuatHang();
            bc.ShowDialog();
        }

       

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                FrmThemTaiKhoan ttk = new FrmThemTaiKhoan();
                ttk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }
               
            
           
        }

        private void đổiQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDoimatkhau dmk= new FrmDoimatkhau();
            dmk.ShowDialog();
        }

        
        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhapHeThong dn = new FrmDangNhapHeThong();
            dn.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNguoiDung nd = new FrmNguoiDung();
            nd.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Ứng Dụng", "Quản Lý KHo Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                               Hướng Dẫn Sử Dụng\n"

     + " Phần mềm được thiết kế với tất cả chức năng nằm ở thanh Menu bên trên cùng.\n"
     + " Các chức năng chính sẽ hiển thị bên dưới. \n\n"
     + "Ở mỗi giao diện chính nếu muốn trở lại hãy sử dụng thanh tác vụ BACK ở trên cùng bên trái để trở lại.\n \n"
     + " Bạn có thể sử dụng các phím tắt bên dưới để truy cập nhanh. \n"
     + "Thông Tin Phần Mềm: F1. \n"
     + "Thông Tin Nhà Phát Hành: F1. \n"
     + "Hướng Dẫn Sử Dụng: F11.\n"
     + "Tài Liệu Vận Hành: F12.\n"
     + "Thông Tin Người Dùng: Alt+F1.\n"
     + "Tạo Tài Khoản: Alt+F2.\n"
     + "Đổi Mật Khẩu: Alt+F3.\n"
     + "Đổi Quyền: Alt+F4.\n"
     + "Đăng xuất: Alt+F5.\n"
     + " Thoát chương trình: Ctrl+W. \n"
     + "Chúng tôi rất vui khi bạn đã sử dụng phần mềm của chúng tôi\n\n"
     + "Chúc Bạn Làm Việc Hiệu Quả", "Hướng Dẫn",
     MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                               Thông Tin Nhà Phát Hành\n"

       + "   Phần Mềm Được Thực Hiện Bởi Các Thành Viên Trong Nhóm Gồm: \n\n"
       + "                                        1. Vũ Hải Hậu\n "
       + "                                       2. Trần Hồng Dương\n"
       + "                                        3. Đỗ Đăng Khải \n"
       + "                                        4. Triệu Văn Linh \n"
       + "                                        5. Nguyễn Quang Huy\n\n"
       + "Ngày Phát Hành Phần Mềm: 14/05/2019\n"
       + "Phần Mềm Quản Lý Kho Hàng Được Thiết Kế Đơn Giản Với Nhiều Chức Năng Chính Cơ Bản Giúp Người Sử Dụng Một Cách Dễ Dàng.", "Thông Tin",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                FrmDoiQuyen dq = new FrmDoiQuyen();
                dq.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }
           

        }

        private void tàiLiệuVậnHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://drive.google.com/file/d/1q4Mv87A_kw3qMpsO_gxi4nIaaExB4UNW/view?usp=sharing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmXuatHang xh = new FrmXuatHang();
            xh.ShowDialog();
        }

        private void nhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNhapHang xh = new FrmNhapHang();
            xh.ShowDialog();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBaoCao bc = new FrmBaoCao();
            bc.ShowDialog();
        }

        private void thốngKêHàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmThongKeSLTonKho TK = new FrmThongKeSLTonKho();
            TK.ShowDialog();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }
    }
}
