using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhoHang.CT
{
    public partial class Frm_PhieuNhap : Form
    {
        public Frm_PhieuNhap()
        {
            InitializeComponent();
        }

        private int key = 0;
        DataAccess acc = new DataAccess();
        private void ClearText()
        {
            txt_maphieu.Clear();
            dt_ngaynhap.Text = DateTime.Now.ToString();
            txtTongTien.Clear();
            txt_ghichu.Clear();
            cb_khohang.ResetText();
            cb_NCC.ResetText();
            cb_NhanVien.ResetText();

        }
        private void Enabletbx()
        {
            txt_maphieu.Enabled = false;
            dt_ngaynhap.Enabled = true;
            txtTongTien.Enabled = false;
            txt_ghichu.Enabled = true;
            cb_khohang.Enabled = true;
            cb_NCC.Enabled = true;
            cb_NhanVien.Enabled = true;
        }

        private void Disabletbx()
        {
            txt_maphieu.Enabled = false;
            dt_ngaynhap.Enabled = false;
            txtTongTien.Enabled = false;
            txt_ghichu.Enabled = false;
            cb_khohang.Enabled = false;
            cb_NCC.Enabled = false;
            cb_NhanVien.Enabled = false;
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
            cb_NhanVien.DataSource = acc.Select_Data("select * from NHANVIEN");
            cb_NCC.DataSource = acc.Select_Data("select * from NHACUNGCAP");
            cb_khohang.DataSource = acc.Select_Data("select * from KHOHANG");
            cb_khohang.DisplayMember = "TENKHO";
            cb_khohang.ValueMember = "MAKHO";
            cb_NhanVien.DisplayMember = "TENNV";
            cb_NhanVien.ValueMember = "MANV";
            cb_NCC.DisplayMember = "TENNHACC";
            cb_NCC.ValueMember = "MANCC";
        }

        private void Frm_PhieuNhap_Load(object sender, EventArgs e)
        {
            ClearText();
            Disabletbx();
            Enablebtn();
            ShowData();
            dtgrPN.DataSource = acc.Select_Data("select pnx.MAPN ,TENKHO , TENNV  , NGAYNHAP , sum(DONGIAN*SOLUONG) as TONGTIEN , pnx.GHICHU ,TENNHACC from PHIEUNHAPKHO pnx Left Outer Join CHITIETPHIEUNHAP ctp on pnx.MAPN=ctp.MAPN Left Outer Join NHANVIEN nv on pnx.NVNHAP=nv.MANV Left Outer Join KHOHANG k on pnx.MAKHO=k.MAKHO Left Outer Join NHACUNGCAP n on pnx.MANCC=n.MANCC group by pnx.MAPN,TENKHO,TENNV, NGAYNHAP,TENNHACC, pnx.GHICHU ");
            dtgrPN.ClearSelection();
        }

        

        private void btThem_Click(object sender, EventArgs e)
        {
            //txt_maphieu.Clear();
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
            Disabletbx();
            if (txt_maphieu.Text.Length != 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"DELETE FROM PHIEUNHAPKHO Where MAPN='" + txt_maphieu.Text + "'";
                        acc.Select_Data("DELETE FROM CHITIETPHIEUNHAP Where MAPN ='" + txt_maphieu.Text + "'");
                        acc.Select_Data(query);
                        ClearText();
                        MessageBox.Show("Xóa thành công!");
                        Frm_PhieuNhap_Load(sender, e);
                        key = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Bạn không thể xóa phiếu nhập này !", "Thông báo");
                    }

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                int count = 0;
                count = dtgrPN.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dtgrPN.Rows[count - 1].Cells[1].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txt_maphieu.Text = "PN00" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txt_maphieu.Text = "PN0" + (chuoi2 + 1).ToString();
                if (txt_maphieu.Text != "")
                {
                    if (txt_maphieu.Text == dtgrPN.CurrentRow.Cells["MAPN"].Value.ToString().Trim())
                    {
                        MessageBox.Show("Phiếu nhập đã tồn tại!", "Lỗi");
                        txt_maphieu.Clear();
                        txt_maphieu.Focus();
                    }
                    else
                    {
                        acc.Select_Data("INSERT INTO PHIEUNHAPKHO(MAPN,MAKHO,NVNHAP ,NGAYNHAP,MANCC,GHICHU)VALUES('" + txt_maphieu.Text + "', N'" + cb_khohang.SelectedValue + "', N'" + cb_NhanVien.SelectedValue + "', '" + dt_ngaynhap.Value + "','" + cb_NCC.SelectedValue + "','"+txt_ghichu.Text+"')");
                        ClearText();
                        MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                        Frm_PhieuNhap_Load(sender, e);
                        key = 0;
                    }
                }
                else
                    MessageBox.Show("Bạn cần nhập đủ thông tin ");
            }

            if (key == 2)
            {
                if (txt_maphieu.Text != "")
                {
                    acc.Select_Data("UPDATE PHIEUNHAPKHO SET MAKHO='" + cb_khohang.SelectedValue + "', NVNHAP='" + cb_NhanVien.SelectedValue + "',NGAYNHAP='" + dt_ngaynhap.Value + "',MANCC='" + cb_NCC.SelectedValue + "',GHICHU='" + txt_ghichu + "' WHERE MAPN='" + txt_maphieu.Text + "'");
                    ClearText();
                    MessageBox.Show("Sửa Thành Công", "Thông Báo!");
                    Frm_PhieuNhap_Load(sender, e);
                    key = 0;

                }
                else
                    MessageBox.Show("Chọn dòng bạn muốn sửa và hãy nhập đầy đủ thông tin");

            }
        }

        private void dtgrPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphieu.Text = dtgrPN.CurrentRow.Cells["MAPN"].Value.ToString();
            cb_khohang.Text = dtgrPN.CurrentRow.Cells["TENKHO"].Value.ToString();
            cb_NhanVien.Text = dtgrPN.CurrentRow.Cells["TENNV"].Value.ToString();
            dt_ngaynhap.Value = DateTime.Parse((dtgrPN.CurrentRow.Cells["NGAYNHAP"].Value).ToString());
            txt_ghichu.Text = dtgrPN.CurrentRow.Cells["GHICHU"].Value.ToString();
            txtTongTien.Text = dtgrPN.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            cb_NCC.Text = dtgrPN.CurrentRow.Cells["TENNCC"].Value.ToString();
            try
            {
                if (dtgrPN.Columns[e.ColumnIndex].Name == "XEMCT")
                {
                    string mph = txt_maphieu.Text;
                    Frm_ChiTietPhieuNhap dn = new Frm_ChiTietPhieuNhap(mph);
                    dn.ShowDialog();
                }
            }
            catch
            {
                Frm_PhieuNhap_Load(sender, e);
            }
           
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            ClearText();
            Frm_PhieuNhap_Load(sender, e);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (tbx_timkiem.Text.Trim() == "")
            {
                MessageBox.Show("Đề Nghị Bạn Nhập Từ Khóa Càn Tìm!", "Thông Báo!");
                return;
            }
            else
            {
                dtgrPN.DataSource = acc.Select_Data("select pnx.MAPN ,TENKHO , TENNV  , NGAYNHAP , sum(DONGIAN*SOLUONG) as TONGTIEN , pnx.GHICHU ,TENNHACC from PHIEUNHAPKHO pnx Left Outer Join CHITIETPHIEUNHAP ctp on pnx.MAPN=ctp.MAPN Left Outer Join NHANVIEN nv on pnx.NVNHAP=nv.MANV Left Outer Join KHOHANG k on pnx.MAKHO=k.MAKHO Left Outer Join NHACUNGCAP n on pnx.MANCC=n.MANCC where (pnx.MAPN like N'%" + tbx_timkiem.Text + "%' or NVNHAP like N'%" + tbx_timkiem.Text + "%' or TENKHO like N'%" + tbx_timkiem.Text + "%' or TENNHACC like N'%" + tbx_timkiem.Text + "%') group by pnx.MAPN,TENKHO,TENNV, NGAYNHAP,TENNHACC, pnx.GHICHU");
                tbx_timkiem.Clear();
                dtgrPN.ClearSelection();
            }
        }

      
    }
}
