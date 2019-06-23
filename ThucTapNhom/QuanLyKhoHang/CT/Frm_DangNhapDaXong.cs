using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKhoHang.CT
{
    public partial class Frm_DangNhapDaXong : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Frm_DangNhapDaXong()
        {
            InitializeComponent();
        }
        public static string QuyenHan = "";
        public static string USERNAME = "";
        public static string MaNV = "";
        public DataTable QH(string UN)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + UN + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataAccess acc = new DataAccess();
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            SqlDataReader reader = acc.ExecuteReader("select USERNAME,PASSWORD, QUYENHAN from DANGNHAP where USERNAME='" + user + "' and PASSWORD='" + pass + "'");
            if (reader.Read() == true)
            {
                QH(txtTaiKhoan.Text);
                MainMenu.Quyenhan = QuyenHan;
                ThongTinNguoiDung.QuyenHan = QuyenHan;
                ThongTinNguoiDung.TenDangNhap = txtTaiKhoan.Text;
                Frm_BaoCao.TenDangNhap = txtTaiKhoan.Text;
                Frm_DoiMatKhauDaXong.USERNAME = txtTaiKhoan.Text;
                Frm_DoiQuyenDaXong.USERNAME = txtTaiKhoan.Text;
                Frm_DoiMatKhauDaXong.QUYENHAN = QuyenHan;
                Frm_TaiKhoanDaXong.Username = txtTaiKhoan.Text;

                this.Hide();
                MessageBox.Show("Chào Mừng Bạn Đã Đến Với Hệ Thống Quản Lý Kho Hàng Của Chúng Tôi!");
                Frm_Main menu = new Frm_Main();
                menu.ShowDialog();
            }
            else if (user == "" || pass == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin");
            }
            else
            {
                MessageBox.Show("Sai Thông Tin Đăng Nhập! Vui Lòng Nhập Lại!");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
        }

        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            //this.txtMatKhau.PasswordChar = this.checkMK.Checked ? char.MinValue : '*';
            if (checkMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

       

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thoát?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


       
        private void txtMatKhau_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX1.Focus();
                DataAccess acc = new DataAccess();
                string user = txtTaiKhoan.Text.Trim();
                string pass = txtMatKhau.Text.Trim();
                SqlDataReader reader = acc.ExecuteReader("select USERNAME,PASSWORD from DANGNHAP where USERNAME='" + user + "' and PASSWORD='" + pass + "'");
                if (reader.Read() == true)
                {
                    QH(txtTaiKhoan.Text);
                    MainMenu.Quyenhan = QuyenHan;
                    ThongTinNguoiDung.QuyenHan = QuyenHan;
                    ThongTinNguoiDung.TenDangNhap = txtTaiKhoan.Text;
                    Frm_BaoCao.TenDangNhap = txtTaiKhoan.Text;
                    Frm_DoiMatKhauDaXong.USERNAME = txtTaiKhoan.Text;
                    Frm_DoiQuyenDaXong.USERNAME = txtTaiKhoan.Text;
                    Frm_DoiMatKhauDaXong.QUYENHAN = QuyenHan;
                    Frm_TaiKhoanDaXong.Username = txtTaiKhoan.Text;
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    MessageBox.Show("Bạn Đang Là: " + QuyenHan + "");
                    this.Hide();
                    MainMenu menu = new MainMenu();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai Thông Tin Đăng Nhập! Vui Lòng Nhập Lại!");
                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    txtTaiKhoan.Focus();
                }


            }
        }

        
    }
}
