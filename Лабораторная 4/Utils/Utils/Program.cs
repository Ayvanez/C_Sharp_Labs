using System;
namespace Utils
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static bool Factorial(int n, out int answer)
        {
            int k; // Loop counter
            int f = 1; // Working value
            bool ok = true; // True if okay, false if not
            try
            {
                checked
                {
                    for (k = 2; k <= n; ++k) 
                    {
                        f = f * k; 
                    }
                }
            }
            catch (Exception) 
            { 
                f = 0; 
                ok = false; 
            }
            answer = f;
            return ok;
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите первое число:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Большим из чисел {0} и {1} является {2} ", x, y, greater);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("До swap: \t" + x + " " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После swap: \t" + x + " " + y);
            int f; 
            bool ok;
            Console.WriteLine("Number for factorial:"); 
            x = int.Parse(Console.ReadLine());
            // Test the factorial function 
            ok = Utils.Factorial(x, out f);
            // Output factorial results 
            if (ok) 
                Console.WriteLine("Factorial(" + x + ") = " + f); 
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
}
