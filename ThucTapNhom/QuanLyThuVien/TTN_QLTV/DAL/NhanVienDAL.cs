using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NhanVienDAL : KetNoi
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("select * from NhanVien");
        }
        public bool Them(NhanVien nv)
        {
            try
            {
                string query = @"INSERT INTO dbo.nhanvien(  MaNV ,TenNV ,NgaySinh ,GioiTinh ,Luong ,DiaChi,SDT,HINHANH)
                                VALUES  ( '" + nv.MaNV + "',N'" + nv.Ten + "','" + nv.NgaySinh + "', N'" + nv.GioiTinh + "','" + nv.Luong + "',N'" + nv.DiaChi + "','" +nv.SDT + "','" + nv.HinhAnh + "')";
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
        public bool Sua(NhanVien nv)
        {
            try
            {
                string query = @"UPDATE dbo.NhanVien set TENNV=N'" + nv.Ten + "', NGAYSINH='" + nv.NgaySinh + "', GIOITINH=N'" + nv.GioiTinh + "',DIACHI=N'" + nv.DiaChi + "',LUONG=" + nv.Luong + ",SDT='" + nv.SDT + "',HINHANH='" + nv.HinhAnh + "' WHERE MANV='" + nv.MaNV + "'";
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
                string query = @"Delete from NhanVien where manv='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE FROM PhieuMuonTra WHERE manv = '" + ma + "'");
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
                
                string query = @"select * from NhanVien where (manv like '%" + chuoi + "%') or (tennv like N'%" + chuoi + "%') or (gioitinh like N'%" + chuoi + "%') or (diachi like N'%" + chuoi + "%')";
                return (DataTable)ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                SetEx(ex);
                return null;
            }
        }
    }
}
