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
    public partial class Frm_DanhMucSP : DevComponents.DotNetBar.OfficeForm
    {
        public Frm_DanhMucSP()
        {
            InitializeComponent();
        }
        DataAccess acc = new DataAccess();
        private string MAKHO;
        private int key = 0;
        public void cleartext()
        {
            tbx_ghichu.Clear();
            tbx_madm.Clear();
            tbx_makho.ResetText();
            tbx_tendm.Clear();


        }
        public void Disable()
        {
            tbx_madm.Enabled = false; tbx_makho.Enabled = false; tbx_tendm.Enabled = false; tbx_ghichu.Enabled = false;
        }
        public void Enable()
        {
            tbx_madm.Enabled = true; tbx_makho.Enabled = true; tbx_tendm.Enabled = true; tbx_ghichu.Enabled = true; tbx_tendm.Focus();
        }
        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu Menu = new MainMenu();
            Menu.ShowDialog();
        }
        public DataTable ThongTinMaKho(string Text)
        {
            SqlDataReader a = acc.ExecuteReader("Select MAKHO FROM KHOHANG WHERE TENKHO LIKE N'" + Text + "'");
            while (a.Read())
            {
                MAKHO = a["MAKHO"].ToString().Trim();
            }
            return null;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            tbx_tendm.Focus();
            Enable();
            tbx_madm.Enabled = true;
            key = 1;
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            bt_chophepsua.Enabled = false;
            bt_ghinhan.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Enable();
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
            bt_chophepsua.Enabled = false;
            bt_ghinhan.Enabled = true;
            key = 2;
            tbx_madm.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bt_xoa.Enabled = false;
            bt_them.Enabled = false;
            bt_chophepsua.Enabled = false;
            bt_ghinhan.Enabled = false;
            //key = 3;
            Disable();
            tbx_madm.Enabled = true;
            if (tbx_madm.Text == "" || dgvDANHMUC.SelectedRows == null)
            {
                MessageBox.Show("Hãy Nhập thông tin mã Danh Mục cần xóa hoặc chọn trên Bảng Dữ liệu");
                tbx_madm.Focus();
                tbx_madm.Enabled = true;
                tbx_madm.BackColor = Color.White;
            }
            else
            {
                if (MessageBox.Show("Bạn có Chắc chắn muốn xóa danh mục này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acc.XOA_DANHMUC("UPDATE SANPHAM SET MADANHMUC=NULL WHERE MADANHMUC='" + tbx_madm.Text + "'");
                    acc.XOA_DANHMUC(tbx_madm.Text);
                    Frm_DanhMucSP_Load(sender, e);
                    MessageBox.Show("Xóa Thành Công Danh Mục!", "Thông Báo");
                    //lb_thongbao.Text = "Xóa Thành Công";
                    cleartext();
                }
            }
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (tbx_tendm.Text == "" || tbx_makho.Text == "")
                {
                    MessageBox.Show("Hãy Nhập đủ thông tin vào các trường", "ThônG Báo");
                    tbx_madm.Focus();

                }
                else
                {
                    var itemMakho = tbx_makho.GetItemText(tbx_makho.SelectedItem);
                    ThongTinMaKho(itemMakho);
                    DataTable dtdm = new DataTable();
                    DataTable dttdm = new DataTable();
                    dtdm = acc.CheckSql("SELECT * From DANHMUC where MADANHMUC='" + tbx_madm.Text + "' ");
                    dttdm = acc.CheckSql("select * from DanhMuc where TENDANHMUC like N'" + tbx_tendm.Text + "'");
                    if (dtdm.Rows.Count > 0 || dttdm.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã danh mục đã tồn tại!", "Cảnh báo");
                        tbx_madm.Clear();
                        tbx_tendm.Clear();
                        tbx_madm.Focus();
                    }

                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn thêm danh mục này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            acc.THEM_DANHMUC(tbx_madm.Text, tbx_tendm.Text, tbx_ghichu.Text, MAKHO);
                            Frm_DanhMucSP_Load(sender, e);
                            MessageBox.Show("Thêm Thành Công Danh Mục!", "Thông Báo");
                            //lb_thongbao.Text = "Thêm Thành Công";
                            cleartext();
                            tbx_tendm.Focus();
                        }

                    }
                }


            }
            if (key == 2)
            {
                if (tbx_madm.Text == "" || dgvDANHMUC.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Nhập Mã Danh mục cần sửa đổi hoặc chọn trực tiếp trên bảng", "Cảnh báo");
                    tbx_madm.Focus();
                }
                else
                {

                    var itemMakho = tbx_makho.GetItemText(tbx_makho.SelectedItem);
                    ThongTinMaKho(itemMakho);
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa danh mục này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        acc.SUA_DANHMUC(tbx_madm.Text, tbx_tendm.Text, tbx_ghichu.Text, MAKHO);
                        Frm_DanhMucSP_Load(sender, e);
                        cleartext();
                        MessageBox.Show("Sửa Thành Công Danh Mục!", "Thông Báo");
                        //lb_thongbao.Text = "Sửa Thành Công";
                    }


                }
            }
        }
        private void Frm_DanhMucSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //MainMenu menu = new MainMenu();
            //menu.ShowDialog();
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
                dgvDANHMUC.DataSource = acc.Select_Data("SELECT Row_number() over(order by MADANHMUC) STT,*from DanhMucSP WHERE ( MADANHMUC like N'%" + tbx_timkiem.Text + "%' OR TENDANHMUC like N'%" + tbx_timkiem.Text + "%' OR DanhMucSP.TENKHO like N'%" + tbx_timkiem.Text + "%' OR DanhMucSP.GHICHU like N'%" + tbx_timkiem.Text + "%' )");
                tbx_timkiem.Clear();
                dgvDANHMUC.ClearSelection();
            }
        }

        private void Frm_DanhMucSP_Load(object sender, EventArgs e)
        {
            tbx_madm.Text = " ";
            Disable();
            bt_xoa.Enabled = true;
            tbx_tendm.Focus();
            acc.AutoCompletecbx(tbx_makho, "SELECT TENKHO FROM KHOHANG", "TENKHO");
            tbx_madm.Enabled = false;
            dgvDANHMUC.DataSource = acc.Select_Data("Select Row_number() over(order by MADANHMUC) STT,* from DANHMUCSP");
            dgvDANHMUC.ClearSelection();
            tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            //hiển thị tiêu đề của các cột:
            dgvDANHMUC.Columns[1].HeaderText = "Mã Danh Mục";
            dgvDANHMUC.Columns[2].HeaderText = "Tên Danh Mục";
            dgvDANHMUC.Columns[3].HeaderText = "Tên Kho";
            dgvDANHMUC.Columns[4].HeaderText = "Ghi Chú";

            //căn độ rộng cột:
            dgvDANHMUC.Columns[0].Width = 50;
            dgvDANHMUC.Columns[1].Width = 110;
            dgvDANHMUC.Columns[2].Width = 185;
            dgvDANHMUC.Columns[3].Width = 200;
            dgvDANHMUC.Columns[4].Width = 200;

            bt_ghinhan.Enabled = false;
            bt_them.Enabled = true;
            bt_xoa.Enabled = true;
            bt_chophepsua.Enabled = true;
        }

        private void Dgv_DANHMUC(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbx_madm.Text = dgvDANHMUC.CurrentRow.Cells["MADANHMUC"].Value.ToString().Trim();
                tbx_tendm.Text = dgvDANHMUC.CurrentRow.Cells["TENDANHMUC"].Value.ToString().Trim();
                tbx_makho.Text = dgvDANHMUC.CurrentRow.Cells["TENKHO"].Value.ToString().Trim();
                tbx_ghichu.Text = dgvDANHMUC.CurrentRow.Cells["GHICHU"].Value.ToString().Trim();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            cleartext();
            Frm_DanhMucSP_Load(sender, e);
        }
    }
}
