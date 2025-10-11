using System;
using HinhHoc;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập cạnh tam giác
        Console.Write("Nhập cạnh a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập cạnh b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Nhập cạnh c: ");
        int c = int.Parse(Console.ReadLine());

        // Tạo đối tượng tam giác
        TamGiac tg = new TamGiac(a, b, c);

        // Hiển thị thông tin
        tg.HienThi();

        Console.ReadLine();
    }
}
