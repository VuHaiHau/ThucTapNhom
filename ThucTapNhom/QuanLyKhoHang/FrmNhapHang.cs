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
    public partial class FrmNhapHang : Form
    {
        public FrmNhapHang()
        {
            InitializeComponent();
        }










        private void Load_dtgrNLK()
        {
            txtMaPNCT.Text = "";
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






        
        //**********************************************************************************************************




        private void button2_Click_1(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idLP = cbLP.Text.Trim();
            string idNV = cbNV.Text.Trim();
            string idNCC = cbNCCCT.Text.Trim();
            //DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            if (idPN == "")
            {
                MessageBox.Show("Bạn chưa điền mã phiếu nhập", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "update PHIEUNHAPKHO set MAKHO = N'" + idLP + "', NVNHAP = N'" + idNV + "', NGAYNHAP = N'" + DateTime.Parse(dtNgayN.Text.ToString()) + "',MANCC = N'" + idNCC + "', GHICHU = N'" + gc + "' where MAPN = N'" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                Load_dtgrPN();
                Load_dtgrNLK();
            }
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

       
      



        private void inPhieu_Click_1(object sender, EventArgs e)
        {
            if (txtMaPN.Text == null || txtMaPN.Text == "")
            {
                MessageBox.Show("Nhập Mã Phiếu Để in!");
            }
            else
            {
                //ReportPhieuXuat.MAPX = txb_maPX.Text;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
          
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

        private void FrmNhapHang_Load_1(object sender, EventArgs e)
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
            accessData acc = new accessData();
            DateTime.Parse(dtNgayN.Text.ToString());
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
            cbNV.DisplayMember = "MANV";
            cbNV.ValueMember = "MANV";
            cbLP.DisplayMember = "MAKHO";
            cbLP.ValueMember = "MAKHO";
            cbNCCCT.DisplayMember = "MANCC";
            cbNCCCT.ValueMember = "MANCC";
            cbNLKCT.DisplayMember = "MASP";
            cbNLKCT.ValueMember = "MASP";
            txtTimPN.Text = "Hãy nhập từ khóa tìm kiếm..";
            txtTimCT.Text = "Hãy nhập từ khóa tìm kiếm..";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void inPhieu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_quaylai_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
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
                string sql = "select * from ChiTietPhieuNhap where MAPN = '" + idPNCT + "' and MASP = '" + idNLKCT + "'";
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
                    string sql2 = "INSERT into ChiTietPhieuNhap VALUES (N'" + idPNCT + "', N'" + idNLKCT + "', " + dg + ", " + sl + ",null)";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPNCT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbNLKCT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtDGNCT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSLCT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSuaCT_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
          
        }

        private void tbx_Soluongnhap(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập số lượng là kí tự số ", "Thông Báo ");
            }
        }

        private void tbx_dongian(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn cần phải nhập đơn giá là kí tự số ", "Thông Báo ");
            }
        }

        private void txt_tk_enter(object sender, EventArgs e)
        {
            if (txtTimPN.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txtTimPN.Text = "";
            }
        }

        private void txt_tk_leave(object sender, EventArgs e)
        {
            if (txtTimPN.Text == "")
            {
                txtTimPN.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_timkiem_enter(object sender, EventArgs e)
        {
            if (txtTimCT.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                txtTimCT.Text = "";
            }
        }

        private void txt_timkiem_leave(object sender, EventArgs e)
        {
            if (txtTimCT.Text == "")
            {
                txtTimCT.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void btnTimCT_Click(object sender, EventArgs e)
        {
            
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
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idLP = cbLP.Text.Trim();
            string idNV = cbNV.Text.Trim();
            string idNCC = cbNCCCT.Text.Trim();
            // DateTime ngayN = dtNgayN.Value;
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
                string sql = "select MAPN, MAKHO, NVNHAP, NGAYNHAP, GHICHU from PHIEUNHAPKHO where MAPN = '" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Lỗi");
                    //txtMaNCC.Clear();
                    //txtMaNCC.Focus();
                }
                else
                {
                    string sql2 = "INSERT into PHIEUNHAPKHO VALUES (N'" + idPN + "', N'" + idLP + "', N'" + idNV + "', N'" + DateTime.Parse(dtNgayN.Text.ToString()) + "',N'" + idNCC + "', N'" + gc + "')";
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK);
                    Load_dtgrPN();
                }
            }
        }

        private void btn_chophepsua_Click(object sender, EventArgs e)
        {
            string idPN = txtMaPN.Text.Trim();
            string idLP = cbLP.Text.Trim();
            string idNV = cbNV.Text.Trim();
            string idNCC = cbNCCCT.Text.Trim();
            // DateTime ngayN = dtNgayN.Value;
            string gc = textBox1.Text.Trim();
            if (idPN == "")
            {
                MessageBox.Show("Bạn chưa điền mã phiếu nhập", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                string sql = "update PHIEUNHAPKHO set MAKHO = N'" + idLP + "', NVNHAP = N'" + idNV + "', NGAYNHAP = N'" + dtNgayN.Text + "',MANCC = N'" + idNCC + "', GHICHU = N'" + gc + "' where MAPN = N'" + idPN + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK);
                Load_dtgrPN();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
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
                    Load_dtgrPN();
                    // Load_dtgrNLK();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == null || txtMaPN.Text == "")
            {
                MessageBox.Show("Nhập Mã Phiếu Để in!");
            }
            else
            {
                //ReportPhieuXuat.MAPX = txb_maPX.Text;
                ReportPhieuNhap baocaof = new ReportPhieuNhap(txtMaPN.Text);
                baocaof.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btlammoi_Click(object sender, EventArgs e)
        {
            ClearText();
            FrmNhapHang_Load_1(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button5_Click_1(object sender, EventArgs e)
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
                string sql = "select * from ChiTietPhieuNhap where MAPN = '" + idPNCT + "' and MASP = '" + idNLKCT + "'";
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
                    string sql2 = "INSERT into ChiTietPhieuNhap VALUES (N'" + idPNCT + "', N'" + idNLKCT + "', " + dg + ", " + sl + ",null)";
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

        private void button4_Click(object sender, EventArgs e)
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
                string sql = "select * from ChiTietPhieuNhap where MAPN = '" + idPNCT + "' and MASP = '" + idNLKCT + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã phiếu nhập hoặc mã sản phẩm không tồn tại!", "Lỗi");
                    //txtMaNCC.Clear();
                    //txtMaNCC.Focus();
                }
                else
                {
                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string sql1 = "update ChiTietPhieuNhap set MASP = N'" + idNLKCT + "', DONGIAN = " + dg + ", SOLUONG = " + sl + " where MAPN = N'" + idPNCT + "' and MASP = N'" + idNLKCT + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            string idNCC = cbNLKCT.Text;
            if (idNCC == "" || txtMaPNCT.Text == "")
            {
                MessageBox.Show("Bạn cần chọn sản phẩm muốn xóa", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
                    string idPNCT = txtMaPNCT.Text;
                    string sql = "delete ChiTietPhieuNhap where MAPN = '" + idPNCT + "' and MASP = '" + idNCC + "'";
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
    }
}
