using System;

namespace GiaiPhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a, b, c;
            Console.Write("Nhập hệ số a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập hệ số c: ");
            c = Convert.ToInt32(Console.ReadLine());

            PTBacHai pt = new PTBacHai(a, b, c);
            pt.Giai();

            Console.ReadLine();
        }
    }
}

