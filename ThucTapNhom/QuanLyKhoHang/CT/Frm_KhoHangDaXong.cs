using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.CT
{
    public partial class Frm_KhoHangDaXong : UserControl
    {
        public Frm_KhoHangDaXong()
        {
            InitializeComponent();
        }
        DataAccess acc = new DataAccess();
        private int key = 0;
        public void Disable()
        {
            tbx_tenkho.Enabled = false; tbx_ghichu.Enabled = false; tbx_tongdmsp.Enabled = false;
        }
        public void Enable()
        {
            tbx_ghichu.Enabled = true; tbx_tongdmsp.Enabled = true; tbx_tenkho.Enabled = true;
        }
        public void clearText()
        {
            tbx_makho.Clear();
            tbx_tenkho.Clear();
            tbx_tongdmsp.Value = 0;
            tbx_ghichu.Clear();
            dgvKHOHANG.ClearSelection();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Enable();
            tbx_tenkho.Focus();
            tbx_makho.Enabled = false;
            btn_ghinhan.Enabled = true;
            bt_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            key = 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Enable();
            tbx_tenkho.Focus();
            tbx_makho.Enabled = false;
            btn_ghinhan.Enabled = true;
            bt_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            key = 2;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Disable();
            tbx_makho.Enabled = false;
            btn_ghinhan.Enabled = true;
            bt_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_chophepsua.Enabled = false;
            key = 3;
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                int count = 0;
                count = dgvKHOHANG.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvKHOHANG.Rows[count - 2].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    tbx_makho.Text = "KHO0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    tbx_makho.Text = "KHO" + (chuoi2 + 1).ToString();
              
               
                    DataTable dtkh = acc.CheckSql("SELECT *FROM KHOHANG WHERE TENKHO=N'" + tbx_tenkho.Text + "'");
                    if (dtkh.Rows.Count > 0)
                    {
                        MessageBox.Show("Kho Hàng đã tồn tại!!", "Cảnh Báo");
                        tbx_tenkho.Clear();
                        tbx_tenkho.Focus();
                    }
                else if (tbx_tenkho.Text == "" || tbx_tongdmsp.Value == 0)
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ hết thông tin", "Lỗi Nhập!");
                    tbx_makho.Focus();
                }
                else
                    {
                        acc.THEM_KHOHANG(tbx_makho.Text, tbx_tenkho.Text, Convert.ToInt32(tbx_tongdmsp.Value), tbx_ghichu.Text);
                        MessageBox.Show("Thêm thành công!","Thông Báo");
                        Frm_KhoHang_Load(sender, e);
                        clearText();
                    }
                
            }
            if (key == 2)
            {
                if (tbx_makho.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ THông Tin Hoặc Chọn Dòng Bạn Muốn sửa!", "Thông Báo");
                    tbx_makho.Focus();
                }
                else
                {
                    acc.SUA_KHOHANG(tbx_makho.Text, tbx_tenkho.Text, Convert.ToInt32(tbx_tongdmsp.Value), tbx_ghichu.Text);
                    MessageBox.Show("Sửa thành công!","Thông Báo");
                    Frm_KhoHang_Load(sender, e);
                    clearText();
                    //bt_them.Enabled = true; bt_xoa.Enabled = false;
                }
            }

            if (key == 3)
            {
                if (tbx_makho.Text == "" || dgvKHOHANG.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Nhập mã Kho Hàng Bạn Muốn Xóa hoặc Chọn Tại Bảng!", "Thông Báo");
                    tbx_makho.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn có Chắc Chắn Muốn xóa Kho này?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                                           
                        acc.XOA_KHOHANG(tbx_makho.Text);
                        MessageBox.Show("Xóa thành công!","Thông Báo");
                        Frm_KhoHang_Load(sender, e);
                        clearText();
                    }
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                MessageBox.Show("Hãy Nhập Thông Tin cần Tìm Kiếm", "Thông Báo");
                tbx_timkiem.Focus();
                return;
            }
            else
            {
                //groupBox_ketquatimkiem.Text = "Kết Quả Tìm Kiếm";
                dgvKHOHANG.DataSource = acc.Select_Data("SELECT Row_number() over(order by MAKHO) STT,* from KhoHang1 WHERE MAKHO LIKE '%" + tbx_timkiem.Text + "%' OR TENKHO LIKE '%" + tbx_timkiem.Text + "%' OR TONGSODMSP LIKE '%" + tbx_timkiem.Text + "%' OR GHICHU LIKE '%" + tbx_timkiem.Text + "%'");
                tbx_timkiem.Clear();
                dgvKHOHANG.ClearSelection();
            }
        }

        private void Frm_KhoHang_Load(object sender, EventArgs e)
        {
            dgvKHOHANG.DataSource = acc.Select_Data("Select Row_number() over(order by MAKHO) STT,* from KhoHang1");
            dgvKHOHANG.ClearSelection();
            //groupBox_ketquatimkiem.Text = "";
            tbx_makho.Text = "";
            tbx_tenkho.Focus();
            Disable();
            tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
          
            //hiển thị tiêu đề của cột:
            dgvKHOHANG.Columns[1].HeaderText = "Mã Kho";
            dgvKHOHANG.Columns[2].HeaderText = "Tên Kho";
            dgvKHOHANG.Columns[3].HeaderText = "Tổng Số DMSP";
            dgvKHOHANG.Columns[4].HeaderText = "Ghi Chú";

            // can chinh do rong cot:
            dgvKHOHANG.Columns[0].Width = 60;
            dgvKHOHANG.Columns[1].Width = 100;
            dgvKHOHANG.Columns[2].Width = 300;
            dgvKHOHANG.Columns[3].Width = 150;
            dgvKHOHANG.Columns[4].Width = 340;

            btn_ghinhan.Enabled = false;
            bt_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_chophepsua.Enabled = true;
        }

        private void dgvKHOHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_makho.Text = dgvKHOHANG.CurrentRow.Cells["MAKHO"].Value.ToString().Trim();
                tbx_tenkho.Text = dgvKHOHANG.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                tbx_tongdmsp.Text = dgvKHOHANG.CurrentRow.Cells["TONGSODMSP"].Value.ToString().Trim();
                tbx_ghichu.Text = dgvKHOHANG.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();

            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clearText();
            Frm_KhoHang_Load(sender, e);
        }

        private void txt_timkiem_leave(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_timkiem_EnTer(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                tbx_timkiem.Text = "";
            }
        }
    }
}
