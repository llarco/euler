using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_003
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long i = 1; i < Convert.ToInt64(args[0]); i++)
            {
                if (Convert.ToInt64(args[0]) % i == 0 && isPrime(i))
                {
                    Console.WriteLine("{0} is a prime factor.", i);
                }
            }
        }

        public static bool isPrime(long n)
        {
            if (n == 0 || n == 1)
                return false;

            if (n < 0)
                return isPrime(-n);
            
            int i = 2;
            int counter = 0;
            while (i < n/2+1)
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
