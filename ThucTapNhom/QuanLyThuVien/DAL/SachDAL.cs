using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class SachDAL : DataConnection
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select * FROM dbo.SACH");
        }
        KetNoi conn = new KetNoi();

        public DataTable GetDataProc(string maphieu)
        {
            return conn.GetDataStr("SELECT * FROM Sach WHERE TENSACH NOT IN (SELECT CHITIETPHIEUMUON.MASACH FROM dbo.chitietphieumuon INNER JOIN dbo.Sach ON  sach.masach = chitietphieumuon.masach WHERE MaPM='" + maphieu + "')");
        }
        public bool Them(Sach entity)
        {
            try
            {
                string query = @"INSERT INTO dbo.sach(  masach ,Tensach ,tentg ,soluong ,namxuatban)
                                VALUES  ( '" + entity.MaSach + "',N'" + entity.Tensach + "','" + entity.TenTG + "', N'" + entity.Soluong + "','" + entity.Namxuatban + "')";
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
                string query = @"UPDATE dbo.Sach set Tensach=N'" + entity.Tensach + "', tentg=N'" + entity.TenTG + "', soluong=" + entity.Soluong + ",Namxuatban='" + entity.Namxuatban + "' WHERE Masach='" + entity.MaSach + "'";
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
                string query = @"DELETE dbo.CHITIETPHIEUMUON WHERE MASACH='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE dbo.SACH WHERE MASACH ='" + ma + "'");
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
                //string query = @"select * from NhanVien where (manv like '%" + chuoi + "%' or ten like N'%" + chuoi + "%' or maphong like '%" + chuoi + "%' or gioitinh like N'%" + chuoi + "%' or luong like '%" + chuoi + "%'or diachi like N'%" + chuoi+ "% or ngaysinh like '%" + DateTime.Parse(chuoi) +"')";
                string query = @"select * from sach where (masach like '%" + chuoi + "%') or (tensach like N'%" + chuoi + "%') or (namxuatban like '%" + chuoi + "%') or (tentg like N'%" + chuoi + "%')";
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
