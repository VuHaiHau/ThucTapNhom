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

namespace TTN_QLTV
{
    public partial class BaoCao : Form
    {
        accessdata acc = new accessdata();
        public static int keyn = 0;
        public static string MaPM;
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            if (keyn == 1)
            {

                SqlConnection con = new SqlConnection();
                string sql = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QLTV;Integrated Security=True";
                con.ConnectionString = sql;
                con.Open();
                acc.OpenConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INRAPHIEUMUON";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mapm", MaPM));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                rpv_baocao.ProcessingMode = ProcessingMode.Local;
                rpv_baocao.LocalReport.ReportPath = "XuatPhieuMuon.rdlc";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = ds.Tables[0];
                    rpv_baocao.LocalReport.DataSources.Clear();
                    rpv_baocao.LocalReport.DataSources.Add(rds);
                    rpv_baocao.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu!");
                    BaoCao bcf = new BaoCao();
                    bcf.Hide();
                }
            }
            if (keyn == 2)
            {

                SqlConnection con = new SqlConnection();
                string sql = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QLTV;Integrated Security=True";
                con.ConnectionString = sql;
                con.Open();
                acc.OpenConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INRAPHIEUTRA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mapm", MaPM));
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                rpv_baocao.ProcessingMode = ProcessingMode.Local;
                rpv_baocao.LocalReport.ReportPath = "XuatPhieuTra.rdlc";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet1";
                    rds.Value = ds.Tables[0];
                    rpv_baocao.LocalReport.DataSources.Clear();
                    rpv_baocao.LocalReport.DataSources.Add(rds);
                    rpv_baocao.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu!");
                    BaoCao bcf = new BaoCao();
                    bcf.Hide();
                }
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
