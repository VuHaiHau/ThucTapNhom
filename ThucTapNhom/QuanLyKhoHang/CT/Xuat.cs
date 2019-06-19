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
    public partial class Xuat : DevComponents.DotNetBar.OfficeForm
    {
        public Xuat()
        {
            InitializeComponent();
        }
        private void Load_dtgrNLK()
        {
            txtMaPNCT.Text = "";
            cbNLKCT.Text = "";

            cbNV.Text = "";
            txtSL.Text = "";
            txtSL.Text = "";


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
        private void Load_dtgrPN()
        {
            txtMaPNCT.Text = "";
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
        private void buttonX1_Click(object sender, EventArgs e)
        {
            //string idPN = txtMaPNCT.Text.Trim();
            //string idLP = cbLP.Text.Trim();
            //string idNV = cbNV.Text.Trim();
            //string idNCC = cbNCCCT.Text.Trim();
            DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            int count = 0;
            count = dtgrPN.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtgrPN.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
                txtMaPNCT.Text = "PX00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaPNCT.Text = "PX0" + (chuoi2 + 1).ToString();

            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";

                string sql2 = "INSERT into PHIEUXUAT VALUES (N'" + txtMaPNCT.Text + "', N'" + cbLP.Text + "', N'" + cbNV.Text + "', N'" + ngayN + "',N'" + cbNCCCT.Text + "', N'" + gc + "')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                Load_dtgrNLK();
                Load_dtgrPN();
                



            }
            catch
            {

            }
        }
        public void ClearText()
        {
            txtMaPNCT.Clear();
            cbLP.ResetText();
            cbNCCCT.ResetText();
            cbNV.ResetText();
            cbNLKCT.ResetText();
            txtSL.Clear();
            txtMaPNCT.Clear();
            txtSL.Clear();
            txtTongTien.Clear();

        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            //string idPN = txtMaPNCT.Text.Trim();
            //string idLP = cbLP.Text.Trim();
            //string idNV = cbNV.Text.Trim();
            //string idNCC = cbNCCCT.Text.Trim();
            //DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            if (txtMaPNCT.Text == "")
            {
                MessageBox.Show("Bạn chưa điền mã phiếu xuất", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "update PHIEUXUAT set MAKHO = N'" + cbLP.SelectedValue + "', NVXUAT = N'" + cbNV.SelectedValue + "', NGAYXUAT = N'" + dtNgayN.Value + "',MAKH = N'" + cbNCCCT.SelectedValue + "', GHICHU = N'" + gc + "' where MAPX = N'" +txtMaPNCT.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                Load_dtgrPN();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (txtMaPNCT.Text == "")
            {
                MessageBox.Show("Bạn cần chọn phiếu nhập muốn xóa", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string idPN = txtMaPNCT.Text;
                    string sql = "delete CHITIETPHIEUXUAT where MAPX = '" + txtMaPNCT.Text + "' DELETE PHIEUXUAT where MAPX = '" + txtMaPNCT.Text + "'";
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

        private void buttonX5_Click(object sender, EventArgs e)
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

        private void buttonX7_Click(object sender, EventArgs e)
        {
            //string idPNCTa = idPNCT.Text.Trim();
            //string idNLKCT = cbNLKCT.SelectedValue();
           
            //string dg = txtSL.Text.Trim();
            //string sl = txtSL.Text.Trim();

            if (idPNCT.Text == "" || cbNLKCT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
          
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                DataTable dt = new DataTable();
                string sql = "select * from ChiTietPhieuXuat where MAPX = '" + idPNCT.Text + "' and MASP = '" + cbNLKCT.SelectedValue + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã Phiếu xuất đã tồn tại!", "Lỗi");
                   
                }
                else
                {
                    string sql2 = "INSERT into ChiTietPhieuXuat VALUES (N'" + idPNCT.Text + "', N'" + cbNLKCT.SelectedValue + "', " + txtDGNCT.Text + ", " + txtSL.Text + ",null) update SANPHAM set SOLUONG=SOLUONG-(SELECT SoLuong FROM ChiTietPhieuXuat WHERE MASP='" + cbNLKCT.SelectedValue + "' AND MAPX='" + idPNCT.Text + "') where MASP='" + cbNLKCT.SelectedValue + "'";
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

        private void buttonX8_Click(object sender, EventArgs e)
        {
            //string idNCC = cbNLKCT.Text;
            if (cbNLKCT.Text == "" || txtMaPNCT.Text == "")
            {
                MessageBox.Show("Bạn cần chọn sản phẩm muốn xóa", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    
                    string sql = "update SANPHAM set SOLUONG=SOLUONG+(SELECT SoLuong FROM ChiTietPhieuXuat WHERE MASP='" + cbNLKCT.SelectedValue + "' AND MAPX='" + idPNCT + "') where MASP='" + idPNCT.Text + "' delete ChiTietPhieuXuat where MAPX = '" + idPNCT.Text + "' and MASP = '" + cbNLKCT.SelectedValue + "'";
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

        private void buttonX9_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimCT.Text;
            if (timkiem == "")
            {
                MessageBox.Show("Bạn chưa nhập vào ô tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dtgrPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPNCT.Text = dtgrPN.CurrentRow.Cells[0].Value.ToString();
            cbLP.SelectedValue = dtgrPN.CurrentRow.Cells[1].Value.ToString();
            cbNV.SelectedValue = dtgrPN.CurrentRow.Cells[2].Value.ToString();
            dtNgayN.Value = DateTime.Parse((dtgrPN.CurrentRow.Cells[3].Value).ToString());
            textBox1.Text = dtgrPN.CurrentRow.Cells[6].Value.ToString();
            cbNCCCT.SelectedValue = dtgrPN.CurrentRow.Cells[5].Value.ToString();
            txtTongTien.Text = dtgrPN.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPNCT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbNLKCT.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtDGNCT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSL.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void Xuat_Load(object sender, EventArgs e)
        {
            txtMaPNCT.Enabled = false;
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con1.Open();
            string sql1 = "select pnx.MAPX as N'Mã phiếu xuất', MAKHO as N'Mã kho', NVXUAT as N'Mã nhân viên', NGAYXUAT as N'Ngày xuất', sum(DONGIAX*SOLUONG) as N'Tổng tiền',MAKH as [Khách Hàng], GHICHU as N'Ghi chú' from PHIEUXUAT pnx Left Outer Join CHITIETPHIEUXUAT ctp on pnx.MAPX=ctp.MAPX group by pnx.MAPX, MAKHO, NVXUAT, NGAYXUAT,MAKH, GHICHU";
            DataSet ds1 = new DataSet();
            SqlDataAdapter dap1 = new SqlDataAdapter(sql1, con1);
            dap1.Fill(ds1);
            dtgrPN.DataSource = ds1.Tables[0];
            dtgrPN.Refresh();
            DataAccess acc = new DataAccess();

            SqlConnection con4 = new SqlConnection();
            con4.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con4.Open();
            string sql4 = "select MAPX as N'Mã phiếu xuất',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAX as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from ChiTietPhieuXuat ctp, SanPham sp where  ctp.MASP=sp.MASP ";
            DataSet ds2 = new DataSet();
            SqlDataAdapter dap2 = new SqlDataAdapter(sql4, con4);
            dap2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
            dataGridView1.Refresh();
            idPNCT.DataSource = acc.Select_Data("Select * from PHIEUXUAT ");
            cbNV.DataSource = acc.Select_Data("Select * from NHANVIEN");
            cbLP.DataSource = acc.Select_Data("Select * from KHOHANG");
            cbNCCCT.DataSource = acc.Select_Data("Select * from KHACHHANG");
            cbNV.DisplayMember = "TENNV";
            cbNV.ValueMember = "MANV";
            idPNCT.DisplayMember = "MAPX";
            idPNCT.ValueMember = "MAPX";
            cbLP.DisplayMember = "TENKHO";
            cbLP.ValueMember = "MAKHO";
            cbNCCCT.DisplayMember = "TENKH";
            cbNCCCT.ValueMember = "MAKH";
            cbNLKCT.DataSource = acc.Select_Data("Select * from SANPHAM");
            cbNLKCT.DisplayMember = "TENSP";
            cbNLKCT.ValueMember = "MASP";
            txtTimPN.Text = "Hãy nhập từ khóa tìm kiếm..";
            txtTimCT.Text = "Hãy nhập từ khóa tìm kiếm..";
            ClearText();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ClearText();
            Xuat_Load(sender, e);
        }
    }
}
