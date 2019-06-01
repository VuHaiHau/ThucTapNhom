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
    public partial class ReportPhieuXuat : Form
    {
        public string MAPX;
        public ReportPhieuXuat(string id)
        {
            InitializeComponent();
            MAPX = id;
        }

        private void ReportPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HoaDonMuaHang.HOADONBANHANG' table. You can move, or remove it, as needed.
            this.HOADONBANHANGTableAdapter.Fill(this.HoaDonMuaHang.HOADONBANHANG,MAPX);

            this.reportViewer1.RefreshReport();
        }
    }
}
