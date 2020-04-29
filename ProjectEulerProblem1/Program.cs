﻿using System;

namespace ProjectEulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.

            int sum = 0;
            int max = 1000;
            for(int i = 1; i < max; i++)
            {
                if(i % 3 == 0)
                {
                    sum += i;
                }
                else if(i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}
