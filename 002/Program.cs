using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_002
{
    class Program
    {
        public static int Main(string[] args)
        {
            bool cont = true;
            int sum = 0;
            int counter = 1;
            while (cont)
            {
                if (Fibonacci(counter) % 2 == 0)
                {
                    sum += Fibonacci(counter);
                }
                counter++;
                if(Fibonacci(counter) >= 4000000)
                    cont = false;
            }

            Console.WriteLine("Sum of even Fibonacci numbers less than 4 million = {0}", sum);

            Console.ReadLine();
            return 0;
        }

        public static int Fibonacci(int n) {
            if(n == 1)
                return 1;
            if(n == 2)
                return 2;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
