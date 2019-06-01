using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {

        public string MaNV { set; get; }

        public string Ten { set; get; }

        public DateTime NgaySinh { set; get; }

        public string GioiTinh { set; get; }

        public string DiaChi { set; get; }

        public int Luong { set; get; }

        
        public NhanVien(string ma, string ten, DateTime ngaysinh, string gioitinh, int luong, string diadiem)
        {
            this.MaNV = ma;
            this.Ten = ten;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.Luong = luong;
            this.DiaChi = diadiem;
        }
    }
}
