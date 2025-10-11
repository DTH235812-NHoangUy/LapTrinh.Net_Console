using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_Bai_2
{
    internal class TimSLN
    {
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
    public int TimMax(int n)
        {
            int max, i, sotam;
            max = 0;
            i = 0;
            do
            {
                Console.Write("Nhập vào số thứ {0} = ", i + 1);
                sotam = Convert.ToInt32(Console.ReadLine());
                if (max < sotam)
                    max = sotam;
                i++;
            } while (i < n);
            return max;
        }
    }
}

