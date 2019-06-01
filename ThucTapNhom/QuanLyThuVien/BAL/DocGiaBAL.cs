using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BAL
{
    public class DocGiaBAL
    {
        DocGiaDAL dal_docgia = new DocGiaDAL();
        public DataTable GetData()
        {
            return dal_docgia.GetData();
        }
        public bool Them(DocGia dg)
        {
            return dal_docgia.Them(dg);
        }
        public bool Sua(DocGia dg)
        {
            return dal_docgia.Sua(dg);
        }
        public bool Xoa(string dg)
        {
            return dal_docgia.Xoa(dg);
        }
        public Exception GetEx()
        {
            return dal_docgia.GetEx();
        }
        public void SetEx(Exception ex)
        {

        }
        public DataTable GetDataTimKiem(string chuoi)
        {
            return dal_docgia.GetDataTimKiem(chuoi);
        }
    }
}
