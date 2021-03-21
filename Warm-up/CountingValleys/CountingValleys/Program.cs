using System;
using System.Linq;

namespace CountingValleys
{
    class Program
    {
        public static int CountingValleys(int steps, string path)
        {
            int valleyCount = 0;
            bool isValley = false;
            int seaLevel = 0;

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'U')
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if (seaLevel < 0)
                {
                    // Valley always starts with a step down (-1)
                    isValley = true;
                }
                else if (isValley && seaLevel == 0)
                {
                    valleyCount++;
                    isValley = false;
                }
            }
            return valleyCount;
        }

        static void Main(string[] args)
        {
            int result = CountingValleys(12, "DDUUDDUDUUUD");
            Console.WriteLine(result);
        }
    }
}
