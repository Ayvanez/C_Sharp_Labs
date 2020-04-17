using System;

namespace Упражнение_4
{
    class Program
    {
        static void Main(string[] args)
        {
                ArithmeticProgression a = new ArithmeticProgression(1, 11);
                int k = 10;
                Console.WriteLine("{0} член арифметической прогрессии с шагом {1} = {2}", k.ToString(), a.d.ToString(), a.GetElement(k).ToString());
                GeometricProgression b = new GeometricProgression(1, 7);
                int p = 5;
                Console.WriteLine("{0} член геометрической прогрессии с шагом {1} = {2}", p.ToString(), b.q.ToString(), b.GetElement(p).ToString());
        }
    }
}
