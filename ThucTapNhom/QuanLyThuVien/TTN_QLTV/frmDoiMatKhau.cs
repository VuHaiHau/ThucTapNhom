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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public static string taikhoan = "";
        private void ClearText()
        {
            tbx_tdn.Clear();
            tbx_matkhaucu.Clear();
            tbx_matkhaumoi.Clear();
            tbx_nlmatkhaumoi.Clear();
        }
        private void btn_dmk_Click(object sender, EventArgs e)
        {
            KetNoi access = new KetNoi();
            if (tbx_tdn.Text == "")
            {
                SqlDataReader reader = access.ExecuteReader("select matkhau from Login where taikhoan= '" + taikhoan + "'");
                while (reader.Read() == true)
                {
                    string sql = "update Login set matkhau ='" + tbx_matkhaumoi.Text + "' where taikhoan ='" + taikhoan + "'";
                    if (tbx_matkhaucu.Text == "" || tbx_matkhaumoi.Text == "" || tbx_nlmatkhaumoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_matkhaumoi.Text != tbx_nlmatkhaumoi.Text)
                        {
                            MessageBox.Show("Mật khẩu thay thế phải trùng nhau");
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật mật khẩu  thành công");
                                frmDoiMatKhau_Load(sender, e);
                            }

                        }
                        
                    }
                }
                tbx_matkhaucu.Clear();
            }
            else
            {
                SqlDataReader reader = access.ExecuteReader("select matkhau from Login where taikhoan= '" + tbx_tdn.Text + "'");
                while (reader.Read() == true)
                {
                    string sql = "update Login set matkhau ='" + tbx_matkhaumoi.Text + "' where taikhoan ='" + tbx_tdn.Text + "'";
                    if (tbx_matkhaucu.Text == "" || tbx_matkhaumoi.Text == "" || tbx_nlmatkhaumoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_matkhaumoi.Text != tbx_nlmatkhaumoi.Text)
                        {
                            MessageBox.Show("Mật khẩu thay thế phải trùng nhau");
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật mật khẩu  thành công");
                                frmDoiMatKhau_Load(sender, e);
                            }
                        }
                    }
                }
                tbx_matkhaucu.Clear();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ClearText();
            frmDoiMatKhau_Load(sender, e);

        }

        private void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
