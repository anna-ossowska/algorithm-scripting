using System;
using System.Linq;
using System.Text;

namespace RepeatedString
{
    class Program
    {
        public static long RepeatedString(string s, long n)
        {
            // aba --> 2
            long counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    counter++;
                }
            }

            // aba aba aba --> 6
            long multiply = n / s.Length;
            counter *= multiply;


            // aba aba aba a --> 7
            long remainder = n % s.Length;
            for (int i = 0; i < remainder; i++)
            {
                if (s[i] == 'a')
                {
                    counter++;
                }
            }

            return counter;
        }

        static void Main(string[] args)
        {
            var result1 = RepeatedString("aba", 10);
            var result2 = RepeatedString("a", 1000000000000);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }
    }
}
