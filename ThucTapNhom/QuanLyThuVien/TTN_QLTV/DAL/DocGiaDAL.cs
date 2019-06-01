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
    public class DocGiaDAL : KetNoi
    {
        public DataTable GetData()
        {
            return(DataTable)ShowDataInGridView("select * FROM SINHVIEN");
        }
        public bool Them(DocGia dg)
        {
            try
            {
                string query = @"INSERT INTO SINHVIEN(  MASV ,TENSV ,NGAYSINH ,GIOITINH ,DIACHI ,LOP)
                                VALUES  ( '" + dg.Masv + "',N'" + dg.Hoten + "','" + dg.Ngaysinh + "', N'" + dg.Gioitinh + "',N'" + dg.Diachi + "',N'" + dg.Lop + "')";
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
        public bool Sua(DocGia entity)
        {
            try
            {
                string query = @"UPDATE SINHVIEN SET TENSV=N'" + entity.Hoten + "', NGAYSINH=N'" + entity.Ngaysinh + "', GIOITINH=N'" + entity.Gioitinh + "',DIACHI=N'" + entity.Diachi + "',LOP=N'" + entity.Lop + "' WHERE MASV='" + entity.Masv + "'";
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
                string query = @"Delete from SINHVIEN where MASV='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM PhieuMuonTra WHERE MASV = '" + ma + "'");
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
                string query = @"select * from SinhVien where (masv like '%" + chuoi + "%') or (tensv like N'%" + chuoi + "%') or (gioitinh like N'%" + chuoi + "%') or (diachi like N'%" + chuoi + "%')or (lop like N'%" + chuoi + "%')";
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
