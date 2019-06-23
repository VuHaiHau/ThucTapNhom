﻿using System;
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
using QuanLyKhoHang.CT;

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
                Frm_NhanVienDaXong nhanvien = new Frm_NhanVienDaXong();
                nhanvien.Show();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap DN = new Frm_DangNhap();
            DN.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Phải là ADMIN thì mới đổi được mật khẩu cho tài khoản khác!");
            Frm_DoiMatKhau dmk = new Frm_DoiMatKhau();
            dmk.Show();
        }
        

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDung ND = new ThongTinNguoiDung();
            ND.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Frm_NhanVienDaXong.QUYENHD = Quyenhan.Trim();
            Frm_BoPhanDaXong.QUYENHD = Quyenhan.Trim();
            Frm_TaiKhoan.QUYENHD = Quyenhan.Trim();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BaoCao BC = new Frm_BaoCao();
            BC.ShowDialog();
        }

        private void btn_danhmuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DanhMucSPDaXong DMSP = new Frm_DanhMucSPDaXong();
            DMSP.Show();
        }

        private void btn_luong_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                Frm_BoPhanDaXong bophan = new Frm_BoPhanDaXong();
                bophan.Show();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }

            
        }

        private void btn_nhacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhaCungCapDaXong nhacc = new Frm_NhaCungCapDaXong();
            nhacc.Show();
        }
        
        private void btn_khohang_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                Frm_KhoHangDaXong kho = new Frm_KhoHangDaXong();
                kho.Show();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }
           
        }

        private void btn_xuatnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhapHang nhapxuat = new Frm_NhapHang();
            nhapxuat.ShowDialog();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_KhachHangDaXong khachhang = new Frm_KhachHangDaXong();
            khachhang.Show();
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
                Frm_DoiQuyen quyen = new Frm_DoiQuyen();
                quyen.Show();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }     
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SanPham sanpham = new Frm_SanPham();
            sanpham.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhanVienDaXong nv = new Frm_NhanVienDaXong();
            nv.Show();
        }

        private void bộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BoPhanDaXong bp = new Frm_BoPhanDaXong();
            bp.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhaCungCapDaXong cc = new Frm_NhaCungCapDaXong();
            cc.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_KhachHangDaXong kh = new Frm_KhachHangDaXong();
            kh.Show();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_KhoHangDaXong k = new Frm_KhoHangDaXong();
            k.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_SanPham sp = new Frm_SanPham();
            sp.Show();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DanhMucSPDaXong dm = new Frm_DanhMucSPDaXong();
            dm.Show();
        }

        

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_XuatHang bc = new Frm_XuatHang();
            bc.ShowDialog();
        }

       

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                Frm_TaiKhoan ttk = new Frm_TaiKhoan();
                ttk.Show();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới có quyền thực hiện được thao tác này!");
            }
               
            
           
        }

        private void đổiQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DoiMatKhau dmk= new Frm_DoiMatKhau();
            dmk.Show();
        }

        
        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_DangNhap dn = new Frm_DangNhap();
            dn.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinNguoiDung nd = new ThongTinNguoiDung();
            nd.Show();
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
            MessageBox.Show("                               HƯỚNG DẪN SỬ DỤNG\n\n"

     + " Phần mềm được thiết kế với tất cả chức năng nằm ở thanh Menu bên trên cùng.\n"
     + " Các chức năng chính sẽ hiển thị bên dưới. \n\n"
     + " Ở mỗi giao diện chính nếu muốn trở lại hãy sử dụng thanh tác vụ BACK ở trên cùng bên trái để trở lại.\n \n"
     + " Bạn có thể sử dụng các phím tắt bên dưới để truy cập nhanh. \n"
     + " Thông Tin Phần Mềm: F1. \n"
     + " Thông Tin Nhà Phát Hành: F1. \n"
     + " Hướng Dẫn Sử Dụng: F11.\n"
     + " Tài Liệu Vận Hành: F12.\n"
     + " Thông Tin Người Dùng: Alt+F1.\n"
     + " Tạo Tài Khoản: Alt+F2.\n"
     + " Đổi Mật Khẩu: Alt+F3.\n"
     + " Đổi Quyền: Alt+F4.\n"
     + " Đăng xuất: Alt+F5.\n"
     + " Thoát chương trình: Ctrl+W. \n"
     + " Chúng tôi rất vui khi bạn đã sử dụng phần mềm của chúng tôi\n\n"
     + " Chúc Bạn Làm Việc Hiệu Quả", "Hướng Dẫn",
     MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                               THÔNG TIN NHÀ PHÁT HÀNH\n\n"

       + "   Phần mềm được thực hiện bởi các thành viên trong nhóm gồm:\n\n"
       + "                                        1. Vũ Hải Hậu\n "
       + "                                       2. Trần Hồng Dương\n"
       + "                                        3. Đỗ Đăng Khải \n"
       + "                                        4. Triệu Văn Linh \n"
       + "                                        5. Nguyễn Quang Huy\n\n"
       + "  Ngày phát hành phần mềm: 14/05/2019\n"
       + "  Phần mềm Quản Lý Kho Hàng được thiết kế đơn giản với nhiều chức năng chính cơ bản giúp người sử dụng một cách dễ dàng.", "Thông Tin",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                Frm_DoiQuyen dq = new Frm_DoiQuyen();
                dq.Show();
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
            Frm_XuatHang xh = new Frm_XuatHang();
            xh.ShowDialog();
        }

        private void nhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_NhapHang xh = new Frm_NhapHang();
            xh.ShowDialog();
        }

        private void báoCáoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BaoCao bc = new Frm_BaoCao();
            bc.ShowDialog();
        }

        private void thốngKêHàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeSLTonKho TK = new ThongKeSLTonKho();
            TK.Show();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }
    }
}
