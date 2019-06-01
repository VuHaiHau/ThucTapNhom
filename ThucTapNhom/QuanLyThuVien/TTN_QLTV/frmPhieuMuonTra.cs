using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BAL;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;



namespace TTN_QLTV
{
    public partial class frmPhieuMuonTra : Form
    {
        public frmPhieuMuonTra()
        {
            InitializeComponent();
        }
        private string MASACH;
        private string NVNHAP;
        private string DOCGIA;
        public DataTable data;
       
        
        accessdata acc = new accessdata();
        private int key = 0;
        SachBAL bal_sach = new SachBAL();
        NhanVienBAL bal_nv = new NhanVienBAL();
        DocGiaBAL bal_dg = new DocGiaBAL();
        PhieuMuonBAL bal_pm = new PhieuMuonBAL();

        public DataTable ThongTinSach(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MASACH FROM SACH WHERE TENSACH LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MASACH = a["MASACH"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinNhanVienNhap(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MANV FROM NHANVIEN WHERE TENNV LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                NVNHAP = a["MANV"].ToString().Trim();
            }
            return null;
        }
        public DataTable ThongTinDocGia(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MASV FROM SINHVIEN WHERE TENSV LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                DOCGIA = a["MASV"].ToString().Trim();
            }
            return null;
        }
        private void ClearText()
        {
            txtMaPhieu.Clear();
            tbxmuon.Clear();
            txttra.Clear();
            dtgNgayMuon.Text = DateTime.Now.ToShortDateString();
            dtgNgayTra.Text = DateTime.Now.ToShortDateString();
        }
        private void Enabletbx()
        {
            txtMaPhieu.Enabled = true;
            cbxnhanvien.Enabled = true;
            cbxdocgia.Enabled = true;
            cbxsach.Enabled = true;
            dtgNgayMuon.Enabled = true;
            dtgNgayTra.Enabled = true;
            tbxmuon.Enabled = true;
            txttra.Enabled = true;
            
        }

        private void Disabletbx()
        {
            txtMaPhieu.Enabled = false;
            cbxnhanvien.Enabled = false;
            cbxdocgia.Enabled = false;
            cbxsach.Enabled = false;
            dtgNgayMuon.Enabled = false;
            dtgNgayTra.Enabled = false;
            tbxmuon.Enabled = false;
            txttra.Enabled = false;
        }
        private void Enablebtn()
        {
            btThem.Enabled = true;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;
        }

        private void Disablebtn()
        {
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btLuu.Enabled = true;

        }
        void ShowData()
        {
            dgvPhieuMuonTra.DataSource = bal_pm.GetData();
            dgvPhieuMuonTra.AutoResizeColumns();
            cbxnhanvien.DataSource = bal_nv.GetData();
            cbxdocgia.DataSource = bal_dg.GetData();
            cbxsach.DataSource = bal_sach.GetData();
            cbxnhanvien.DisplayMember = "TENNV";
            cbxnhanvien.ValueMember = "MANV";
            cbxdocgia.DisplayMember = "TENSV";
            cbxdocgia.ValueMember = "MASV";
            cbxsach.DisplayMember = "TENSACH";
            cbxsach.ValueMember = "MASACH";
            dtgNgayMuon.Value = DateTime.Now;
            dtgNgayTra.Value = DateTime.Now;

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Disabletbx();
            btLuu.Enabled = true;
            key = 3;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            btLuu.Enabled = true;
            key = 2;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Disablebtn();
            Enabletbx();
            dtgNgayTra.Enabled = false;
            txttra.Enabled = false;
            btLuu.Enabled = true;
            key = 1;
        }

        

        private void dgvPhieuMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvPhieuMuonTra.Rows[e.RowIndex];
                txtMaPhieu.Text = row.Cells["MAPHIEU"].Value.ToString().Trim();
                cbxnhanvien.Text = row.Cells["TENNV"].Value.ToString().Trim();
                cbxdocgia.Text = row.Cells["TENSV"].Value.ToString().Trim();
                cbxsach.Text = row.Cells["TENSACH"].Value.ToString().Trim();
                dtgNgayMuon.Text= row.Cells["NGAYMUON"].Value.ToString().Trim();
                dtgNgayTra.Text = row.Cells["NGAYTRA"].Value.ToString().Trim();
                tbxmuon.Text = row.Cells["SOLUONGMUON"].Value.ToString().Trim();
                txttra.Text = row.Cells["SOLUONGTRA"].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                ex = bal_pm.GetEx();
                MessageBox.Show(ex.Message);
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void frmPhieuMuonTra1_Load(object sender, EventArgs e)
        {
            Disabletbx();
            Enablebtn();
            ShowData();
            dgvPhieuMuonTra.DataSource = bal_pm.GetData();
            dgvPhieuMuonTra.ClearSelection();
            dgvPhieuMuonTra.Columns["MAPHIEU"].HeaderText = "Mã Phiếu";
            dgvPhieuMuonTra.Columns["TENNV"].HeaderText = "Nhân Viên";
            dgvPhieuMuonTra.Columns["TENSV"].HeaderText = "Độc Giả ";
            dgvPhieuMuonTra.Columns["TENSACH"].HeaderText = "Sách";
            dgvPhieuMuonTra.Columns["NGAYMUON"].HeaderText = "Ngày Mượn";
            dgvPhieuMuonTra.Columns["NGAYTRA"].HeaderText = "Ngày Trả";
            dgvPhieuMuonTra.Columns["SOLUONGMUON"].HeaderText = "Số Lượng Mượn";
            dgvPhieuMuonTra.Columns["SOLUONGTRA"].HeaderText = "Số Lượng Trả";


            dgvPhieuMuonTra.Columns["MAPHIEU"].Width = 100;
            dgvPhieuMuonTra.Columns["TENNV"].Width = 200;
            dgvPhieuMuonTra.Columns["TENSV"].Width = 130;
            dgvPhieuMuonTra.Columns["TENSACH"].Width = 100;
            dgvPhieuMuonTra.Columns["NGAYMUON"].Width = 100;
            dgvPhieuMuonTra.Columns["NGAYTRA"].Width = 100;
            dgvPhieuMuonTra.Columns["SOLUONGMUON"].Width = 100;
            dgvPhieuMuonTra.Columns["SOLUONGTRA"].Width = 100;
        }

        private void btLammoi_Click(object sender, EventArgs e)
        {
            frmPhieuMuonTra1_Load(sender, e);
            ClearText();
            key = 0;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (key == 1)
            {
                if (txtMaPhieu.Text == "" || tbxmuon.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các ô");
                }
                else 
                {
                    var nvnhap = cbxnhanvien.GetItemText(cbxnhanvien.SelectedItem);
                    ThongTinNhanVienNhap(nvnhap);
                    var docgiamuon = cbxdocgia.GetItemText(cbxdocgia.SelectedItem);
                    ThongTinDocGia(docgiamuon);
                    var sachmuon = cbxsach.GetItemText(cbxsach.SelectedItem);
                    ThongTinSach(sachmuon);
                    DataTable dtnv = acc.CheckSql("select *from NHANVIEN WHERE TENNV like N'" + cbxnhanvien.Text + "'");
                    DataTable dtdg = acc.CheckSql("SELECT *from SINHVIEN WHERE TENSV like N'" + cbxdocgia.Text + "'");
                    DataTable dtsach = acc.CheckSql("SELECT *FROM SACH WHERE TENSACH like N'" + cbxsach.Text + "'");


                    acc.THEMPHIEUMUONTRA(txtMaPhieu.Text, DOCGIA, NVNHAP, dtgNgayMuon.Value);
                    SqlDataReader sda = acc.ExecuteReader("SELECT TOP 1 MAPHIEU FROM PHIEUMUONTRA ORDER BY MAPHIEU DESC");
                    if (sda.Read() == true)
                    {
                        acc.THEMCTPMT(sda[0].ToString(), MASACH, Convert.ToInt16(tbxmuon.Text));
                    }
                    frmPhieuMuonTra1_Load(sender, e);
                    dgvPhieuMuonTra.ClearSelection();
                }

            }


            if (key == 2)
            {
                if (dgvPhieuMuonTra.SelectedRows == null)
                {
                    MessageBox.Show("Hãy chọn 1 phiếu nhập để sửa");
                }
                else if (txtMaPhieu.Text == "" || txttra.Text == "" || tbxmuon.Text == "")
                {
                    MessageBox.Show("Hãy điền đủ thông tin vào các ô");
                    
                }
                else
                {
                    var nvnhap = cbxnhanvien.GetItemText(cbxnhanvien.SelectedItem);
                    ThongTinNhanVienNhap(nvnhap);
                    var docgiamuon = cbxdocgia.GetItemText(cbxdocgia.SelectedItem);
                    ThongTinDocGia(docgiamuon);
                    var sachmuon = cbxsach.GetItemText(cbxsach.SelectedItem);
                    ThongTinSach(sachmuon);
                    DataTable dtnv = acc.CheckSql("select *from NHANVIEN WHERE TENNV like N'" + cbxnhanvien.Text + "'");
                    DataTable dtdg = acc.CheckSql("SELECT *from SINHVIEN WHERE TENSV like N'" + cbxdocgia.Text + "'");
                    DataTable dtsach = acc.CheckSql("SELECT *FROM SACH WHERE TENSACH like N'" + cbxsach.Text + "'");
                    
                        acc.SUAPHIEUMUONTRA(txtMaPhieu.Text, DOCGIA, NVNHAP, dtgNgayMuon.Value);
                        acc.SUACTPMT(txtMaPhieu.Text, MASACH, Convert.ToInt16(txttra.Text), dtgNgayTra.Value, Convert.ToInt16(tbxmuon.Text));
                        frmPhieuMuonTra1_Load(sender, e);
                        dgvPhieuMuonTra.ClearSelection();
                        ClearText();
                    
                }
            }
            if (key == 3)
            {
                if (txtMaPhieu.Text == "" || dgvPhieuMuonTra.SelectedRows == null)
                {
                    MessageBox.Show("Hãy Chọn 1 phiếu mượn trả để xóa");
                }
                else if (MessageBox.Show("Bạn Có chắc chắn muốn xóa phiếu mượn trả", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acc.XOAPMT(txtMaPhieu.Text);
                    frmPhieuMuonTra1_Load(sender, e);
                    dgvPhieuMuonTra.ClearSelection();
                    ClearText();
                }
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                ShowData();
                if (bal_pm.GetDataTimKiem(txtTimKiem.Text.Trim()) != null)
                {
                    dgvPhieuMuonTra.DataSource = bal_pm.GetDataTimKiem(txtTimKiem.Text.Trim());

                }
                else
                {
                    Exception ex = bal_pm.GetEx();
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
                MessageBox.Show("Bạn cần nhập thông tin để tìm kiếm !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == null || txtMaPhieu.Text == "")
            {
                MessageBox.Show("Hãy Chọn 1 phiếu để In");

            }
            else
            {
                BaoCao.MaPM = txtMaPhieu.Text;
                BaoCao.keyn = 2;
                BaoCao baocaof = new BaoCao();
                baocaof.ShowDialog();
            }

        }
        
        private void dgvPhieuMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maphieu = dgvPhieuMuonTra.CurrentRow.Cells["MAPHIEU"].Value.ToString();
            frmChiTietPhieuMuon ctpm = new frmChiTietPhieuMuon(maphieu);
            ctpm.ShowDialog();
            
            
        }

        private void frmPhieuMuonTra_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btninpm_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == null || txtMaPhieu.Text == "")
            {
                MessageBox.Show("Hãy Chọn 1 phiếu để In");

            }
            else
            {
                BaoCao.MaPM = txtMaPhieu.Text;
                BaoCao.keyn = 1;
                BaoCao baocaof = new BaoCao();
                baocaof.ShowDialog();
            }
        }

        private void frmPhieuMuonTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            frmMain fmain = new frmMain();
            fmain.Show();
        }
    }
}
