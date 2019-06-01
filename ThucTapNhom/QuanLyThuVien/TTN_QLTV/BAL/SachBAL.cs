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
    public class SachBAL
    {
        SachDAL dal_sach = new SachDAL();
        public DataTable GetData()
        {
            return dal_sach.GetData();
        }
      
        public bool Them(Sach nv)
        {
            return dal_sach.Them(nv);
        }
        public bool Sua(Sach nv)
        {
            return dal_sach.Sua(nv);
        }
        
        public Exception GetEx()
        {
            return dal_sach.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string ma)
        {
            return dal_sach.Xoa(ma);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_sach.GetDataTimKiem(chuoi);
        }
    }
}
