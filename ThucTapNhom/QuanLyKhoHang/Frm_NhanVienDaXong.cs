using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class Frm_NhanVienDaXong : UserControl
    {
        public Frm_NhanVienDaXong()
        {
            InitializeComponent();
        }
        DataAccess acc = new DataAccess();
        public static string TDN;
        public static string filepath = "";
        private string filename;
        private int key = 0;
        private int keyall = 0;
        private string MaBP;
        public static string QUYENHD;
        private string MANV;
        private string TRANGTHAI;

        public DataTable ThongTinMABP(string TENBP)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("Select MABP FROM BOPHAN WHERE TENBP like N'" + TENBP + "'");
            while (a.Read())
            {
                MaBP = a["MABP"].ToString().Trim();
            }
            return null;
        }

        public DataTable ThongTinTDN(string TDNHT)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM DANGNHAP WHERE USERNAME = '" + TDNHT + "'");
            while (a.Read())
            {
                MANV = a["MANV"].ToString().Trim();
            }
            return null;
        }

        public DataTable ThongTinMANV(string TENBP)
        {
            DataAccess acc = new DataAccess();
            SqlDataReader a = acc.ExecuteReader("Select MABP FROM BOPHAN WHERE TENBP like N'" + TENBP + "'");
            while (a.Read())
            {
                MaBP = a["MABP"].ToString().Trim();
            }
            return null;
        }
        // Xóa text trong TextBox
        public void ClearText()
        {
            tbx_MaNV.Clear();
            tbx_TenNV.Clear();
            tbx_Email.Clear();
            tbx_DienThoai.Clear();
            tbx_DiaChi.Clear();
            tbx_luong.Clear();
            tbx_MaBP.ResetText();
            tbx_chucvu.Clear();
            rbtn_Nam.Checked = true;
            pc_nhanvien.Image = null;
            dateTimePicker_NS.Text = DateTime.Now.ToShortDateString();
            tbx_MaNV.Focus();
            filename = "";
            tbx_MaNV.Enabled = false;
            dgvNhanVien.ClearSelection();
        }

        private void Enabletbx()
        {
            tbx_chucvu.Enabled = true;
            tbx_DiaChi.Enabled = true;
            tbx_DienThoai.Enabled = true;
            tbx_Email.Enabled = true;
            tbx_luong.Enabled = true;
            tbx_MaBP.Enabled = true;
            tbx_MaNV.Enabled = true;
            tbx_TenNV.Enabled = true;
            dateTimePicker_NS.Enabled = true;
            pn_radio.Enabled = true;
        }
        private void Disabletbx()
        {
            tbx_chucvu.Enabled = false;
            tbx_DiaChi.Enabled = false;
            tbx_DienThoai.Enabled = false;
            tbx_Email.Enabled = false;
            tbx_luong.Enabled = false;
            tbx_MaBP.Enabled = false;
            tbx_MaNV.Enabled = false;
            tbx_TenNV.Enabled = false;
            dateTimePicker_NS.Enabled = false;
            pn_radio.Enabled = false;
            
        }

        private void Enablebtn()
        {
            btn_ghinhan.Enabled = false;
            btn_file.Enabled = false;
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            bt_xoa.Enabled = true;
        }

        private void Disablebtn()
        {
            btn_ghinhan.Enabled = true;
            btn_sua.Enabled = false;
            btn_them.Enabled = false;
            bt_xoa.Enabled = false;
            btn_file.Enabled = true;
        }
      
        private void NhanVIen_Load(object sender, EventArgs e)
        {
            cbx_nv.SelectedIndex = 0;
            Disabletbx();
            Enablebtn();
            lbx_trangthai.Visible = true;
            cbx_trangthai.Visible = true;
            cbx_trangthai.Checked = false;
            acc.AutoComplete(tbx_MaNV, "SELECT MANV FROM NHANVIEN");
            acc.AutoCompletecbx(tbx_MaBP, "SELECT TENBP FROM BOPHAN", "TENBP");
            acc.AutoComplete(tbx_chucvu, "SELECT CHUCVU FROM NHANVIEN");
            tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE NHANVIEN.TRANGTHAI = '1' order by MANV asc");
            dgvNhanVien.ClearSelection();
            tbx_MaNV.Enabled = false;
            rbtn_Nam.Checked = true;

            dgvNhanVien.Columns["TRANGTHAI"].HeaderText = "TT";
            dgvNhanVien.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["TENNV"].HeaderText = "Nhân Viên";
            dgvNhanVien.Columns["EMAIL"].HeaderText = "Email";
            dgvNhanVien.Columns["NS"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["GT"].HeaderText = "GT";
            dgvNhanVien.Columns["DIENTHOAI"].HeaderText = "Điện Thoại";
            dgvNhanVien.Columns["CHUCVU"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["HINHANH"].HeaderText = "Ảnh";
            dgvNhanVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["LUONG"].HeaderText = "Lương";
            dgvNhanVien.Columns["TENBP"].HeaderText = "Bộ Phận";

            dgvNhanVien.Columns[0].Width = 30;
            dgvNhanVien.Columns[1].Width = 135;
            dgvNhanVien.Columns[2].Width = 150;
            dgvNhanVien.Columns[3].Width = 150;
            dgvNhanVien.Columns[4].Width = 100;
            dgvNhanVien.Columns[5].Width = 60;
            dgvNhanVien.Columns[6].Width = 120;
            dgvNhanVien.Columns[7].Width = 150;
            dgvNhanVien.Columns[8].Width = 150;
            dgvNhanVien.Columns[9].Width = 120;
            dgvNhanVien.Columns[10].Width = 100;
            dgvNhanVien.Columns[11].Width = 190;
            dgvNhanVien.CurrentRow.Cells["TRANGTHAI"].ReadOnly = false;

            //if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
            //{
            //    bt_xoa.Enabled = true;
            //    lbx_nv.Enabled = true;
            //    cbx_nv.Enabled = true;
            //}
            //else
            //{
            //    bt_xoa.Enabled = false;
            //    lbx_nv.Enabled = false;
            //    cbx_nv.Enabled = false;
            //}
        }

      

        private void dgvNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                bt_xoa_Click(sender, e);
            }
        }

      
      

    
        private void lbx_xemall_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbx_trangthai.Visible = true;
            cbx_trangthai.Visible = true;
            cbx_trangthai.Enabled = false;
            cbx_trangthai.Checked = false;
            ClearText();
            dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP order by MANV asc");
        }

        private void lbx_nvdanghi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cbx_trangthai.Checked = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            bt_xoa.Enabled = false;
            lbx_trangthai.Visible = true;
            cbx_trangthai.Visible = true;
            cbx_trangthai.Enabled = false;
            keyall = 4;
            ClearText();
            dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE NHANVIEN.TRANGTHAI = '0' order by MANV asc");
        }

        
      

     

     
       

    
      

        private void cbx_nv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbx_nv.SelectedIndex == 0)
            {
                lbx_trangthai.Visible = true;
                cbx_trangthai.Visible = true;
                cbx_trangthai.Enabled = true;
                cbx_trangthai.Checked = true;
                btn_them.Enabled = true;
                bt_xoa.Enabled = true;
                bt_xoa.Enabled = true;
                ClearText();
                dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE NHANVIEN.TRANGTHAI = '1' order by MANV asc");
                dgvNhanVien.ClearSelection();
            }

            if (cbx_nv.SelectedIndex == 1)
            {
                cbx_trangthai.Checked = false;
                btn_them.Enabled = false;
                bt_xoa.Enabled = false;
                bt_xoa.Enabled = false;
                lbx_trangthai.Visible = true;
                cbx_trangthai.Visible = true;
                cbx_trangthai.Enabled = false;
                keyall = 4;
                ClearText();
                dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE NHANVIEN.TRANGTHAI = '0' order by MANV asc");
                dgvNhanVien.ClearSelection();
            }

            if (cbx_nv.SelectedIndex == 2)
            {
                lbx_trangthai.Visible = true;
                cbx_trangthai.Visible = true;
                cbx_trangthai.Enabled = false;
                cbx_trangthai.Checked = false;
                btn_them.Enabled = true;
                bt_xoa.Enabled = true;
                bt_xoa.Enabled = true;
                ClearText();
                dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP order by MANV asc");
                dgvNhanVien.ClearSelection();
            }
        }

      

       

        private void tbx_TenNV_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên Nhân Viên phải là kí tự chữ ", "Thông Báo ");
            }
        }

       
        private void tbx_DienThoai_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập số điện thoại là kí tự số ", "Thông Báo ");
            }
        }

        private void tbx_DienThoai_TextChanged(object sender, EventArgs e)
        {

            string t = tbx_DienThoai.Text;
            if (t.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                tbx_DienThoai.Focus();
            }
        }

        private void txb_Email(object sender, EventArgs e)
        {

            string t = tbx_Email.Text;
            if (t.Contains("@") != true || t.Length < 5)
            {
                MessageBox.Show("Địa chỉ mail không hợp lệ không hợp lệ");
                tbx_Email.Focus();
            }
        }

        private void txb_Luong(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập lương của nhân viên là kí tự số ", "Thông Báo ");
            }
        }

        private void txt_Timkiem_Enter(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                tbx_timkiem.Text = "";
            }
        }

        private void txt_Timkiem_Leave(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

      
       

        

      

       

        private void btlammoi_Click_1(object sender, EventArgs e)
        {
            NhanVIen_Load(sender, e);
            ClearText();
            key = 0;
        }

        

        private void btn_them_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            tbx_MaNV.Enabled = false;
            key = 1;
            if (keyall == 4)
            {
                cbx_trangthai.Enabled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();

            tbx_MaNV.Enabled = false;
            key = 2;
            if (keyall == 4)
            {
                cbx_trangthai.Enabled = true;
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            
            btn_file.Enabled = false;
            tbx_MaNV.Enabled = false;
            tbx_MaNV.Focus();
            key = 3;
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                int count = 0;
                count = dgvNhanVien.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvNhanVien.Rows[count - 2].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    tbx_MaNV.Text = "NV00" + (chuoi2 + 2).ToString();
                else if (chuoi2 + 1 < 100)
                    tbx_MaNV.Text = "NV0" + (chuoi2 + 2).ToString();
                lbx_trangthai.Visible = false;
                cbx_trangthai.Visible = false;
                if (tbx_TenNV.Text.Trim() == "" || tbx_Email.Text.Trim() == "" || tbx_DienThoai.Text.Trim() == "" || tbx_DiaChi.Text.Trim() == "" || tbx_luong.Text.Trim() == "" || tbx_MaBP.Text.Trim() == "")
                {
                    MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin!", "Thông Báo!");
                    tbx_MaNV.Focus();
                }
                else
                {
                    var item = tbx_MaBP.GetItemText(tbx_MaBP.SelectedItem);
                    ThongTinMABP(item);
                    DataTable dtnv = new DataTable();
                    DataTable dtbp = new DataTable();
                    dtnv = acc.CheckSql("select * from NHANVIEN where MANV ='" + tbx_MaNV.Text + "'");
                    dtbp = acc.CheckSql("select * from BOPHAN where MABP ='" + MaBP + "'");
                    if (dtnv.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi");
                        tbx_MaNV.Clear();
                        tbx_MaNV.Focus();
                    }
                    else if (dtbp.Rows.Count < 1)
                    {
                        MessageBox.Show("Bộ phận không tồn tại!", "Lỗi");
                        tbx_MaBP.ResetText();
                    }
                    else
                    {
                        string gt = "Nam";
                        if (rbtn_Nu.Checked == true)
                        {
                            gt = "Nữ";
                        }
                        //if (tbx_TenNV.Text == dgvNhanVien.CurrentRow.Cells["TENNV"].Value.ToString().Trim())
                        //{
                        //    MessageBox.Show("Nhân Viên Này Đã Tồn Tại. Vui Lòng Sửa Lại!", "Thông Báo!");
                        //}
                        else
                        {
                            acc.Them_NhanVien(tbx_MaNV.Text, tbx_TenNV.Text, tbx_Email.Text, dateTimePicker_NS.Value, gt, tbx_DienThoai.Text, tbx_chucvu.Text, filename, tbx_DiaChi.Text, float.Parse(tbx_luong.Text), MaBP);
                            MessageBox.Show("Thêm Thành Công", "Thông Báo!");
                            NhanVIen_Load(sender, e);
                            key = 0;
                        }
                    }
                }
            }
            if (key == 2)
            {
                if (cbx_trangthai.Checked == true)
                {
                    TRANGTHAI = "1";
                }
                else
                {
                    TRANGTHAI = "0";
                }
                string abc = TRANGTHAI;
                dgvNhanVien.BeginEdit(true);
                if (tbx_MaNV.Text.Trim() == "" || tbx_luong.Text.Trim() == "" || tbx_MaBP.Text.Trim() == "" /* || tbx_TenNV.Text.Trim() == "" || tbx_Email.Text.Trim() == "" || tbx_DienThoai.Text.Trim() == "" || tbx_DiaChi.Text.Trim() == "" || tbx_luong.Text.Trim() == "" */)
                {
                    MessageBox.Show("Chọn Dòng Bạn Muốn Sửa và Hãy Nhập Đầy Đủ Thông Tin. Tối Thiểu Mã NV và Lương Và MaBP!", "Thông Báo!");
                    tbx_MaNV.Focus();
                }
                else
                {
                    var item = tbx_MaBP.GetItemText(tbx_MaBP.SelectedItem);
                    ThongTinMABP(item);
                    DataTable dtbp = new DataTable();
                    dtbp = acc.CheckSql("select * from BOPHAN where MABP ='" + MaBP + "'");
                    if (dtbp.Rows.Count < 1)
                    {
                        MessageBox.Show("Phòng Ban không tồn tại!", "Lỗi");
                    }
                    //else if (tbx_MaNV.Text != dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString().Trim())
                    //{
                    //    MessageBox.Show("Mã Nhân Viên không thể thay đổi!", "Lỗi");
                    //}
                    else
                    {
                        string gt = "Nam";
                        if (rbtn_Nu.Checked == true)
                        {
                            gt = "Nữ";
                        }
                        if (filepath == Application.StartupPath + "\\Images\\" + dgvNhanVien.CurrentRow.Cells["HINHANH"].Value.ToString() &&
                            gt == dgvNhanVien.CurrentRow.Cells["GT"].Value.ToString() &&
                            tbx_TenNV.Text == dgvNhanVien.CurrentRow.Cells["TENNV"].Value.ToString().Trim() &&
                            tbx_MaBP.Text == dgvNhanVien.CurrentRow.Cells["TENBP"].Value.ToString().Trim() &&
                            tbx_luong.Text == dgvNhanVien.CurrentRow.Cells["LUONG"].Value.ToString().Trim() &&
                            tbx_Email.Text == dgvNhanVien.CurrentRow.Cells["EMAIL"].Value.ToString().Trim() &&
                            tbx_DienThoai.Text == dgvNhanVien.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim() &&
                            tbx_DiaChi.Text == dgvNhanVien.CurrentRow.Cells["DIACHI"].Value.ToString().Trim() &&
                            tbx_chucvu.Text == dgvNhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString().Trim() &&
                            Convert.ToBoolean(dgvNhanVien.CurrentRow.Cells["TRANGTHAI"].Value) == cbx_trangthai.Checked)
                        {
                            MessageBox.Show("Toàn Bộ Thông Tin Nhân Viên Đã Tồn Tại. Vui Lòng Sủa Lại!", "Thông Báo!");
                        }
                        else
                        {
                            if (MessageBox.Show("Bạn Chắc Chắn Muốn Sửa Nhân Viên Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                acc.CapNhat_NhanVien(tbx_MaNV.Text, tbx_TenNV.Text, tbx_Email.Text, dateTimePicker_NS.Value, gt, tbx_DienThoai.Text, tbx_chucvu.Text, filename, tbx_DiaChi.Text, float.Parse(tbx_luong.Text), MaBP, TRANGTHAI);
                                MessageBox.Show("Sửa Thành Công!", "Thông Báo!");
                                NhanVIen_Load(sender, e);
                                key = 0;
                            }
                            else
                            {

                            }
                        }
                    }
                }
                dgvNhanVien.EndEdit();
            }
            if (key == 3)
            {
                if (cbx_trangthai.Checked == false)
                {
                    MessageBox.Show("Nhân Viên này Đã Nghỉ!");
                }
                else
                {
                    if (tbx_MaNV.Text.Trim() == "" || dgvNhanVien.SelectedRows == null)
                    {
                        MessageBox.Show("Hãy Nhập Mã Nhân Viên Muốn Xóa Hoặc Chọn Dòng Muốm Xóa!,", "Cảnh Báo!");
                        tbx_MaNV.Focus();
                    }
                    else
                    {
                        ThongTinTDN(TDN);
                        if (MANV != tbx_MaNV.Text)
                        {
                            DataTable dtbp = new DataTable();
                            dtbp = acc.CheckSql("select * from BOPHAN where NQL ='" + tbx_MaNV.Text + "'");
                            DataTable dtnv = new DataTable();
                            dtnv = acc.CheckSql("select * from DANGNHAP where MANV ='" + tbx_MaNV.Text + "'");
                            if (dtbp.Rows.Count > 0 || dtnv.Rows.Count > 0)
                            {
                                if (MessageBox.Show("Nhân Viên Đang Tốn Tại Ơ Bảng Bộ Phận, Đăng Nhập! Bạn Chắc Chắn Muốn Xóa! Toàn Bộ Thông Tin Liên Quan Đến Nhân Viên Sẽ Chuyển Về Default!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    acc.CheckSql("Update BOPHAN SET NQL = null WHERE NQL = '" + tbx_MaNV.Text + "'");
                                    acc.CheckSql("DELETE DANGNHAP WHERE MANV = '" + tbx_MaNV.Text + "'");
                                    acc.Xoa_NhanVien(tbx_MaNV.Text);
                                    MessageBox.Show("Xóa Thành Công!", "Thông Báo!");

                                    NhanVIen_Load(sender, e);
                                    key = 0;
                                }
                            }
                            else
                            {

                                if (MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Nhân Viên Này?", "Xác Nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    acc.Xoa_NhanVien(tbx_MaNV.Text);
                                    MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                                    NhanVIen_Load(sender, e);
                                    key = 0;
                                }
                                else
                                {

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không Thể Xoá Nhân Viên Này!");
                        }
                    }
                }
            }
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Cần Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
                {
                    dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE NHANVIEN.MANV like N'%" + tbx_timkiem.Text + "%' OR TENNV like N'%" + tbx_timkiem.Text + "%' OR EMAIL like N'%" + tbx_timkiem.Text + "%' OR NS like N'%" + tbx_timkiem.Text + "%' OR GT like N'%" + tbx_timkiem.Text + "%' OR NHANVIEN.DIENTHOAI like N'%" + tbx_timkiem.Text + "%' OR CHUCVU like N'%" + tbx_timkiem.Text + "%' OR DIACHI like N'%" + tbx_timkiem.Text + "%' OR LUONG like N'%" + tbx_timkiem.Text + "%' OR TENBP like N'%" + tbx_timkiem.Text + "%' order by MANV asc");
                    tbx_timkiem.Clear();
                    dgvNhanVien.ClearSelection();
                }
                else
                {
                    dgvNhanVien.DataSource = acc.Select_Data("Select NHANVIEN.TRANGTHAI, MANV, TENNV, EMAIL, NS, GT, NHANVIEN.DIENTHOAI, CHUCVU, HINHANH, DIACHI, LUONG, TENBP from NHANVIEN left join BOPHAN on BOPHAN.MABP = NHANVIEN.MABP WHERE TRANGTHAI = '1' and (NHANVIEN.MANV like N'%" + tbx_timkiem.Text + "%' OR TENNV like N'%" + tbx_timkiem.Text + "%' OR EMAIL like N'%" + tbx_timkiem.Text + "%' OR NS like N'%" + tbx_timkiem.Text + "%' OR GT like N'%" + tbx_timkiem.Text + "%' OR NHANVIEN.DIENTHOAI like N'%" + tbx_timkiem.Text + "%' OR CHUCVU like N'%" + tbx_timkiem.Text + "%' OR DIACHI like N'%" + tbx_timkiem.Text + "%' OR LUONG like N'%" + tbx_timkiem.Text + "%' OR TENBP like N'%" + tbx_timkiem.Text + "%') order by MANV asc");
                    tbx_timkiem.Clear();
                    dgvNhanVien.ClearSelection();
                }
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            PictureBox objpt = new PictureBox();
            ofdImages.Title = "Chọn File Ảnh!";
            ofdImages.InitialDirectory = @"Documents";//Thư mục mặc định khi mở
            ofdImages.Filter = "All files (*.*)|*.*";// Lọc ra những file cần hiển thị
            ofdImages.FilterIndex = 1;//chúng ta có All files là 1,jpg là 2
            ofdImages.RestoreDirectory = true;
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                string filenameX = ofdImages.FileName;
                pc_nhanvien.Image = Image.FromFile(ofdImages.FileName);
                filename = Path.GetFileName(ofdImages.FileName);
                pc_nhanvien.SizeMode = PictureBoxSizeMode.StretchImage;
                filepath = Application.StartupPath + "\\Images\\" + filename;
                if (!File.Exists(filenameX)) return;

                if (File.Exists(filepath))
                {

                }
                else
                    try
                    {
                        File.Copy(filenameX, filepath);
                    }
                    catch
                    {
                        MessageBox.Show("Đã phát sinh lỗi trong việc chọn ảnh upload, vui lòng kiểm tra lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                filename = "";
                pc_nhanvien.Image = null;
            }
        }

     
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearText();
            NhanVIen_Load(sender, e);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvNhanVien.Rows[e.RowIndex].Cells["TRANGTHAI"].ReadOnly = true;
                tbx_MaNV.Text = dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString().Trim();
                tbx_TenNV.Text = dgvNhanVien.CurrentRow.Cells["TENNV"].Value.ToString().Trim();
                tbx_Email.Text = dgvNhanVien.CurrentRow.Cells["EMAIL"].Value.ToString().Trim();
                tbx_DienThoai.Text = dgvNhanVien.CurrentRow.Cells["DIENTHOAI"].Value.ToString().Trim();
                tbx_DiaChi.Text = dgvNhanVien.CurrentRow.Cells["DIACHI"].Value.ToString().Trim();
                tbx_luong.Text = dgvNhanVien.CurrentRow.Cells["LUONG"].Value.ToString().Trim();
                tbx_MaBP.Text = dgvNhanVien.CurrentRow.Cells["TENBP"].Value.ToString().Trim();
                if (dgvNhanVien.CurrentRow.Cells["GT"].Value.ToString() == "Nam")
                {
                    rbtn_Nam.Checked = true;
                    rbtn_Nu.Checked = false;
                }
                else
                {
                    rbtn_Nam.Checked = false;
                    rbtn_Nu.Checked = true;
                }

                if (Convert.ToBoolean(dgvNhanVien.CurrentRow.Cells["TRANGTHAI"].Value) == true)
                {
                    //if (QUYENHD == "ADMIN" || QUYENHD == "Admin" || QUYENHD == "admin")
                    //{
                        if (key == 1 || key == 2 || key == 3 || cbx_nv.SelectedIndex == 1)
                        {
                            bt_xoa.Enabled = false;
                            cbx_trangthai.Checked = true;
                        }
                        else
                        {
                            bt_xoa.Enabled = true;
                            cbx_trangthai.Checked = true;
                        }

                    //}
                    //else
                    //{
                    //    bt_xoa.Enabled = false;
                    //}
                }
                else
                {
                    cbx_trangthai.Checked = false;
                    bt_xoa.Enabled = false;
                }
                tbx_chucvu.Text = dgvNhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString().Trim();
                dateTimePicker_NS.Text = dgvNhanVien.CurrentRow.Cells["NS"].Value.ToString().Trim();
                filename = dgvNhanVien.CurrentRow.Cells["HINHANH"].Value.ToString().Trim();
                if (filename == "")
                {
                    pc_nhanvien.Image = null;
                }
                else
                {
                    filepath = Application.StartupPath + "\\Images\\" + filename;
                    if (!File.Exists(filepath))
                    {
                        pc_nhanvien.Image = null;
                    }
                    else
                    {
                        pc_nhanvien.Image = Image.FromFile(filepath.ToString());
                        pc_nhanvien.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private void txt_tennv(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên nhân viên phải là kí tự chữ ", "Thông Báo ");
            }
        }

        private void txttimkiem_leave(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_timkiem(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                tbx_timkiem.Text = "";
            }
        }

        private void txt_dt_leave(object sender, EventArgs e)
        {
            string t = tbx_DienThoai.Text;
            if (t.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                tbx_DienThoai.Focus();
            }
        }

        private void txt_dt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần nhập số điện thoại là kí tự số ", "Thông Báo ");
            }
        }

        private void txt_Luong(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập lương của nhân viên là kí tự số ", "Thông Báo ");
            }
        }

        private void txt_email(object sender, EventArgs e)
        {
            string t = tbx_Email.Text;
            if (t.Contains("@") != true || t.Length < 5)
            {
                MessageBox.Show("Địa chỉ mail không hợp lệ không hợp lệ");
                tbx_Email.Focus();
            }
        }
    }
}
