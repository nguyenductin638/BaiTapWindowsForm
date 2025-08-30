using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class TinhToan
    {
        public long GiaiThua(int n)
        {
            int s = 1;
            for (int i = 2; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }
        public long Tong(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            return s;
        }
    }
}
