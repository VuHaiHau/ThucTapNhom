using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BAL
{
    public class TheLoaiBAL
    {
        TheLoaiDAL dal_TheLoai = new TheLoaiDAL();
        public DataTable GetData()
        {
            return dal_TheLoai.GetData();
        }

        public bool Them(TheLoai tl)
        {
            return dal_TheLoai.Them(tl);
        }
        public bool Sua(TheLoai tl)
        {
            return dal_TheLoai.Sua(tl);
        }
        public Exception GetEx()
        {
            return dal_TheLoai.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public bool Xoa(string ma)
        {
            return dal_TheLoai.Xoa(ma);
        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_TheLoai.GetDataTimKiem(chuoi);
        }
    }
}
