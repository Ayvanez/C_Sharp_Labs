using System;
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\nwhile: \t\t");
            int i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);
            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine("\n\n*** Цикл с постусловием ***");
            double x, x1, x2, y;
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            x = x1;
            Console.Write("\nx \tSinx");
            do
            {
                y = Math.Sin(x);
                Console.Write("\n{0} \t{1}", x, y);
                x = x + 0.01;
            }
            while (x <= x2);

            Console.WriteLine("\n\n*** Алгоритм Евклида с предусловием ***");
            int a, b, temp;
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine());
            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.Write("\nNOD = {0}", b);

            Console.WriteLine("\n\n*** Цикл с предусловием ***");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            x = x1;
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.Write("\n{0} \t{1}", x, y);
                x = x + 0.01;
            }

            Console.WriteLine("\n\n*** Алгоритм Евклида с постусловием ***");
            Console.Write("a = ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine());
            temp = a;
            do
            {
                a = temp;
                if (a == b)
                {
                    Console.Write("a = b");
                    break;
                }
                else if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);
            Console.WriteLine("\nNOD = {0}", b);
        }
    }
}
