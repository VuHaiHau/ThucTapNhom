using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class ReportPhieuNhap : Form
    {
        public static string MAPN;
        public ReportPhieuNhap(string id)
        {
            InitializeComponent();
            MAPN = id;
        }

        private void ReportPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HoaDonMuaHang.HOADONMUAHANG' table. You can move, or remove it, as needed.
            this.HOADONMUAHANGTableAdapter.Fill(this.HoaDonMuaHang.HOADONMUAHANG,MAPN);

            this.reportViewer1.RefreshReport();
        }
    }
}
