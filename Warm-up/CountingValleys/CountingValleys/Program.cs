using System;
using System.Linq;

namespace CountingValleys
{
    class Program
    {
        public static int countingValleys(int steps, string path)
        {
            int up = 1;
            int down = -1;
            int[] intArr = new int[path.Length];

            int valleyCount = 0;
            bool isValley = false;
            int sum = 0;

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'U')
                {
                    intArr[i] = up;
                }
                else
                {
                    intArr[i] = down;
                }
            }

            for (int i = 0; i < intArr.Length; i++)
            {
                sum += intArr[i];

                if (sum < 0)
                {
                    // Valley always starts with a step down (-1)
                    isValley = true;
                }
                else if (sum == 0 && isValley)
                {
                    valleyCount++;
                    isValley = false;
                }
            }
            return valleyCount;
        }

        static void Main(string[] args)
        {
            int result = countingValleys(12, "DDUUDDUDUUUD");
            Console.WriteLine(result);
        }
    }
}
