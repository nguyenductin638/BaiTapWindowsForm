using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class NhanVien
    {
        public string MaNV {  get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }
        public NhanVien(string ma, string hoten, DateTime ngaysinh, int hsluong, int hsphucap)
        {
            MaNV = ma;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            HeSoLuong = hsluong;
            HeSoPhuCap = hsphucap;
        }
        public int TongLuong ()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", 
                MaNV, HoTen, NgaySinh.ToShortDateString(), HeSoLuong, HeSoPhuCap);
        }
    }
}
