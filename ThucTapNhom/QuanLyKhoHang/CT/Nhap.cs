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
    public partial class Nhap : DevComponents.DotNetBar.OfficeForm
    {

        private void Load_dtgrNLK()
        {
            //txtMaPNCT.Text = "";
            cbNLKCT.Text = "";


            txtDGNCT.Text = "";
            txtSLCT.Text = "";


            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            string sql = "select MAPN as N'Mã phiếu nhập',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAN as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from ChiTietPhieuNhap ctp, SanPham sp where  ctp.MASP=sp.MASP";
            SqlDataAdapter dt = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            dt.Fill(dataTable);
            con.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void Load_dtgrPN()
        {
            txtMaPN.Text = "";
            cbLP.Text = "";
            cbNV.Text = "";

            txtTongTien.Text = "";
            textBox1.Text = "";
            cbNCCCT.Text = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            string sql = "select pnx.MAPN as N'Mã phiếu nhập', MAKHO as N'Mã kho', NVNHAP as N'Mã nhân viên', NGAYNHAP as N'Ngày nhập', sum(DONGIAN*SOLUONG) as N'Tổng tiền',MANCC as [Mã nhà cung cấp], GHICHU as N'Ghi chú' from PHIEUNHAPKHO pnx Left Outer Join CHITIETPHIEUNHAP ctp on pnx.MAPN=ctp.MAPN group by pnx.MAPN, MAKHO, NVNHAP, NGAYNHAP,MANCC, GHICHU";
            SqlDataAdapter dt = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dataTable = new DataTable();
            dt.Fill(dataTable);
            con.Close();
            dtgrPN.DataSource = dataTable;
        }


        public Nhap()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            txtMaPN.Clear();
            txtDGNCT.Clear();
            //txtMaPNCT.Clear();
            txtSLCT.Clear();
            txtTongTien.Clear();
            cbLP.ResetText();
            cbNCCCT.ResetText();
            cbNLKCT.ResetText();
            cbNV.ResetText();


        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string gc = textBox1.Text.Trim();
            int count = 0;
            count = dtgrPN.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dtgrPN.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
                txtMaPN.Text = "PN00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 < 100)
                txtMaPN.Text = "PN0" + (chuoi2 + 1).ToString();
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";

                string sql2 = "INSERT into PHIEUNHAPKHO VALUES (N'" + idPN + "', N'" + cbLP.Text + "', N'" + cbNV.Text + "', N'" + DateTime.Parse(dtNgayN.Text.ToString()) + "',N'" + cbNCCCT.Text + "', N'" + gc + "')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                //Load_dtgrNLK();
                //Load_dtgrPN();
            }
            catch { }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string gc = textBox1.Text.Trim();
            if (idPN == "")
            {
                MessageBox.Show("Bạn chưa điền mã phiếu nhập", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "update PHIEUNHAPKHO set MAKHO = N'" + cbLP.Text + "', NVNHAP = N'" + cbNV.Text + "', NGAYNHAP = N'" + dtNgayN.Text + "',MANCC = N'" + cbNCCCT.Text + "', GHICHU = N'" + gc + "' where MAPN = N'" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                //Load_dtgrPN();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
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
                    string sql = "delete CHITIETPHIEUNHAP where MAPN = '" + idPN + "' DELETE PHIEUNHAPKHO where MAPN = '" + idPN + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    //Load_dtgrPN();
                    // Load_dtgrNLK();
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
                string sql = "select pnx.MAPN as N'Mã phiếu nhập', MAKHO as N'Mã kho', NVNHAP as N'Mã nhân viên', NGAYNHAP as N'Ngày nhập', sum(DONGIAN*SOLUONG) as N'Tổng tiền',MANCC as N'Mã nhà cung cấp', GHICHU as N'Ghi chú' from PHIEUNHAPKHO pnx Left Outer Join CHITIETPHIEUNHAP ctp on pnx.MAPN=ctp.MAPN where (pnx.MAPN like N'%" + timkiem + "%' or NVNHAP like N'%" + timkiem + "%' or MAKHO like N'%" + timkiem + "%') group by pnx.MAPN, MAKHO, NVNHAP, NGAYNHAP,MANCC, GHICHU";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                con.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                con.Close();
                dtgrPN.DataSource = dataTable;
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ClearText();
            Frm_NhapHang_Load(sender, e);
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            string idPNCTa = idPNCT.Text.Trim();
            string idNLKCT = cbNLKCT.Text.Trim();


            string dg = txtDGNCT.Text.Trim();
            string sl = txtSLCT.Text.Trim();

            if (idPNCTa == "" || idNLKCT == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                DataTable dt = new DataTable();
                string sql = "select * from ChiTietPhieuNhap where MAPN = '" + idPNCTa + "' and MASP = '" + idNLKCT + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã Phiếu nhập đã tồn tại!", "Lỗi");
                    //txtMaNCC.Clear();
                    //txtMaNCC.Focus();
                }
                else
                {
                    string sql2 = "INSERT into ChiTietPhieuNhap VALUES (N'" + idPNCTa + "', N'" + idNLKCT + "', " + dg + ", " + sl + ",null) update SANPHAM set SOLUONG=SOLUONG+(SELECT SoLuong FROM ChiTietPhieuNhap WHERE MASP='" + idNLKCT + "' AND MAPN='" + idPNCTa + "') where MASP='" + idNLKCT + "'";
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
            string idNCC = cbNLKCT.Text;

            if (idNCC == "" || idPNCT.Text == "")
            {
                MessageBox.Show("Bạn cần chọn sản phẩm muốn xóa", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string idPNCTa = idPNCT.Text;
                    string sql = "update SANPHAM set SOLUONG=SOLUONG-(SELECT SoLuong FROM ChiTietPhieuNhap WHERE MASP='" + idNCC + "' AND MAPN='" + idPNCTa + "') where MASP='" + idNCC + "' delete ChiTietPhieuNhap where MAPN = '" + idPNCTa + "' and MASP = '" + idNCC + "'";
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
                MessageBox.Show("Bạn chưa nhập vào ô tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "select MAPN as N'Mã phiếu nhập',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAN as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from CHITIETPHIEUNHAP ctp Left Outer Join SANPHAM sp on sp.MASP=ctp.MASP where (ctp.MAPN like N'%" + timkiem + "%'  or sp.MASP like N'%" + timkiem + "%' or TENSP like N'%" + timkiem + "%') ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);
                con.Open();
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                con.Close();
                dataGridView1.DataSource = dataTable;
            }
        }

       

        private void Frm_NhapHang_Load(object sender, EventArgs e)
        {

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con1.Open();
            string sql1 = "select pnx.MAPN as N'Mã phiếu nhập', MAKHO as N'Mã kho', NVNHAP as N'Mã nhân viên', NGAYNHAP as N'Ngày nhập', sum(DONGIAN*SOLUONG) as N'Tổng tiền',MANCC as [Mã nhà cung cấp], GHICHU as N'Ghi chú' from PHIEUNHAPKHO pnx Left Outer Join CHITIETPHIEUNHAP ctp on pnx.MAPN=ctp.MAPN group by pnx.MAPN, MAKHO, NVNHAP, NGAYNHAP,MANCC, GHICHU";
            DataSet ds1 = new DataSet();
            SqlDataAdapter dap1 = new SqlDataAdapter(sql1, con1);
            dap1.Fill(ds1);
            dtgrPN.DataSource = ds1.Tables[0];
            dtgrPN.Refresh();
            DataAccess acc = new DataAccess();
           // DateTime.Parse(dtNgayN.Text.ToString());
            SqlConnection con4 = new SqlConnection();
            con4.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con4.Open();
            string sql4 = "select MAPN as N'Mã phiếu nhập',  sp.MASP as N'Mã sản phẩm',TENSP as N'Tên sản phẩm', ctp.DONGIAN as N'Đơn giá', ctp.SOLUONG as N'Số lượng' from ChiTietPhieuNhap ctp, SanPham sp where  ctp.MASP=sp.MASP ";
            DataSet ds2 = new DataSet();
            SqlDataAdapter dap2 = new SqlDataAdapter(sql4, con4);
            dap2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
            dataGridView1.Refresh();
            cbNLKCT.DataSource = acc.Select_Data("Select *from SanPham");
            cbNV.DataSource = acc.Select_Data("Select * from NHANVIEN");
            cbLP.DataSource = acc.Select_Data("Select * from KHOHANG");
            cbNCCCT.DataSource = acc.Select_Data("Select * from NHACUNGCAP");
            idPNCT.DataSource = acc.Select_Data("Select * from PHIEUNHAPKHO");
            cbNV.DisplayMember = "MANV";
            cbNV.ValueMember = "MANV";
            cbLP.DisplayMember = "MAKHO";
            cbLP.ValueMember = "MAKHO";
            cbNCCCT.DisplayMember = "MANCC";
            cbNCCCT.ValueMember = "MANCC";
            cbNLKCT.DisplayMember = "MASP";
            cbNLKCT.ValueMember = "MASP";
            idPNCT.DisplayMember = "MAPN";
            idPNCT.ValueMember = "MAPN";
            txtTimPN.Text = "Hãy nhập từ khóa tìm kiếm..";
            txtTimCT.Text = "Hãy nhập từ khóa tìm kiếm..";
            ClearText();
        }
      

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == null || txtMaPN.Text == "")
            {
                MessageBox.Show("Nhập Mã Phiếu Để in!");
            }
            else
            {
                //ReportPhieuXuat.MAPX = txb_maPX.Text;
                HoaDonBanHang baocaof = new HoaDonBanHang(txtMaPN.Text);
                baocaof.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPNCT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbNLKCT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtDGNCT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSLCT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dtgrPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPN.Text = dtgrPN.CurrentRow.Cells[0].Value.ToString();
            cbLP.Text = dtgrPN.CurrentRow.Cells[1].Value.ToString();
            cbNV.Text = dtgrPN.CurrentRow.Cells[2].Value.ToString();
            dtNgayN.Value = DateTime.Parse((dtgrPN.CurrentRow.Cells[3].Value).ToString());
            textBox1.Text = dtgrPN.CurrentRow.Cells[6].Value.ToString();
            cbNCCCT.Text = dtgrPN.CurrentRow.Cells[5].Value.ToString();
            txtTongTien.Text = dtgrPN.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
