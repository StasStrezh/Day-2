using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumberTask
{
    public class InsertingNumbers
    {
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

            var array1 = new BitArray(new int[] { num1 });
            var array2 = new BitArray(new int[] { num2 });

            int q = 0;
            for (int w = i; i <= j; i++, j++)
            {
                array1[w] = array1[w] | array2[j];
            }

            int[] array3 = new int[1];
            array1.CopyTo(array3, 0);
            return array3[0];
        }
    }
}
