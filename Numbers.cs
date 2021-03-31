using System;
using System.Linq;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return (int)(new float[] { number1, number2, number3 }).Min();
        }

        public int FindMaximum(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            return (int)(new float[] { number1, number2, number3 }).Max();
        }
    }
}