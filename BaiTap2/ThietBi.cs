using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSX { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public ThietBi(string ma, string ten, string nuocsx, int dongia, int soluong)
        {
            MaThietBi = ma;
            TenThietBi = ten;
            NuocSX = nuocsx;
            DonGia = dongia;
            SoLuong = soluong;
        }
        public int ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",
                MaThietBi, TenThietBi, NuocSX, DonGia, SoLuong);
        }
    }
}
