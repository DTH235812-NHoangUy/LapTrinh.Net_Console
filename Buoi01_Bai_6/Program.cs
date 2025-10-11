using System;
using QuanLyNhanVien;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Thiết lập lương cơ bản dùng chung cho tất cả nhân viên
        Console.Write("Nhập lương cơ bản (áp dụng cho tất cả nhân viên): ");
        double basic = double.Parse(Console.ReadLine());
        Employee.SetBasicSalary(basic);

        // Nhập 1 nhân viên
        Employee emp = new Employee();
        emp.Input();

        // Hiển thị thông tin nhân viên
        emp.Display();

        Console.ReadLine();
    }
}
