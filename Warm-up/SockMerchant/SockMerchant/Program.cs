using System.Collections.Generic;
using System.Linq;
using System;

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            HashSet<int> socksHash = new HashSet<int>();
            int sockPairs = 0;

            foreach (var item in ar)
            {
                if (socksHash.Contains(item))
                {
                    socksHash.Remove(item);
                    sockPairs++;
                }
                else
                {
                    socksHash.Add(item);
                }
            }
            return sockPairs;
        }


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = Console.ReadLine().Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }
    }
}
