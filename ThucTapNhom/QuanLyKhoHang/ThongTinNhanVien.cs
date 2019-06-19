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
    public partial class ThongTinNhanVien : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static string MANV;
        public ThongTinNhanVien(string id)
        {
            InitializeComponent();
            MANV = id;
        }

        private void FrmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKhoHangDataSet3.ThongTinNhanVien' table. You can move, or remove it, as needed.
            this.ThongTinNhanVienTableAdapter.Fill(this.QuanLyKhoHangDataSet3.ThongTinNhanVien,MANV);

            this.reportViewer1.RefreshReport();
        }
    }
}
