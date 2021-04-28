using System;
using System.Collections.Generic;
using System.Linq;

namespace _2D
{
    class Program
    {
        static int hourglassSum(int[,] arr)
        {
            var hourGlassList = new List<int>();

            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y < 5; y++)
                {
                    var sum = arr[x - 1, y - 1]     +  arr[x - 1, y]  +  arr[x - 1, y + 1]
                                                    +  arr[x, y] +
                                 arr[x + 1, y - 1]  +  arr[x + 1, y]  +  arr[x + 1, y + 1];

                    hourGlassList.Add(sum);
                }
            }

            return hourGlassList.Max();
        }

        static void Main(string[] args)
        {

            int[,] testArr = new int[,] { { 1, 1, 1, 0, 0, 0 },
                                          { 0, 1, 0, 0, 0, 0 },
                                          { 1, 1, 1, 0, 0, 0 },
                                          { 0, 0, 2, 4, 4, 0 },
                                          { 0, 0, 0, 2, 0, 0 },
                                          { 0, 0, 1, 2, 4, 0 } };

            Console.WriteLine(hourglassSum(testArr));

            //Console.WriteLine(testArr[0, 0]);
            //Console.WriteLine(testArr[0, 1]);
            //Console.WriteLine(testArr[0, 2]);

            //Console.WriteLine(testArr[1, 1]);

            //Console.WriteLine(testArr[2, 0]);
            //Console.WriteLine(testArr[2, 1]);
            //Console.WriteLine(testArr[2, 2]);
        }
    }
}
