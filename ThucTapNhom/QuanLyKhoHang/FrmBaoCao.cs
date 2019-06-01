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

namespace QuanLyKhoHang
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private int key = 0;
        private int keyx = 0;
        private int keybtn = 0;
        public string SelectQuery;
        public string FromQuery;
        public string Query;
        public string SelectQueryX;
        public string FromQueryX;
        public string QueryX;
        public static string TenDangNhap = "";

        public DataTable SelectThongTin(string TDN)
        {
            SqlDataReader a = acc.ExecuteReader("SELECT TENNV FROM NHANVIEN, DANGNHAP WHERE NHANVIEN.MANV = DANGNHAP.MANV AND DANGNHAP.USERNAME='" + TDN + "'");
            while (a.Read())
            {
                lbx_tennv.Text = a["TENNV"].ToString();
            }
            return null;
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            SelectThongTin(TenDangNhap);
            timer.Start();
            // Dành Cho Nhập
            AutoCompletecbx(cbx_kho, "Select TENKHO from KHOHANG", "TENKHO");
            AutoCompletecbx(cbx_ncc, "Select TENNHACC from NHACUNGCAP", "TENNHACC");
            AutoCompletecbx(cbx_tensp, "Select TENSP from SANPHAM", "TENSP");
            AutoCompletecbx(cbx_nv, "Select TENNV from NHANVIEN", "TENNV");
            AutoCompletecbx(cbx_giasp, "Select GIA from SANPHAM", "GIA");
            tbx_ngaynhap.Enabled = false;
            tbx_tungay.Enabled = false;
            tbx_denngay.Enabled = false;
           btn_huythaotac.Enabled = true;
            
            // Dành Cho Xuất

            AutoCompletecbx(cbx_khox, "Select TENKHO from KHOHANG", "TENKHO");
            AutoCompletecbx(cbx_khachhangx, "Select TENKH from KHACHHANG", "TENKH");
            AutoCompletecbx(cbx_spx, "Select TENSP from SANPHAM", "TENSP");
            AutoCompletecbx(cbx_nvx, "Select TENNV from NHANVIEN", "TENNV");
            AutoCompletecbx(cbx_giax, "Select GIA from SANPHAM", "GIA");
            tbx_denngayx.Enabled = false;
            dpc_denngay.Enabled = false;
            dpc_denngayx.Enabled = false;
            tbx_tungayx.Enabled = false;
            tbx_ngayxuatx.Enabled = false;
            btn_huythaotac.Enabled = true;

            if (Query == null)
            {
                btn_xembc.Enabled = false;
            }
            else
            {
                btn_xembc.Enabled = true;
            }

            if (QueryX == null)
            {
                btn_xembaocaox.Enabled = false;
            }
            else
            {
                btn_xembaocaox.Enabled = true;
            }

        }

        public void AutoCompletecbx(ComboBox cbx_combobox, string sql, string tencot)
        {
            cbx_combobox.DataSource = acc.Select_Data(sql);
            cbx_combobox.DisplayMember = tencot;
            cbx_combobox.ValueMember = tencot;
            cbx_combobox.SelectedIndex = -1;
        }

        private void BaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
        }

       

        private void btn_xemtat_Click_1(object sender, EventArgs e)
        {
            string SelectQuery = "Select N.MAPN as [Mã Phiếu Nhập], KHO.TENKHO as [Tên Kho], SP.TENSP as [Tên Sản Phẩm], NCC.TENNHACC as [Tên Nhà Cung Cấp], CTN.DONGIAN as [Đơn Giá], TongTien = CTN.SOLUONG* DONGIAN , NV.TENNV as [Tên Nhân Viên], N.NGAYNHAP as [Ngày Nhập]";
            string FromQuery = "from PHIEUNHAPKHO N, CHITIETPHIEUNHAP CTN, SANPHAM SP, NHACUNGCAP NCC, NHANVIEN NV, KHOHANG KHO where N.MAPN = CTN.MAPN and CTN.MASP = SP.MASP and N.MANCC = NCC.MANCC and N.NVNHAP = NV.MANV and N.MAKHO = KHO.MAKHO ";
            string Query = SelectQuery + FromQuery;
            dgv_thongkenhap.DataSource = acc.Select_Data(Query);
            BaoCaoN_F.TenKho = cbx_kho.Text;
            BaoCaoN_F.TenNcc_Kh = cbx_ncc.Text;
            BaoCaoN_F.TenNv = cbx_nv.Text;
            BaoCaoN_F.TenSp = cbx_tensp.Text;
            BaoCaoN_F.TuNgay = tbx_tungay.Text;
            BaoCaoN_F.NgayNh_Xu = tbx_ngaynhap.Text;
            BaoCaoN_F.DenNgay = tbx_denngay.Text;
            BaoCaoN_F.Gia = cbx_giasp.Text;
            keybtn = 2;
            btn_xembc.Enabled = true;
        }

        private void dpc_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            tbx_ngaynhap.Text = dpc_ngaynhap.Value.ToShortDateString();
            dpc_tungay.Enabled = false;
            dpc_denngay.Enabled = false;
        }

        private void dpc_dateto_ValueChanged(object sender, EventArgs e)
        {
            dpc_ngaynhap.Enabled = false;
            dpc_denngay.Enabled = true;
            kiemtrangaythangnam();
            if (key == 1 || key == 2 || key == 3 || key == 4)
            {
                tbx_tungay.Clear();
                dpc_tungay.Value = DateTime.Now;
                key = 0;
            }
            else
            {
                tbx_tungay.Text = dpc_tungay.Value.ToShortDateString();
            }
        }

        private void dpc_todate_ValueChanged(object sender, EventArgs e)
        {
            dpc_ngaynhap.Enabled = false;
            kiemtrangaythangnam();
            if (key == 1 || key == 2 || key == 3 || key == 4)
            {
                tbx_denngay.Clear();
                dpc_denngay.Value = DateTime.Now;
                key = 0;
            }
            else
            {
                tbx_denngay.Text = dpc_denngay.Value.ToShortDateString();
            }
        }

        private void kiemtrangaythangnam()
        {
            if (dpc_tungay.Value > DateTime.Now || dpc_denngay.Value > DateTime.Now)
            {
                MessageBox.Show("Lỗi! Chưa Đến Thời Gian Này!");
                key = 4;
            }
            else
            {
                if (tbx_tungay.Text != "" || tbx_denngay.Text != "")
                {
                    if (dpc_tungay.Value.Year > dpc_denngay.Value.Year)
                    {
                        MessageBox.Show("Lỗi NĂm!");
                        key = 1;
                    }
                    else
                    {
                        if (dpc_tungay.Value.Year == dpc_denngay.Value.Year)
                        {
                            if (dpc_tungay.Value.Month > dpc_denngay.Value.Month)
                            {
                                MessageBox.Show("Lỗi Tháng!");
                                key = 2;
                            }
                            else
                            {
                                if (dpc_tungay.Value.Month <= dpc_denngay.Value.Month)
                                {
                                    if (dpc_tungay.Value.Month == dpc_denngay.Value.Month)
                                    {
                                        if (dpc_denngay.Value.Day < dpc_tungay.Value.Day)
                                        {
                                            MessageBox.Show("Lỗi Ngày!");
                                            key = 3;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ClearN();
        }

        private void ClearN()
        {
            dpc_denngay.Value = DateTime.Now;
            dpc_ngaynhap.Value = DateTime.Now;
            dpc_tungay.Value = DateTime.Now;
            dpc_tungay.Enabled = true;
            dpc_ngaynhap.Enabled = true;
            dpc_denngay.Enabled = true;
            tbx_denngay.Clear();
            tbx_ngaynhap.Clear();
            tbx_tungay.Clear();
            cbx_giasp.ResetText();
            cbx_kho.ResetText();
            cbx_ncc.ResetText();
            cbx_nv.ResetText();
            cbx_tensp.ResetText();
        }

        private void btn_xembc_Click(object sender, EventArgs e)
        {
            //FrmBaoCaoF baocaof = new FrmBaoCaoF();
            //FrmBaoCaoF.keyn = 1;
            //baocaof.ShowDialog();
        }

       
       

        private void ClearX()
        {
            dpc_tungayx.Enabled = true;
            dpc_ngayxuat.Enabled = true;
            dpc_denngayx.Enabled = true;
            tbx_tungayx.Clear();
            tbx_ngayxuatx.Clear();
            tbx_denngayx.Clear();
            cbx_giax.ResetText();
            cbx_khachhangx.ResetText();
            cbx_khox.ResetText();
            cbx_nvx.ResetText();
            cbx_spx.ResetText();
        }
       

        private void dpc_ngayxuat_ValueChanged(object sender, EventArgs e)
        {
            tbx_ngayxuatx.Text = dpc_ngayxuat.Value.ToShortDateString();
            dpc_denngayx.Enabled = false;
            dpc_tungayx.Enabled = false;
        }

        private void dpc_tungayx_ValueChanged(object sender, EventArgs e)
        {
            dpc_ngayxuat.Enabled = false;
            kiemtrangaythangnamx();
            if (keyx == 1 || keyx == 2 || keyx == 3 || keyx == 4)
            {
                tbx_tungayx.Clear();
                dpc_tungayx.Value = DateTime.Now;
                keyx = 0;
            }
            else
            {
                tbx_tungayx.Text = dpc_tungayx.Value.ToShortDateString();
            }
        }

        private void dpc_denngayx_ValueChanged(object sender, EventArgs e)
        {
            dpc_ngayxuat.Enabled = false;
            kiemtrangaythangnamx();
            if (keyx == 1 || keyx == 2 || keyx == 3 || keyx == 4)
            {
                tbx_denngayx.Clear();
                dpc_denngayx.Value = DateTime.Now;
                keyx = 0;
            }
            else
            {
                tbx_denngayx.Text = dpc_denngayx.Value.ToShortDateString();
            }
        }

        private void kiemtrangaythangnamx()
        {
            if (dpc_tungayx.Value > DateTime.Now || dpc_denngayx.Value > DateTime.Now)
            {
                MessageBox.Show("Lỗi! Chưa Đến Thời Gian Này!");
                keyx = 4;
            }
            else
            {
                if (tbx_tungayx.Text != "" || tbx_denngayx.Text != "")
                {
                    if (dpc_tungayx.Value.Year > dpc_denngayx.Value.Year)
                    {
                        MessageBox.Show("Lỗi NĂm!");
                        keyx = 1;
                    }
                    else
                    {
                        if (dpc_tungayx.Value.Year == dpc_denngayx.Value.Year)
                        {
                            if (dpc_tungayx.Value.Month > dpc_denngayx.Value.Month)
                            {
                                MessageBox.Show("Lỗi Tháng!");
                                keyx = 2;
                            }
                            else
                            {
                                if (dpc_tungayx.Value.Month <= dpc_denngayx.Value.Month)
                                {
                                    if (dpc_tungayx.Value.Month == dpc_denngayx.Value.Month)
                                    {
                                        if (dpc_denngayx.Value.Day < dpc_tungayx.Value.Day)
                                        {
                                            MessageBox.Show("Lỗi Ngày!");
                                            keyx = 3;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        

      

        private void mnts_bcnv_Click(object sender, EventArgs e)
        {
            AutoCompletecbx(cbx_nv, "Select TENNV from NHANVIEN WHERE TRANGTHAI = '0'", "TENNV");
            AutoCompletecbx(cbx_nvx, "Select TENNV from NHANVIEN WHERE TRANGTHAI = '0'", "TENNV");
            cbx_giasp.Enabled = false;
            cbx_ncc.Enabled = false;
            cbx_kho.Enabled = false;
            cbx_tensp.Enabled = false;
            dpc_denngay.Enabled = false;
            dpc_ngaynhap.Enabled = false;
            dpc_tungay.Enabled = false;
            cbx_spx.Enabled = false;
            cbx_khox.Enabled = false;
            cbx_khachhangx.Enabled = false;
            cbx_giax.Enabled = false;
            dpc_tungayx.Enabled = false;
            dpc_ngayxuat.Enabled = false;
            dpc_denngayx.Enabled = false;
            btn_huythaotac.Enabled = true;
        }

       

      

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            ClearN();
        }

       

        private void btn_huyx_Click(object sender, EventArgs e)
        {
            ClearX();
        }

        private void btn_xemtatcax_Click_1(object sender, EventArgs e)
        {
            string SelectQueryX = "Select X.MAPX as [Mã Phiếu], KHO.TENKHO as [Kho], SP.TENSP as [Sản Phẩm], KH.TENKH as [Khách Hàng], CTX.DONGIAX as [Đơn Giá], TongTien=CTX.SOLUONG*DONGIAX , NV.TENNV as [Nhân Viên], X.NGAYXUAT as [Ngày Xuất]  ";
            string FromQueryX = "from PHIEUXUAT X, CHITIETPHIEUXUAT CTX, SANPHAM SP, KHACHHANG KH, NHANVIEN NV, KHOHANG KHO where X.MAPX = CTX.MAPX and CTX.MASP = SP.MASP and X.MAKH = KH.MAKH and X.NVXUAT = NV.MANV and X.MAKHO = KHO.MAKHO ";
            string QueryX = SelectQueryX + FromQueryX;
            dgv_thongkexuat.DataSource = acc.Select_Data(QueryX);
            BaoCaoX_F.TenKho = cbx_khox.Text;
            BaoCaoX_F.TenNcc_Kh = cbx_khachhangx.Text;
            BaoCaoX_F.TenNv = cbx_nvx.Text;
            BaoCaoX_F.TenSp = cbx_spx.Text;
            BaoCaoX_F.TuNgay = tbx_tungayx.Text;
            BaoCaoX_F.NgayNh_Xu = tbx_ngayxuatx.Text;
            BaoCaoX_F.DenNgay = tbx_denngayx.Text;
            BaoCaoX_F.Gia = cbx_giax.Text;
            btn_xembaocaox.Enabled = true;
        }

        private void btn_xembaocaox_Click_1(object sender, EventArgs e)
        {
           
           BaoCaoX_F m=new BaoCaoX_F();
            m.ShowDialog();
        }

        private void btn_xembc_Click_1(object sender, EventArgs e)
        {
            BaoCaoN_F baocaof = new BaoCaoN_F();
            baocaof.ShowDialog();
        }

        private void btn_huythaotac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Hủy Không?", "Quản Lý KHo Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.Hide();
                MainMenu home = new MainMenu();
                home.ShowDialog();
            }
           
        }

        private void lbx_tennv_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNguoiDung nd = new FrmNguoiDung();
            nd.ShowDialog();
        }

        private void lbx_ngaythanglap_Click(object sender, EventArgs e)
        {

        }

        private void dgv_thongkenhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();
        }

        private void tbx_tungay_TextChanged(object sender, EventArgs e)
        {

        }

        private void dpc_tungay_ValueChanged(object sender, EventArgs e)
        {

            dpc_ngaynhap.Enabled = false;
            dpc_denngay.Enabled = true;
            kiemtrangaythangnam();
            if (key == 1 || key == 2 || key == 3 || key == 4)
            {
                tbx_tungay.Clear();
                dpc_tungay.Value = DateTime.Now;
                key = 0;
            }
            else
            {
                tbx_tungay.Text = dpc_tungay.Value.ToShortDateString();
            }
        }

        private void dpc_denngay_ValueChanged(object sender, EventArgs e)
        {
            dpc_ngaynhap.Enabled = false;
            kiemtrangaythangnam();
            if (key == 1 || key == 2 || key == 3 || key == 4)
            {
                tbx_denngay.Clear();
                dpc_denngay.Value = DateTime.Now;
                key = 0;
            }
            else
            {
                tbx_denngay.Text = dpc_denngay.Value.ToShortDateString();
            }
        }

       

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            SelectQuery = "Select N.MAPN as [Mã Phiếu], KHO.TENKHO as [Kho], SP.TENSP as [Sản Phẩm], NCC.TENNHACC as [Nhà Cung Cấp], CTN.DONGIAN as [Đơn Giá], TONGTIEN=CTN.SOLUONG*DONGIAN, NV.TENNV as [Nhân Viên], N.NGAYNHAP as [Ngày Nhập] from PHIEUNHAPKHO N, CHITIETPHIEUNHAP CTN, SANPHAM SP, NHACUNGCAP NCC, NHANVIEN NV, KHOHANG KHO where N.MAPN = CTN.MAPN and CTN.MASP = SP.MASP and N.MANCC = NCC.MANCC and N.NVNHAP = NV.MANV and N.MAKHO = KHO.MAKHO  ";

            if (cbx_kho.Text != "")
                FromQuery = FromQuery + " And " + "KHO.TENKHO like N'%" + cbx_kho.Text + "%'";

            if (cbx_tensp.Text != "")
                FromQuery = FromQuery + "And " + "SP.TENSP like N'%" + cbx_tensp.Text + "%'";

            if (cbx_ncc.Text != "")
                FromQuery = FromQuery + "And " + "NCC.TENNHACC like N'%" + cbx_ncc.Text + "%'";

            if (cbx_giasp.Text != "")
                FromQuery = FromQuery + "And " + "DONGIAN like N'%" + cbx_giasp.Text + "%'";

            if (cbx_nv.Text != "")
                FromQuery = FromQuery + "And " + "NV.TENNV like N'%" + cbx_nv.Text + "%'";

            if (tbx_ngaynhap.Text != "")
                FromQuery = FromQuery + "And " + "N.NGAYNHAP = Convert(Datetime,'" + tbx_ngaynhap.Text + "',103)";

            if (tbx_tungay.Text != "" && tbx_denngay.Text != "")
            {
                FromQuery = FromQuery + "And " + "N.NGAYNHAP > Convert(Datetime,'" + tbx_tungay.Text + "',103) And N.NGAYNHAP < Convert(Datetime,'" + tbx_denngay.Text + "',103)";
            }

            Query = SelectQuery + FromQuery;
            if ((cbx_kho.Text != "" || cbx_ncc.Text != "" || cbx_giasp.Text != "" || cbx_nv.Text != "" || cbx_tensp.Text != "" || tbx_ngaynhap.Text != "") || (tbx_tungay.Text != "" && tbx_denngay.Text != ""))
            {
                dgv_thongkenhap.DataSource = acc.Select_Data(Query);
                FromQuery = null;
                BaoCaoN_F.TenKho = cbx_kho.Text;
                BaoCaoN_F.TenNcc_Kh = cbx_ncc.Text;
                BaoCaoN_F.TenNv = cbx_nv.Text;
                BaoCaoN_F.TenSp = cbx_tensp.Text;
                BaoCaoN_F.TuNgay = tbx_tungay.Text;
                BaoCaoN_F.NgayNh_Xu = tbx_ngaynhap.Text;
                BaoCaoN_F.DenNgay = tbx_denngay.Text;
                BaoCaoN_F.Gia = cbx_giasp.Text;
                btn_xembc.Enabled = true;
                ClearN();
            }
            else
            {
                MessageBox.Show("Bạn Chưa Nhập Dữ Liệu Cần Lọc!");
            }
        }

        private void btn_timkiemx_Click(object sender, EventArgs e)
        {
            SelectQueryX = "Select X.MAPX as [Mã Phiếu], KHO.TENKHO as [Kho], SP.TENSP as [Sản Phẩm], KH.TENKH as [Khách Hàng], CTX.DONGIAX as [Đơn Giá], TongTien=CTX.SOLUONG*DONGIAX , NV.TENNV as [Nhân Viên], X.NGAYXUAT as [Ngày Xuất]  ";
            FromQueryX = "from PHIEUXUAT X, CHITIETPHIEUXUAT CTX, SANPHAM SP, KHACHHANG KH, NHANVIEN NV, KHOHANG KHO where X.MAPX = CTX.MAPX and CTX.MASP = SP.MASP and X.MAKH = KH.MAKH and X.NVXUAT = NV.MANV and X.MAKHO = KHO.MAKHO ";

            if (cbx_khox.Text != "")
                FromQueryX = FromQueryX + "And " + "KHO.TENKHO like N'%" + cbx_khox.Text + "%' ";

            if (cbx_spx.Text != "")
                FromQueryX = FromQueryX + "And " + "SP.TENSP like N'%" + cbx_spx.Text + "%' ";

            if (cbx_khachhangx.Text != "")
                FromQueryX = FromQueryX + "And " + "KH.TENKH like N'%" + cbx_khachhangx.Text + "%' ";

            if (cbx_giax.Text != "")
                FromQueryX = FromQueryX + "And " + "DONGIAX like N'%" + cbx_giax.Text + "%' ";

            if (cbx_nvx.Text != "")
                FromQueryX = FromQueryX + "And " + "NV.TENNV like N'%" + cbx_nvx.Text + "%' ";

            if (tbx_ngayxuatx.Text != "")
                FromQueryX = FromQueryX + "And " + "X.NGAYXUAT = Convert(Datetime,'" + tbx_ngayxuatx.Text + "',103)";

            if (tbx_tungayx.Text != "" && tbx_denngayx.Text != "")
            {
                FromQueryX = FromQueryX + "And " + "X.NGAYXUAT > Convert(Datetime,'" + tbx_tungayx.Text + "',103) And X.NGAYXUAT < Convert(Datetime,'" + tbx_denngayx.Text + "',103) ";
            }

            QueryX = SelectQueryX + FromQueryX;
            if ((cbx_khox.Text != "" || cbx_khachhangx.Text != "" || cbx_giax.Text != "" || cbx_nvx.Text != "" || cbx_spx.Text != "" || tbx_ngayxuatx.Text != "") || (tbx_tungayx.Text != "" && tbx_denngayx.Text != ""))
            {
                dgv_thongkexuat.DataSource = acc.Select_Data(QueryX);
                FromQueryX = null;
                BaoCaoX_F.TenKho = cbx_khox.Text;
                BaoCaoX_F.TenNcc_Kh = cbx_khachhangx.Text;
                BaoCaoX_F.TenNv = cbx_nvx.Text;
                BaoCaoX_F.TenSp = cbx_spx.Text;
                BaoCaoX_F.TuNgay = tbx_tungayx.Text;
                BaoCaoX_F.NgayNh_Xu = tbx_ngayxuatx.Text;
                BaoCaoX_F.DenNgay = tbx_denngayx.Text;
                BaoCaoX_F.Gia = cbx_giax.Text;
                btn_xembaocaox.Enabled = true;
                ClearX();

            }
            else
            {
                MessageBox.Show("Bạn Chưa Nhập Dữ Liệu Cần Lọc!");
            }
        }

        private void dpc_tungayx_ValueChanged_1(object sender, EventArgs e)
        {
            //dpc_ngayxuat.Enabled = false;
            //kiemtrangaythangnamx();
            //if (keyx == 1 || keyx == 2 || keyx == 3 || keyx == 4)
            //{
            //    tbx_tungayx.Clear();
            //    dpc_tungayx.Value = DateTime.Now;
            //    keyx = 0;
            //}
            //else
            //{
            //    tbx_tungayx.Text = dpc_tungayx.Value.ToShortDateString();
            //}
        }

        private void dpc_denngayx_ValueChanged_1(object sender, EventArgs e)
        {
            //dpc_ngayxuat.Enabled = false;
            //kiemtrangaythangnamx();
            //if (keyx == 1 || keyx == 2 || keyx == 3 || keyx == 4)
            //{
            //    tbx_denngayx.Clear();
            //    dpc_denngayx.Value = DateTime.Now;
            //    keyx = 0;
            //}
            //else
            //{
            //    tbx_denngayx.Text = dpc_denngayx.Value.ToShortDateString();
            //}
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            lbx_ngaythanglap.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }
    }
}

