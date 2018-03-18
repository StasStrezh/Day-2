using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingRootNewton
{
    public class FindNthRoot
    {
        /// <summary>
        /// Newton formula
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <param name="eps"></param>
        /// <returns>Answer</returns>
        public static double Newton(double num, int i, double eps)
        {
            Input(num, i, eps);
            double x1 = num / i;
            double x2 = 1.0 / i * ((i - 1) * x1 + num / Math.Pow(x1, i - 1));
            while (Math.Abs(x1 - x2) > eps)
            {
                x1 = x2;
                x2 = 1.0 / i * ((i - 1) * x1 + num / Math.Pow(x1, i - 1));
            }
            return x2;

        }
        /// <summary>
        /// Valids the input
        /// </summary>
        /// <param name="num"></param>
        /// <param name="i"></param>
        /// <param name="eps"></param>
        private static void Input(double num, int i, double eps)
        {
            if ((num <= 0 && i % 2 == 0) || i <= 0) throw new ArgumentException("Number must be > 0!");
            if (eps <= 0 || eps >= 1) throw new ArgumentOutOfRangeException("0 < eps < 1!");
        }
    }
}
