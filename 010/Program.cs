using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_010
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            long i = 1;
            while(i < 2000000)
            {
                if (isPrime(i))
                {
                    sum += i;
                    Console.WriteLine("Adding {0}, Sum = {1}",i, sum);
                }
                i++;
            }

            Console.WriteLine("{0}", sum);

        }

        public static bool isPrime(long n)
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
