using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SachDAL : KetNoi
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT dbo.SACH.MASACH, dbo.SACH.TENSACH, dbo.SACH.TENTG, dbo.SACH.NAMXUATBAN, dbo.SACH.SOLUONG, dbo.THELOAI.TENTHELOAI FROM dbo.SACH INNER JOIN dbo.THELOAI ON dbo.SACH.MATHELOAI = dbo.THELOAI.MATHELOAI order by MaSach");
        }
        public bool Them(Sach entity)
        {
            try
            {
                string query = @"INSERT INTO dbo.sach(  masach ,Tensach ,tentg ,namxuatban,soluong ,matheloai)
                                VALUES  ( '" + entity.MaSach + "',N'" + entity.Tensach + "',N'" + entity.TenTG + "', N'" + entity.Namxuatban + "','" + entity.Soluong + "','" + entity.MaTheLoai + "')";
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
        public bool Sua(Sach entity)
        {
            try
            {
                string query = @"UPDATE dbo.Sach SET TENSACH=N'" + entity.Tensach + "', TENTG=N'" + entity.TenTG + "', NamXuatBan=" + entity.Namxuatban + ",SoLuong='" + entity.Soluong + "',MaTheloai='" + entity.MaTheLoai + "' WHERE Masach='" + entity.MaSach + "'";
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
                string query = @"DELETE dbo.SACH WHERE MASACH='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE dbo.CTPHIEUMUONTRA WHERE MASACH ='" + ma + "'");
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
                string query = "select MASACH,TENSACH,TENTG,NAMXUATBAN,SOLUONG,TENTHELOAI FROM THELOAI,SACH WHERE THELOAI.MATHELOAI=SACH.MATHELOAI AND (TENSACH like N'%" + chuoi + "%' or MASACH like N'%" + chuoi + "%' or TENTG like N'%" + chuoi + "%' or NAMXUATBAN like N'%" + chuoi + "%' or TENTHELOAI like N'%" + chuoi + "%')";
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
