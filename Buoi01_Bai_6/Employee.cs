using System;

namespace QuanLyNhanVien
{
    class Employee
    {
        // Thuộc tính riêng
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;

        // Thuộc tính dùng chung (static)
        private static double basicSalary;

        // Các phương thức Getter
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }

        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }

        // Thiết lập bậc lương
        public void SetSalaryLevel(double level)
        {
            salaryLevel = level;
        }

        // Thiết lập lương cơ bản (static)
        public static void SetBasicSalary(double salary)
        {
            basicSalary = salary;
        }

        // Nhập thông tin nhân viên
        public void Input()
        {
            Console.Write("Nhập ID nhân viên: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Nhập họ tên nhân viên: ");
            name = Console.ReadLine();

            Console.Write("Nhập năm sinh: ");
            yearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Nhập bậc lương: ");
            salaryLevel = double.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin nhân viên
        public void Display()
        {
            Console.WriteLine("========== Thông tin nhân viên ==========");
            Console.WriteLine($"ID           : {id}");
            Console.WriteLine($"Họ tên       : {name}");
            Console.WriteLine($"Năm sinh     : {yearOfBirth}");
            Console.WriteLine($"Lương cơ bản : {basicSalary}");
            Console.WriteLine($"Thu nhập     : {GetIncome()}");
            Console.WriteLine("=========================================");
        }
    }
}

