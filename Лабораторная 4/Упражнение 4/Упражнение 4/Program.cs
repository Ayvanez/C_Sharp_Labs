using System;
namespace Упражнение_4
{
    class Operation
    {
        static bool Exist(float a, float b, float c)
        {
            bool exist = true;
            if (a + b < c || a + c < b || b + c < a)
                exist = false;
            return exist;
        }
        public static double Area(float a, float b, float c)
        {
            double S;
            if (Exist(a, b, c))
            {
                double p = (a + b + c) / 2;
                return(Math.Sqrt(p * (p - a) * (p - b) * (p - b)));
            }
            else
            {
                Console.WriteLine("Заданного треугольника неcуществует");
                return 0;
            }
        }
        public static double Area(float a)
        {
            return Math.Sqrt(1.5 * a * (0.5 * a) * (0.5 * a) * (0.5 * a));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение площади какого треугольника вам необходимо вычислить?");
            Console.WriteLine("Равносторонний = Y/ Не равносторонний = N");
            char x = char.Parse(Console.ReadLine());
            switch (x)
            {
                case 'Y':
                    {
                        Console.WriteLine("Введите размер стороны треугольника");
                        float a = float.Parse(Console.ReadLine());
                        double S = Operation.Area(a);
                        Console.WriteLine("S = {0}", S);
                        break;
                    }
                case 'N':
                    {
                        Console.WriteLine("Введите размер первой стороны треугольника");
                        float a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер второй стороны треугольника");
                        float b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите размер третьей стороны треугольника");
                        float c = float.Parse(Console.ReadLine());
                        double S = Operation.Area(a, b, c);
                        if (S != 0)
                            Console.WriteLine("Площадь треугольника = " + S);
                        break;
                    }
            }
        }
    }
}
