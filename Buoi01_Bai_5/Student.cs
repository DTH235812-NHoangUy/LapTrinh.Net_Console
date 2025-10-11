using System;

namespace Buoi01_Bai_5
{
    internal class Student
    {
        // Private fields
        private string _hoTen;
        private int _tuoi;
        private double _diemToan;
        private double _diemVan;
        private double _dtb;

        // Constructor
        public Student()
        {
            _hoTen = "";
            _tuoi = 0;
            _diemToan = 0;
            _diemVan = 0;
            _dtb = 0;
        }

        // Properties
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public int Tuoi
        {
            get { return _tuoi; }
            set { _tuoi = value; }
        }

        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }

        public double DiemVan
        {
            get { return _diemVan; }
            set { _diemVan = value; }
        }

        public double Dtb
        {
            get { return Math.Round((_diemToan + _diemVan) / 2, 2); }
        }

        // Method to input student information
        public void Nhap()
        {
            Console.Write("\t- Nhập họ tên: ");
            HoTen = Console.ReadLine();

            double temp;

            // Nhập điểm Toán
            while (true)
            {
                Console.Write("\t- Nhập điểm Toán: ");
                if (double.TryParse(Console.ReadLine(), out temp) && temp >= 0 && temp <= 10)
                {
                    DiemToan = temp;
                    break;
                }
                Console.WriteLine("\t!!! Điểm phải nằm trong khoảng 0 -> 10");
            }

            // Nhập điểm Văn
            while (true)
            {
                Console.Write("\t- Nhập điểm Văn: ");
                if (double.TryParse(Console.ReadLine(), out temp) && temp >= 0 && temp <= 10)
                {
                    DiemVan = temp;
                    break;
                }
                Console.WriteLine("\t!!! Điểm phải nằm trong khoảng 0 -> 10");
            }
        }

        // Method to output student info
        public void Xuat()
        {
            Console.WriteLine("{0,-20}{1,-15}{2,-15}{3,-10}", HoTen, DiemToan, DiemVan, Dtb);
        }
    }
}
