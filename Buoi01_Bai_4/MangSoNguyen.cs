using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_Bai_4
{
    internal class MangSoNguyen
    {
        public int NhapSoDuong()
        {
            int so;
            do
            {
                Console.Write(">> Nhập số nguyên dương (>0): ");
                so = Convert.ToInt32(Console.ReadLine());
            } while (so <= 0);
            return so;
        }
    public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
            Console.WriteLine();
        }
        public int TimSoLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
        public int TimSoNhoNhat(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }
        public int TinhTong(int[] a)
        {
            int tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        public void SapXepTangDan(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}
