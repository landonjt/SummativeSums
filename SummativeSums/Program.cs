using System;
using System.Collections.Generic;

namespace summativesums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] array2 = { 999, -60, -77, 14, 160, 301 };
            int[] array3 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
        140, 150, 160, 170, 180, 190, 200, -99 };

            int sum1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            int sum2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sum2 += array2[i];
            }

            int sum3 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                sum3 += array3[i];
            }

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Console.ReadLine();

        }

    }
}

