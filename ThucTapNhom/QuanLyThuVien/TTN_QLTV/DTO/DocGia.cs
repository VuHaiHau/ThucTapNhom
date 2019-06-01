using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGia
    {

        public string Masv { set; get; }

        public string Hoten { set; get; }

        public DateTime Ngaysinh { set; get; }

        public string Gioitinh { set; get; }

        public string Diachi { set; get; }

        public string Lop { set; get; }

        public DocGia(string _Masv, string Hoten, DateTime Ngaysinh, string gioitinh, string diachi, string lop)
        {
            this.Masv = _Masv;
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Lop = lop;
        }
    }
}
