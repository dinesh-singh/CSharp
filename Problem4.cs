using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DineshEuler
{
    static class Problem4
    {
       static public int LargestSixDigitPalindrome()
       {
           int maxVal = 0;

           for (int i = 999; i > 0; i--)
           {
               for (int j = i - 10; j <= i; j++)
               {
                   maxVal = 0;
                   if (IsPalindrome(i * j))
                   {
                       maxVal = i * j;
                   }
               }

               if (maxVal != 0)
               {
                   break;
               }

           }

           return maxVal;
       }

       static public bool IsPalindrome(int number)
       {
           string orignalNumber = number.ToString();
           string reversedNumber = orignalNumber;
           if (orignalNumber == reversedNumber)
           {
               return true;
           }
           else
           {
               return false;
           }
       }


    }
}
