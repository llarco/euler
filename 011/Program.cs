using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_011
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[20,20];

            System.IO.StreamReader file = new System.IO.StreamReader(@"\\ubsprod.msad.ubs.net\userdata\larcol\home\documents\visual studio 2010\Projects\Euler-011\Euler-011\Data.txt");


            for (int i = 0; i < 20; i++)
            {
                char[] line = file.ReadLine().ToArray();
                for (int j = 0; j < 20; j++)
                {
                    data[i, j] = Convert.ToInt32(line[3*j].ToString() + line[3*j+1].ToString());
                }
            }

            int max = 0;
            //vertically
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    int prod = data[i, j] * data[i, j + 1] * data[i, j + 2] * data[i, j + 3];
                    if (prod > max)
                        max = prod;
                }
            }

            //horizontally
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int prod = data[i, j] * data[i+1, j] * data[i+2, j] * data[i+3, j];
                    if (prod > max)
                        max = prod;
                }
            }

            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    int prod = data[i, j] * data[i + 1, j+1] * data[i + 2, j+2] * data[i + 3, j+3];
                    if (prod > max)
                        max = prod;
                }
            }

            for (int i = 3; i < 20; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    int prod = data[i, j] * data[i - 1, j + 1] * data[i - 2, j + 2] * data[i - 3, j + 3];
                    if (prod > max)
                        max = prod;
                }
            }

            Console.WriteLine(max);

        }
    }
}
