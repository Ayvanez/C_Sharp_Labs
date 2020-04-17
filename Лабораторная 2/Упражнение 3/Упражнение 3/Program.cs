using System;

namespace Упражнение_3
{
    public struct Distance
    {
        public int feet;
        public double inches;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance d1;
            Distance d2;
            Distance d3;
            double temp;
            Console.Write("Enter number of feet for the first value: ");
            d1.feet = int.Parse(Console.ReadLine());
            Console.Write("Enter number of inches for the first value: ");
            d1.inches = int.Parse(Console.ReadLine());
            Console.Write("Enter number of feet for the second value: ");
            d2.feet = int.Parse(Console.ReadLine());
            Console.Write("Enter number of inches for the second value: ");
            d2.inches = int.Parse(Console.ReadLine());
            d3.inches = d1.inches + d2.inches;
            d3.feet = d1.feet + d2.feet + (int)(d3.inches/12);
            temp = d1.inches + d2.inches;
            d3.inches = temp % 12;
            Console.WriteLine("Results of summ: {0} '- {1} \"", d3.feet, d3.inches);
        }
    }
}
