using System;

namespace HinhHoc
{
    class TamGiac
    {
        // Fields (thuộc tính private)
        private int _canh1;
        private int _canh2;
        private int _canh3;

        // Properties
        public int Canh1
        {
            get { return _canh1; }
            set { _canh1 = value; }
        }

        public int Canh2
        {
            get { return _canh2; }
            set { _canh2 = value; }
        }

        public int Canh3
        {
            get { return _canh3; }
            set { _canh3 = value; }
        }

        public int Chuvi
        {
            get { return Canh1 + Canh2 + Canh3; }
        }

        public string LoaiTamGiac
        {
            get
            {
                if (!HopLe())
                    return "Không phải tam giác";

                if (Canh1 == Canh2 && Canh2 == Canh3)
                    return "Tam giác đều";
                else if (Canh1 == Canh2 || Canh1 == Canh3 || Canh2 == Canh3)
                {
                    if (LaTamGiacVuong())
                        return "Tam giác vuông cân";
                    return "Tam giác cân";
                }
                else if (LaTamGiacVuong())
                    return "Tam giác vuông";
                else
                    return "Tam giác thường";
            }
        }

        public float DienTich
        {
            get
            {
                if (!HopLe())
                    return 0;

                float p = Chuvi / 2.0f;
                double dt = Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
                return (float)Math.Round(dt, 2);
            }
        }

        // Constructor không tham số
        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = -5;
        }

        // Constructor có 3 tham số
        public TamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
        }

        // Kiểm tra tam giác hợp lệ
        public bool HopLe()
        {
            return (Canh1 > 0 && Canh2 > 0 && Canh3 > 0 &&
                    Canh1 + Canh2 > Canh3 &&
                    Canh1 + Canh3 > Canh2 &&
                    Canh2 + Canh3 > Canh1);
        }

        // Kiểm tra tam giác vuông
        private bool LaTamGiacVuong()
        {
            int a2 = Canh1 * Canh1;
            int b2 = Canh2 * Canh2;
            int c2 = Canh3 * Canh3;
            return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        }

        // Phương thức hiển thị thông tin
        public void HienThi()
        {
            Console.WriteLine("Thông tin tam giác:");
            Console.WriteLine($"- Cạnh 1: {Canh1}");
            Console.WriteLine($"- Cạnh 2: {Canh2}");
            Console.WriteLine($"- Cạnh 3: {Canh3}");

            if (!HopLe())
            {
                Console.WriteLine("=> Đây không phải là tam giác hợp lệ.");
            }
            else
            {
                Console.WriteLine($"- Chu vi: {Chuvi}");
                Console.WriteLine($"- Diện tích: {DienTich}");
                Console.WriteLine($"- Loại tam giác: {LoaiTamGiac}");
            }
        }
    }
}
