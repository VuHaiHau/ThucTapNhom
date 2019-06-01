using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public string MaSach { set; get; }

        public string Tensach { set; get; }

        public string TenTG { set; get; }

        public string Namxuatban { set; get; }

        public int Soluong { set; get; }

        public string MaTheLoai { set; get; }
       

        public Sach(string _Masach, string ten, string tentg, string namxuatban, int soluong,string Matheloai)
        {
            this.MaSach = _Masach;
            this.Tensach = ten;
            this.TenTG = tentg;
            this.Soluong = soluong;
            this.Namxuatban = namxuatban;
            this.MaTheLoai = Matheloai;
        }
    }
}
