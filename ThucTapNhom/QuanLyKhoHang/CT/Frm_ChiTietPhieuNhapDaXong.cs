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
    public partial class Frm_ChiTietPhieuNhapDaXong : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public string maphieunhap;
        public Frm_ChiTietPhieuNhapDaXong(string mp)
        {
            InitializeComponent();
            maphieunhap = mp;
        }
        private int key = 0;
        DataAccess acc = new DataAccess();
        private void ClearText()
        {
            cb_sanpham.ResetText();
            //txtmaphieu.Clear();
            txt_dongia.Clear();
            txt_soluong.Clear();
        }
        private void Enabletbx()
        {
            txtmaphieu.Enabled = false;
            cb_sanpham.Enabled = true;
            txt_soluong.Enabled = true;
            txt_dongia.Enabled = true;
        }

        private void Disabletbx()
        {
            txtmaphieu.Enabled = false;
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
            txtmaphieu.Text = maphieunhap;
            cb_sanpham.DataSource = acc.Select_Data("select * from SANPHAM");
            cb_sanpham.DisplayMember = "TENSP";
            cb_sanpham.ValueMember = "MASP";
        }

        private void Frm_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = acc.Select_Data("select MAPN ,  sp.MASP ,TENSP , ctp.DONGIAN , ctp.SOLUONG  from ChiTietPhieuNhap ctp, SanPham sp where  ctp.MASP=sp.MASP and MAPN='" + maphieunhap + "' ");
            ClearText();
            Disabletbx();
            Enablebtn();
            ShowData();
            tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
            dt_ChiTietPhieuNhap.DataSource = acc.Select_Data("select MAPN ,  sp.MASP ,TENSP , ctp.DONGIAN , ctp.SOLUONG  from ChiTietPhieuNhap ctp, SanPham sp where  ctp.MASP=sp.MASP and MAPN='"+maphieunhap+"' ");
            dt_ChiTietPhieuNhap.ClearSelection();
            dt_ChiTietPhieuNhap.Columns["MAPN"].HeaderText = "Mã Phiếu Nhập";
            dt_ChiTietPhieuNhap.Columns["MASP"].HeaderText = "Mã Sản Phẩm";
            dt_ChiTietPhieuNhap.Columns["TENSP"].HeaderText = "Tên Sản Phẩm";
            dt_ChiTietPhieuNhap.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dt_ChiTietPhieuNhap.Columns["DONGIAN"].HeaderText = "Đơn Giá";
            dt_ChiTietPhieuNhap.Columns["MAPN"].Width = 150;
            dt_ChiTietPhieuNhap.Columns["MASP"].Width = 150;
            dt_ChiTietPhieuNhap.Columns["TENSP"].Width = 180;
            dt_ChiTietPhieuNhap.Columns["SOLUONG"].Width = 145;
            dt_ChiTietPhieuNhap.Columns["DONGIAN"].Width = 150;
            try
            {
                txtmaphieu.Text = dt.Rows[0][0].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Không có bất kỳ sản phẩm nào trong phiếu nhập này");
            }
        }

        private void dt_ChiTietPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphieu.Text = dt_ChiTietPhieuNhap.CurrentRow.Cells["MAPN"].Value.ToString();
            cb_sanpham.Text = dt_ChiTietPhieuNhap.CurrentRow.Cells["TENSP"].Value.ToString();
            txt_dongia.Text= dt_ChiTietPhieuNhap.CurrentRow.Cells["DONGIAN"].Value.ToString();
            txt_soluong.Text = dt_ChiTietPhieuNhap.CurrentRow.Cells["SOLUONG"].Value.ToString();
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
            if (txtmaphieu.Text.Length != 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này trong phiếu nhập", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                       
                        acc.Select_Data("update SANPHAM set SOLUONG=SOLUONG-(SELECT SoLuong FROM ChiTietPhieuNhap WHERE MASP='" + cb_sanpham.SelectedValue + "' AND MAPN='" + maphieunhap + "') where MASP='" + cb_sanpham.SelectedValue + "' delete ChiTietPhieuNhap where MAPN = '" + maphieunhap + "' and MASP = '" + cb_sanpham.SelectedValue + "'");
                       
                        ClearText();
                        MessageBox.Show("Xóa thành công!");
                        Frm_ChiTietPhieuNhap_Load(sender, e);
                        key = 0;
                    

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_dongia.Text == "" || txt_soluong.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các mục!", "Thông Báo");

                }
                else
                {
                    acc.Select_Data("INSERT into ChiTietPhieuNhap VALUES (N'" + maphieunhap + "', N'" + cb_sanpham.SelectedValue + "', " + txt_soluong.Text + "," + txt_dongia.Text + " ) update SANPHAM set SOLUONG=SOLUONG+(SELECT SoLuong FROM ChiTietPhieuNhap WHERE MASP='" + cb_sanpham.SelectedValue + "' AND MAPN='" + maphieunhap + "') where MASP='" + cb_sanpham.SelectedValue + "'");
                    ClearText();
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                    Frm_ChiTietPhieuNhap_Load(sender, e);
                    key = 0;
                }
            }
            catch
            {
                MessageBox.Show("Sản Phẩm Bạn Chọn Đã Có Trong Phiếu! Vui Lòng Chọn Lại!");
                ClearText();
            }
           
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_PhieuNhapDaXong pn = new Frm_PhieuNhapDaXong();
            pn.Show();
          
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "Hãy nhập từ khóa tìm kiếm..")
            {
                tbx_timkiem.Text = "";
            }
        }

        private void txt_timkiem_leave(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text == "")
            {
                tbx_timkiem.Text = "Hãy nhập từ khóa tìm kiếm..";
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
                dt_ChiTietPhieuNhap.DataSource = acc.Select_Data("select MAPN,  sp.MASP,TENSP , ctp.DONGIAN , ctp.SOLUONG  from CHITIETPHIEUNHAP ctp Left Outer Join SANPHAM sp on sp.MASP=ctp.MASP where (sp.MASP like N'%" + tbx_timkiem.Text + "%' or TENSP like N'%" + tbx_timkiem.Text + "%') and MAPN='" + maphieunhap + "' ");
                tbx_timkiem.Clear();
                dt_ChiTietPhieuNhap.ClearSelection();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            ClearText();
            Frm_ChiTietPhieuNhap_Load(sender, e);
        }
    }
}
