using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KetNoi
    {
        public string strConnection = @"Data Source=DESKTOP-3SFFPGN\HAUMTA;Initial Catalog=QLTV;Integrated Security=True";
        public SqlConnection conn;
        public KetNoi()
        {
            if (conn != null && conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            else if (conn == null)
            {
                conn = new SqlConnection();
                conn.ConnectionString = strConnection;
                conn.Open();
            }
        }
        public DataTable GetDataStr(string strSql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        

        public DataTable GetDataProc(string NameProc, SqlParameter[] para)
        {

            SqlCommand cmd = new SqlCommand(NameProc, conn);
            // cmd.CommandText = NameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            //cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int ExcuteSQL(string strSQL)
        {
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
        public int ExcuteSQL(string NameProc, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = NameProc;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
            {
                cmd.Parameters.AddRange(para);
            }
            cmd.Connection = conn;
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
        public DataSet HD1(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "DATAS");
            return ds;
        }
        public DataSet HD2(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet HD3(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        private Exception ex = new Exception();
        
        public void OpenConection()
        {
            conn = new SqlConnection(strConnection);
            conn.Open();
        }
        public SqlConnection GetCon()
        {
            return this.conn;
        }

        public void CloseConnection()
        {
            conn.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, strConnection);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        public Exception GetEx()
        {
            return ex;
        }
        public void SetEx(Exception ex)
        {
            this.ex = ex;
        }
        public SqlDataReader ExecuteReader(String sql)
        {
            OpenConection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public bool executenonquery(String sql)
        {
            OpenConection();
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            return true;
        }
    }
}
