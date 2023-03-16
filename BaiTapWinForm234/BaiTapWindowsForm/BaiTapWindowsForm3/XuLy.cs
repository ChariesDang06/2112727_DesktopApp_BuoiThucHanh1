using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm3
{
    internal class XuLy
    {
        public static void TachChuoi(string hoten, ref string str1, ref string str2)
        {
            int firstIndex = hoten.LastIndexOf(' ') + 1;
            str1 = hoten.Substring(0, firstIndex);
            str2 = hoten.Substring(firstIndex, hoten.Length-firstIndex);
        }

        public static bool ThuTu(int n1, int n2)
        {
            bool kq = true;

            if(n2 == n1 + 1)
                kq = true;
            else
                kq = false;
            return kq;
        }
    }
}
