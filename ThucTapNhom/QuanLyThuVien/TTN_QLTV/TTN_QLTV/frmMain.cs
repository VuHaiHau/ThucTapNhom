using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QLTV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string Quyenhan = "";
        private void btn_nhanv_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                frmnhanvien nv = new frmnhanvien();
                nv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocGia docgia = new frmDocGia();
            docgia.ShowDialog();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmSach sach = new frmSach();
            sach.ShowDialog();
        }

        private void btn_xuatnhap_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmPhieuMuonTra muontra = new frmPhieuMuonTra();
            muontra.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau doimk = new frmDoiMatKhau();
            doimk.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap DN = new frmDangNhap();
            DN.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmnguoidung DN = new frmnguoidung();
            DN.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                               Thông Tin Nhà Phát Hành\n"

        + "   Phần Mềm Được Thực Hiện Bởi Các Thành Viên Trong Nhóm Gồm: \n\n"
        + "                                        Trần Hồng Dương\n "
        + "                                         Vũ Hải Hậu \n"
        + "                                         Đỗ Đăng Khải \n"
        + "                                         Nguyễn Quang Huy \n"
        + "                                        Triệu Văn Linh\n\n"
        + "Phần Mềm Quản Lý Thư Viện Được Thiết Kế Đơn Giản Với Các Chức Năng Chính Cơ Bản", "Thông Tin",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                               Hướng Dẫn Sử Dụng\n"

       + " Phần mềm được thiết kế với tất cả chức năng nằm ở thanh Menu bên trên cùng.\n" 
       + " Các chức năng chính sẽ hiển thị bên dưới. \n\n"

       
       + " Bạn có thể sử dụng các phím tắt bên dưới để truy cập nhanh. \n"
       + "Thông Tin Người Dùng: Ctrl+Shift+N . \n"
       + "Đăng Xuất: Alt+F4 .\n"
       + "Thông Tin Nhà Phát Hành: F1. \n"
       + "Hướng Dẫn Sử Dụng :F12 .\n \n"
       + "Lưu Ý:\n"
       + "Khi mượn sách bạn chỉ được mượn 1 lần và phải trả hết sách rồi mới được mượn thêm.\n\n"
       +"Chúng tôi rất vui khi bạn đã sử dụng phần mềm của chúng tôi\n\n"
       +"Chúc Bạn Làm Việc Hiệu Quả", "Hướng Dẫn",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmnguoidung DN = new frmnguoidung();
            DN.ShowDialog();
        }

        private void cậpNhậtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyenhan.Trim() == "ADMIN" || Quyenhan.Trim() == "Admin" || Quyenhan.Trim() == "admin")
            {
                this.Hide();
                frmnhanvien nv = new frmnhanvien();
                nv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn Phải là ADMIN thì mới thực hiện được thao tác này!");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau doimk = new frmDoiMatKhau();
            doimk.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap DN = new frmDangNhap();
            DN.ShowDialog();
        }

        private void quảnLýKhoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSach sach = new frmSach();
            sach.ShowDialog();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocGia docgia = new frmDocGia();
            docgia.ShowDialog();
        }

        private void quảnLýPhiếuMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhieuMuonTra muontra = new frmPhieuMuonTra();
            muontra.ShowDialog();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTheLoai tl = new frmTheLoai();
            tl.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void báoCáoKhoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiLiệuVậnHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://drive.google.com/file/d/1Dp7rUqjuvirRfiNllriTKeaLDZ9aqR5C/view?usp=sharing");
        }
    }
}
