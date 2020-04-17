using System;

namespace Упражнение_2_Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
			int s;
			double x, y;
			s = 0;
			bool next = true;
			while(next)
			{
				Console.WriteLine("Введите координаты пули");
				Console.Write("x = ");
				x = double.Parse(Console.ReadLine());
				Console.Write("y = ");
				y = double.Parse(Console.ReadLine());
				if (x * x + y * y <= 1)
					s += 10;
				else if (x * x + y * y > 1 && x * x + y * y <= 4)
					s += 5;
				else if (x * x + y * y > 4 && x * x + y * y <= 9)
					s += 1;
				Console.WriteLine("Хотите продолжить стрельбу? Y/N");
				char anser = char.Parse(Console.ReadLine());
				switch (anser)
				{
					case 'Y': next = true; break;
					case 'N': next = false; break;
				}
			}
			Console.WriteLine("Набранная сумма очков: {0}", s);
		}
    }
}
