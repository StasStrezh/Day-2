using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxEl
{
    public class Searching
    {
        public static int Search(int[] array)
        {
            return Maximum(array, 0, array.Length - 1);
        }
        static int Maximum(int[] arr, int left, int right)
        {
            if (left == right)
                return arr[left];
            else
            {
                int buff1 = Maximum(arr, left, (left + right) / 2);
                int buff2 = Maximum(arr, (left + right) / 2 + 1, right);

                return Math.Max(buff1, buff2);
            }
        }
    }
}
