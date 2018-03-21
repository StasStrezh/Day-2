using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumberTask
{
    /// <summary>
    /// Contain methods to work with binary numbers
    /// </summary>
    public class InsertingNumbers
    {
        /// <summary>
        /// Insert one number to another
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns>New number</returns>
        public static int InsertNumber(int num1, int num2, int i, int j)
        {
            if(i<0 || j<0 || i>31 || j>31)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(i>j)
            {
                throw new ArgumentException();
            }

            int arr1 = ((num1 >> j) << (i + j)) | ((int.MaxValue >> 30 - i) & num1);
            int arr2 = (num2 << i + 1) & (int.MaxValue >> 30 - j);
            int arr3 = arr1 | arr2;
            return arr3;
        }
    }
}
