using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm
{
    internal class TinhToan
    {
        public static void CongHaiSo(float a,  float b, ref float s)
        {
            s = a + b;
        }
        public static void TongDaySo(int n, ref float s)
        {
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
        }
    }
}
