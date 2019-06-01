using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BAL;


namespace TTN_QLTV
{
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        private int key = 0;
        NhanVienBAL bal_nhanvien = new NhanVienBAL();
        private void ClearText()
        {
            txtMaNV.Clear();
            txtTen.Clear();
            txtDiachi.Clear();
            txtLuong.Clear();
            dtNgaySinh.Text = DateTime.Now.ToShortDateString();
            rbNam.Checked = false;
            rbNu.Checked = false;

        }
        private void Enabletbx()
        {
            txtTen.Enabled = true;
            txtMaNV.Enabled = true;
            txtDiachi.Enabled = true;
            txtLuong.Enabled = true;
            dtNgaySinh.Enabled = true;
            gbGT.Enabled = true;
        }
        private void Disabletbx()
        {

            txtTen.Enabled = false;
            txtMaNV.Enabled = false;
            txtDiachi.Enabled = false;
            txtLuong.Enabled = false;
            dtNgaySinh.Enabled = false;
            gbGT.Enabled = false;
        }
        private void Enablebtn()
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void Disablebtn()
        {
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btnLuu.Enabled = true;

        }
        void ShowData()
        {
            dgvNhanVien.DataSource = bal_nhanvien.GetData();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            dgvNhanVien.DataSource = bal_nhanvien.GetData();
            dgvNhanVien.ClearSelection();
            dgvNhanVien.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["TENNV"].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dgvNhanVien.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["LUONG"].HeaderText = "Lương";


            dgvNhanVien.Columns["MANV"].Width = 100;
            dgvNhanVien.Columns["TENNV"].Width = 160;
            dgvNhanVien.Columns["NGAYSINH"].Width = 100;
            dgvNhanVien.Columns["GIOITINH"].Width = 50;
            dgvNhanVien.Columns["DIACHI"].Width = 200;
            dgvNhanVien.Columns["LUONG"].Width = 120;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void dgvNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                btlammoi_Click(sender, e);
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            frmnhanvien_Load(sender, e);
            ClearText();
            key = 0;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            btnLuu.Enabled = true;
            key = 1;
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            Disablebtn();
            Enabletbx();
            btnLuu.Enabled = true;
            key = 2;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            btnLuu.Enabled = true;
            key = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (key == 1)
            {
                if (txtMaNV.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtLuong.Text != "")
                {
                    string gioitinh = "";
                    if (rbNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }

                    NhanVien nv = new NhanVien(txtMaNV.Text.ToString().Trim(), txtTen.Text.ToString().Trim(), DateTime.Parse(dtNgaySinh.Text.ToString()), gioitinh, int.Parse(txtLuong.Text.ToString()), txtDiachi.Text.ToString().Trim());
                    if (bal_nhanvien.Them(nv) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Thêm thành công");
                        frmnhanvien_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_nhanvien.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }

                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");
            }

            if (key == 2)
            {


                if (txtMaNV.Text != "" && txtTen.Text != "" && txtDiachi.Text != "" && txtLuong.Text != "")
                {

                    string gioitinh = "";
                    if (rbNam.Checked)
                    {
                        gioitinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioitinh = "Nữ";
                    }

                    NhanVien nv = new NhanVien(txtMaNV.Text.ToString().Trim(), txtTen.Text.ToString().Trim(), DateTime.Parse(dtNgaySinh.Text.ToString()), gioitinh, int.Parse(txtLuong.Text.ToString()), txtDiachi.Text.ToString().Trim());
                    if (bal_nhanvien.Sua(nv) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        frmnhanvien_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_nhanvien.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Chọn dòng bạn muốn sửa và hãy nhập đầy đủ thông tin");

            }
            if (key == 3)
            {
                if (txtMaNV.Text.Length != 0)
                {
                    string query = @"DELETE FROM SinhVien Where masv='" + txtMaNV.Text + "'";

                    if (bal_nhanvien.Xoa(txtMaNV.Text.Trim()))
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Xóa thành công");
                        frmnhanvien_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_nhanvien.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn");
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MANV"].Value);
            txtTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TENNV"].Value);
            txtDiachi.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DIACHI"].Value);
            txtLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["LUONG"].Value);
            dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value);
            if (dgvNhanVien.CurrentRow.Cells["GIOITINH"].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                ShowData();
                if (bal_nhanvien.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dgvNhanVien.DataSource = bal_nhanvien.GetDataTimKiem(txtTimKiem.Text.Trim());

                }
                else
                {
                    Exception ex = bal_nhanvien.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }
    }
}
