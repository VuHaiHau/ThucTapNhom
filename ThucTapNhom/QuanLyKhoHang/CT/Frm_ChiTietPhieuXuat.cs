using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.CT
{
    public partial class Frm_ChiTietPhieuXuat : DevComponents.DotNetBar.OfficeForm
    {
        public string maphieuxuat;
        public Frm_ChiTietPhieuXuat(string ma)
        {
            InitializeComponent();
            maphieuxuat = ma;
        }
        private int key = 0;
        DataAccess acc = new DataAccess();
        private void ClearText()
        {
            cb_sanpham.ResetText();
            cb_maphieu.ResetText();
            txt_dongia.Clear();
            txt_soluong.Clear();
        }
        private void Enabletbx()
        {
            cb_maphieu.Enabled = true;
            cb_sanpham.Enabled = true;
            txt_soluong.Enabled = true;
            txt_dongia.Enabled = true;
        }

        private void Disabletbx()
        {
            cb_maphieu.Enabled = false;
            cb_sanpham.Enabled = false;
            txt_soluong.Enabled = false;
            txt_dongia.Enabled = false;
        }
        private void Enablebtn()
        {
            bt_them.Enabled = true;
            bt_xoa.Enabled = true;
            bt_luu.Enabled = false;
        }

        private void Disablebtn()
        {
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
        }

        void ShowData()
        {
            cb_maphieu.DataSource = acc.Select_Data("select * from PHIEUXUAT");
            cb_sanpham.DataSource = acc.Select_Data("select * from SANPHAM");
            cb_maphieu.DisplayMember = "MAPX";
            cb_maphieu.ValueMember = "MAPX";
            cb_sanpham.DisplayMember = "TENSP";
            cb_sanpham.ValueMember = "MASP";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            bt_luu.Enabled = true;
            key = 1;
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Disabletbx();
            if (cb_maphieu.Text.Length != 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này trong phiếu nhập", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    acc.Select_Data("update SANPHAM set SOLUONG=SOLUONG+(SELECT SoLuong FROM ChiTietPhieuXuat WHERE MASP='" + cb_sanpham.SelectedValue + "' AND MAPN='" + cb_maphieu.SelectedValue + "') where MASP='" + cb_sanpham.SelectedValue + "' delete ChiTietPhieuXuat where MAPN = '" + cb_maphieu.SelectedValue + "' and MASP = '" + cb_sanpham.SelectedValue + "'");

                    ClearText();
                    MessageBox.Show("Xóa thành công!");
                    Frm_ChiTietPhieuXuat_Load(sender, e);
                    key = 0;


                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void Frm_ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = acc.Select_Data("select MAPX ,  sp.MASP ,TENSP , ctp.DONGIAX , ctp.SOLUONG  from ChiTietPhieuXuat ctp, SanPham sp where  ctp.MASP=sp.MASP and MAPX='" + cb_maphieu.SelectedValue + "' ");
            ClearText();
            Disabletbx();
            Enablebtn();
            ShowData();
            dt_ChiTietPhieuNhap.DataSource = acc.Select_Data("select MAPX ,  sp.MASP ,TENSP , ctp.DONGIAX , ctp.SOLUONG  from ChiTietPhieuXuat ctp, SanPham sp where  ctp.MASP=sp.MASP and MAPX='" + cb_maphieu.SelectedValue + "' ");
            dt_ChiTietPhieuNhap.ClearSelection();
            dt_ChiTietPhieuNhap.Columns["MAPX"].HeaderText = "Mã Phiếu Xuất";
            dt_ChiTietPhieuNhap.Columns["MASP"].HeaderText = "Mã Sản Phẩm";
            dt_ChiTietPhieuNhap.Columns["TENSP"].HeaderText = "Tên Sản Phẩm";
            dt_ChiTietPhieuNhap.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dt_ChiTietPhieuNhap.Columns["DONGIAX"].HeaderText = "Đơn Giá";
            //try
            //{
               // cb_maphieu.Text = dt.Rows[0][0].ToString().Trim();
            //}
            //catch
            //{
            //    MessageBox.Show("Không có bất kỳ sản phẩm nào trong phiếu xuất này");
            //}
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                acc.Select_Data("INSERT into ChiTietPhieuXuat VALUES (N'" + cb_maphieu.SelectedValue + "', N'" + cb_sanpham.SelectedValue + "', " + txt_soluong.Text + "," + txt_dongia.Text + " ) update SANPHAM set SOLUONG=SOLUONG-(SELECT SoLuong FROM ChiTietPhieuXuat WHERE MASP='" + cb_sanpham.SelectedValue + "' AND MAPN='" + cb_maphieu.SelectedValue + "') where MASP='" + cb_sanpham.SelectedValue + "'");
                ClearText();
                MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                Frm_ChiTietPhieuXuat_Load(sender, e);
                key = 0;
            }

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_PhieuXuat pn = new Frm_PhieuXuat();
            pn.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ClearText();
            Frm_ChiTietPhieuXuat_Load(sender, e);
        }

        private void txt_timkiem_leave(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            }
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                tbx_timkiem.Text = "";
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Cần Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dt_ChiTietPhieuNhap.DataSource = acc.Select_Data("select MAPX,  sp.MASP,TENSP , ctp.DONGIAX , ctp.SOLUONG  from CHITIETPHIEUXUAT ctp Left Outer Join SANPHAM sp on sp.MASP=ctp.MASP where (sp.MASP like N'%" + tbx_timkiem.Text + "%' or TENSP like N'%" + tbx_timkiem.Text + "%') and MAPX='" + maphieuxuat + "' ");
                tbx_timkiem.Clear();
                dt_ChiTietPhieuNhap.ClearSelection();
            }
        }
    }
}
