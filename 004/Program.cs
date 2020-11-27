using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_004
{
    class Program
    {
        static void Main(string[] args)
        {

            int prod = 1;
            for (int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    if (isPalin(i * j))
                    {
                        if ((i * j) > prod)
                            prod = i * j;
                    }
                }
            }

            Console.WriteLine("{0}", prod);
        }

        public static bool isPalin(int i)
        {

            char[] input = i.ToString().ToCharArray();
            int m = 0;
            int n = input.Length - 1;
            while (m < n)
            {
                if (input[m] != input[n])
                {
                    return false;
                }
                else
                {
                    m++;
                    n--;
                }
            }
            return true;

        }


    }
}
