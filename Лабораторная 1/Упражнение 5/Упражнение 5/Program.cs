using System;
namespace Упражнение_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the perimetr of equilateral triangle");
                double P = Convert.ToDouble(Console.ReadLine());
                double a = P / 3;
                double p = P / 2;
                double S = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
                Console.WriteLine("side\tresult");
                Console.WriteLine("{0:0.##}\t{1:0.##}", a, S);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
        }

    }
}