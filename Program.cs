using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DineshEuler
{
    class Program
    {
        /// <summary>
        /// Main method For Problem 1
        /// </summary>
        //static void Main()
        //{
        //    foreach (var item in Problem1.MultipleOf3(1000))
        //    {
        //        Console.Write(item + ",");
        //    }

        //    Console.WriteLine();

        //    foreach (var item in Problem1.MultipleOf5(1000))
        //    {
        //        Console.Write(item + ",");
        //    }

        //    Console.WriteLine(Problem1.SumOfMultiples(1000));

        //    Console.ReadLine();
        //}


        static void Main()
        {
            //foreach (var item in Problem2.ShowFibonnaci(Problem2.SumType.Even))
            //{
            //    Console.Write(item + ",");
            //}

            //Console.ReadLine();
            //Console.WriteLine();


            Console.WriteLine(Problem2.Fibonacci(Problem2.SumType.Even));
            Console.ReadLine();
        }

    }
}
