using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace TTN_QLTV
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
        }
        private int key = 0;
        DocGiaBAL bal_docgia = new DocGiaBAL();
        private void ClearText()
        {
            txtHoten.Clear();
            txtMaSV.Clear();
            txtLop.Clear();
            txtDiachi.Clear();
            dtgNgaySinh.Text = DateTime.Now.ToShortDateString();
            rbNam.Checked = false;
            rbNu.Checked = false;

        }
        private void Enabletbx()
        {
            txtHoten.Enabled = true;
            txtMaSV.Enabled = true;
            txtDiachi.Enabled = true;
            txtLop.Enabled = true;
            dtgNgaySinh.Enabled = true;
            gbGT.Enabled = true;
        }
        private void Disabletbx()
        {

            txtHoten.Enabled = false;
            txtMaSV.Enabled = false;
            txtDiachi.Enabled = false;
            txtLop.Enabled = false;
            dtgNgaySinh.Enabled = false;
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
            dgvDocGia.DataSource = bal_docgia.GetData();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            dgvDocGia.DataSource = bal_docgia.GetData();
            dgvDocGia.ClearSelection();
            dgvDocGia.Columns["MASV"].HeaderText = "Mã Độc Giả";
            dgvDocGia.Columns["TENSV"].HeaderText = "Tên Độc Giả";
            dgvDocGia.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dgvDocGia.Columns["GIOITINH"].HeaderText = "Giới Tính";
            dgvDocGia.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvDocGia.Columns["LOP"].HeaderText = "Lớp";


            dgvDocGia.Columns["MASV"].Width = 100;
            dgvDocGia.Columns["TENSV"].Width = 160;
            dgvDocGia.Columns["NGAYSINH"].Width = 100;
            dgvDocGia.Columns["GIOITINH"].Width = 50;
            dgvDocGia.Columns["DIACHI"].Width = 200;
            dgvDocGia.Columns["LOP"].Width = 100;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                ShowData();
                if (bal_docgia.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dgvDocGia.DataSource = bal_docgia.GetDataTimKiem(txtTimKiem.Text.Trim());

                }
                else
                {
                    Exception ex = bal_docgia.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                btlammoi_Click(sender, e);
            }
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            frmDocGia_Load(sender, e);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (txtMaSV.Text != "" && txtHoten.Text != "" && txtDiachi.Text != "" && txtLop.Text != "")
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
                    
                    DocGia dg = new DocGia(txtMaSV.Text.ToString().Trim(), txtHoten.Text.ToString().Trim(), DateTime.Parse(dtgNgaySinh.Text.ToString()), gioitinh, txtDiachi.Text.ToString().Trim(), txtLop.Text.ToString().Trim());
                    if (bal_docgia.Them(dg) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Thêm thành công");
                        frmDocGia_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_docgia.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                
                }
                    else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");
            }

            if (key == 2)
            {
                
                   
                if (txtMaSV.Text != "" && txtHoten.Text != "" && txtDiachi.Text != "" && txtLop.Text != "")
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

                    DocGia dg = new DocGia(txtMaSV.Text.ToString().Trim(), txtHoten.Text.ToString().Trim(), DateTime.Parse(dtgNgaySinh.Text.ToString()), gioitinh ,txtDiachi.Text.Trim(), txtLop.Text.ToString().Trim());
                    if (bal_docgia.Sua(dg) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        frmDocGia_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_docgia.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Chọn dòng bạn muốn sửa và hãy nhập đầy đủ thông tin");

            }
            if (key == 3)
            {
                if (txtMaSV.Text.Length != 0)
                {
                    string query = @"DELETE FROM SinhVien Where masv='" + txtMaSV.Text + "'";

                    if (bal_docgia.Xoa(txtMaSV.Text.Trim()))
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Xóa thành công");
                        frmDocGia_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_docgia.GetEx();
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            btnLuu.Enabled = true;
            key = 3;
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = Convert.ToString(dgvDocGia.CurrentRow.Cells["MASV"].Value);
            txtHoten.Text = Convert.ToString(dgvDocGia.CurrentRow.Cells["TENSV"].Value);
            txtLop.Text = Convert.ToString(dgvDocGia.CurrentRow.Cells["LOP"].Value);
            txtDiachi.Text = Convert.ToString(dgvDocGia.CurrentRow.Cells["DIACHI"].Value);
            dtgNgaySinh.Text = Convert.ToString(dgvDocGia.CurrentRow.Cells["NGAYSINH"].Value);
            if (dgvDocGia.CurrentRow.Cells["GIOITINH"].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }
    }
}
