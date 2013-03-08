using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DineshEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (Problem3.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            //Problem3.IsPrime(15);

            Console.Read();
        }
    }
}
