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
using Microsoft.Reporting.WinForms;
namespace QuanLyKhoHang
{
    public partial class Frm_BaoCaoX_F : Form
    {
        DataAccess acc = new DataAccess();
        public static string TDN;
        public static int keyn = 0;
        public static string TenKho = null;
        public static string TenNcc_Kh = null;
        public static string TenSp = null;
        public static string TenNv = null;
        public static string Gia = null;
        public static string NgayNh_Xu = null;
        public static string TuNgay = null;
        public static string DenNgay = null;
        public Frm_BaoCaoX_F()
        {
            InitializeComponent();
        }

        private void BaoCaoX_F_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            string sql = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QuanLyKhoHang;Integrated Security=True";
            con.ConnectionString = sql;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCX";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TENNV", TenNv));
            cmd.Parameters.Add(new SqlParameter("@TENSP", TenSp));
            cmd.Parameters.Add(new SqlParameter("@TENKH", TenNcc_Kh));
            cmd.Parameters.Add(new SqlParameter("@TENKHO", TenKho));
            cmd.Parameters.Add(new SqlParameter("@NGAYXUAT", NgayNh_Xu));
            cmd.Parameters.Add(new SqlParameter("@GIA", Gia));
            cmd.Parameters.Add(new SqlParameter("@TUNGAY", TuNgay));
            cmd.Parameters.Add(new SqlParameter("@DENNGAY", DenNgay));
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "BaoCaoXuat.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BaoCaoXuat";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không Có Dữ Liệu!");
                Frm_BaoCaoX_F bcf = new Frm_BaoCaoX_F();
                bcf.Hide();
            }
        }
    }
}
