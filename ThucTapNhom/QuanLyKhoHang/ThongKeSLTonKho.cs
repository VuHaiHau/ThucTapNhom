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
    public partial class ThongKeSLTonKho : UserControl
    {
        public ThongKeSLTonKho()
        {
            InitializeComponent();
        }

        private void FrmThongKeSL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKhoHangDataSet2.TK_SoLuong' table. You can move, or remove it, as needed.
            this.TK_SoLuongTableAdapter.Fill(this.QuanLyKhoHangDataSet2.TK_SoLuong);

            this.reportViewer1.RefreshReport();
         
        }
    }
}
