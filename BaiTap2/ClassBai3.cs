using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class ClassBai3
    {
        public void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }
        public long GiaiThua(int n)
        {
            int s = 1;
            for (int i = 2; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }
    }
}
