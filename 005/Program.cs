using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_005
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            int i = 20;
            while (!found)
            {
                bool div = true;
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j != 0)
                    {
                        div = false;
                        break;
                    }
                }

                if (div)
                {
                    found = true;
                }
                i++;
            }

            Console.WriteLine("{0}", i-1);


        }
    }
}
