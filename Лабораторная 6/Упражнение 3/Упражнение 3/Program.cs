using System;

namespace Упражнение_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle triangle = new Triangle(4, 7, 15);
                triangle.PrintSides();
                Console.WriteLine("Периметр треугольника = {0}", triangle.Perim());
                Console.WriteLine("Площадь треугольника = {0}", triangle.Area());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: {0}", e.Message);
                Console.WriteLine("Такого треугольника не может существовать в природе!!!");
            }

        }
    }
}
