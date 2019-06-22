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
    public partial class Frm_ChiTietPhieuNhap : DevComponents.DotNetBar.OfficeForm
    {
        public string maphieunhap;
        public Frm_ChiTietPhieuNhap(string mp)
        {
            InitializeComponent();
            maphieunhap = mp;
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
            cb_maphieu.DataSource = acc.Select_Data("select * from PHIEUNHAPKHO");
            cb_sanpham.DataSource = acc.Select_Data("select * from SANPHAM");
            cb_maphieu.DisplayMember = "MAPN";
            cb_maphieu.ValueMember = "MAPN";
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
            dt_ChiTietPhieuNhap.DataSource = acc.Select_Data("select MAPN ,  sp.MASP ,TENSP , ctp.DONGIAN , ctp.SOLUONG  from ChiTietPhieuNhap ctp, SanPham sp where  ctp.MASP=sp.MASP and MAPN='"+maphieunhap+"' ");
            dt_ChiTietPhieuNhap.ClearSelection();
            dt_ChiTietPhieuNhap.Columns["MAPN"].HeaderText = "Mã Phiếu Nhập";
            dt_ChiTietPhieuNhap.Columns["MASP"].HeaderText = "Mã Sản Phẩm";
            dt_ChiTietPhieuNhap.Columns["TENSP"].HeaderText = "Tên Sản Phẩm";
            dt_ChiTietPhieuNhap.Columns["SOLUONG"].HeaderText = "Số Lượng";
            dt_ChiTietPhieuNhap.Columns["DONGIAN"].HeaderText = "Đơn Giá";
            try
            {
                cb_maphieu.Text = dt.Rows[0][0].ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Không có bất kỳ sản phẩm nào trong phiếu nhập này");
            }
        }

        private void dt_ChiTietPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_maphieu.Text = dt_ChiTietPhieuNhap.CurrentRow.Cells["MAPN"].Value.ToString();
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
            if (cb_maphieu.Text.Length != 0)
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
            if(key==1)
            {
                acc.Select_Data("INSERT into ChiTietPhieuNhap VALUES (N'" + maphieunhap + "', N'" + cb_sanpham.SelectedValue + "', " + txt_soluong.Text + "," + txt_dongia.Text + " ) update SANPHAM set SOLUONG=SOLUONG+(SELECT SoLuong FROM ChiTietPhieuNhap WHERE MASP='" + cb_sanpham.SelectedValue + "' AND MAPN='" + maphieunhap + "') where MASP='" + cb_sanpham.SelectedValue + "'");
                ClearText();
                MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                Frm_ChiTietPhieuNhap_Load(sender, e);
                key = 0;
            }
           
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_PhieuNhap pn = new Frm_PhieuNhap();
            pn.Show();
          
        }

       
    }
}
