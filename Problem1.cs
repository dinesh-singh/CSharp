using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace DineshEuler
{
    /// <summary>
    /// Finding Multiples of 3 and 5 below Specified Number
    /// </summary>
    public static class Problem1
    {
        public static ReadOnlyCollection<UInt64> MultipleOf3(UInt64 noOfMultiples)
        {
            List<UInt64> multiples = new List<UInt64>();
            for (UInt64 i = 1; i < noOfMultiples; i++)
            {
                if (i % 3 == 0)
                {
                    multiples.Add(i);
                }
            }


            return new ReadOnlyCollection<UInt64>(multiples);
        }


        public static ReadOnlyCollection<UInt64> MultipleOf5(UInt64 noOfMultiples)
        {
            List<UInt64> multiples = new List<UInt64>();
            for (UInt64 i = 1; i < noOfMultiples; i++)
            {
                if (i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }


            return new ReadOnlyCollection<UInt64>(multiples);
        }


        public static UInt64 SumOfMultiples(UInt64 noOfMultiples)
        {
            UInt64 sum = 0;
            for (UInt64 i = 1; i < noOfMultiples; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
