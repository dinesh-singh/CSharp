using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DineshEuler
{
    public static class Problem3
    {
        public static int FindLargestPrimeFactor(int number)
        {
            List<int> primeFactors = new List<int>();
            int intermediateNum = 0;
            for (int i = number; i < 0; i--)
            {
                if ((intermediateNum = number % i) == 0)
                {
                    
                }
            }

            return primeFactors.Max();
        }

        public static bool IsPrime(int number)
        {
            bool isPrime = true;
            int inter = 0;
            for (int i = 2; i < number; i++)
            {
                if ((inter = number/i) > 0)
                {
                    if((inter*i)==number)
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
