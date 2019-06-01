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
    public partial class BaoCaoN_F : Form
    {
        accessData acc = new accessData();
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
        
        public BaoCaoN_F()
        {
            InitializeComponent();
        }

        private void BaoCaoN_F_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            string sql = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QLKH;Integrated Security=True";
            con.ConnectionString = sql;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TENNV", TenNv));
            cmd.Parameters.Add(new SqlParameter("@TENSP", TenSp));
            cmd.Parameters.Add(new SqlParameter("@TENNCC", TenNcc_Kh));
            cmd.Parameters.Add(new SqlParameter("@TENKHO", TenKho));
            cmd.Parameters.Add(new SqlParameter("@NGAYNHAP", NgayNh_Xu));
            cmd.Parameters.Add(new SqlParameter("@GIA", Gia));
            cmd.Parameters.Add(new SqlParameter("@TUNGAY", TuNgay));
            cmd.Parameters.Add(new SqlParameter("@DENNGAY", DenNgay));
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            ReportParameter tungay = new ReportParameter("Tungay", TuNgay);
            ReportParameter denngay = new ReportParameter("Denngay", DenNgay);
            ReportParameter tu = new ReportParameter("Tu", "Từ");
            ReportParameter den = new ReportParameter("Den", "Đến");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "BaoCaoNhap.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "BaoCaoNhap";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { tu });
                //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { den });
                //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { tungay });
                //rpv_baocao.LocalReport.SetParameters(new ReportParameter[] { denngay });
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Không Có Dữ Liệu!");
                BaoCaoN_F bcf = new BaoCaoN_F();
                bcf.Hide();
            }

            //this.reportViewer1.RefreshReport();
        }
    }
}
