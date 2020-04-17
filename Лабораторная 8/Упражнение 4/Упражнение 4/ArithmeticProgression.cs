using System;
using System.Collections.Generic;
using System.Text;

namespace Упражнение_4
{
    class ArithmeticProgression : IProgression
    {
        public int a1 { get; set; }
        public int d { get; set; }
        public ArithmeticProgression(int a1, int d)
        {
            this.a1 = a1;
            this.d = d;
        }
        public int GetElement(int k)
        {
            return a1 + (k - 1) * d;
        }
    }
}
