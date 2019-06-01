using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TTN_QLTV
{
    class accessdata
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd;

        // Chuỗi Kết Nối
        public void getconnection()
        {
            string sql = @"Data Source=DUONG-PC\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
            con = new SqlConnection(sql);
        }

        //  Mở Kết nối
        public void OpenConnect()
        {
            getconnection();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        // Đóng kết nối
        public void CloseConnect()
        {
            getconnection();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        // CHeck Query database
        public DataTable CheckSql(string sql)
        {
            OpenConnect();
            dt = new DataTable();
            cmd = new SqlCommand(sql, con);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            CloseConnect();
            return dt;
        }

        // Lấy Dữ Liệu Table cho Datagridview
        public DataTable Select_Data(string query)
        {
            dt = new DataTable();
            OpenConnect();
            cmd = new SqlCommand(query, con);
            // cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            CloseConnect();
            return dt;
        }

        public DataSet Select(string query)
        {
            DataSet ds = new DataSet();
            OpenConnect();
            cmd = new SqlCommand(query, con);
            // cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            CloseConnect();
            return ds;
        }
        public bool executenonquery(String sql)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            return true;
        }
        public SqlDataReader ExecuteReader(String sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public int executeScalar(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            int n = (int)cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            return n;

        }
        public SqlDataAdapter executeDatatable(string sql)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.SelectCommand = cmd;
            return sda;
        }

        // lấy dữ liệu Auto Gợi ý
        public void getData(AutoCompleteStringCollection dataCollection, string sql)
        {
            OpenConnect();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataCollection.Add(row[0].ToString().Trim());
            }
        }

        // Auto Gợi Ý Textbox
        public void AutoComplete(TextBox tbx_textbox, string sql)
        {
            tbx_textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbx_textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, sql);
            tbx_textbox.AutoCompleteCustomSource = DataCollection;
        }

        public void AutoCompletecbx(ComboBox cbx_combobox, string sql, string tencot)
        {
            cbx_combobox.DataSource = Select_Data(sql);
            cbx_combobox.DisplayMember = tencot;
            cbx_combobox.ValueMember = tencot;
            cbx_combobox.SelectedIndex = -1;
            cbx_combobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx_combobox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
            getData(dataCollection, sql);
            cbx_combobox.AutoCompleteCustomSource = dataCollection;
        }
        //gợi ý textbox sử dụng mảng:
        public void getDatabyArray(AutoCompleteStringCollection datacolection, string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                datacolection.Add(a[i].ToString());
            }
        }
        public void AutoCompleteByArray(TextBox txt, string[] a)
        {
            txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection Data = new AutoCompleteStringCollection();
            getDatabyArray(Data, a);
            txt.AutoCompleteCustomSource = Data;
        }
        public SqlCommand THEMCTPMT(string maphieu, string masach,int soluongmuon)
        {
            OpenConnect();
            cmd = new SqlCommand("ThemCTPMT123", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAPHIEU", maphieu));
            cmd.Parameters.Add(new SqlParameter("MASACH", masach));
            cmd.Parameters.Add(new SqlParameter("SOLUONGMUON", soluongmuon));
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand THEMPHIEUMUONTRA(string maphieu, string madocgia, string manhanvien, DateTime ngaymuon)
        {
            OpenConnect();
            cmd = new SqlCommand("THEMPHIEUMUONTRA123", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAPHIEU", maphieu));
            cmd.Parameters.Add(new SqlParameter("MASV", madocgia));
            cmd.Parameters.Add(new SqlParameter("MANV", manhanvien));
            cmd.Parameters.Add(new SqlParameter("NGAYMUON", ngaymuon));
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand SUAPHIEUMUONTRA(string maphieu, string madocgia, string manhanvien, DateTime ngaymuon)
        {
            OpenConnect();
            cmd = new SqlCommand("SuaPhieuMuonTra", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAPHIEU", maphieu));
            cmd.Parameters.Add(new SqlParameter("MASV", madocgia));
            cmd.Parameters.Add(new SqlParameter("MANV", manhanvien));
            cmd.Parameters.Add(new SqlParameter("NGAYMUON", ngaymuon));
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand SUACTPMT(string maphieu, string masach, int soluongtra, DateTime ngaytra, int soluongmuon)
        {
            OpenConnect();
            cmd = new SqlCommand("suactphieumuontra", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAPHIEU", maphieu));
            cmd.Parameters.Add(new SqlParameter("MASACH", masach));
            cmd.Parameters.Add(new SqlParameter("SOLUONGTRA", soluongtra));
            cmd.Parameters.Add(new SqlParameter("NGAYTRA", ngaytra));
            cmd.Parameters.Add(new SqlParameter("SOLUONGMUON", soluongmuon));
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand XOAPMT(string mapmt)
        {
            OpenConnect();
            cmd = new SqlCommand("XOAPMT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAPHIEU", mapmt));
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand CapNhat_NguoiDung(string MANV, string HINHANH)
        {
            OpenConnect();
            cmd = new SqlCommand("CAPNHAT_NGUOIDUNG", con);
            cmd.Parameters.Add(new SqlParameter("@MANV", MANV));
            cmd.Parameters.Add(new SqlParameter("@HINHANH", HINHANH));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand Them_TaiKhoan(string taikhoan, string matkhau, string manv, string phanquyen)
        {
            OpenConnect();
            cmd = new SqlCommand("Insert_taikhoan", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taikhoan", taikhoan));
            cmd.Parameters.Add(new SqlParameter("@matkhau", matkhau));
            cmd.Parameters.Add(new SqlParameter("@phanquyen", phanquyen));
            cmd.Parameters.Add(new SqlParameter("@MANV", manv));
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }

        //Cập Nhật Tài Khoản
        public SqlCommand CapNhat_TaiKhoan(string username, string password, string manv, string quyenhan)
        {
            OpenConnect();
            cmd = new SqlCommand("UPDATE_TAIKHOAN", con);
            cmd.Parameters.Add(new SqlParameter("@taikhoan", username));
            cmd.Parameters.Add(new SqlParameter("@matkhau", password));
            cmd.Parameters.Add(new SqlParameter("@phanquyen", quyenhan));
            cmd.Parameters.Add(new SqlParameter("@manv", manv));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
        public SqlCommand Xoa_TaiKhoan(string username)
        {
            OpenConnect();
            cmd = new SqlCommand("XOATAIKHOAN", con);
            cmd.Parameters.Add(new SqlParameter("@taikhoan", username));
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            CloseConnect();
            return cmd;
        }
    }
}
