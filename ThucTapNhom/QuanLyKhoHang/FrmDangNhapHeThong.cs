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

namespace QuanLyKhoHang
{
    public partial class FrmDangNhapHeThong : Form
    {
        public static string QuyenHan = "";
        public static string USERNAME = "";
        public static string MaNV = "";

        public FrmDangNhapHeThong()
        {
            InitializeComponent();
        }

        public DataTable QH(string UN)
        {
            accessData acc = new accessData();
            SqlDataReader a = acc.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + UN + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }

        

      

       
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            accessData acc = new accessData();
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            SqlDataReader reader = acc.ExecuteReader("select USERNAME,PASSWORD, QUYENHAN from DANGNHAP where USERNAME='" + user + "' and PASSWORD='" + pass + "'");
            if (reader.Read() == true)
            {
                QH(txtTaiKhoan.Text);
                MainMenu.Quyenhan = QuyenHan;
                FrmNguoiDung.QuyenHan = QuyenHan;
                FrmNguoiDung.TenDangNhap = txtTaiKhoan.Text;
                FrmBaoCao.TenDangNhap = txtTaiKhoan.Text;
                FrmDoimatkhau.USERNAME = txtTaiKhoan.Text;
                FrmDoiQuyen.USERNAME = txtTaiKhoan.Text;
                FrmDoimatkhau.QUYENHAN = QuyenHan;
                FrmThemTaiKhoan.Username = txtTaiKhoan.Text;

                this.Hide();
                MessageBox.Show("Chào Mừng Bạn Đã Đến Với Hệ Thống Quản Lý Kho Hàng Của Chúng Tôi!");
                MainMenu menu = new MainMenu();
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thoát?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

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

        private void txtMatKhau_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDangNhap.Focus();
                accessData acc = new accessData();
                string user = txtTaiKhoan.Text.Trim();
                string pass = txtMatKhau.Text.Trim();
                SqlDataReader reader = acc.ExecuteReader("select USERNAME,PASSWORD from DANGNHAP where USERNAME='" + user + "' and PASSWORD='" + pass + "'");
                if (reader.Read() == true)
                {
                    QH(txtTaiKhoan.Text);
                    MainMenu.Quyenhan = QuyenHan;
                    FrmNguoiDung.QuyenHan = QuyenHan;
                    FrmNguoiDung.TenDangNhap = txtTaiKhoan.Text;
                    FrmBaoCao.TenDangNhap = txtTaiKhoan.Text;
                    FrmDoimatkhau.USERNAME = txtTaiKhoan.Text;
                    FrmDoiQuyen.USERNAME = txtTaiKhoan.Text;
                    FrmDoimatkhau.QUYENHAN = QuyenHan;
                    FrmThemTaiKhoan.Username = txtTaiKhoan.Text;
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
