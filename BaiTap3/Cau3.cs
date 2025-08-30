using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class Cau3
    {
        public void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            string[] s = hoten.Split(' ');
            s1 += s[0];
            for (int i = 1; i < s.Length - 1; i++)
            {
                s1 += " " + s[i];
            }
            s2 = s[s.Length - 1];
        }
        public bool ThuTu(int n1, int n2)
        {
            if (n1 == n2 + 1 || n2 == n1 + 1)
                return true;
            return false;
        }
    }
}
