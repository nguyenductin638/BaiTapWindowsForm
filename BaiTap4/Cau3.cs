using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class Cau3
    {
        public int USCLN(int m, int n)
        {
            while (n != 0)
            {
                int temp = n;
                n = m % n;
                m = temp;
            }
            return m;
        }
    }
}
