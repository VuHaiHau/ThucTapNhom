using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuMuonTra
    {

        public string MaPhieu { set; get; }

        public string MaSV { set; get; }

        public string MaNV { set; get; }

        public DateTime NgayMuon { set; get; }


        public PhieuMuonTra(string maphieu, string masv,string manv, DateTime ngaymuon)
        {
            this.MaPhieu = maphieu;
            this.MaSV = masv;
            this.MaNV = manv;
            this.NgayMuon = ngaymuon;
        }
    }
}
