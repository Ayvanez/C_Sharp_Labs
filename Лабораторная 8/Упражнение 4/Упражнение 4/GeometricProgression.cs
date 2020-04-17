using System;
using System.Collections.Generic;
using System.Text;

namespace Упражнение_4
{
    class GeometricProgression : IProgression
    {
        public int b1 { get; set; }
        public int q { get; set; }
        public GeometricProgression(int b1, int q)
        {
            this.b1 = b1;
            this.q = q;
        }
        public int GetElement(int k)
        {
            return b1 * Convert.ToInt32(Math.Pow(q, k - 1));
        }
    }
}
