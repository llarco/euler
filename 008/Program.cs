using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler_008
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"\\ubsprod.msad.ubs.net\userdata\larcol\home\documents\visual studio 2010\Projects\Euler-008\Euler-008\Data.txt");

            char[] input = text.ToCharArray();

            int[] digits = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                digits[i] = (int)Char.GetNumericValue(input[i]);
            }

            int prod = 1;
            for (int i = 0; i < digits.Length - 5; i++)
            {
                int temp = 1;
                for (int j = 0; j < 5; j++)
                {
                    temp *= digits[i + j];
                }
                if (temp > prod)
                    prod = temp;
            }

            Console.WriteLine("{0}", prod);


        }

    }
}
