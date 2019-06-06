using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhoHang
{
    public partial class FrmXuatHang : Form
    {
        public FrmXuatHang()
        {
            InitializeComponent();
        }










        private void Load_dtgrNLK()
        {
            txtMaPNCT.Text = "";
            cbNLKCT.Text = "";

            cbNV.Text = "";
            txtDGNCT.Text = "";
            txtSLCT.Text = "";


            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            string sql = "select MAPX as N'Mã phiếu xuất',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAX as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from ChiTietPhieuXuat ctp, SanPham sp where  ctp.MASP=sp.MASP";
            SqlDataAdapter dt = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            dt.Fill(dataTable);
            con.Close();
            dataGridView1.DataSource = dataTable;
        }






        
        //**********************************************************************************************************
        
        

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idLP = cbLP.Text.Trim();
            string idNV = cbNV.Text.Trim();
            string idNCC = cbNCCCT.Text.Trim();
            DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            if (idPN == "")
            {
                MessageBox.Show("Bạn chưa điền mã phiếu nhập", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "update PHIEUNHAPKHO set MAKHO = N'" + idLP + "', NVNHAP = N'" + idNV + "', NGAYNHAP = N'" + ngayN + "',MANCC = N'" + idNCC + "', GHICHU = N'" + gc + "' where MAPN = N'" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                Load_dtgrPN();
            }
        }

      

      

     
        private void Load_dtgrPN()
        {
            txtMaPN.Text = "";
            cbLP.Text = "";
            cbNV.Text = "";
            dtNgayN.Value = DateTime.Now;
            txtTongTien.Text = "";
            textBox1.Text = "";
            cbNCCCT.Text = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            string sql = "select pnx.MAPX as N'Mã phiếu xuất', MAKHO as N'Mã kho', NVXUAT as N'Mã nhân viên', NGAYXUAT as N'Ngày xuất', sum(DONGIAX*SOLUONG) as N'Tổng tiền',MAKH as [Khách Hàng], GHICHU as N'Ghi chú' from PHIEUXUAT pnx Left Outer Join CHITIETPHIEUXUAT ctp on pnx.MAPX=ctp.MAPX group by pnx.MAPX, MAKHO, NVXUAT, NGAYXUAT,MAKH, GHICHU";
            SqlDataAdapter dt = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            dt.Fill(dataTable);
            con.Close();
            dtgrPN.DataSource = dataTable;
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idLP = cbLP.Text.Trim();
            string idNV = cbNV.Text.Trim();
            string idNCC = cbNCCCT.Text.Trim();
            DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            if (idPN == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                DataTable dt = new DataTable();
                string sql = "select MAPX, MAKHO, NVXUAT, NGAYXUAT, GHICHU from PHIEUXUAT where MAPX = '" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã Phiếu xuất đã tồn tại!", "Lỗi");
                    //txtMaNCC.Clear();
                    //txtMaNCC.Focus();
                }
                else
                {
                    string sql2 = "INSERT into PHIEUXUAT VALUES (N'" + idPN + "', N'" + idLP + "', N'" + idNV + "', N'" + ngayN + "',N'" + idNCC + "', N'" + gc + "')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                    Load_dtgrNLK();
                    Load_dtgrPN();
                }
            }
        }

        private void dtgrPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPN.Text = dtgrPN.CurrentRow.Cells[0].Value.ToString();
            cbLP.Text = dtgrPN.CurrentRow.Cells[1].Value.ToString();
            cbNV.Text = dtgrPN.CurrentRow.Cells[2].Value.ToString();
            dtNgayN.Value = DateTime.Parse((dtgrPN.CurrentRow.Cells[3].Value).ToString());
            textBox1.Text = dtgrPN.CurrentRow.Cells[6].Value.ToString();
            cbNCCCT.Text = dtgrPN.CurrentRow.Cells[5].Value.ToString();
            txtTongTien.Text = dtgrPN.CurrentRow.Cells[4].Value.ToString();
        }

        private void FrmXuatHang_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con1.Open();
            string sql1 = "select pnx.MAPX as N'Mã phiếu xuất', MAKHO as N'Mã kho', NVXUAT as N'Mã nhân viên', NGAYXUAT as N'Ngày xuất', sum(DONGIAX*SOLUONG) as N'Tổng tiền',MAKH as [Khách Hàng], GHICHU as N'Ghi chú' from PHIEUXUAT pnx Left Outer Join CHITIETPHIEUXUAT ctp on pnx.MAPX=ctp.MAPX group by pnx.MAPX, MAKHO, NVXUAT, NGAYXUAT,MAKH, GHICHU";
            DataSet ds1 = new DataSet();
            SqlDataAdapter dap1 = new SqlDataAdapter(sql1, con1);
            dap1.Fill(ds1);
            dtgrPN.DataSource = ds1.Tables[0];
            dtgrPN.Refresh();
            accessData acc = new accessData();

            SqlConnection con4 = new SqlConnection();
            con4.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con4.Open();
            string sql4 = "select MAPX as N'Mã phiếu xuất',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAX as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from ChiTietPhieuXuat ctp, SanPham sp where  ctp.MASP=sp.MASP ";
            DataSet ds2 = new DataSet();
            SqlDataAdapter dap2 = new SqlDataAdapter(sql4, con4);
            dap2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
            dataGridView1.Refresh();

            cbNV.DataSource = acc.Select_Data("Select * from NHANVIEN");
            cbLP.DataSource = acc.Select_Data("Select * from KHOHANG");
            cbNCCCT.DataSource = acc.Select_Data("Select * from KHACHHANG");
            cbNV.DisplayMember = "MANV";
            cbNV.ValueMember = "MANV";
            cbLP.DisplayMember = "MAKHO";
            cbLP.ValueMember = "MAKHO";
            cbNCCCT.DisplayMember = "MAKH";
            cbNCCCT.ValueMember = "MAKH";
            cbNLKCT.DataSource = acc.Select_Data("Select * from SANPHAM");
            cbNLKCT.DisplayMember = "MASP";
            cbNLKCT.ValueMember = "MASP";
            txtTimPN.Text = "Hãy nhập từ khóa tìm kiếm..";
            txtTimCT.Text = "Hãy nhập từ khóa tìm kiếm..";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idLP = cbLP.Text.Trim();
            string idNV = cbNV.Text.Trim();
            string idNCC = cbNCCCT.Text.Trim();
            DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            if (idPN == "")
            {
                MessageBox.Show("Bạn chưa điền mã phiếu xuất", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "update PHIEUXUAT set MAKHO = N'" + idLP + "', NVXUAT = N'" + idNV + "', NGAYXUAT = N'" + ngayN + "',MAKH = N'" + idNCC + "', GHICHU = N'" + gc + "' where MAPX = N'" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                Load_dtgrPN();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Bạn cần chọn phiếu nhập muốn xóa", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string idPN = txtMaPN.Text;
                    string sql = "delete CHITIETPHIEUXUAT where MAPX = '" + idPN + "' DELETE PHIEUXUAT where MAPX = '" + idPN + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    Load_dtgrPN();
                    Load_dtgrNLK();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimPN.Text;
            if (timkiem == "")
            {
                MessageBox.Show("Bạn chưa nhập vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "select pnx.MAPX as N'Mã phiếu xuất', MAKHO as N'Mã kho', NVXUAT as N'Mã nhân viên', NGAYXUAT as N'Ngày xuất', sum(DONGIAX*SOLUONG) as N'Tổng tiền',MAKH as N'Mã Khách Hàng', GHICHU as N'Ghi chú' from PHIEUXUAT pnx Left Outer Join CHITIETPHIEUXUAT ctp on pnx.MAPX=ctp.MAPX where (pnx.MAPX like N'%" + timkiem + "%' or NVXUAT like N'%" + timkiem + "%' or MAKHO like N'%" + timkiem + "%') group by pnx.MAPX, MAKHO, NVXUAT, NGAYXUAT,MAKH, GHICHU";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                con.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                con.Close();
                dtgrPN.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPNCT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbNLKCT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtDGNCT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSLCT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void inPhieu_Click_1(object sender, EventArgs e)
        {
            if (txtMaPN.Text == null || txtMaPN.Text == "")
            {
                MessageBox.Show("Nhập Mã Phiếu Để in!");
            }
            else
            {
                
                ReportPhieuXuat baocaof = new ReportPhieuXuat(txtMaPN.Text);
                baocaof.ShowDialog();
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string idPNCT = txtMaPNCT.Text.Trim();
            string idNLKCT = cbNLKCT.Text.Trim();


            string dg = txtDGNCT.Text.Trim();
            string sl = txtSLCT.Text.Trim();

            if (idPNCT == "" || idNLKCT == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                DataTable dt = new DataTable();
                string sql = "select * from ChiTietPhieuXuat where MAPX = '" + idPNCT + "' and MASP = '" + idNLKCT + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã Phiếu xuất đã tồn tại!", "Lỗi");
                    //txtMaNCC.Clear();
                    //txtMaNCC.Focus();
                }
                else
                {
                    string sql2 = "INSERT into ChiTietPhieuXuat VALUES (N'" + idPNCT + "', N'" + idNLKCT + "', " + dg + ", " + sl + ",null)";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                    Load_dtgrNLK();
                    Load_dtgrPN();
                }
            }
        }

        private void btnSuaCT_Click_1(object sender, EventArgs e)
        {
            string idPNCT = txtMaPNCT.Text.Trim();
            string idNLKCT = cbNLKCT.Text.Trim();
            string dg = txtDGNCT.Text.Trim();
            string sl = txtSLCT.Text.Trim();

            if (idPNCT == "" || idNLKCT == "")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                DataTable dt = new DataTable();
                string sql = "select * from ChiTietPhieuXuat where MAPX = '" + idPNCT + "' and MASP = '" + idNLKCT + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã phiếu xuất hoặc mã sản phẩm không tồn tại!", "Lỗi");
                    //txtMaNCC.Clear();
                    //txtMaNCC.Focus();
                }
                else
                {
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string sql1 = "update ChiTietPhieuXuat set MASP = N'" + idNLKCT + "', DONGIAX = " + dg + ", SOLUONG = " + sl + " where MAPX = N'" + idPNCT + "' and MASP = N'" + idNLKCT + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, con1);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    con1.Close();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                    Load_dtgrNLK();
                    Load_dtgrPN();
                }
            }

        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string idNCC = cbNLKCT.Text;
            if (idNCC == "" || txtMaPNCT.Text == "")
            {
                MessageBox.Show("Bạn cần chọn nguyên liệu muốn xóa", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa nguyên liệu này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string idPNCT = txtMaPNCT.Text;
                    string sql = "delete ChiTietPhieuXuat where MAPX = '" + idPNCT + "' and MASP = '" + idNCC + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    Load_dtgrNLK();
                    Load_dtgrPN();
                }
            }
        }

        private void txb_SoLuongXuat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập số lượng là kí tự số ", "Thông Báo ");
            }
        }

        private void txb_dongiax(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập đơn giá là kí tự số ", "Thông Báo ");
            }
        }

        

        private void txt_Timkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimPN.Text == "")
            {
                txtTimPN.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_TK_Enter(object sender, EventArgs e)
        {
            if (txtTimPN.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txtTimPN.Text = "";
            }
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txtTimCT.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txtTimCT.Text = "";
            }
        }

        private void txt_tk_leave(object sender, EventArgs e)
        {

            if (txtTimCT.Text == "")
            {
                txtTimCT.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void btnTimCT_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimCT.Text;
            if (timkiem == "")
            {
                MessageBox.Show("Bạn chưa nhập vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "select MAPX as N'Mã phiếu xuất',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAX as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from CHITIETPHIEUXUAT ctp Left Outer Join SANPHAM sp on sp.MASP=ctp.MASP where (ctp.MAPX like N'%" + timkiem + "%'  or sp.MASP like N'%" + timkiem + "%' or TENSP like N'%" + timkiem + "%') group by MAPX,sp.MASP,TENSP,ctp.DONGIAX,ctp.SOLUONG";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                con.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                con.Close();
                dataGridView1.DataSource = dataTable;
            }
        }

        public void ClearText()
        {
            txtMaPN.Clear();
            txtDGNCT.Clear();
            txtMaPNCT.Clear();
            txtSLCT.Clear();
            txtTongTien.Clear();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            ClearText();
            FrmXuatHang_Load(sender, e);
        }
    }
}
