using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class PhieuMuonTraDAL :KetNoi
    {
        public DataTable GetData()
        {
            return (DataTable)ShowDataInGridView("SELECT dbo.PHIEUMUONTRA.MAPHIEU, dbo.NHANVIEN.TENNV, dbo.SINHVIEN.TENSV, dbo.SACH.TENSACH, dbo.PHIEUMUONTRA.NGAYMUON,dbo.CTPHIEUMUONTRA.NGAYTRA, dbo.CTPHIEUMUONTRA.SOLUONGMUON, dbo.CTPHIEUMUONTRA.SOLUONGTRA FROM dbo.CTPHIEUMUONTRA INNER JOIN dbo.PHIEUMUONTRA ON dbo.CTPHIEUMUONTRA.MAPHIEU = dbo.PHIEUMUONTRA.MAPHIEU INNER JOIN dbo.NHANVIEN ON dbo.PHIEUMUONTRA.MANV = dbo.NHANVIEN.MANV INNER JOIN dbo.SACH ON dbo.CTPHIEUMUONTRA.MASACH = dbo.SACH.MASACH INNER JOIN dbo.SINHVIEN ON dbo.PHIEUMUONTRA.MASV = dbo.SINHVIEN.MASV order by maphieu");
        }
        public bool Them(PhieuMuonTra pm)
        {
            try
            {
                string query = @"INSERT INTO PHIEUMUONTRA(MAPHIEU,MASV ,MANV ,NGAYMUON)
                                VALUES ( '" + pm.MaPhieu + "','" + pm.MaSV + "','" + pm.MaNV + "', '" + pm.NgayMuon + "')";
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
        public bool Sua(PhieuMuonTra pm)
        {
            try
            {
                string query = @"UPDATE PhieuMuonTra set MaSV='" + pm.MaSV + "', MaNV='" + pm.MaNV + "', NgayMuon='" + pm.NgayMuon + "' WHERE MaPM='" + pm.MaPhieu + "'";
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
                string query = @"DELETE dbo.PHIEUMUONTRA WHERE MAPHIEU='" + ma + "'";
                OpenConection();
                ExecuteQueries(@"DELETE dbo.CHITIETPHIEUMUON WHERE MAPHIEU ='" + ma + "'");
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
                
                string query = @"SELECT dbo.PHIEUMUONTRA.MAPHIEU, dbo.NHANVIEN.TENNV, dbo.SINHVIEN.TENSV, dbo.SACH.TENSACH, dbo.PHIEUMUONTRA.NGAYMUON,dbo.CTPHIEUMUONTRA.NGAYTRA, dbo.CTPHIEUMUONTRA.SOLUONGMUON, dbo.CTPHIEUMUONTRA.SOLUONGTRA FROM dbo.CTPHIEUMUONTRA INNER JOIN dbo.PHIEUMUONTRA ON dbo.CTPHIEUMUONTRA.MAPHIEU = dbo.PHIEUMUONTRA.MAPHIEU INNER JOIN dbo.NHANVIEN ON dbo.PHIEUMUONTRA.MANV = dbo.NHANVIEN.MANV INNER JOIN dbo.SACH ON dbo.CTPHIEUMUONTRA.MASACH = dbo.SACH.MASACH INNER JOIN dbo.SINHVIEN ON dbo.PHIEUMUONTRA.MASV = dbo.SINHVIEN.MASV where (PHIEUMUONTRA.MAPHIEU like '%" + chuoi + "%') or (TENNV like N'%" + chuoi + "%') or (TENSV like '%" + chuoi + "%') or (NGAYMUON like N'%" + chuoi + "%')or (NGAYTRA like N'%" + chuoi + "%')or (TENSACH like N'%" + chuoi + "%')";
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
