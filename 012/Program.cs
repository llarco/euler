using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_012
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            int counter = numDiv(triangle(i));
            while (counter < 500)
            {
                Console.WriteLine("{0}: {1}", triangle(i), counter);
                
                i++;
                counter = numDiv(triangle(i));
            }

            Console.WriteLine(triangle(i));

        }

        public static int triangle(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }

        public static int numDiv(int n)
        {
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    counter++;
            }
            return counter;
        }
    }
}
