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
    public partial class Frm_DoiMatKhauDaXong : UserControl
    {
        public static string USERNAME = "";
        public static string QUYENHAN = "";
        public Frm_DoiMatKhauDaXong()
        {
            InitializeComponent();
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            if (QUYENHAN == "ADMIN     " || QUYENHAN == "Admin     " || QUYENHAN == "admin     ")
            {

            }
            else
            {
                tbx_tdn.Enabled = true;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            if (tbx_tdn.Text == "" || tbx_matkhaucu.Text == "" || tbx_matkhaumoi.Text == "" || tbx_nlmatkhaumoi.Text == "") 
            {
                SqlDataReader reader = access.ExecuteReader("select Password from DANGNHAP where USERNAME= '" + USERNAME + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set PASSWORD ='" + tbx_matkhaumoi.Text + "' where USERNAME ='" + USERNAME + "'";
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
                                MessageBox.Show("Cập nhật mật khẩu thành công");
                                this.Hide();

                            }
                        }
                    }
                }
                tbx_matkhaucu.Clear();
            }
            else
            {
                SqlDataReader reader = access.ExecuteReader("select Password from DANGNHAP where USERNAME= '" + tbx_tdn.Text + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set PASSWORD ='" + tbx_matkhaumoi.Text + "' where USERNAME ='" + tbx_tdn.Text + "'";
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
                                MessageBox.Show("Cập nhật mật khẩu thành công");

                            }
                        }
                    }
                }
                tbx_matkhaucu.Clear();
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Hủy Thao Tác?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Hủy thành công");
                tbx_tdn.Clear();
                tbx_matkhaucu.Clear();
                tbx_matkhaumoi.Clear();
                tbx_nlmatkhaumoi.Clear();
            }
        }

        private void Doimk(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Frm_Main m = new Frm_Main();
            m.ShowDialog();
                
        }
    }
}
