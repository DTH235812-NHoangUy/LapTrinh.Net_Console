using System;

namespace GiaiPhuongTrinhBac2
{
    class PTBacHai
    {
        // Thuộc tính (fields)
        private int _soa;
        private int _sob;
        private int _soc;

        // Property cho các hệ số
        public int Soa
        {
            get { return _soa; }
            set { _soa = value; }
        }

        public int Sob
        {
            get { return _sob; }
            set { _sob = value; }
        }

        public int Soc
        {
            get { return _soc; }
            set { _soc = value; }
        }

        // Constructor không tham số
        public PTBacHai()
        {
            Soa = 0;
            Sob = 0;
            Soc = 0;
        }

        // Constructor có tham số
        public PTBacHai(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }

        // Phương thức tính và in nghiệm phương trình bậc 2
        public void Giai()
        {
            Console.WriteLine($"\nPhương trình: {Soa}x² + {Sob}x + {Soc} = 0");

            if (Soa == 0)
            {
                // Phương trình bậc nhất hoặc vô nghiệm
                if (Sob == 0)
                {
                    if (Soc == 0)
                        Console.WriteLine("Phương trình vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -(double)Soc / Sob;
                    Console.WriteLine("Phương trình có một nghiệm duy nhất x = {0}", Math.Round(x, 2));
                }
            }
            else
            {
                // Phương trình bậc hai
                double delta = Sob * Sob - 4 * Soa * Soc;

                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -(double)Sob / (2 * Soa);
                    Console.WriteLine("Phương trình có nghiệm kép x = {0}", Math.Round(x, 2));
                }
                else
                {
                    double x1 = (-Sob + Math.Sqrt(delta)) / (2 * Soa);
                    double x2 = (-Sob - Math.Sqrt(delta)) / (2 * Soa);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0}", Math.Round(x1, 2));
                    Console.WriteLine("x2 = {0}", Math.Round(x2, 2));
                }
            }
        }
    }
}
