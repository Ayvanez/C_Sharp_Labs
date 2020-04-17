using System;
namespace Упражнение_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            Console.Write("Введите длину массива: ");
            myArray = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < myArray.Length; ++i)
            {
                Console.Write("myArray[{0}]=", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма всех элементов массива: {0}", ArrSum(myArray));
            Console.WriteLine("Среднее значение массива: {0}", ArrAvarage(myArray));
            Console.WriteLine("Сумма отрицательных элементов массива: {0}", ArrSumNegative(myArray));
            Console.WriteLine("Сумма положительных элементов массива: {0}", ArrSumPositive(myArray));
            Console.WriteLine("Сумма элементов с нечётнами номерами: {0}", ArrOddSum(myArray));
            Console.WriteLine("Сумма элементов с чётными номерами: {0}", ArrEvenSum(myArray));
            Console.WriteLine("Индекс максимального элемента массива: {0}", ArrMax(myArray));
            Console.WriteLine("Индекс минимального элемента массива: {0}", ArrMin(myArray));
            Console.WriteLine("Произведение элементов массива, расположенных между максимальным и минимальным элементами: {0}", ArrBetween(myArray));
        }
        private static int ArrSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        private static double ArrAvarage(int[] arr)
        {
            return (double)ArrSum(arr) / arr.Length;
        }
        private static int ArrSumNegative(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0) { sum = sum + arr[i]; }
            }
            return sum;
        }
        private static int ArrSumPositive(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 0) { sum = sum + arr[i]; }
            }
            return sum;
        }
        private static int ArrOddSum(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i+=2)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        private static int ArrEvenSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        private static int ArrMax(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[max]) max = i;
            }
            return max;
        }
        private static int ArrMin(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[min]) min = i;
            }
            return min;
        }
        private static int ArrBetween(int[] arr)
        {

            int max = ArrMax(arr);
            int min = ArrMin(arr);
            int btw = 1;
            int a, b;
            if (max > min)
            {
                a = min;
                b = max;
            }
            else
            {
                a = max;
                b = min;
            }
            for (int i = a + 1; i < b; i++)
                btw *= arr[i];
            return btw;
        }
    }
}
