using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TTN_QLTV
{
    public partial class frmChiTietPhieuMuon : Form
    {
        public string MaPM { get; set; }
        private string MASACH;
        public DataTable data;
        public string Query;
        public frmChiTietPhieuMuon(string mapm)
        {
            InitializeComponent();
            MaPM = mapm;
            txtMaPhieu.Text = mapm;
        }
        accessdata acc = new accessdata();
        public DataTable ThongTinSach(string TEXT)
        {
            SqlDataReader a = acc.ExecuteReader("Select MASACH FROM SACH WHERE TENSACH LIKE N'%" + TEXT + "%'");
            while (a.Read())
            {
                MASACH = a["MASACH"].ToString().Trim();
            }
            return null;
        }
        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Hãy điền đủ thông tin vào các ô");
            }
            else
            {
                var sachmuon = cbxsach.GetItemText(cbxsach.SelectedItem);
                ThongTinSach(sachmuon);
                DataTable dtsach = acc.CheckSql("SELECT *FROM SACH WHERE TENSACH like N'" + cbxsach.Text + "'");


                
                    acc.THEMCTPMT(MaPM, MASACH, Convert.ToInt16(tbxmuon.Text));

                frmChiTietPhieuMuon_Load(sender, e);
                dgvctpmt.ClearSelection();
            }


        }

        private void frmChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            Query = "Select MAPHIEU,SACH.TENSACH,SOLUONGMUON from CTPhieuMuonTra,SACH where SACH.MASACH=CTPHIEUMUONTRA.MASACH";
            dgvctpmt.DataSource = acc.Select_Data(Query);
            cbxsach.DataSource = acc.Select_Data("Select *from SACH");
            cbxsach.DisplayMember = "TENSACH";
            cbxsach.ValueMember = "MASACH";
            dgvctpmt.ClearSelection();
            dgvctpmt.Columns["MAPHIEU"].HeaderText = "Mã Phiếu";
            dgvctpmt.Columns["TENSACH"].HeaderText = "Tên Sách";
            dgvctpmt.Columns["SOLUONGMUON"].HeaderText = "Số Lượng Mượn";
            dgvctpmt.Columns["MAPHIEU"].Width = 200;
            dgvctpmt.Columns["TENSACH"].Width = 250;
            dgvctpmt.Columns["SOLUONGMUON"].Width = 150;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
