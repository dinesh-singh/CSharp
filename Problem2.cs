using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DineshEuler
{
    /// <summary>
    /// Finding Sum Of Even Fibonacci series up to 4 Million
    /// </summary>
    class Problem2
    {
        public enum SumType
        {
            Even=2,
            Odd=3
        }

        public static UInt64 Fibonacci(SumType evenOrOdd)
        {
            List<UInt64> fib = new List<UInt64>();
            fib.Add(0);
            //fib.Add(1);
            


            UInt64 output = 0;
            UInt64 divisor = Convert.ToUInt64(evenOrOdd);
            UInt64 temp = 0;
            for (int i = 1; i <= 4000000; i++)
            {
                if (i < 3)
                {
                    fib.Add((ulong)i);
                    temp = (ulong)i;
                }
                else
                {
                    temp = fib.ElementAt(i - 1) + fib.ElementAt(i - 2);
                    fib.Add(temp);
                }
                if (temp < 4000000)
                {
                    if (temp % divisor == 0)
                        output += temp;
                }
                else
                {
                    break;
                }
            }

            return output;
        }

        public static ReadOnlyCollection<UInt64> ShowFibonnaci(SumType evenOrOdd)
        {
            List<UInt64> fib = new List<UInt64>();
            fib.Add(0);
            fib.Add(1);
            List<UInt64> output = new List<UInt64>();
            UInt64 divisor = Convert.ToUInt64(evenOrOdd);
            UInt64 temp = 0;
            for (int i = 2; i <= 400000; i++)
            {
                //fib.Add(i-1);
                temp = fib.ElementAt(i-1) + fib.ElementAt(i-2);
                fib.Add(temp);
                if (temp % divisor == 0)
                    output.Add(temp);
            }

            return new ReadOnlyCollection<UInt64>(output);
        }
    }
}
