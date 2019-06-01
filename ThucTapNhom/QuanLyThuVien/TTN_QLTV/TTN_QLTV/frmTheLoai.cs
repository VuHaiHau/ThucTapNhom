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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }
        accessdata acc = new accessdata();
        private int key = 0;
        TheLoaiBAL bal_theloai = new TheLoaiBAL();
        private void ClearText()
        {
            txtmatl.Clear();
            txttentl.Clear();

        }
        private void Enabletbx()
        {
            txtmatl.Enabled = true;
            txttentl.Enabled = true;
            
        }
        private void Disabletbx()
        {

            txtmatl.Enabled = false;
            txttentl.Enabled = false;
            
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
            dgvtheloai.DataSource = bal_theloai.GetData();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            cbxtheloai.DataSource = acc.Select_Data("select * from theloai");
            cbxtheloai.DisplayMember = "TENTHELOAI";
            Disabletbx();
            Enablebtn();
            dgvtheloai.DataSource = bal_theloai.GetData();
            dgvtheloai.ClearSelection();
            dgvtheloai.Columns["MATHELOAI"].HeaderText = "Mã Thể Loại";
            dgvtheloai.Columns["TENTHELOAI"].HeaderText = "Tên Thể Loại";
            
            


            dgvtheloai.Columns["MATHELOAI"].Width =300;
            dgvtheloai.Columns["TENTHELOAI"].Width =300;
            
           
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
           
        }

        private void btlammoi_Click(object sender, EventArgs e)
        {
            TheLoai_Load(sender, e);
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
                if (txtmatl.Text != "" && txttentl.Text != "" )
                {
                    TheLoai tl = new TheLoai(txtmatl.Text.ToString().Trim(), txttentl.Text.ToString().Trim());
                    if (bal_theloai.Them(tl) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Thêm thành công");
                        TheLoai_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_theloai.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Mã thể loại đã tồn tại");
                    }

                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");
            }

            if (key == 2)
            {


                if (txtmatl.Text != "" && txttentl.Text != "")
                {

                    TheLoai tl = new TheLoai(txtmatl.Text.ToString().Trim(), txttentl.Text.ToString().Trim());
                    if (bal_theloai.Sua(tl) == true)
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Sửa thành công");
                        TheLoai_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_theloai.GetEx();
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
                else
                    MessageBox.Show("Chọn dòng bạn muốn sửa và hãy nhập đầy đủ thông tin");

            }
            if (key == 3)
            {
                if (txtmatl.Text.Length != 0)
                {
                    string query = @"DELETE FROM THELOAI Where matheloai='" + txtmatl.Text + "'";

                    if (bal_theloai.Xoa(txtmatl.Text.Trim()))
                    {
                        ClearText();
                        ShowData();
                        MessageBox.Show("Xóa thành công");
                        TheLoai_Load(sender, e);
                        key = 0;
                    }
                    else
                    {
                        Exception ex = bal_theloai.GetEx();
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

        private void dgvtheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatl.Text = Convert.ToString(dgvtheloai.CurrentRow.Cells["MATHELOAI"].Value);
            txttentl.Text = Convert.ToString(dgvtheloai.CurrentRow.Cells["TENTHELOAI"].Value);
           
        }

        private void frmTheLoai_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }

        private void cbxtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            dgvtheloai.DataSource=acc.Select_Data("select MASACH as[Mã Sách],TENSACH as[Tên Sách],TENTHELOAI FROM SACH,THELOAI WHERE SACH.MATHELOAI=THELOAI.MATHELOAI and TENTHELOAI = N'"+ cbxtheloai.Text +"'");
            dgvtheloai.Columns["TENTHELOAI"].Width = 200;
            dgvtheloai.Columns["Tên Sách"].Width = 300;
        }
    }
}
