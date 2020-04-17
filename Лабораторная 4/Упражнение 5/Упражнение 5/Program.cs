using System;
namespace Упражнение_5
{
    class Myroot
    {
        public static int Roots(float a, float b, float c, ref double x1, ref double x2)
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return 1;
            }
            else if (D == 0)
            {
                x1 = x2 = -b / 2 * a;
                return 0;
            }
            else
                return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            double x1 = 0, x2 = 0;
            Console.WriteLine("Введите коэффициент перед х^2(a):");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент перед х(b):");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите свободный коэффициент(с):");
            c = float.Parse(Console.ReadLine());
            int result = Myroot.Roots(a, b, c, ref x1, ref x2);
            if (result == -1)
            {
                Console.WriteLine("корней уравнения с коэффициентами а = " +  a + ", b = " + b + ", c = " + c + " нет");
            }
            else if (result == 0)
            {
                Console.WriteLine("корень уравнения с коэффициентами а = " + a + ", b = " + b + ", c = " + c + " один: х1 = х2 = " + x1);
            }
            else
                Console.WriteLine("корни уравнения с коэффициентами а = " + a + ", b = " + b + ", c = " + c + "равны: х1 = " + x1 + ", x2 = " + x2);
        }
    }
}
