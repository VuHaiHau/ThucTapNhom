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
using DAL;


namespace TTN_QLTV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public static string QuyenHan = "";
        public static string USERNAME = "";
        public static string MaNV = "";
        
        
        public DataTable QH(string UN)
        {
            accessdata acc = new accessdata();
            SqlDataReader a = acc.ExecuteReader("SELECT phanquyen FROM Login WHERE taikhoan='" + UN + "'");
            while (a.Read())
            {
                QuyenHan = a["phanquyen"].ToString();

            }
            return null;
        }

        private void btDangNhap_Click_1(object sender, EventArgs e)
        {
            accessdata acc = new accessdata();
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            SqlDataReader reader = acc.ExecuteReader("select taikhoan,matkhau,phanquyen from login where taikhoan='" + user + "' and matkhau='" + pass + "'");
            if (reader.Read() == true)
            {
                QH(txtTaiKhoan.Text);
                frmMain.Quyenhan = QuyenHan;
                frmnguoidung.QuyenHan = QuyenHan;
                frmnguoidung.taikhoan = txtTaiKhoan.Text;
                frmThemTaiKhoan.Username = txtTaiKhoan.Text;

                MessageBox.Show("Bạn Đã Đăng Nhập Thành Công ");
                this.Hide();
                frmMain menu = new frmMain();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác");
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }

        private void checkMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
