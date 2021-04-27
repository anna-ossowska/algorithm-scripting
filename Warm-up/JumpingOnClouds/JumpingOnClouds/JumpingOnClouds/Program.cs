using System;
using System.Collections.Generic;
using System.Linq;

namespace JumpingOnClouds
{
    class Program
    {
        public static int JumpingOnClouds(List<int> c)
        {
            int counter = 0;

            for (int i = 0; i < c.Count - 1; i++)
            {
                
                if (i + 2 < c.Count && c[i + 2] == 0)
                {
                    i++;
                }
                counter++;
            }

            return counter;
        }

        static void Main(string[] args)
        {
            var c = new List<int> { 0, 0, 0, 0, 1, 0 };

            Console.WriteLine(JumpingOnClouds(c));
        }
    }
}
