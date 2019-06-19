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
    public partial class Frm_KhachHang : UserControl
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        DataAccess acc = new DataAccess();
        private int key = 0;

        public void ClearText()
        {
            tbx_makh.Clear();
            tbx_tenkh.Clear();
            tbx_diachi.Clear();
            tbx_gioitinh.Clear();
            tbx_dienthoai.Clear();
            tbx_email.Clear();
            tbx_fax.Clear();
            tbx_makh.Enabled = false;
            dgvKhachHang.ClearSelection();
            tbx_makh.Focus();
        }
        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            bt_xoa.Enabled = false;
            tbx_diachi.Enabled = true;
            tbx_dienthoai.Enabled = true;
            tbx_email.Enabled = true;
            tbx_fax.Enabled = true;
            bt_luu.Enabled = true;

            tbx_gioitinh.Enabled = true;
            tbx_makh.Enabled = true;
            tbx_tenkh.Enabled = true;

            key = 1;
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            acc.AutoComplete(tbx_makh, "SELECT MAKH FROM KHACHHANG");
            dgvKhachHang.DataSource = acc.Select_Data("Select Row_number() over(order by MAKH) STT,* from KhachHangMua");
            ClearText();
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            bt_xoa.Enabled = true;
            tbx_diachi.Enabled = false;
            tbx_dienthoai.Enabled = false;
            tbx_email.Enabled = false;
            tbx_fax.Enabled = false;
            bt_luu.Enabled = false;
            tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            tbx_gioitinh.Enabled = false;
            tbx_makh.Enabled = false;
            tbx_tenkh.Enabled = false;

            dgvKhachHang.Columns["MAKH"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["TENKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dgvKhachHang.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            dgvKhachHang.Columns["EMAIL"].HeaderText = "Email";
            dgvKhachHang.Columns["FAX"].HeaderText = "Fax";
            dgvKhachHang.Columns[0].Width = 50;
            dgvKhachHang.Columns[1].Width = 100;
            dgvKhachHang.Columns[2].Width = 150;
            dgvKhachHang.Columns[3].Width = 110;
            dgvKhachHang.Columns[4].Width = 90;
            dgvKhachHang.Columns[5].Width = 120;
            dgvKhachHang.Columns[6].Width = 160;
            dgvKhachHang.Columns[7].Width = 100;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            bt_xoa.Enabled = false;
            tbx_diachi.Enabled = true;
            tbx_dienthoai.Enabled = true;
            tbx_email.Enabled = true;
            tbx_fax.Enabled = true;
            tbx_gioitinh.Enabled = true;
            tbx_makh.Enabled = true;
            tbx_tenkh.Enabled = true;
            bt_luu.Enabled = true;
            key = 2;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (tbx_makh.Text.Trim() == "" || dgvKhachHang.SelectedRows == null)
            {
                MessageBox.Show("Hãy Nhập Mã Khách Hàng Muốn Xóa Hoặc Chọn Dòng Muốn Xóa!,", "Cảnh Báo!");

            }
            else
            {
                DataTable dtpx = new DataTable();
                dtpx = acc.CheckSql("select * from PHIEUXUAT where MAKH ='" + tbx_makh.Text + "'");

                if (dtpx.Rows.Count > 0)
                {
                    if (MessageBox.Show("Khách Hàng  Đang Tốn Tại Ơ Bảng PHIEUXUAT, PHIEUNHAP! Bạn Có Muốn Xóa Thông Tin KH Này!", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.CheckSql("Update PHIEUXUAT SET MAKH = null WHERE MAKH = '" + tbx_makh.Text + "'");
                    }

                }
                else
                {
                    if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Khách Hàng Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.Xoa_KhachHang(tbx_makh.Text);
                        Frm_KhachHang_Load(sender, e);
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                    }
                    else
                    {

                    }
                }

            }
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_tenkh.Text.Trim() == "" || tbx_diachi.Text.Trim() == "" || tbx_dienthoai.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!,", "Thông Báo!");
                    tbx_makh.Focus();
                }
                else
                {
                    DataTable dtkho = new DataTable();
                    dtkho = acc.CheckSql("select * from KHACHHANG where MAKH ='" + tbx_makh.Text + "'");
                    if (dtkho.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã Khách Hàng đã tồn tại!", "Lỗi");
                        tbx_makh.Clear();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Thêm Khách Hàng Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.Them_KhachHang(tbx_makh.Text, tbx_tenkh.Text, tbx_diachi.Text, tbx_gioitinh.Text, tbx_dienthoai.Text, tbx_email.Text, tbx_fax.Text);
                            Frm_KhachHang_Load(sender, e);
                            MessageBox.Show("Thêm Thành Công!", "Thông Báo!");
                        }
                        else
                        {

                        }
                    }
                }
            }
            if (key == 2)
            {
                dgvKhachHang.BeginEdit(true);
                if (tbx_tenkh.Text == "" || tbx_diachi.Text == "" || tbx_gioitinh.Text == "" || tbx_dienthoai.Text == "" || tbx_email.Text == "" || tbx_fax.Text == "")
                {
                    MessageBox.Show("Chọn Dòng Bạn Muốn Sửa", "Thông Báo!");
                    tbx_makh.Focus();
                }
                else
                {
                    if (tbx_makh.Text != dgvKhachHang.CurrentRow.Cells["MAKH"].Value.ToString().Trim() || tbx_makh.Text == "")
                    {
                        MessageBox.Show("Mã Khách Hàng chưa được nhập hoặc đã bị thay đổi!", "Lỗi");
                    }
                    else
                    {
                        if (tbx_tenkh.Text == dgvKhachHang.CurrentRow.Cells["TENKH"].Value.ToString().Trim() && tbx_makh.Text == dgvKhachHang.CurrentRow.Cells["MAKH"].Value.ToString().Trim() && tbx_diachi.Text == dgvKhachHang.CurrentRow.Cells["DIACHI"].Value.ToString().Trim() && tbx_gioitinh.Text == dgvKhachHang.CurrentRow.Cells["GIOITINH"].Value.ToString().Trim() && tbx_dienthoai.Text == dgvKhachHang.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim() && tbx_email.Text == dgvKhachHang.CurrentRow.Cells["EMAIL"].Value.ToString().Trim() && tbx_fax.Text == dgvKhachHang.CurrentRow.Cells["FAX"].Value.ToString().Trim())
                        {
                            MessageBox.Show("Toàn Bộ Thông Tin Khách Hàng Đã Tồn Tại. Vui Lòng Sủa Lại!", "Thông Báo!");
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa Khách Hàng Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                acc.CapNhat_KhachHang(tbx_makh.Text, tbx_tenkh.Text, tbx_diachi.Text, tbx_gioitinh.Text, tbx_dienthoai.Text, tbx_email.Text, tbx_fax.Text);
                                Frm_KhachHang_Load(sender, e);
                                MessageBox.Show("Sửa Thành Công!", "Thông Báo!");
                            }
                            else
                            {

                            }
                        }
                    }
                }
                dgvKhachHang.EndEdit();
            }
            if (key == 3)
            {
                //    if (tbx_makh.Text.Trim() == "" || dgvKhachHang.SelectedRows == null)
                //    {
                //        MessageBox.Show("Hãy Nhập Mã Khách Hàng Muốn Xóa Hoặc Chọn Dòng Muốm Xóa!,", "Cảnh Báo!");

                //    }
                //    else
                //    {
                //        DataTable dtpx = new DataTable();
                //        dtpx = acc.CheckSql("select * from PHIEUXUAT where MAKH ='" + tbx_makh.Text + "'");

                //        if (dtpx.Rows.Count > 0)
                //        {
                //            if (MessageBox.Show("Khách Hàng  Đang Tốn Tại Ơ Bảng PHIEUXUAT, PHIEUNHAP! Bạn Có Muốn Xóa Thông Tin KH Này!", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //            {
                //                acc.CheckSql("Update PHIEUXUAT SET MAKH = null WHERE MAKH = '" + tbx_makh.Text + "'");
                //            }

                //        }
                //        else
                //        {
                //            if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Khách Hàng Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //            {
                //                acc.Xoa_KhachHang(tbx_makh.Text);
                //                KhachHang_Load(sender, e);
                //                MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                //            }
                //            else
                //            {

                //            }
                //        }
                //    }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearText();
            Frm_KhachHang_Load(sender, e);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dgvKhachHang.DataSource = acc.Select_Data("Select Row_number() over(order by MAKH) STT,  * from KHACHHANGMUA Where MAKH like N'%" + tbx_timkiem.Text + "%' OR TENKH like N'%" + tbx_timkiem.Text + "%' OR DIACHI like N'%" + tbx_timkiem.Text + "%' OR GIOITINH like N'%" + tbx_timkiem.Text + "%' OR DIENTHOAI like N'%" + tbx_timkiem.Text + "%' OR EMAIL like N'%" + tbx_timkiem.Text + "%'");
                tbx_timkiem.Clear();
                dgvKhachHang.ClearSelection();
            }
        }

        private void dgv_nhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_makh.Text = dgvKhachHang.CurrentRow.Cells["MAKH"].Value.ToString().Trim();
                tbx_tenkh.Text = dgvKhachHang.CurrentRow.Cells["TENKH"].Value.ToString().Trim();
                tbx_diachi.Text = dgvKhachHang.CurrentRow.Cells["DIACHI"].Value.ToString().Trim();
                tbx_gioitinh.Text = dgvKhachHang.CurrentRow.Cells["GIOITINH"].Value.ToString().Trim();
                tbx_dienthoai.Text = dgvKhachHang.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim();
                tbx_email.Text = dgvKhachHang.CurrentRow.Cells["EMAIL"].Value.ToString().Trim();
                tbx_fax.Text = dgvKhachHang.CurrentRow.Cells["FAX"].Value.ToString().Trim();
            }
        }
    }
}
