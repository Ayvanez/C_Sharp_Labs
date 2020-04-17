using System;
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            for (int i = 0; i < myArray.Length; i = i + 1)
            {
                if (myArray[i] % 2 == 0) myArray[i] = 0;
            }
            foreach (int i in myArray) Console.Write("{0} ", i);
            Console.WriteLine();
            int[] MyArray;
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            for (int i = 0; i < MyArray.Length; ++i)
            {
                Console.Write("a[{0}]=", i);
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in MyArray) Console.Write("{0} ", i);
        }
    }
}
