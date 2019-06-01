using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai
    {
        public string MaTheLoai { set; get; }

        public string TenTheLoai { set; get; }
        public TheLoai(string _MaTheLoai, string tentheloai)
        {
            this.MaTheLoai=_MaTheLoai;
            this.TenTheLoai = tentheloai;
            
        }
    }
}
