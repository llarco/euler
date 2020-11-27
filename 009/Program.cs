using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_009
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    for (int k = 1; k < 1000; k++)
                    {
                        if ((i * i + j * j == k * k) && (i + j + k == 1000))
                        {
                            x = i;
                            y = j;
                            z = k;
                            break;
                        }
                    }
                }
            }


            Console.WriteLine("a={0}\nb={1}\nc={2}", x,y,z);
            Console.WriteLine("abc = {0}", x * y * z);


        }
    }
}
