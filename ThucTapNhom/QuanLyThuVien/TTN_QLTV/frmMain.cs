using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btn_nhanv_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmnhanvien nhanvien = new frmnhanvien();
            nhanvien.ShowDialog();
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
    }
}
