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
    public partial class Frm_DoiQuyen : DevComponents.DotNetBar.OfficeForm
    {
        public Frm_DoiQuyen()
        {
            InitializeComponent();
        }
        public static string USERNAME = "";
        public static string QuyenHan = "";
        DataAccess acc = new DataAccess();

        public DataTable QH(string USERNAME)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("SELECT QUYENHAN FROM DANGNHAP WHERE USERNAME='" + USERNAME + "'");
            while (a.Read())
            {
                QuyenHan = a["QUYENHAN"].ToString();

            }
            return null;
        }

        private void Frm_DoiQuyen_Load(object sender, EventArgs e)
        {
            acc.AutoComplete(tbx_tdn, "SELECT USERNAME FROM DANGNHAP");
            acc.AutoComplete(tbx_quyencu, "SELECT QUYENHAN FROM DANGNHAP");
            acc.AutoComplete(tbx_quyenmoi, "SELECT QUYENHAN FROM DANGNHAP");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            if (tbx_tdn.Text == null)
            {
                SqlDataReader reader = access.ExecuteReader("select QUYENHAN from DANGNHAP where USERNAME= '" + USERNAME + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set QUYENHAN ='" + tbx_quyenmoi.Text + "' where USERNAME ='" + USERNAME + "'";
                    if (tbx_quyencu.Text == "" || tbx_quyenmoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_quyenmoi.Text == tbx_quyencu.Text)
                        {
                            MessageBox.Show("Quyền Hạn mới phải khác Quyền Hạn cũ!");
                            tbx_quyenmoi.Clear();
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật quyền hạn thành công");

                            }
                        }
                    }
                }
            }
            else
            {
                SqlDataReader reader = access.ExecuteReader("select QUYENHAN from DANGNHAP where USERNAME= '" + tbx_tdn.Text + "'");
                while (reader.Read() == true)
                {
                    string sql = "update DANGNHAP set QUYENHAN ='" + tbx_quyenmoi.Text + "' where USERNAME ='" + tbx_tdn.Text + "'";
                    if (tbx_quyencu.Text == "" || tbx_quyenmoi.Text == "")
                    {
                        MessageBox.Show("Yêu cầu điền đủ vào các mục");
                    }
                    else
                    {
                        if (tbx_quyenmoi.Text == tbx_quyencu.Text)
                        {
                            MessageBox.Show("Quyền Hạn mới phải khác Quyền Hạn cũ!");
                            tbx_quyenmoi.Clear();
                        }
                        else
                        {
                            if (access.executenonquery(sql) == true)
                            {
                                MessageBox.Show("Cập nhật quyền hạn thành công");

                            }
                        }
                    }
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Chắn Muốn Hủy Thao Tác?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Hủy thành công");
            }
        }

        private void tendangnhap(object sender, EventArgs e)
        {
            if (tbx_tdn.Text == null)
            {
                tbx_tdn.Enabled = false;
                QH(USERNAME);
                tbx_quyencu.Text = QuyenHan.Trim();
            }
            else
            {
                QH(tbx_tdn.Text);
                tbx_quyencu.Text = QuyenHan.Trim();
            }
        }
    }
}
