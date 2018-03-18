using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFindingNumbers
{
    /// <summary>
    /// This is the methods for searching next bigger number
    /// </summary>
    public class FindingNumbers
    {
        /// <summary>
        /// Tackes a number and returns bigger number consisting of the numbers of the source number
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Bigger number</returns>
        public static int FindNextBiggerNumber(int num)
        {
            if (num<0 || num>=int.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(num<=11)
            {
                return -1;
            }

            return NextBiggerNumber(num);
        }

        /// <summary>
        /// Finds the next bigger number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Next bigger number</returns>
        private static int NextBiggerNumber(int number)
        {
            int[] buffer = new int[number.ToString().Length];
            for(int i = buffer.Length-1; i>-1; i--)
            {
                buffer[i] = number % 10;
                number /= 10;
            }
            int index = IndexSearching(buffer);

            if(index== -1)
            {
                return -1;
            }
            int temp=0;
            if(index<buffer.Length-1)
            {
                temp = buffer[index];
                buffer[index] = buffer[index + 1];
                buffer[index + 1] = temp;
                Array.Sort(buffer, index + 1, buffer.Length - index - 1);
            }

            int result = 0;
            for(int i = 0; i<buffer.Length; i++)
            {
                result += (int)(buffer[i] * Math.Pow(10, buffer.Length - 1 - i));
            }
            return result;
        }

        /// <summary>
        /// Finds index
        /// </summary>
        /// <param name="temp"></param>
        /// <returns>Index</returns>
        private static int IndexSearching(int[] temp)
        {
            for(int i = temp.Length-1; i>0; i--)
            {
                if(temp[i]>temp[i-1])
                {
                    return (i - 1);
                }
            }
            return -1;
        }
    }
}
