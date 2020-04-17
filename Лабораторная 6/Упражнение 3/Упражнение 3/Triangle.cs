using System;
using System.Collections.Generic;
using System.Text;

namespace Упражнение_3
{
    class Triangle
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public Triangle(int A, int B, int C)
		{
            this.a = A;
            this.b = B;
            this.c = C;
            if (a > (b + c)) throw new Exception("Сторона А больше суммы длин двух других сторон");
            if (b > (a + c)) throw new Exception("Сторона B больше суммы длин двух других сторон");
            if (c > (a + b)) throw new Exception("Сторона C больше суммы длин двух других сторон");
        }
        public void PrintSides()
        {
            Console.WriteLine("Сторона A = {0}\nСторона B = {1}\nСторона C = {2}\n", this.a, this.b, this.c);
        }
        public int Perim()
        {
            return (this.a + this.b + this.c);
        }
        public double Area()
        {
            double P = Perim();
            double p = P / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
