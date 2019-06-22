using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.CT
{
    public partial class Frm_BoPhanDaXong : UserControl
    {
        public Frm_BoPhanDaXong()
        {
            InitializeComponent();
        }
        DataAccess acc = new DataAccess();
        private int key = 0;
        private string MAKHO;
        private string MANV;
        public static string QUYENHD;

        public DataTable ThongTinMaKho(string TEXT)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("Select MAKHO FROM KHOHANG WHERE TENKHO LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MAKHO = a["MAKHO"].ToString().Trim();
            }
            return null;
        }

        public DataTable ThongTinMaNV(string TEXT)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM NHANVIEN WHERE TENNV LIKE N'" + TEXT + "'");
            while (a.Read())
            {
                MANV = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public void ClearText()
        {
            tbx_MaBP.Clear();
            tbx_TenBP.Clear();
            tbx_Dienthoai.Clear();
            tbx_MaKho.ResetText();
            tbx_NQL.ResetText();
            dgv_BoPhan.ClearSelection();
            tbx_MaBP.Focus();
        }

        private void Disabletbx()
        {
            tbx_MaBP.Enabled = false;
            tbx_MaKho.Enabled = false;
            tbx_NQL.Enabled = false;
            tbx_TenBP.Enabled = false;
            tbx_Dienthoai.Enabled = false;
        }

        private void Enabletbx()
        {
            tbx_MaBP.Enabled = false;
            tbx_MaKho.Enabled = true;
            tbx_NQL.Enabled = true;
            tbx_TenBP.Enabled = true;
            tbx_Dienthoai.Enabled = true;
        }

        private void Disablebtn()
        {
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_ghinhan.Enabled = true;
        }

        private void Enablebtn()
        {
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_ghinhan.Enabled = false;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            key = 1;
            Disablebtn();
            Enabletbx();
            tbx_MaBP.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            key = 2;
            Disablebtn();
            Enabletbx();
            tbx_MaBP.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            tbx_MaBP.Enabled = false;
            btn_ghinhan.Enabled = false;
            
                DataTable dtnv = new DataTable();
                dtnv = acc.CheckSql("select * from NHANVIEN where MABP ='" + tbx_MaBP.Text + "'");
                if (dtnv.Rows.Count > 0)
                {
                    if (MessageBox.Show("Bộ Phận Đang Tốn Tại Ơ Bảng Nhân Viên! Bạn Chắc Chắn Muốn Xóa!Toàn Bộ Thông Tin Liên Quan Đến Bộ Phận Sẽ Chuyển Về Default!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.CheckSql("Update NHANVIEN SET MABP = null WHERE MABP = '" + tbx_MaBP.Text + "'");
                        acc.Xoa_BoPhan(tbx_MaBP.Text);
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                        Frm_BoPhan_Load(sender, e);
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Bộ Phận Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.Xoa_BoPhan(tbx_MaBP.Text);
                        MessageBox.Show("Xóa Thành Công!", "Thông Báo");
                        Frm_BoPhan_Load(sender, e);
                    }
                  
                }
            
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                int count = 0;
                count = dgv_BoPhan.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgv_BoPhan.Rows[count - 2].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    tbx_MaBP.Text = "BP00" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    tbx_MaBP.Text = "BP0" + (chuoi2 + 1).ToString();
                if (tbx_TenBP.Text.Trim() == "" || tbx_Dienthoai.Text.Trim() == "" || tbx_MaKho.Text.Trim() == "" || tbx_NQL.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!", "Thông Báo!");
                    tbx_MaBP.Focus();
                }
                else
                {
                    var itemnv = tbx_NQL.GetItemText(tbx_NQL.SelectedItem);
                    ThongTinMaNV(itemnv);
                    var itemkho = tbx_MaKho.GetItemText(tbx_MaKho.SelectedItem);
                    ThongTinMaKho(itemkho);
                    DataTable dtkho = new DataTable();
                    DataTable dtbp = new DataTable();
                    DataTable dtnql = new DataTable();
                    DataTable dttbp = new DataTable();
                    dtnql = acc.CheckSql("select * from NHANVIEN where TENNV like N'" + itemnv + "'");
                    dtkho = acc.CheckSql("select * from KHOHANG where TENKHO like N'" + itemkho + "'");
                    dtbp = acc.CheckSql("select * from BOPHAN where MABP ='" + tbx_MaBP.Text + "'");
                    dttbp = acc.CheckSql("select * from BOPHAN where TENBP like N'" + tbx_TenBP.Text + "'");
                    if (dttbp.Rows.Count > 0)
                    {
                        MessageBox.Show("Bộ Phận đã tồn tại!", "Lỗi");
                        tbx_TenBP.Clear();
                        tbx_TenBP.Focus();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Kho Hàng không tồn tại!", "Lỗi");
                        tbx_MaKho.ResetText();
                    }
                    else if (dtnql.Rows.Count < 1)
                    {
                        MessageBox.Show("Người Quản Lý không tồn tại!", "Lỗi");
                        tbx_NQL.ResetText();
                    }
                    else
                    {
                        if (tbx_MaBP.Text == dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString() && tbx_TenBP.Text == dgv_BoPhan.CurrentRow.Cells["TENBP"].Value.ToString().Trim() && tbx_MaKho.Text == dgv_BoPhan.CurrentRow.Cells["TENKHO"].Value.ToString().Trim() && tbx_NQL.Text == dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim() && tbx_Dienthoai.Text == dgv_BoPhan.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim())
                        {
                            MessageBox.Show("Toàn Bộ Thông Tin Bộ Phận Đã Tồn Tại. Vui Lòng Sủa Lại!", "Thông Báo!");
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn Chắc Chắn Muốn Thêm Bộ Phận Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                acc.Them_BoPhan(tbx_MaBP.Text, tbx_TenBP.Text, tbx_Dienthoai.Text, MAKHO, MANV);
                                Frm_BoPhan_Load(sender, e);
                                MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                            }

                        }
                    }
                }
            }
            if (key == 2)
            {
                dgv_BoPhan.BeginEdit(true);
                if (tbx_MaBP.Text.Trim() == "" || tbx_NQL.Text.Trim() == "" || tbx_MaKho.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin Hoặc Chọn Dòng Bạn Muốn Sửa. Tối Thiểu MABP + MAKHO + NQL!", "Thông Báo!");
                    tbx_MaBP.Focus();
                }
                else
                {
                    var itemnv = tbx_NQL.GetItemText(tbx_NQL.SelectedItem);
                    ThongTinMaNV(itemnv);
                    var itemkho = tbx_MaKho.GetItemText(tbx_MaKho.SelectedItem);
                    ThongTinMaKho(itemkho);
                    DataTable dtkho = new DataTable();
                    DataTable dtnql = new DataTable();
                    dtnql = acc.CheckSql("select * from NHANVIEN where TENNV like N'" + itemnv + "'");
                    dtkho = acc.CheckSql("select * from KHOHANG where TENKHO like N'" + itemkho + "'");
                    if (tbx_MaBP.Text != dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim())
                    {
                        MessageBox.Show("Mã Bộ Phận đã bị thay đổi!", "Lỗi");
                        tbx_MaBP.Text = dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim();
                    }
                    else if (dtkho.Rows.Count < 1)
                    {
                        MessageBox.Show("Kho Hàng không tồn tại!", "Lỗi");
                        tbx_NQL.Text = dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                        tbx_MaKho.Text = dgv_BoPhan.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                    }
                    else if (dtnql.Rows.Count < 1)
                    {
                        MessageBox.Show("Người Quản Lý không tồn tại!", "Lỗi");
                        tbx_NQL.Text = dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa Bộ Phận Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.CapNhat_BoPhan(tbx_MaBP.Text, tbx_TenBP.Text, tbx_Dienthoai.Text, MAKHO, MANV);
                            MessageBox.Show("Sửa Thành Công!", "Thông Báo");
                            Frm_BoPhan_Load(sender, e);
                        }
                        else
                        {

                        }
                    }
                }
                dgv_BoPhan.EndEdit();
            }
            
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearText();
            Frm_BoPhan_Load(sender, e);
        }

        private void Frm_BoPhan_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            acc.AutoComplete(tbx_MaBP, "SELECT MABP FROM BOPHAN");
            acc.AutoCompletecbx(tbx_MaKho, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            acc.AutoCompletecbx(tbx_NQL, "SELECT TENNV FROM NHANVIEN", "TENNV");

            dgv_BoPhan.DataSource = acc.Select_Data("Select Row_number() over(order by MABP) STT,* from BP");

            dgv_BoPhan.Columns[0].Width = 45;
            dgv_BoPhan.Columns[1].Width = 120;
            dgv_BoPhan.Columns[2].Width = 160;
            dgv_BoPhan.Columns[3].Width = 100;
            dgv_BoPhan.Columns[4].Width = 160;
            dgv_BoPhan.Columns[5].Width = 150;

            dgv_BoPhan.Columns["MABP"].HeaderText = "Mã Bộ Phận";
            dgv_BoPhan.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            dgv_BoPhan.Columns["TENKHO"].HeaderText = "Kho";
            dgv_BoPhan.Columns["TENNV"].HeaderText = "Người Quản Lý";
            dgv_BoPhan.Columns["TENBP"].HeaderText = "Bộ Phận";

            dgv_BoPhan.ClearSelection();
            ClearText();

            //if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
            //{
            //    btn_xoa.Enabled = true;
            //}
            //else
            //{
            //    btn_xoa.Enabled = false;
            //}
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
                dgv_BoPhan.DataSource = acc.Select_Data("SELECT Row_number() over(order by MABP) STT,*from BP WHERE ( BP.MABP like N'%" + tbx_timkiem.Text + "%' OR TENBP like N'%" + tbx_timkiem.Text + "%' OR BP.DIENTHOAI like N'%" + tbx_timkiem.Text + "%' OR TENKHO like N'%" + tbx_timkiem.Text + "%' OR TENNV like N'%" + tbx_timkiem.Text + "%')");
                tbx_timkiem.Clear();
                dgv_BoPhan.ClearSelection();
            }
        }

        private void dgv_BoPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_MaBP.Text = dgv_BoPhan.CurrentRow.Cells["MABP"].Value.ToString().Trim();
                tbx_TenBP.Text = dgv_BoPhan.CurrentRow.Cells["TENBP"].Value.ToString().Trim();
                tbx_Dienthoai.Text = dgv_BoPhan.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim();
                tbx_MaKho.Text = dgv_BoPhan.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                tbx_NQL.Text = dgv_BoPhan.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
            }
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                tbx_timkiem.Text = "";
            }
        }

        private void txt_TenBP(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên Bộ Phận phải là kí tự chữ ", "Thông Báo ");
            }
        }

        private void txt_SoDT(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần nhập số điện thoại là kí tự số ", "Thông Báo ");
            }
        }

        private void txt_SoDT(object sender, EventArgs e)
        {
            string t = tbx_Dienthoai.Text;
            if (t.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                tbx_Dienthoai.Focus();
            }
        }

        private void tbx_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoPhan(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }
    }
}
