using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_006
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }

            int squareofSum = (int)Math.Pow(100.0 * 101.0 / 2.0, 2.0);

            Console.WriteLine("{0}", squareofSum - sumOfSquares);
        }
    }
}
