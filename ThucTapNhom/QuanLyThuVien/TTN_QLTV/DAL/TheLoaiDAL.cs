using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class TheLoaiDAL:KetNoi
    {

        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select * FROM dbo.TheLoai");
        }
        public bool Them(TheLoai tl)
        {
            try
            {
                string query = @"INSERT INTO TheLoai(  matheloai ,Tentheloai )
                                VALUES  ( '" + tl.MaTheLoai + "',N'" + tl.TenTheLoai + "')";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public bool Sua(TheLoai tl)
        {
            try
            {
                string query = @"UPDATE dbo.TheLoai set TENTHELOAI=N'" + tl.TenTheLoai + "' WHERE MaTheLoai='" + tl.MaTheLoai + "'";
                OpenConection();
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public bool Xoa(String ma)
        {
            try
            {
                string query = @"DELETE THELOAI WHERE MATHELOAI='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE SACH WHERE MASACH ='" + ma + "'");
                ExecuteQueries(query);
                CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return false;
            }
        }
        public DataTable GetDataTimKiem(string chuoi)
        {

            try
            {
               
                string query = @"select * from theloai where (matheloai like '%" + chuoi + "%') or (tentheloai like N'%" + chuoi + "%') ";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
            // }

        }
    }
}
