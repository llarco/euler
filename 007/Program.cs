using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_007
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 2;
            int counter = 0;
            bool found = false;
            while (!found)
            {
                if (isPrime(i))
                {
                    counter++;
                }
                if (counter == 10001)
                {
                    found = true;
                    Console.WriteLine("{0}", i);
                }
                i++;

            }
        }

        public static bool isPrime(int n)
        {
            if (n == 0 || n == 1)
                return false;

            if (n < 0)
                return isPrime(-n);

            int i = 2;
            int counter = 0;
            while (i < n / 2 + 1)
            {
                if (n % i == 0)
                    counter++;

                if (counter > 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
