using System;

namespace Упражнение_1_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("year = ");
            int year = Int32.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
