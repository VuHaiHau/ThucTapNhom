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
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        private int key = 0;
        SachBAL bal_sach = new SachBAL();
        TheLoaiBAL bus = new TheLoaiBAL();
       
        private void ClearText()
        {
            txtMasach.Clear();
            txtTensach.Clear();
            txtsoluong.Clear();
            txttentacgia.Clear();
            txtnamxb.Clear();
        }
        private void Enabletbx()
        {
            txtMasach.Enabled = true;
            txtTensach.Enabled = true;
            txttentacgia.Enabled = true;
            txtsoluong.Enabled = true;
            txtnamxb.Enabled = true;
            cbxtheloai.Enabled = true;
        }
        private void Disabletbx()
        {
            txtMasach.Enabled = false;
            txtTensach.Enabled = false;
            txttentacgia.Enabled = false;
            txtsoluong.Enabled = false;
            txtnamxb.Enabled = false;
            cbxtheloai.Enabled = false;
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
            dgvSach.DataSource = bal_sach.GetData();
            dgvSach.AutoResizeColumns();
            cbxtheloai.DataSource = bus.GetData();
            cbxtheloai.DisplayMember = "TENTHELOAI";
            cbxtheloai.ValueMember = "MATHELOAI";
        }


        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            btnLuu.Enabled = true;
            key = 3;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            btnLuu.Enabled = true;
            key = 2;
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            Disablebtn();
            Enabletbx();
            btnLuu.Enabled = true;
            key = 1;
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSach.Rows[e.RowIndex];
                txtMasach.Text = row.Cells["MASACH"].Value.ToString().Trim();
                txtTensach.Text = row.Cells["TENSACH"].Value.ToString().Trim();
                txttentacgia.Text = row.Cells["TENTG"].Value.ToString().Trim();
                txtnamxb.Text = row.Cells["NAMXUATBAN"].Value.ToString().Trim();
                txtsoluong.Text = row.Cells["SOLUONG"].Value.ToString().Trim();
                cbxtheloai.Text = row.Cells["TENTHELOAI"].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = bal_sach.GetEx();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void dgvSach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
         
        }

        private void frmSach_Load(object sender, EventArgs e)
        {

            Disabletbx();
            Enablebtn();
            ShowData();
            dgvSach.DataSource = bal_sach.GetData();
            dgvSach.ClearSelection();
            dgvSach.Columns["MASACH"].HeaderText = "Mã Sách";
            dgvSach.Columns["TENSACH"].HeaderText = "Tên Sách";
            dgvSach.Columns["TENTG"].HeaderText = "Tên Tác Giả";
            dgvSach.Columns["NAMXUATBAN"].HeaderText = "Năm Xuất Bản";
            dgvSach.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dgvSach.Columns["TENTHELOAI"].HeaderText = "Tên Thể Loại";


            dgvSach.Columns["MASACH"].Width = 100;
            dgvSach.Columns["TENSACH"].Width = 200;
            dgvSach.Columns["TENTG"].Width = 130;
            dgvSach.Columns["NAMXUATBAN"].Width = 100;
            dgvSach.Columns["SOLUONG"].Width = 100;
            dgvSach.Columns["TENTHELOAI"].Width = 100;
        }

        private void dgvSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                btlammoi_Click(sender, e);
            }
        }

        private void dgvSach_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {

                if (txtMasach.Text != "" && txtnamxb.Text != "" && txttentacgia.Text != "" && txtTensach.Text != "")
                {
                    Sach sach = new Sach(txtMasach.Text.ToString().Trim(), txtTensach.Text.ToString().Trim(), txttentacgia.Text.Trim(), txtnamxb.Text.ToString().Trim(), int.Parse(txtsoluong.Text.Trim()), cbxtheloai.SelectedValue.ToString().Trim());
                    if (bal_sach.Them(sach) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Thêm thành công");
                        frmSach_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_sach.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Mã sách đã tồn tại");
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");
            }
            
            if (key == 2)
            {
                if (txtMasach.Text != "" && txtnamxb.Text != "" && txttentacgia.Text != "" && txtTensach.Text != "")
                {
                    try
                    {
                        Sach sach = new Sach(txtMasach.Text.ToString().Trim(), txtTensach.Text.ToString().Trim(), txttentacgia.Text.Trim(), txtnamxb.Text.ToString().Trim(), int.Parse(txtsoluong.Text.Trim()), cbxtheloai.SelectedValue.ToString().Trim());

                        bal_sach.Sua(sach);
                        ClearText();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        frmSach_Load(sender, e);
                        key = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chọn dòng bạn muốn sửa và hãy nhập đầy đủ thông tin");

            }
            if (key == 3)
            {
                if (txtMasach.Text.Length != 0)
                {
                    string query = @"DELETE FROM dbo.Sach Where manv='" + txtMasach.Text + "'";
                    
                    if (bal_sach.Xoa(txtMasach.Text.Trim()))
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Xóa thành công");
                        frmSach_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_sach.GetEx();
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

        private void btlammoi_Click(object sender, EventArgs e)
        {
            frmSach_Load(sender, e);
            ClearText();
            key = 0;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text != "")
            {
                ShowData();
                if (bal_sach.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dgvSach.DataSource = bal_sach.GetDataTimKiem(txtTimKiem.Text.Trim());
                    
                }
                else
                {
                    Exception ex = bal_sach.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void frmSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
    }
}
