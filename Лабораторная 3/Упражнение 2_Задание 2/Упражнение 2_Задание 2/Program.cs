using System;

namespace Упражнение_2_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
			int s, k, m;
			s = 0;
			Console.WriteLine("Введите диапазон числе, который нужно исключить из 100");
			Console.Write("Нижняя граница: ");
			k = Int32.Parse(Console.ReadLine());
			Console.Write("Верхняя граница граница: ");
			m = Int32.Parse(Console.ReadLine());
			for (int i = 1; i <= 100; i++)
			{
				if ((i > k) && (i < m))
					continue;
				s += i;
			}
			Console.WriteLine("Итоговая сумма: {0}", s);
		}
    }
}