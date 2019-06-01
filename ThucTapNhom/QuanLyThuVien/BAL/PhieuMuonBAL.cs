using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BAL
{
    public class PhieuMuonBAL
    {
        PhieuMuonTraDAL dal_PhieuMuon = new PhieuMuonTraDAL();
        public DataTable GetData()
        {
            return dal_PhieuMuon.GetData();
        }

        public bool Them(PhieuMuonTra pm)
        {
            return dal_PhieuMuon.Them(pm);
        }
        public bool Sua(PhieuMuonTra pm)
        {
            return dal_PhieuMuon.Sua(pm);
        }
        public Exception GetEx()
        {
            return dal_PhieuMuon.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string ma)
        {
            return dal_PhieuMuon.Xoa(ma);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_PhieuMuon.GetDataTimKiem(chuoi);
        }
    }
}
